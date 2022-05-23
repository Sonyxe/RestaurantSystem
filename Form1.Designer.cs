namespace RestaurantSystem
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Date = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.Panel();
            this.FiestaTb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FiestaCb = new System.Windows.Forms.CheckBox();
            this.TunaTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TunaCb = new System.Windows.Forms.CheckBox();
            this.DiabloTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DiabloCb = new System.Windows.Forms.CheckBox();
            this.FoodTb = new System.Windows.Forms.Label();
            this.ReceiptTb = new System.Windows.Forms.Panel();
            this.Drinks = new System.Windows.Forms.Panel();
            this.CoffeeTb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CoffeeCb = new System.Windows.Forms.CheckBox();
            this.JuiceTb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.JuiceCb = new System.Windows.Forms.CheckBox();
            this.ColaTb = new System.Windows.Forms.TextBox();
            this.DrinksTb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ColaCb = new System.Windows.Forms.CheckBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Tables = new System.Windows.Forms.Panel();
            this.Table3Tb = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Table3Cb = new System.Windows.Forms.CheckBox();
            this.Table2Tb = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Table2Cb = new System.Windows.Forms.CheckBox();
            this.Table1Tb = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Table1Cb = new System.Windows.Forms.CheckBox();
            this.TablesTb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Food.SuspendLayout();
            this.Drinks.SuspendLayout();
            this.Tables.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.Date);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(32, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1156, 100);
            this.panel1.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.ForeColor = System.Drawing.Color.OrangeRed;
            this.Date.Location = new System.Drawing.Point(1027, 42);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(62, 25);
            this.Date.TabIndex = 1;
            this.Date.Text = "Timer";
            this.Date.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Date.Click += new System.EventHandler(this.Date_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumOrchid;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 46);
            this.label3.TabIndex = 1;
            this.label3.Text = "PIZZA";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Food
            // 
            this.Food.BackColor = System.Drawing.Color.Purple;
            this.Food.Controls.Add(this.FiestaTb);
            this.Food.Controls.Add(this.label6);
            this.Food.Controls.Add(this.FiestaCb);
            this.Food.Controls.Add(this.TunaTb);
            this.Food.Controls.Add(this.label5);
            this.Food.Controls.Add(this.TunaCb);
            this.Food.Controls.Add(this.DiabloTb);
            this.Food.Controls.Add(this.label4);
            this.Food.Controls.Add(this.DiabloCb);
            this.Food.Controls.Add(this.FoodTb);
            this.Food.Location = new System.Drawing.Point(314, 135);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(246, 404);
            this.Food.TabIndex = 1;
            // 
            // FiestaTb
            // 
            this.FiestaTb.Location = new System.Drawing.Point(166, 234);
            this.FiestaTb.Name = "FiestaTb";
            this.FiestaTb.Size = new System.Drawing.Size(37, 26);
            this.FiestaTb.TabIndex = 9;
            this.FiestaTb.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(71, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fiesta";
            // 
            // FiestaCb
            // 
            this.FiestaCb.AutoSize = true;
            this.FiestaCb.Location = new System.Drawing.Point(43, 238);
            this.FiestaCb.Name = "FiestaCb";
            this.FiestaCb.Size = new System.Drawing.Size(22, 21);
            this.FiestaCb.TabIndex = 7;
            this.FiestaCb.UseVisualStyleBackColor = true;
            this.FiestaCb.CheckedChanged += new System.EventHandler(this.FiestaCb_CheckedChanged);
            // 
            // TunaTb
            // 
            this.TunaTb.Location = new System.Drawing.Point(166, 169);
            this.TunaTb.Name = "TunaTb";
            this.TunaTb.Size = new System.Drawing.Size(37, 26);
            this.TunaTb.TabIndex = 6;
            this.TunaTb.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(71, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 22);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tuna";
            // 
            // TunaCb
            // 
            this.TunaCb.AutoSize = true;
            this.TunaCb.Location = new System.Drawing.Point(43, 173);
            this.TunaCb.Name = "TunaCb";
            this.TunaCb.Size = new System.Drawing.Size(22, 21);
            this.TunaCb.TabIndex = 4;
            this.TunaCb.UseVisualStyleBackColor = true;
            this.TunaCb.CheckedChanged += new System.EventHandler(this.TunaCb_CheckedChanged);
            // 
            // DiabloTb
            // 
            this.DiabloTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DiabloTb.Location = new System.Drawing.Point(166, 110);
            this.DiabloTb.Name = "DiabloTb";
            this.DiabloTb.Size = new System.Drawing.Size(37, 26);
            this.DiabloTb.TabIndex = 3;
            this.DiabloTb.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Diablo";
            // 
            // DiabloCb
            // 
            this.DiabloCb.AutoSize = true;
            this.DiabloCb.Location = new System.Drawing.Point(43, 114);
            this.DiabloCb.Name = "DiabloCb";
            this.DiabloCb.Size = new System.Drawing.Size(22, 21);
            this.DiabloCb.TabIndex = 1;
            this.DiabloCb.UseVisualStyleBackColor = true;
            this.DiabloCb.CheckedChanged += new System.EventHandler(this.DiabloCb_CheckedChanged);
            // 
            // FoodTb
            // 
            this.FoodTb.AutoSize = true;
            this.FoodTb.BackColor = System.Drawing.Color.MediumOrchid;
            this.FoodTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FoodTb.Location = new System.Drawing.Point(94, 31);
            this.FoodTb.Name = "FoodTb";
            this.FoodTb.Size = new System.Drawing.Size(61, 25);
            this.FoodTb.TabIndex = 0;
            this.FoodTb.Text = "Food";
            this.FoodTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReceiptTb
            // 
            this.ReceiptTb.BackColor = System.Drawing.Color.White;
            this.ReceiptTb.Location = new System.Drawing.Point(872, 135);
            this.ReceiptTb.Name = "ReceiptTb";
            this.ReceiptTb.Size = new System.Drawing.Size(316, 276);
            this.ReceiptTb.TabIndex = 2;
            // 
            // Drinks
            // 
            this.Drinks.BackColor = System.Drawing.Color.Purple;
            this.Drinks.Controls.Add(this.CoffeeTb);
            this.Drinks.Controls.Add(this.label9);
            this.Drinks.Controls.Add(this.CoffeeCb);
            this.Drinks.Controls.Add(this.JuiceTb);
            this.Drinks.Controls.Add(this.label8);
            this.Drinks.Controls.Add(this.JuiceCb);
            this.Drinks.Controls.Add(this.ColaTb);
            this.Drinks.Controls.Add(this.DrinksTb);
            this.Drinks.Controls.Add(this.label7);
            this.Drinks.Controls.Add(this.ColaCb);
            this.Drinks.Location = new System.Drawing.Point(595, 135);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(246, 404);
            this.Drinks.TabIndex = 2;
            // 
            // CoffeeTb
            // 
            this.CoffeeTb.Location = new System.Drawing.Point(166, 230);
            this.CoffeeTb.Name = "CoffeeTb";
            this.CoffeeTb.Size = new System.Drawing.Size(37, 26);
            this.CoffeeTb.TabIndex = 18;
            this.CoffeeTb.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(71, 234);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Coffee";
            // 
            // CoffeeCb
            // 
            this.CoffeeCb.AutoSize = true;
            this.CoffeeCb.Location = new System.Drawing.Point(43, 234);
            this.CoffeeCb.Name = "CoffeeCb";
            this.CoffeeCb.Size = new System.Drawing.Size(22, 21);
            this.CoffeeCb.TabIndex = 16;
            this.CoffeeCb.UseVisualStyleBackColor = true;
            this.CoffeeCb.CheckedChanged += new System.EventHandler(this.CoffeeCb_CheckedChanged);
            // 
            // JuiceTb
            // 
            this.JuiceTb.Location = new System.Drawing.Point(166, 169);
            this.JuiceTb.Name = "JuiceTb";
            this.JuiceTb.Size = new System.Drawing.Size(37, 26);
            this.JuiceTb.TabIndex = 15;
            this.JuiceTb.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(71, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Juice";
            // 
            // JuiceCb
            // 
            this.JuiceCb.AutoSize = true;
            this.JuiceCb.Location = new System.Drawing.Point(43, 173);
            this.JuiceCb.Name = "JuiceCb";
            this.JuiceCb.Size = new System.Drawing.Size(22, 21);
            this.JuiceCb.TabIndex = 13;
            this.JuiceCb.UseVisualStyleBackColor = true;
            this.JuiceCb.CheckedChanged += new System.EventHandler(this.JuiceCb_CheckedChanged);
            // 
            // ColaTb
            // 
            this.ColaTb.Location = new System.Drawing.Point(167, 110);
            this.ColaTb.Name = "ColaTb";
            this.ColaTb.Size = new System.Drawing.Size(37, 26);
            this.ColaTb.TabIndex = 12;
            this.ColaTb.Text = "0";
            // 
            // DrinksTb
            // 
            this.DrinksTb.AutoSize = true;
            this.DrinksTb.BackColor = System.Drawing.Color.MediumOrchid;
            this.DrinksTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DrinksTb.Location = new System.Drawing.Point(84, 31);
            this.DrinksTb.Name = "DrinksTb";
            this.DrinksTb.Size = new System.Drawing.Size(73, 25);
            this.DrinksTb.TabIndex = 1;
            this.DrinksTb.Text = "Drinks";
            this.DrinksTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(72, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cola";
            // 
            // ColaCb
            // 
            this.ColaCb.AutoSize = true;
            this.ColaCb.Location = new System.Drawing.Point(44, 114);
            this.ColaCb.Name = "ColaCb";
            this.ColaCb.Size = new System.Drawing.Size(22, 21);
            this.ColaCb.TabIndex = 10;
            this.ColaCb.UseVisualStyleBackColor = true;
            this.ColaCb.CheckedChanged += new System.EventHandler(this.ColaCb_CheckedChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Tables
            // 
            this.Tables.BackColor = System.Drawing.Color.Purple;
            this.Tables.Controls.Add(this.Table3Tb);
            this.Tables.Controls.Add(this.label10);
            this.Tables.Controls.Add(this.Table3Cb);
            this.Tables.Controls.Add(this.Table2Tb);
            this.Tables.Controls.Add(this.label11);
            this.Tables.Controls.Add(this.Table2Cb);
            this.Tables.Controls.Add(this.Table1Tb);
            this.Tables.Controls.Add(this.label12);
            this.Tables.Controls.Add(this.Table1Cb);
            this.Tables.Controls.Add(this.TablesTb);
            this.Tables.Location = new System.Drawing.Point(32, 135);
            this.Tables.Name = "Tables";
            this.Tables.Size = new System.Drawing.Size(246, 404);
            this.Tables.TabIndex = 10;
            // 
            // Table3Tb
            // 
            this.Table3Tb.Location = new System.Drawing.Point(166, 234);
            this.Table3Tb.Name = "Table3Tb";
            this.Table3Tb.Size = new System.Drawing.Size(37, 26);
            this.Table3Tb.TabIndex = 9;
            this.Table3Tb.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(71, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 22);
            this.label10.TabIndex = 8;
            this.label10.Text = "Table3";
            // 
            // Table3Cb
            // 
            this.Table3Cb.AutoSize = true;
            this.Table3Cb.Location = new System.Drawing.Point(43, 238);
            this.Table3Cb.Name = "Table3Cb";
            this.Table3Cb.Size = new System.Drawing.Size(22, 21);
            this.Table3Cb.TabIndex = 7;
            this.Table3Cb.UseVisualStyleBackColor = true;
            this.Table3Cb.CheckedChanged += new System.EventHandler(this.Table3Cb_CheckedChanged);
            // 
            // Table2Tb
            // 
            this.Table2Tb.Location = new System.Drawing.Point(166, 169);
            this.Table2Tb.Name = "Table2Tb";
            this.Table2Tb.Size = new System.Drawing.Size(37, 26);
            this.Table2Tb.TabIndex = 6;
            this.Table2Tb.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(71, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 22);
            this.label11.TabIndex = 5;
            this.label11.Text = "Table2";
            // 
            // Table2Cb
            // 
            this.Table2Cb.AutoSize = true;
            this.Table2Cb.Location = new System.Drawing.Point(43, 173);
            this.Table2Cb.Name = "Table2Cb";
            this.Table2Cb.Size = new System.Drawing.Size(22, 21);
            this.Table2Cb.TabIndex = 4;
            this.Table2Cb.UseVisualStyleBackColor = true;
            this.Table2Cb.CheckedChanged += new System.EventHandler(this.Table2Cb_CheckedChanged);
            // 
            // Table1Tb
            // 
            this.Table1Tb.Location = new System.Drawing.Point(166, 110);
            this.Table1Tb.Name = "Table1Tb";
            this.Table1Tb.Size = new System.Drawing.Size(37, 26);
            this.Table1Tb.TabIndex = 3;
            this.Table1Tb.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(71, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 22);
            this.label12.TabIndex = 2;
            this.label12.Text = "Table1";
            // 
            // Table1Cb
            // 
            this.Table1Cb.AutoSize = true;
            this.Table1Cb.Location = new System.Drawing.Point(43, 114);
            this.Table1Cb.Name = "Table1Cb";
            this.Table1Cb.Size = new System.Drawing.Size(22, 21);
            this.Table1Cb.TabIndex = 1;
            this.Table1Cb.UseVisualStyleBackColor = true;
            this.Table1Cb.CheckedChanged += new System.EventHandler(this.Table1Cb_CheckedChanged);
            // 
            // TablesTb
            // 
            this.TablesTb.AutoSize = true;
            this.TablesTb.BackColor = System.Drawing.Color.MediumOrchid;
            this.TablesTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesTb.Location = new System.Drawing.Point(82, 31);
            this.TablesTb.Name = "TablesTb";
            this.TablesTb.Size = new System.Drawing.Size(78, 25);
            this.TablesTb.TabIndex = 0;
            this.TablesTb.Text = "Tables";
            this.TablesTb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(868, 449);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "SubTotal";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkMagenta;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Crimson;
            this.button1.Location = new System.Drawing.Point(872, 492);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Reset";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(1106, 449);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 13;
            this.label2.Text = "Total";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkMagenta;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Crimson;
            this.button2.Location = new System.Drawing.Point(1101, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 31);
            this.button2.TabIndex = 14;
            this.button2.Text = "Print";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(1000, 449);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 22);
            this.label13.TabIndex = 15;
            this.label13.Text = "Tax";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkMagenta;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.DarkMagenta;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Crimson;
            this.button3.Location = new System.Drawing.Point(987, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 31);
            this.button3.TabIndex = 16;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1215, 564);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tables);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.ReceiptTb);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Food.ResumeLayout(false);
            this.Food.PerformLayout();
            this.Drinks.ResumeLayout(false);
            this.Drinks.PerformLayout();
            this.Tables.ResumeLayout(false);
            this.Tables.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel Food;
        private System.Windows.Forms.Label FoodTb;
        private System.Windows.Forms.Panel ReceiptTb;
        private System.Windows.Forms.Panel Drinks;
        private System.Windows.Forms.Label DrinksTb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox FiestaTb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox FiestaCb;
        private System.Windows.Forms.TextBox TunaTb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox TunaCb;
        private System.Windows.Forms.TextBox DiabloTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox DiabloCb;
        private System.Windows.Forms.TextBox CoffeeTb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox CoffeeCb;
        private System.Windows.Forms.TextBox JuiceTb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox JuiceCb;
        private System.Windows.Forms.TextBox ColaTb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ColaCb;
        private System.Windows.Forms.Panel Tables;
        private System.Windows.Forms.TextBox Table3Tb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox Table3Cb;
        private System.Windows.Forms.TextBox Table2Tb;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox Table2Cb;
        private System.Windows.Forms.TextBox Table1Tb;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox Table1Cb;
        private System.Windows.Forms.Label TablesTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button3;
    }
}

