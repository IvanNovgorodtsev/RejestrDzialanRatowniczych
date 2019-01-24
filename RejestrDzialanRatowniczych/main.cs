using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RejestrDzialanRatowniczych
{
    static class main
    {
        public static bool conStatus = false;
        public static string datasource;
        public static string initialcatalog;
        public static SqlConnection con;


        // MSIGP70
        // werszyn0.0.1

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            if (conStatus) Application.Run(new Osoba());
        }
    }
}
