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
                dumper.DumpMessagesAPK(Paths.OutputPath);
            if (DumpResources)
                dumper.DumpResources(Paths.OutputPath);
            if (DumpStringsDL)
                dumper.DumpMessagesDownload(Paths.OutputPath, Paths.RepositoryPath);
            if (DumpSound)
                dumper.DumpSound(Paths.OutputPath);
            if (DumpVideo)
                dumper.DumpVideo(Paths.OutputPath);
            if (DumpProto)
                dumper.DumpProto(Paths.OutputPath, Paths.RepositoryPath);
        }

        public void ConvertKTX()
        {
            string[] files = Directory.EnumerateFiles(Paths.OutputPath, "*.ktx", SearchOption.AllDirectories).ToArray();
            string[] images = Directory.EnumerateFiles(Paths.OutputPath, "*.*", SearchOption.AllDirectories)
                .Where(s => s.EndsWith(".png") || s.EndsWith(".jpg"))
                .ToArray();

            string outPath = Path.Combine(Paths.RepositoryPath, "images");

            //Copie de tous les fichiers png et jpg
            foreach (string file in images)
            {
                Console.WriteLine(file);
                DirectoryInfo outDir = Directory.CreateDirectory(Path.GetDirectoryName(file).Replace(Paths.OutputPath, outPath));
                File.Copy(file, Path.Combine(outDir.FullName, Path.GetFileName(file)), true);
            }

            //Conversion et copie des fichiers ktx
            foreach (string file in files)
            {
                DirectoryInfo outDir = Directory.CreateDirectory(Path.GetDirectoryName(file).Replace(Paths.OutputPath, outPath));
                string fileName = Path.GetFileNameWithoutExtension(file) + ".png";

                Process.Start(Paths.KTXConverterPath, "-i " + file + " -f r8g8b8a8 -d " + Path.Combine(outDir.FullName, fileName))
                    ?.WaitForExit();
            }
        }
    }
}