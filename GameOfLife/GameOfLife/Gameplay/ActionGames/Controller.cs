using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using GameOfLife.Gameplay;
using GameOfLife.Data;
using Newtonsoft.Json;
using System.Runtime.Serialization.Json;
using GameOfLife.Gameplay.Objects;

namespace GameOfLife.Gameplay
{
    public class Controller
    {
        public void ItemSelection()
        {
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(GameSettings));
            string fileContent = System.IO.File.ReadAllText("GameSettings.json");
            GameSettings settings = new GameSettings();
            bool flag = true;
            bool flag1;
            ConsoleKeyInfo opt;
            do
            {
                Console.Clear();
                Console.WriteLine("--> Введите 1,чтобы НАЧАТЬ НОВУЮ ИГРУ;");
                Console.WriteLine("--> Введите 2,чтобы ПРОДОЛЖИТЬ СОХРАНЕННУЮ ИГРУ;");
                Console.WriteLine("--> Введите 3,чтобы ПРОСМОТРЕТЬ СПИСОК СОХРАНЕННЫХ ИГР;");
                Console.WriteLine("--> Введите Esc,чтобы произошел ВЫХОД из приложения;");
                opt = Console.ReadKey();
                switch (opt.Key)
                {
                    case ConsoleKey.D1:
                        settings = (GameSettings)json.ReadObject(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(fileContent))); 
                        SelectionTypeOfGame(settings);
                        flag = false;
                        break;
                    case ConsoleKey.D2:
                        flag1 = StartSavingGame(settings);
                        if (!flag1)
                        {
                            Console.WriteLine("\nНе существует сохраненной игры,пожалуйста,начните новую игру");
                            Console.ReadLine();
                            break;
                        }
                        flag = false;
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        AccessToTheGame();
                        ItemSelection();
                        flag = false;
                        break;
                    case ConsoleKey.Escape:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                        Console.ReadKey();
                        break;
                }
            } while (flag);
        }
        public int SelectionTypeOfContinued()
        {
            int type=0;
            bool flag = true;
            ConsoleKeyInfo opt;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Clear();
                Console.WriteLine("--> Введите 1,чтобы продолжить игру со стандартным поведением;");
                Console.WriteLine("--> Введите 2,чтобы продолжить игру с возможностью размножения клеток;");
                Console.WriteLine("--> Введите 3,чтобы продолжить игру по смешанному типу;");
                opt = Console.ReadKey();
                switch (opt.Key)
                {
                    case ConsoleKey.D1:
                        type= 1;
                        flag = false;
                        break;
                    case ConsoleKey.D2:
                        type = 2;
                        flag = false;
                        break;
                    case ConsoleKey.D3:
                        type = 3;
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                        Console.ReadKey();
                        break;
                }
            } while (flag);
            return type;
        }
        public void AccessToTheGame()
        {
            bool flag=false;
            StreamReader sr = null;
            sr = new StreamReader("Game1.txt");
            if (sr.Peek() >= 0)
            {
                Console.WriteLine("--Доступна игра стандартного типа!");
                sr.Close();
                Deleted(1);
                flag = true;
            }
            else
            {
                sr.Close();
            }
            sr = new StreamReader("Game2.txt");
            if (sr.Peek() >= 0)
            {
                Console.WriteLine("--Доступна игра с возможностью размножения клеток!");
                sr.Close();
                Deleted(2);
                flag = true;
            }
            else
            {
                sr.Close();
            }
            sr = new StreamReader("Game3.txt");
            if (sr.Peek() >= 0)
            {
                Console.WriteLine("--Доступна игра смещанного типа!");
                sr.Close();
                Deleted(3);
                flag = true;
            }
            else
            {
                sr.Close();
            }
            if (!flag)
            {
                Console.WriteLine("--Нет доступных игр!");
                Console.ReadLine();
            }
        }
        public void Deleted(int k)
        {
            ConsoleKeyInfo opt;
            bool flag = true;
            StreamWriter sr=null;
            do
            {
                Console.WriteLine("Вы хотите удалить данную игру?");
                Console.WriteLine("--> Введите 1,чтобы удалить данную игру;");
                Console.WriteLine("--> Введите 2,чтобы не удалять данную игру;");
                opt = Console.ReadKey();
                switch (opt.Key)
                {
                    case ConsoleKey.D1:
                        if (k == 1)
                        {
                            sr = new StreamWriter("Game1.txt");
                        }
                        if (k == 2)
                        {
                            sr = new StreamWriter("Game2.txt");
                        }
                        if (k == 3)
                        {
                            sr = new StreamWriter("Game3.txt");
                        }
                        sr.Dispose();
                        sr.Close();
                        flag = false;
                        break;
                    case ConsoleKey.D2:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                        Console.ReadKey();
                        break;
                }
            } while (flag);
        }
        public bool StartSavingGame(GameSettings settings)
        {
            StandardGrass ob1 = null;
            Grass ob2 = null;
            GrassAndStGrass ob3 = null;
            int type = SelectionTypeOfContinued();
            StreamReader sr = null;
            int str;
            if (type == 1)
            {
                sr = new StreamReader("Game1.txt");
            }
            if (type == 2)
            {
                sr = new StreamReader("Game2.txt");
            }
            if (type == 3)
            {
                sr = new StreamReader("Game3.txt");
            }
            if (sr.Peek() < 0)
            {
                sr.Close();
                return false;
            }
            else
            {
                sr.ReadLine();
                settings.height = Int32.Parse(sr.ReadLine());
                settings.width = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursDie = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursReproduce = Int32.Parse(sr.ReadLine());
                settings.minNeighboursReproduce = Int32.Parse(sr.ReadLine());
                if (type == 1)
                {
                    ob1 = new StandardGrass(settings, 1);
                    ob1.age = Int32.Parse(sr.ReadLine());
                    ob1.kolLife = Int32.Parse(sr.ReadLine());
                    for (int i = 0; i < ob1.height; i++)
                    {
                        for (int j = 0; j < ob1.width; j++)
                        {
                            str = Int32.Parse(sr.ReadLine());
                            if (str == 1)
                            {
                                ob1.gameField[i, j].type = 1;
                            }
                        }
                    }
                    sr.Close();
                    StreamWriter sw = new StreamWriter("Game1.txt", false);
                    GameSaving(ob1, sw, 1);
                }
                if (type == 2)
                {
                    ob2 = new Grass(settings, 2);
                    ob2.age = Int32.Parse(sr.ReadLine());
                    ob2.kolLife = Int32.Parse(sr.ReadLine());
                    for (int i = 0; i < ob2.height; i++)
                    {
                        for (int j = 0; j < ob2.width; j++)
                        {
                            str = Int32.Parse(sr.ReadLine());
                            if (str == 2)
                            {
                                ob2.gameField[i, j].type = 2;
                            }
                        }
                    }
                    sr.Close();
                    StreamWriter sw = new StreamWriter("Game2.txt", false);
                    GameSaving(ob2, sw, 2);
                }
                if (type == 3)
                {
                    ob3 = new GrassAndStGrass(settings, 3);
                    ob3.age = Int32.Parse(sr.ReadLine());
                    ob3.kolLife = Int32.Parse(sr.ReadLine());
                    for (int i = 0; i < ob3.height; i++)
                    {
                        for (int j = 0; j < ob3.width; j++)
                        {
                            str = Int32.Parse(sr.ReadLine());
                            if (str == 1)
                            {
                                ob3.gameField[i, j].type = 1;
                            }
                            if (str == 2)
                            {
                                ob3.gameField[i, j].type = 2;
                            }
                        }
                    }
                    sr.Close();
                    StreamWriter sw = new StreamWriter("Game3.txt", false);
                    GameSaving(ob3, sw, 3);
                }
                }
                return true;
        }
        public void SelectionTypeOfGame(GameSettings setting)
        {
            bool flag = true;
            StreamWriter sw = null;
            ConsoleKeyInfo opt;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.Clear();
                Console.WriteLine("--> Введите 1,чтобы начать игру со стандартным поведением;");
                Console.WriteLine("--> Введите 2,чтобы начать игру с возможностью размножения клеток;");
                Console.WriteLine("--> Введите 3,чтобы начать игру по смешанному типу;");
                opt = Console.ReadKey();
                switch (opt.Key)
                {
                    case ConsoleKey.D1:
                        sw = new StreamWriter("Game1.txt", false);
                        StandardGrass ob1 = new StandardGrass(setting,1);
                        ob1.Arrangement();
                        Game(ob1,sw);
                        flag = false;
                        break;
                    case ConsoleKey.D2:
                        sw = new StreamWriter("Game2.txt", false);
                        Grass ob2 = new Grass(setting,2);
                        ob2.Arrangement();
                        Game(ob2,sw);
                        flag = false;
                        break;
                    case ConsoleKey.D3:
                        sw = new StreamWriter("Game3.txt", false);
                        GrassAndStGrass ob3 = new GrassAndStGrass(setting, 3);
                        ob3.Arrangement();
                        Game(ob3,sw);
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                        Console.ReadKey();
                        break;
                }
            } while (flag);
            Console.ResetColor();
        }
        public void Game(GameObject ob,StreamWriter sw)
        {
            Draw draw = new Draw();
            bool flag=true;
            Console.Clear();
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Текущее поколение игры: {0}", ob.age);
                Console.WriteLine("Текущее количество живых объектов: {0}", ob.kolLife);
                Console.ResetColor();
                draw.Drawing(ob);
                if (GameMenu(sw))
                {
                    sw.WriteLine(ob.typeGame);
                    sw.WriteLine(ob.height);
                    sw.WriteLine(ob.width);
                    sw.WriteLine(ob.maxDie);
                    sw.WriteLine(ob.maxReproduse);
                    sw.WriteLine(ob.minReproduse);
                    sw.WriteLine(ob.age);
                    sw.WriteLine(ob.kolLife);
                    for (int i = 0; i < ob.height; i++)
                    {
                        for (int j = 0; j < ob.width; j++)
                        {
                            if (ob.gameField[i, j].type == 1)
                            {
                                sw.WriteLine(1);
                            }
                            if(ob.gameField[i, j].type == 2)
                            {
                                sw.WriteLine(2);
                            }
                            if (ob.gameField[i, j].type == 0)
                            {
                                sw.WriteLine(0);
                            }
                        }
                    }
                    sw.Close();
                    ItemSelection();
                    break;
                }
                Console.Clear();
                flag = ob.Game(ob);
            }
            Console.WriteLine("Игра закончена!");
            sw.Close();
            Console.ReadLine();
            ItemSelection();
        }
        public void GameSaving(GameObject ob,StreamWriter sw,int type)
        {
            GameSettings setting=new GameSettings();
            setting = GameSetting(ob);
            bool flag=true;
            Draw draw = new Draw();
			Console.Clear();
			while (flag)
			{
				Console.ForegroundColor = ConsoleColor.White;
				Console.WriteLine("Текущее поколение игры: {0}", ob.age);
				Console.WriteLine("Текущее количество живых объектов: {0}", ob.kolLife);
				Console.ResetColor();
				draw.Drawing(ob);
				if (GameMenu(sw))
				{
					sw.WriteLine(ob.typeGame);
                    sw.WriteLine(ob.height);
					sw.WriteLine(ob.width);
					sw.WriteLine(ob.maxDie);
					sw.WriteLine(ob.maxReproduse);
					sw.WriteLine(ob.minReproduse);
					sw.WriteLine(ob.age);
                    sw.WriteLine(ob.kolLife);
                    for (int i = 0; i < ob.height; i++)
					{
						for (int j = 0; j < ob.width; j++)
						{
                            if (ob.gameField[i, j].type == 1)
                            {
                                sw.WriteLine(1);
                            }
                            if (ob.gameField[i, j].type == 2)
                            {
                                sw.WriteLine(2);
                            }
                            if (ob.gameField[i, j].type == 0)
                            {
                                sw.WriteLine(0);
                            }
						}
					}
					sw.Close();
					ItemSelection();
					break;
				}
                flag = ob.Game(ob);
			}
            Console.WriteLine("Игра закончена!");
			sw.Dispose();
			sw.Close();
            Console.ReadLine();
            ItemSelection();
        }
        public GameSettings GameSetting(GameObject ob)
        {
            GameSettings game = new GameSettings();
            game.height = ob.height;
            game.width = ob.width;
            game.maxNeighboursDie = ob.maxDie;
            game.maxNeighboursReproduce = ob.maxReproduse;
            game.minNeighboursReproduce = ob.minReproduse;
            return game;
        }
        public bool GameMenu(StreamWriter sw)
        {
            bool flag = true;
            ConsoleKeyInfo opt;
            Console.ForegroundColor = ConsoleColor.White;
            do
            {
                Console.WriteLine("\n\n--> Нажмите Enter,чтобы ПРОДОЛЖИТЬ ТЕКУЩУЮ ИГРУ;");
                Console.WriteLine("--> Нажмите 1,чтобы ЗАВЕРШИТЬ ИГРУ С СОХРАНЕНИЕМ;");
                Console.WriteLine("--> Нажмите 2,чтобы ЗАВЕРШИТЬ ИГРУ БЕЗ СОХРАНЕНИЯ;");
                opt = Console.ReadKey();
                switch (opt.Key)
                {
                    case ConsoleKey.Enter:
                        Console.ResetColor();
                        return false;
                    case ConsoleKey.D1:
                        Console.ResetColor();
                        return true;
                    case ConsoleKey.D2:
                        Console.ResetColor();
                        sw.Dispose();
                        sw.Close();
                        ItemSelection();
                        break;
                    default:
                        Console.WriteLine("\nНе правильный ввод,пожалуйста,попробуйте еще раз!");
                        Console.ReadKey();
                        break;
                }
            } while (flag);
            return false;
        }
    }
}