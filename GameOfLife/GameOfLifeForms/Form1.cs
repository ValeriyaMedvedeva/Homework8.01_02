using GameOfLifeForms.Data;
using GameOfLifeForms.Gameplay;
using GameOfLifeForms.Gameplay.Objects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameOfLifeForms
{
    public partial class Form1 : Form
    {
        StandardGrass ob1 = null;
        Grass ob2 = null;
        GrassAndStGrass ob3 = null;
        bool f1 = false;
        bool f2 = false;
        bool f3 = false;
        GameSettings settings = new GameSettings();
        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(GameSettings));
            string fileContent = System.IO.File.ReadAllText("GameSettings.json");
            settings = (GameSettings)json.ReadObject(new System.IO.MemoryStream(Encoding.UTF8.GetBytes(fileContent)));
        }

        private void BeginStType(object sender, EventArgs e)
        {
            f1 = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            menuStrip1.Items[0].Visible = false;
            ob1 = new StandardGrass(settings, 1);
            ob1.Arrangement();
            Continue(ob1);
        }

        private void BeginGrass(object sender, EventArgs e)
        {
            f2 = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            menuStrip1.Items[0].Visible = false;
            ob2 = new Grass(settings, 2);
            ob2.Arrangement();
            Continue(ob2);
        }

        private void BeginStAndGrass(object sender, EventArgs e)
        {
            f3 = true;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            menuStrip1.Items[0].Visible = false;
            ob3 = new GrassAndStGrass(settings, 3);
            ob3.Arrangement();
            Continue(ob3);
        }
        private void Continue(GameObject ob)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            textBox1.Enabled = true;
            bool flag = true;
            menuStrip1.Items[0].Visible = false;
            textBox1.Clear();
            flag = ob.Game(ob);
            Drawing(ob);
            if (!flag)
            {
                textBox1.Clear();
                textBox1.AppendText("Игра закончена!");
                menuStrip1.Items[0].Visible = true;
                button1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
                textBox1.Enabled = false;
                f1 = false;
            }
        }
        private void ContinueStand(object sender, EventArgs e)
        {
            f1 = true;
            StandardGrass ob = null;
            textBox1.Enabled = true;
            int str;
            StreamReader sr = new StreamReader("Game1.txt");
            if (sr.Peek() < 0)
            {
                sr.Close();
                textBox1.Clear();
                textBox1.AppendText("Такой сохраненной игры нет!");
            }
            else
            {
                sr.ReadLine();
                settings.height = Int32.Parse(sr.ReadLine());
                settings.width = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursDie = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursReproduce = Int32.Parse(sr.ReadLine());
                settings.minNeighboursReproduce = Int32.Parse(sr.ReadLine());
                ob = new StandardGrass(settings, 1);
                ob.age = Int32.Parse(sr.ReadLine());
                ob.kolLife = Int32.Parse(sr.ReadLine());
                for (int i = 0; i < ob.height; i++)
                {
                   for (int j = 0; j < ob.width; j++)
                   {
                       str = Int32.Parse(sr.ReadLine());
                            if (str == 1)
                            {
                                ob.gameField[i, j].type = 1;
                            }
                        }
                    }
                    sr.Close();
                    Continue(ob);
              }
        }
        private void ContinueGrass(object sender, EventArgs e)
        {
            f2 = true;
            Grass ob = null;
            textBox1.Enabled = true;
            int str;
            StreamReader sr = new StreamReader("Game2.txt");
            if (sr.Peek() < 0)
            {
                sr.Close();
                textBox1.Clear();
                textBox1.AppendText("Такой сохраненной игры нет!");
            }
            else
            {
                sr.ReadLine();
                settings.height = Int32.Parse(sr.ReadLine());
                settings.width = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursDie = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursReproduce = Int32.Parse(sr.ReadLine());
                settings.minNeighboursReproduce = Int32.Parse(sr.ReadLine());
                ob = new Grass(settings, 2);
                ob.age = Int32.Parse(sr.ReadLine());
                ob.kolLife = Int32.Parse(sr.ReadLine());
                for (int i = 0; i < ob.height; i++)
                {
                    for (int j = 0; j < ob.width; j++)
                    {
                        str = Int32.Parse(sr.ReadLine());
                        if (str == 2)
                        {
                            ob.gameField[i, j].type = 2;
                        }
                    }
                }
                sr.Close();
                Continue(ob);
            }
        }

        private void ContinueGrassAndStand(object sender, EventArgs e)
        {
            f3 = true;
            GrassAndStGrass ob = null;
            textBox1.Enabled = true;
            int str;
            StreamReader sr = new StreamReader("Game3.txt");
            if (sr.Peek() < 0)
            {
                sr.Close();
                textBox1.Clear();
                textBox1.AppendText("Такой сохраненной игры нет!");
            }
            else
            {
                sr.ReadLine();
                settings.height = Int32.Parse(sr.ReadLine());
                settings.width = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursDie = Int32.Parse(sr.ReadLine());
                settings.maxNeighboursReproduce = Int32.Parse(sr.ReadLine());
                settings.minNeighboursReproduce = Int32.Parse(sr.ReadLine());
                ob = new GrassAndStGrass(settings, 3);
                ob.age = Int32.Parse(sr.ReadLine());
                ob.kolLife = Int32.Parse(sr.ReadLine());
                for (int i = 0; i < ob.height; i++)
                {
                    for (int j = 0; j < ob.width; j++)
                    {
                        str = Int32.Parse(sr.ReadLine());
                        if (str == 2)
                        {
                            ob.gameField[i, j].type = 2;
                        }
                        if (str == 1)
                        {
                            ob.gameField[i, j].type = 1;
                        }
                    }
                }
                sr.Close();
                Continue(ob);
            }
        }

        private void WatchList(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox1.Clear();
            bool flag = false;
            StreamReader sr = null;
            sr = new StreamReader("Game1.txt");
            if (sr.Peek() >= 0)
            {
                textBox1.AppendText("--Доступна игра стандартного типа!\n");
                sr.Close();
                flag = true;
            }
            else
            {
                sr.Close();
            }
            sr = new StreamReader("Game2.txt");
            if (sr.Peek() >= 0)
            {
                textBox1.AppendText("--Доступна игра с возможностью размножения клеток!\n");
                sr.Close();
                flag = true;
            }
            else
            {
                sr.Close();
            }
            sr = new StreamReader("Game3.txt");
            if (sr.Peek() >= 0)
            {
                textBox1.AppendText("--Доступна игра смещанного типа!\n");
                sr.Close();
                flag = true;
            }
            else
            {
                sr.Close();
            }
            if (!flag)
            {
                textBox1.AppendText("--Нет доступных игр!\n");
            }
        }

        private void RemoveStandAndGrass(object sender, EventArgs e)
        {
            textBox1.Clear();
            Delete(3);
        }
        private void Delete(int k)
        {
            StreamWriter sr = null;
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
        }

        private void RemoveGrass(object sender, EventArgs e)
        {
            textBox1.Clear();
            Delete(2);
        }

        private void RemoveStand(object sender, EventArgs e)
        {
            textBox1.Clear();
            Delete(1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = null;
            if (f1)
            {
                sw = new StreamWriter("Game1.txt", false);
                Save(sw, ob1);
                f1 = false;
            }
            if (f2)
            {
                sw = new StreamWriter("Game2.txt", false);
                Save(sw, ob2);
                f2 = false;
            }
            if (f3)
            {
                sw = new StreamWriter("Game3.txt", false);
                Save(sw, ob3);
                f3 = false;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            f1 = false;
            f2 = false;
            f3 = false;
            menuStrip1.Items[0].Visible = true;
        }
        private void Save(StreamWriter sw, GameObject ob)
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (f1)
            {
                Continue(ob1);
            }
            if (f2)
            {
                Continue(ob2);
            }
            if (f3)
            {
                Continue(ob3);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            menuStrip1.Items[0].Visible = true;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            textBox1.Enabled = false;
            f1 = false;
            f2 = false;
            f3 = false;
        }
        public void Drawing(GameObject ob)
        {
            textBox1.AppendText("\n");
            for (int i = 0; i < ob.height; i++)
            {
                textBox1.AppendText("\n");
                for (int k = 0; k < ob.width; k++)
                {
                    textBox1.AppendText(" _  ");
                }
                textBox1.AppendText("\n");
                textBox1.AppendText("|");
                for (int j = 0; j < ob.width; j++)
                {
                    switch (ob.gameField[i, j].type)
                    {
                        case 1:
                            textBox1.AppendText(" # ");
                            break;
                        case 2: ;
                            textBox1.AppendText(" o ");
                            break;
                        default:
                            textBox1.AppendText("    ");
                            break;
                    }
                    textBox1.AppendText("|");
                }
            }
            textBox1.AppendText("\n");
            for (int k = 0; k < ob.width; k++)
            {
                textBox1.AppendText(" _  ");
            }

        }
    }
}
