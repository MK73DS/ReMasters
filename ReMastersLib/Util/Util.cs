using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;

namespace ReMastersLib
{
    public static class Util
    {
        public static byte[] GetSlice(byte[] src, int offset, int length)
        {
            byte[] data = new byte[length];
            Buffer.BlockCopy(src, offset, data, 0, data.Length);
            return data;
        }

        public static void Copy(string source, string target, SearchOption so = SearchOption.AllDirectories)
        {
            var diSource = new DirectoryInfo(source);
            var diTarget = new DirectoryInfo(target);
            
            CopyAll(diSource, diTarget, so);
        }
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target, SearchOption so = SearchOption.AllDirectories)
        {
            Directory.CreateDirectory(target.FullName);
            
            foreach (FileInfo fi in source.GetFiles("*", SearchOption.TopDirectoryOnly))
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            if (so == SearchOption.AllDirectories)
            {
                foreach (DirectoryInfo subDirectory in source.GetDirectories())
                {
                    DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(subDirectory.Name);
                    CopyAll(subDirectory, nextTargetSubDir);
                }
            }

        }
        
        public abstract class FileComparer {

            /// <summary>
            /// Fileinfo for source file
            /// </summary>
            protected readonly FileInfo FileInfo1;
    
            /// <summary>
            /// Fileinfo for target file
            /// </summary>
            protected readonly FileInfo FileInfo2;

            /// <summary>
            /// Base class for creating a file comparer
            /// </summary>
            /// <param name="filePath01">Absolute path to source file</param>
            /// <param name="filePath02">Absolute path to target file</param>
            protected FileComparer(string filePath01, string filePath02) { 
                FileInfo1 = new FileInfo(filePath01);
                FileInfo2 = new FileInfo(filePath02);
                EnsureFilesExist();
            }

            /// <summary>
            /// Compares the two given files and returns true if the files are the same
            /// </summary>
            /// <returns>true if the files are the same, false otherwise</returns>
            public bool Compare() {
                if (IsDifferentLength()) { 
                    return false;
                }
                if (IsSameFile()) {
                    return true;
                }
                return OnCompare();
            }
 
            /// <summary>
            /// Compares the two given files and returns true if the files are the same
            /// </summary>
            /// <returns>true if the files are the same, false otherwise</returns>
            protected abstract bool OnCompare();
 
            private bool IsSameFile() {
                return string.Equals(FileInfo1.FullName, FileInfo2.FullName, StringComparison.OrdinalIgnoreCase);
            }
 
            /// <summary>
            /// Does an early comparison by checking files Length, if lengths are not the same, files are definetely different
            /// </summary>
            /// <returns>true if different length</returns>
            private bool IsDifferentLength() {
                return FileInfo1.Length != FileInfo2.Length;
            }
 
            /// <summary>
            /// Makes sure files exist
            /// </summary>
            private void EnsureFilesExist() {
                if (FileInfo1.Exists == false) {
                    throw new ArgumentNullException(nameof(FileInfo1));
                }
                if (FileInfo2.Exists == false) {
                    throw new ArgumentNullException(nameof(FileInfo2));
                }
            }

        }

        public abstract class ReadIntoByteBufferInChunks : FileComparer {

            protected readonly int ChunkSize;

            protected ReadIntoByteBufferInChunks(string filePath01, string filePath02, int chunkSize) : base(filePath01, filePath02) {
                ChunkSize = chunkSize;
            }

            protected int ReadIntoBuffer(in Stream stream, in byte[] buffer) {
                var bytesRead = 0;
                while (bytesRead < buffer.Length) {
                    var read = stream.Read(buffer, bytesRead, buffer.Length - bytesRead);
                    // Reached end of stream.
                    if (read == 0) {
                        return bytesRead;
                    }
                    bytesRead += read;
                }
                return bytesRead;
            }

        }
        
        public class ReadFileInChunksAndCompareVector : ReadIntoByteBufferInChunks {
            public ReadFileInChunksAndCompareVector(string filePath01, string filePath02, int chunkSize) 
                : base(filePath01, filePath02, chunkSize) {
            }

            protected override bool OnCompare() {
                return StreamAreEqual(FileInfo1.OpenRead(), FileInfo2.OpenRead());
            }

            private bool StreamAreEqual(in Stream stream1, in Stream stream2) {
                var buffer1 = new byte[ChunkSize];
                var buffer2 = new byte[ChunkSize];

                while (true) {
                    var count1 = ReadIntoBuffer(stream1, buffer1);
                    var count2 = ReadIntoBuffer(stream2, buffer2);

                    if (count1 != count2)
                    {
                        return false;
                    }

                    if (count1 == 0) {
                        return true;
                    }

                    var totalProcessed = 0;
                    while (totalProcessed < buffer1.Length) {
                        if (Vector.EqualsAll(new Vector<byte>(buffer1, totalProcessed), new Vector<byte>(buffer2, totalProcessed)) == false) {
                            return false;
                        }
                        totalProcessed += Vector<byte>.Count;
                    }
                }
            }
        }

        public static IEnumerable<string> GetNewOrModified(IEnumerable<string> currentPath, IEnumerable<string> previousPath, GameDataPaths paths)
        {
            // New files
            var newFiles = currentPath.Except(previousPath);

            // Looking for modified files
            List<string> modifiedFiles = new List<string>();

            int i = 0;
            int size = currentPath.Except(newFiles).Count();
            Console.Write("Comparing files... ({0}/{1})", i, size);
            foreach (string file in currentPath.Except(newFiles))
            {
                string currFile = Path.Combine(paths.OutputPath, file);
                string prevFile = Path.Combine(paths.PreviousPath, file);
                
                Console.Write("\rComparing files... ({0}/{1})              ", ++i, size);

                if (new ReadFileInChunksAndCompareVector(currFile, prevFile, 131072).Compare())
                    continue;
                
                modifiedFiles.Add(file);
            }
            Console.Write("\n");

            return newFiles
                .Concat(modifiedFiles)
                .Select(path => Path.Combine(paths.OutputPath, path));
        }
    }
}