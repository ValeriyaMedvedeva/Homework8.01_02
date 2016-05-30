using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Data;
using System.Runtime.Serialization;

namespace GameOfLife.Gameplay
{
   public class GameObject 
    {
        public Object[,] gameField;
        public int height;
        public int width;
        public int typeGame;
        public int age = 1;
        public int kolLife;
        public int maxDie;
        public int maxReproduse;
        public int minReproduse;
         public bool Game(GameObject ob)
         {
             int str = height;
             int stb = width;
             bool flag=false;
             bool flag1;
             age++;
             for (int i = 1; i < str - 1; i++)
             {
                 for (int j = 1; j < stb - 1; j++)
                 {
                     if (ob.typeGame == 1)
                     {
                         flag1 = Game1(i, j, ob);
                         if (flag1)
                         {
                             flag = true;
                         }
                     }
                     if (ob.typeGame == 2)
                     {
                         flag1 = Game2(i, j, ob);
                         if (flag1)
                         {
                             flag = true;
                         }
                     }
                     if (ob.typeGame == 3)
                     {
                         flag1 = Game3(i, j, ob);
                         if (flag1)
                         {
                             flag = true;
                         }
                     }
                 }
             }
             if (flag)
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }
         public bool Game1(int i, int j,GameObject ob)
         {
             int neighborLife;
             neighborLife = NumberOfLife(i, j);
             if (gameField[i, j].type == 1)
             {
                 if (neighborLife > 3 || neighborLife < 2)
                 {
                     gameField[i, j].type = 0;
                     kolLife--;
                     return true;
                 }
             }
             if (gameField[i, j].type == 0)
             {
                 if (neighborLife == 3)
                 {
                     gameField[i, j].type = 1;
                     kolLife++;
                     return true;
                 }
             }
             return false;
         }
         public bool Game2(int i, int j,GameObject ob)
         {
             int neighborLife;
             neighborLife = NumberOfLife2(i, j);
             if (gameField[i, j].type == 2)
             {
                 if (neighborLife > ob.maxDie)
                 {
                     gameField[i, j].type = 0;
                     kolLife--;
                     return true;
                 }
                 if (neighborLife >= ob.minReproduse && neighborLife <= ob.maxReproduse)
                 {
                     if (neighborLife < 8)
                     {
                         for (int k = i - 1; k < i + 2; k++)
                         {
                             for (int m = j - 1; m < j + 2; m++)
                             {
                                 if (gameField[k, m].type == 0 && k != 0 && m != 0 && k != ob.height - 1 && m != ob.width - 1)
                                 {
                                     gameField[k, m].type = 2;
                                     kolLife++;
                                     break;
                                 }
                             }
                         }
                         return true;
                     }
                 }
             }
             return false; 
         }
         public bool Game3(int i, int j, GameObject ob)
         {
             int neighborLife;
             neighborLife = NumberOfLife2(i, j) + NumberOfLife(i,j);
             if (gameField[i, j].type == 1)
             {
                 if (neighborLife > 3 || neighborLife < 2)
                 {
                     gameField[i, j].type = 0;
                     kolLife--;
                     return true;
                 }
             }
             if (gameField[i, j].type == 0)
             {
                 if (neighborLife == 3)
                 {
                     gameField[i, j].type = 1;
                     kolLife++;
                     return true;
                 }
             }
             if (gameField[i, j].type == 2)
             {
                 if (neighborLife > ob.maxDie)
                 {
                     gameField[i, j].type = 0;
                     kolLife--;
                     return true;
                 }
                 if (neighborLife >= ob.minReproduse && neighborLife <= ob.maxReproduse)
                 {
                     if (neighborLife < 8)
                     {
                         for (int k = i - 1; k < i + 2; k++)
                         {
                             for (int m = j - 1; m < j + 2; m++)
                             {
                                 if (gameField[k, m].type == 0 && k != 0 && m != 0 && k != ob.height - 1 && m != ob.width - 1)
                                 {
                                     gameField[k, m].type = 2;
                                     kolLife++;
                                     break;
                                 }
                             }
                         }
                         return true;
                     }
                 }
             }
             return false;
         }
         public int NumberOfLife(int k, int m)
         {
             int kol = 0;
             for (int i = k - 1; i < k + 2; i++)
             {
                 for (int j = m - 1; j < m + 2; j++)
                 {
                     if (i != k || j != m)
                     {
                         if (gameField[i, j].type == 1)
                         {
                             kol++;
                         }
                     }
                 }
             }
             return kol;
         }
         public int NumberOfLife2(int k, int m)
         {
             int kol = 0;
             for (int i = k - 1; i < k + 2; i++)
             {
                 for (int j = m - 1; j < m + 2; j++)
                 {
                     if (i != k || j != m)
                     {
                         if (gameField[i, j].type == 2)
                         {
                             kol++;
                         }
                     }
                 }
             }
             return kol;
         }
    }
}