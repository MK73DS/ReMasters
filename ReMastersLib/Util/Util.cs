using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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

        public static void Copy(string source, string target)
        {
            var diSource = new DirectoryInfo(source);
            var diTarget = new DirectoryInfo(target);
            
            CopyAll(diSource, diTarget);
        }
        public static void CopyAll(DirectoryInfo source, DirectoryInfo target)
        {
            Directory.CreateDirectory(target.FullName);

            foreach (FileInfo fi in source.GetFiles())
            {
                fi.CopyTo(Path.Combine(target.FullName, fi.Name), true);
            }

            foreach (DirectoryInfo subDirectory in source.GetDirectories())
            {
                DirectoryInfo nextTargetSubDir = target.CreateSubdirectory(subDirectory.Name);
                CopyAll(subDirectory, nextTargetSubDir);
            }
        }

        public static string[] GetNewOrModified(string[] currentPath, string[] previousPath, GameDataPaths paths)
        {
            List<String> curr = currentPath
                .Select(path => path.ToString()
                    .Replace(paths.OutputPath, "")
                    .TrimStart(Path.DirectorySeparatorChar)
                )
                .ToList();
            
            List<String> prev = previousPath
                .Select(path => path.ToString()
                    .Replace(paths.PreviousPath, "")
                    .TrimStart(Path.DirectorySeparatorChar)
                )
                .ToList();

            List<String> newModifiedFiles = curr.Except(prev)
                .ToList();

            foreach (string file in curr.Except(newModifiedFiles))
            {
                string currFile = Path.Combine(paths.OutputPath, file);
                string prevFile = Path.Combine(paths.PreviousPath, file);
                
                if (!File.ReadAllBytes(currFile).SequenceEqual(File.ReadAllBytes(prevFile)))
                {
                    newModifiedFiles.Add(file);
                }
            }

            return newModifiedFiles
                .Select(path => Path.Combine(paths.OutputPath, path))
                .ToArray();
        }
    }
}