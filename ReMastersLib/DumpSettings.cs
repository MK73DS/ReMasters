using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;

namespace ReMastersLib
{
    public class DumpSettings
    {
        public bool DumpStringsAPK { get; set; } = true;
        public bool DumpStringsDL { get; set; } = true;
        public bool DumpResources { get; set; } = true;
        public bool DumpSound { get; set; } = true;
        public bool DumpVideo { get; set; } = true;
        public bool DumpProto { get; set; } = true;

        public readonly GameDataPaths Paths;

        public DumpSettings(GameDataPaths p) => Paths = p;

        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.String")]
        [SuppressMessage("ReSharper.DPA", "DPA0002: Excessive memory allocations in SOH", MessageId = "type: System.UInt32[]")]
        public void DumpGameData()
        {
            var dumper = new GameDumper(Paths.UnpackedAPKPath, Paths.DownloadPath);
            dumper.LoadShard(Paths.ShardPath);
            dumper.InitializeShardData(Paths.OutputPath);

            if (DumpStringsAPK)
            {
                Console.WriteLine("Dumping APK Messages...");
                dumper.DumpMessagesAPK(Paths.OutputPath);
            }

            if (DumpResources)
            {
                Console.WriteLine("Dumping Resources...");
                dumper.DumpResources(Paths.OutputPath);
            }

            if (DumpStringsDL)
            {
                Console.WriteLine("Dumping Download Messages...");
                dumper.DumpMessagesDownload(Paths.OutputPath, Paths.RepositoryPath);
            }

            if (DumpSound)
            {
                Console.WriteLine("Dumping Sounds...");
                dumper.DumpSound(Paths.OutputPath);
            }

            if (DumpVideo)
            {
                Console.WriteLine("Dumping Videos...");
                dumper.DumpVideo(Paths.OutputPath);
            }

            if (DumpProto)
            {
                Console.WriteLine("Dumping Protos...");
                dumper.DumpProto(Paths.OutputPath, Paths.RepositoryPath);
            }
        }

        public void ConvertKTX()
        {
            Console.WriteLine("Getting image and texture files list...");
            var outFiles = Directory.EnumerateFiles(Paths.OutputPath, "*.ktx", SearchOption.AllDirectories)
                .Select(fi => fi.Replace(Paths.OutputPath, "").TrimStart(Path.DirectorySeparatorChar));
            var outImages = Directory.EnumerateFiles(Paths.OutputPath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"))
                .Select(fi => fi.Replace(Paths.OutputPath, "").TrimStart(Path.DirectorySeparatorChar));

            var files = outFiles; 
            var images = outImages;
            
            if (!String.IsNullOrEmpty(Paths.PreviousPath))
            {
                Console.WriteLine("Getting old version image and texture files list...");
                var prevFiles = Directory.EnumerateFiles(Paths.PreviousPath, "*.ktx", SearchOption.AllDirectories)
                    .Select(fi => fi.Replace(Paths.PreviousPath, "").TrimStart(Path.DirectorySeparatorChar));
                var prevImages = Directory.EnumerateFiles(Paths.PreviousPath, "*.*", SearchOption.AllDirectories)
                    .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"))
                    .Select(fi => fi.Replace(Paths.PreviousPath, "").TrimStart(Path.DirectorySeparatorChar));
                
                Console.WriteLine("Getting list of new and modified images...");
                // Récupération des images qui ont été rajoutées OU modifiées
                images = Util.GetNewOrModified(outImages, prevImages, Paths);
                Console.WriteLine("{0} new/modified images", images.Count());
            
                Console.WriteLine("Getting list of new and modified textures...");
                // Récupération des fichiers qui ont été rajoutés OU modifiés
                files = Util.GetNewOrModified(outFiles, prevFiles, Paths);
                Console.WriteLine("{0} new/modified textures", files.Count());
            }

            string outPath = Path.Combine(Paths.RepositoryPath, "images");

            //Copie de tous les fichiers png et jpg
            Console.WriteLine("Copying image files to output directory...");
            foreach (string file in images)
            {
                DirectoryInfo outDir = Directory.CreateDirectory(Path.Combine(outPath, Path.GetDirectoryName(file) ?? "/"));
                File.Copy(Path.Combine(Paths.OutputPath, file), Path.Combine(outDir.FullName, Path.GetFileName(file)), true);
            }

            //Conversion et copie des fichiers ktx
            Console.WriteLine("Converting and copying texture files to output directory...");
            foreach (string file in files)
            {
                DirectoryInfo outDir = Directory.CreateDirectory(Path.Combine(outPath, Path.GetDirectoryName(file) ?? "/"));
                string fileName = Path.GetFileNameWithoutExtension(file) + ".png";

                Process.Start(Paths.KTXConverterPath, "-i " + Path.Combine(Paths.OutputPath, file) + " -f r8g8b8a8 -d " + Path.Combine(outDir.FullName, fileName))
                    ?.WaitForExit();
            }
        }
    }
}