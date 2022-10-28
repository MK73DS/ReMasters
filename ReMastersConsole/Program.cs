using System;
using ReMastersLib;

namespace ReMastersConsole
{
    public static class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length > 1)
            {
                Console.WriteLine("Not a console app, really. Don't do that!");
                Console.ReadLine();
            }

            const string GameVersion = "2.26.0";

            var paths = new GameDataPaths
            {
                UnpackedAPKPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data\v" + GameVersion + @"\apk",
                DownloadPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data\v" + GameVersion + @"\resources",
                ShardPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data\v" + GameVersion + @"\resources\assetdb_shard",

                OutputPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\temp",
                
                RepositoryPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\Repository",
                KTXConverterPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\PVRTexToolCLI.exe",
            };

            var settings = new DumpSettings(paths)
            {
                DumpStringsDL = true,
                DumpStringsAPK = true,

                DumpResources = true,
                DumpSound = false,
                DumpVideo = false,
                DumpProto = true,
            };

            settings.DumpGameData();
            settings.ConvertKTX();
            
            
        }
    }
}
