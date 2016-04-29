using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    static class Program
    {
        // user info
        public static User user;

        // login windows
        public static Login loginWin;

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginWin = new Login();
            Application.Run(loginWin);
        }
    }
}
