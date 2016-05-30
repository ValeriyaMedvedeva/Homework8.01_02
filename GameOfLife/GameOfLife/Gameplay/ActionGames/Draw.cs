using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Gameplay
{
    class Draw
    {
        public void Drawing(GameObject ob)
        {
            Console.WriteLine();
            for (int i = 0; i < ob.height; i++)
            {
                Console.WriteLine();
                for (int k = 0; k < ob.width; k++)
                {
                    Console.Write(" _");
                }
                Console.WriteLine();
                Console.Write("|");
                for (int j = 0; j < ob.width; j++)
                {
                    switch (ob.gameField[i, j].type)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write("#");
                            Console.ResetColor();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("o");
                            Console.ResetColor();
                            break;
                        default:
                            Console.Write(" ");
                            break;
                    }
                    Console.Write("|");
                }
            }
            Console.WriteLine();
            for (int k = 0; k < ob.width; k++)
            {
                Console.Write(" _");
            }
        }
    }
}