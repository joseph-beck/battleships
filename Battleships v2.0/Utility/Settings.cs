#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
#endregion

namespace Battleships_v2._0 
{
    static class Settings 
    {
        // y6dRPX4Hu7jPyjJxj3iQbcHNi8vyB5lGTbrsVvXH
        // https://test-game-server-845f8-default-rtdb.europe-west1.firebasedatabase.app/
        // ..\\databases\\test-database
        public static void LoadSettings() 
        {
            FileHandling filehandling = new FileHandling();
            //Console.WriteLine(ConfigurationManager.ConnectionStrings["settings"].ConnectionString);
            string[] settings = filehandling.Get1DArrayFromFile("..\\config\\settings.txt");

            AuthSecret = settings[0];
            BasePath = settings[1];
            SQLiteConnection = settings[2];
            ReplayPath = settings[3];
        }
        public static string AuthSecret { get; private set; }
        public static string BasePath { get; private set; }
        public static string SQLiteConnection { get; private set; }
        public static string ReplayPath { get; private set; }
    }
}
