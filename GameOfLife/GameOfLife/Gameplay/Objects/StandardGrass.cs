using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Data;
using System.Runtime.Serialization;

namespace GameOfLife.Gameplay.Objects
{
    public class StandardGrass : GameObject
    {
        public StandardGrass(GameSettings setting, int type)
        {
            gameField = new Object[setting.height, setting.width];
            for (int i = 0; i < gameField.GetLength(0); i++)
            {
                for (int j = 0; j < gameField.GetLength(1); j++)
                {
                    gameField[i, j] = new Object();
                }
            }
            height = setting.height;
            width = setting.width;
            typeGame = type;
            kolLife = 0;
        }
        public void Arrangement()
        {
            Random random = new Random();
            int r;
            for (int i = 1; i < gameField.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < gameField.GetLength(1) - 1; j++)
                {
                    r = random.Next(0, 2);
                    if (r == 0)
                    {
                        gameField[i, j].type = 0;
                    }
                    else
                    {
                        gameField[i, j].type = 1;
                        kolLife++;
                    }
                }
            }
        }
    }
}
