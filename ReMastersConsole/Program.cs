using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
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
            
            const string DataPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data";

            string[] versionsList = Directory
                .GetDirectories(DataPath)
                .Select(dir => dir.Replace(DataPath + @"\", ""))
                .OrderBy(s => s)
                .ToArray();

            string currentVersion = "";

            if (args.Length == 1 && Array.IndexOf(versionsList, args[0]) > -1)
            {
                Console.WriteLine("Selected version : " + args[0]);
                currentVersion = args[0];
            }
            
            GameVersions gameVersions = new GameVersions(versionsList, currentVersion);

            var paths = new GameDataPaths
            {
                RepositoryPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\Repository",
                KTXConverterPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\PVRTexToolCLI.exe",
                
                UnpackedAPKPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data\" + gameVersions.Current() + @"\apk",
                DownloadPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data\" + gameVersions.Current() + @"\resources",
                ShardPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\data\" + gameVersions.Current() + @"\resources\assetdb_shard",
                
                OutputPath = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\out\" + gameVersions.Current(),
            };

            if (!String.IsNullOrEmpty(gameVersions.Previous()))
            {
                paths.PreviousPath =
                    @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters\out\" + gameVersions.Previous();
                
                Directory.CreateDirectory(paths.PreviousPath);
            }

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
