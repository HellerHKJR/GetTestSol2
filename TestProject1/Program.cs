using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TestProject1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Console.WriteLine("프로그램 시작합니다");

            Application.Run(new Form1());
        }
    }
}
