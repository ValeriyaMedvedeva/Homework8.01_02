using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using GameOfLife.Gameplay;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Stream fl1 = File.Open("Game1.txt",System.IO.FileMode.OpenOrCreate);
            fl1.Close();
			Stream fl2 = File.Open("Game2.txt", System.IO.FileMode.OpenOrCreate);
            fl2.Close();
			Stream fl3 = File.Open("Game3.txt", System.IO.FileMode.OpenOrCreate);
            fl3.Close();
            Controller mn = new Controller();
            mn.ItemSelection();
        }
    }
}