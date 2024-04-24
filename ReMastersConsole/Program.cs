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
            if (args.Length > 1)
            {
                Console.WriteLine("Not a console app, really. Don't do that!");
                Console.ReadLine();
            }

            const string WorkingDir = @"D:\Documents\Hack_Datamine\Switch\Tools\ReMasters";
            const string DataDir = WorkingDir + @"\data\";

            string[] versionsList = Directory
                .GetDirectories(DataDir)
                .Select(dir => dir.Replace(DataDir, ""))
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
                DataPath = DataDir,
                RepositoryPath = WorkingDir + @"\Repository",
                KTXConverterPath = WorkingDir + @"\PVRTexToolCLI.exe",
                
                UnpackedAPKPath = DataDir + gameVersions.Current() + @"\apk",
                DownloadPath = DataDir + gameVersions.Current() + @"\resources",
                ShardPath = DataDir + gameVersions.Current() + @"\resources\assetdb_shard",
                
                OutputPath = WorkingDir + @"\out\" + gameVersions.Current(),
            };

            Directory.CreateDirectory(paths.OutputPath);

            if (!String.IsNullOrEmpty(gameVersions.Previous()))
            {
                paths.PreviousPath = WorkingDir + @"\out\" + gameVersions.Previous();
                
                Directory.CreateDirectory(paths.PreviousPath);
            }

            #if DEBUG
            var settings = new DumpSettings(paths)
                {
                    DumpStringsDL = false,
                    DumpStringsAPK = false,

                    DumpResources = false,
                    DumpSound = false,
                    DumpVideo = false,
                    DumpProto = true,
                };

                settings.DumpGameData();
            #else
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
            #endif

        }
    }
}
