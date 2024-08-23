using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using ReMastersLib;

namespace ReMastersConsole
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("You must specify the version");
                System.Environment.Exit(1);
            }

            var version = args[0];
            const string dir = "/DATA/PokemonMastersDatamine";

            var paths = new GameDataPaths
            {
                UnpackedAPKPath = $"{dir}/{version}/apk",
                DownloadPath = $"{dir}/{version}/downloaded-resource-dir",
                ShardPath = $"{dir}/{version}/downloaded-resource-dir/assetdb_shard",

                OutputPath = $"{dir}/{version}/dump",
            };

            var settings = new DumpSettings(paths)
            {
                DumpStringsDL = true,
                DumpStringsAPK = true,

                DumpResources = true,
                DumpSound = true,
                DumpVideo = true,
                DumpProto = true,
            };

            settings.DumpGameData();
        }
    }
}
