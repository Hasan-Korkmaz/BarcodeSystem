using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MarketBarkod.MainStart;

namespace MarketBarkod
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        public static MainPage mainPage;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Startup());
        }

        public static Form Startup()
        {
            mainPage = new MainPage();
            //dbAtach();
            return mainPage;

        }
        
        //TODO: VERİTABANIU BACKUPI ALINACAK
        /*
        static void dbAtach()
        {
            
                string connectString =
                    "Server=.; " +
                    "Integrated Security=true";
                SqlConnectionStringBuilder builder =
                    new SqlConnectionStringBuilder(connectString);
                Console.WriteLine("Original: " + builder.ConnectionString);
                Console.WriteLine("AttachDBFileName={0}", builder.AttachDBFilename);
              
                builder.AttachDBFilename = @"C:\BarkodSon\BarcodeSystem.mdf";
                Console.WriteLine("Modified: " + builder.ConnectionString);

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    // Now use the open connection.
                    Console.WriteLine("Database = " + connection.Database);
                }
                Console.WriteLine("Press any key to finish.");
                Console.ReadLine();
        }*/
    }
}
