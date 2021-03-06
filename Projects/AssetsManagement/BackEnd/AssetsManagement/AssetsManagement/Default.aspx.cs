﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Web;
using System.Web.UI;
using DataRepo.Controllers.Configuration;

namespace AssetsManagement
{

    public partial class Default : System.Web.UI.Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            button1.Text = "You clicked me";

            /*var sqlitePath = Path.Combine(Environment
            .GetFolderPath(Environment.SpecialFolder.ApplicationData), @"OlsonSoftware\FinanceManager"); Directory
                .CreateDirectory(sqlitePath); var fileName = $"{sqlitePath}\fmd.db"; if (!File.Exists(fileName)) File.Create(fileName);
                 optionsBuilder.UseSqlite($"Data Source={fileName}");*/
            var currentDirectory = System.IO.Directory.GetCurrentDirectory();

            //var hf= System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            NativeLibraryHack.DoHack();
            _ = new EFContext($"Data Source={currentDirectory}/blogging.db");

            try
            {
               
            }
            catch (Exception ex)
            {
                var h = ex.Message;
                var e = ex.StackTrace;
            }




        }
    }


    public class NativeLibraryHack
    {
        public static bool Hacked { get; private set; }

        public static bool DoHack()
        {
            if (Hacked) return true;

            try
            {
                const string runtimeFolderName = "/runtimes";

                var destinationPath = typeof(SQLitePCL.raw).Assembly.Location
                    .Replace("\\", "/");
                var destinationLength = destinationPath.LastIndexOf("/", StringComparison.OrdinalIgnoreCase);
                var destinationDirectory = destinationPath.Substring(0, destinationLength) + runtimeFolderName;

                var sourcePath = new Uri(typeof(SQLitePCL.raw).Assembly.CodeBase)
                    .AbsolutePath;
                var sourceLength = sourcePath.LastIndexOf("/", StringComparison.OrdinalIgnoreCase);
                var sourceDirectory = sourcePath.Substring(0, sourceLength) + runtimeFolderName;

                if (Directory.Exists(sourceDirectory))
                    CopyFilesRecursively(new DirectoryInfo(sourceDirectory), new DirectoryInfo(destinationDirectory));
            }
            catch (Exception ex)
            {
                //Ignore Exception
                Debug.WriteLine(ex.Message);
                return false;
            }

            return (Hacked = true);
        }

        private static void CopyFilesRecursively(
            DirectoryInfo source,
            DirectoryInfo target
        )
        {
            foreach (var dir in source.GetDirectories())
                CopyFilesRecursively(dir, target.CreateSubdirectory(dir.Name));

            foreach (var file in source.GetFiles())
            {
                try
                {
                    var destinationFile = Path.Combine(target.FullName, file.Name);
                    if (!File.Exists(destinationFile))
                        file.CopyTo(destinationFile);
                }
                catch (Exception ex)
                {
                    //Ignore Exception
                    Debug.WriteLine(ex.Message);
                }
            }
        }
    }
}
