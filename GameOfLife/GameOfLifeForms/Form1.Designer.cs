namespace GameOfLifeForms
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.менюИгрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.начатьНовуюИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартногоТипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сКлеткамиТипаТраваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.смешанногоТипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.продолжитьИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартногоТипаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.сКлеткамиТипаТраваToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.смещанногоТипаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.посмотретьСписокСохраненнныхИгрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьСохраненнуюИгруToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стандартногоToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сКлеткамиТипаТраваToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.смешанногоТипаToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.менюИгрыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(393, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // менюИгрыToolStripMenuItem
            // 
            this.менюИгрыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.начатьНовуюИгруToolStripMenuItem,
            this.продолжитьИгруToolStripMenuItem,
            this.посмотретьСписокСохраненнныхИгрToolStripMenuItem,
            this.удалитьСохраненнуюИгруToolStripMenuItem});
            this.менюИгрыToolStripMenuItem.Name = "менюИгрыToolStripMenuItem";
            this.менюИгрыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.менюИгрыToolStripMenuItem.Text = "Меню игры";
            // 
            // начатьНовуюИгруToolStripMenuItem
            // 
            this.начатьНовуюИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартногоТипаToolStripMenuItem,
            this.сКлеткамиТипаТраваToolStripMenuItem,
            this.смешанногоТипаToolStripMenuItem});
            this.начатьНовуюИгруToolStripMenuItem.Name = "начатьНовуюИгруToolStripMenuItem";
            this.начатьНовуюИгруToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.начатьНовуюИгруToolStripMenuItem.Text = "Начать новую игру";
            // 
            // стандартногоТипаToolStripMenuItem
            // 
            this.стандартногоТипаToolStripMenuItem.Name = "стандартногоТипаToolStripMenuItem";
            this.стандартногоТипаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.стандартногоТипаToolStripMenuItem.Text = "Стандартного типа";
            this.стандартногоТипаToolStripMenuItem.Click += new System.EventHandler(this.BeginStType);
            // 
            // сКлеткамиТипаТраваToolStripMenuItem
            // 
            this.сКлеткамиТипаТраваToolStripMenuItem.Name = "сКлеткамиТипаТраваToolStripMenuItem";
            this.сКлеткамиТипаТраваToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.сКлеткамиТипаТраваToolStripMenuItem.Text = "С клетками типа Трава";
            this.сКлеткамиТипаТраваToolStripMenuItem.Click += new System.EventHandler(this.BeginGrass);
            // 
            // смешанногоТипаToolStripMenuItem
            // 
            this.смешанногоТипаToolStripMenuItem.Name = "смешанногоТипаToolStripMenuItem";
            this.смешанногоТипаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.смешанногоТипаToolStripMenuItem.Text = "Смешанного типа";
            this.смешанногоТипаToolStripMenuItem.Click += new System.EventHandler(this.BeginStAndGrass);
            // 
            // продолжитьИгруToolStripMenuItem
            // 
            this.продолжитьИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартногоТипаToolStripMenuItem1,
            this.сКлеткамиТипаТраваToolStripMenuItem1,
            this.смещанногоТипаToolStripMenuItem});
            this.продолжитьИгруToolStripMenuItem.Name = "продолжитьИгруToolStripMenuItem";
            this.продолжитьИгруToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.продолжитьИгруToolStripMenuItem.Text = "Продолжить игру";
            // 
            // стандартногоТипаToolStripMenuItem1
            // 
            this.стандартногоТипаToolStripMenuItem1.Name = "стандартногоТипаToolStripMenuItem1";
            this.стандартногоТипаToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.стандартногоТипаToolStripMenuItem1.Text = "Стандартного типа";
            this.стандартногоТипаToolStripMenuItem1.Click += new System.EventHandler(this.ContinueStand);
            // 
            // сКлеткамиТипаТраваToolStripMenuItem1
            // 
            this.сКлеткамиТипаТраваToolStripMenuItem1.Name = "сКлеткамиТипаТраваToolStripMenuItem1";
            this.сКлеткамиТипаТраваToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.сКлеткамиТипаТраваToolStripMenuItem1.Text = "С клетками типа Трава";
            this.сКлеткамиТипаТраваToolStripMenuItem1.Click += new System.EventHandler(this.ContinueGrass);
            // 
            // смещанногоТипаToolStripMenuItem
            // 
            this.смещанногоТипаToolStripMenuItem.Name = "смещанногоТипаToolStripMenuItem";
            this.смещанногоТипаToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.смещанногоТипаToolStripMenuItem.Text = "Смешанного типа";
            this.смещанногоТипаToolStripMenuItem.Click += new System.EventHandler(this.ContinueGrassAndStand);
            // 
            // посмотретьСписокСохраненнныхИгрToolStripMenuItem
            // 
            this.посмотретьСписокСохраненнныхИгрToolStripMenuItem.Name = "посмотретьСписокСохраненнныхИгрToolStripMenuItem";
            this.посмотретьСписокСохраненнныхИгрToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.посмотретьСписокСохраненнныхИгрToolStripMenuItem.Text = "Посмотреть список сохраненнных  игр";
            this.посмотретьСписокСохраненнныхИгрToolStripMenuItem.Click += new System.EventHandler(this.WatchList);
            // 
            // удалитьСохраненнуюИгруToolStripMenuItem
            // 
            this.удалитьСохраненнуюИгруToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стандартногоToolStripMenuItem,
            this.сКлеткамиТипаТраваToolStripMenuItem2,
            this.смешанногоТипаToolStripMenuItem1});
            this.удалитьСохраненнуюИгруToolStripMenuItem.Name = "удалитьСохраненнуюИгруToolStripMenuItem";
            this.удалитьСохраненнуюИгруToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.удалитьСохраненнуюИгруToolStripMenuItem.Text = "Удалить сохраненную игру";
            // 
            // стандартногоToolStripMenuItem
            // 
            this.стандартногоToolStripMenuItem.Name = "стандартногоToolStripMenuItem";
            this.стандартногоToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.стандартногоToolStripMenuItem.Text = "Стандартного типа";
            this.стандартногоToolStripMenuItem.Click += new System.EventHandler(this.RemoveStand);
            // 
            // сКлеткамиТипаТраваToolStripMenuItem2
            // 
            this.сКлеткамиТипаТраваToolStripMenuItem2.Name = "сКлеткамиТипаТраваToolStripMenuItem2";
            this.сКлеткамиТипаТраваToolStripMenuItem2.Size = new System.Drawing.Size(200, 22);
            this.сКлеткамиТипаТраваToolStripMenuItem2.Text = "С клетками типа Трава";
            this.сКлеткамиТипаТраваToolStripMenuItem2.Click += new System.EventHandler(this.RemoveGrass);
            // 
            // смешанногоТипаToolStripMenuItem1
            // 
            this.смешанногоТипаToolStripMenuItem1.Name = "смешанногоТипаToolStripMenuItem1";
            this.смешанногоТипаToolStripMenuItem1.Size = new System.Drawing.Size(200, 22);
            this.смешанногоТипаToolStripMenuItem1.Text = "Смешанного типа";
            this.смешанногоТипаToolStripMenuItem1.Click += new System.EventHandler(this.RemoveStandAndGrass);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 47);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(355, 274);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 327);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(85, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Продолжить ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(270, 327);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Закончить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 362);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GameOfLife";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem менюИгрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem начатьНовуюИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартногоТипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сКлеткамиТипаТраваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem смешанногоТипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem продолжитьИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартногоТипаToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem сКлеткамиТипаТраваToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem смещанногоТипаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem посмотретьСписокСохраненнныхИгрToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьСохраненнуюИгруToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem стандартногоToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сКлеткамиТипаТраваToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem смешанногоТипаToolStripMenuItem1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

