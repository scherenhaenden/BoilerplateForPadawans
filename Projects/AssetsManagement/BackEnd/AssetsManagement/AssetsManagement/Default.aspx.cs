using System;
using System.IO;
using System.Web.UI;
using AssetsManagement.Tools.LoadLib;
using DataRepo.Controllers.Configuration;

namespace AssetsManagement
{

    public partial class Default : Page
    {
        public void button1Clicked(object sender, EventArgs args)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
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
}
