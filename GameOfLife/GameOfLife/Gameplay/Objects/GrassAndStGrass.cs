using GameOfLife.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife.Gameplay.Objects
{
    public class GrassAndStGrass : GameObject
    {
        public GrassAndStGrass(GameSettings setting, int type)
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
            maxDie = setting.maxNeighboursDie;
            maxReproduse = setting.maxNeighboursReproduce;
            minReproduse = setting.minNeighboursReproduce;
        }
        public void Arrangement()
        {
            Random random = new Random();
            int r;
            for (int i = 1; i < gameField.GetLength(0) - 1; i++)
            {
                for (int j = 1; j < gameField.GetLength(1) - 1; j++)
                {
                    r = random.Next(0, 5);
                    if (r == 0 || r==4)
                    {
                        gameField[i, j].type = 0;
                    }
                    if(r==1|| r==3)
                    {
                        gameField[i, j].type = 1;
                        kolLife++;
                    }
                    if (r == 2)
                    {
                        gameField[i, j].type = 2;
                        kolLife++;
                    }
                }
            }
        }
    }
}
