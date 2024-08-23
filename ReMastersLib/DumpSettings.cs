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
    }
}
