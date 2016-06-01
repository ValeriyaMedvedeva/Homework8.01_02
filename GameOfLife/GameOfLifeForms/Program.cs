using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeForms
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Stream fl1 = File.Open("Game1.txt", System.IO.FileMode.OpenOrCreate);
            fl1.Close();
            Stream fl2 = File.Open("Game2.txt", System.IO.FileMode.OpenOrCreate);
            fl2.Close();
            Stream fl3 = File.Open("Game3.txt", System.IO.FileMode.OpenOrCreate);
            fl3.Close();
        }
    }
}
