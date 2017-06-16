using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatHachB2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static string connStr = "Data Source=DESKTOP-O2T8GRH\\SQLEXPRESS;Initial Catalog=ThiB2;user=sa;pwd=123";
        public static string MBT;
        public static string SBD;
        public static Start start;
        public static XacNhan xacnhan;
        public static Thi thi;
        public static KetQuaThi ketquathi;
     
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            start = new Start();
            Application.Run(start);
        }
    }
}
