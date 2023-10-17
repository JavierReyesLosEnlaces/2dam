namespace HamburgueseríaWindowsForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            comprarHamburguesaToolStripMenuItem = new ToolStripMenuItem();
            quieresPanDeCentenoToolStripMenuItem = new ToolStripMenuItem();
            ConPanConCar = new ToolStripMenuItem();
            ConPanSinCar = new ToolStripMenuItem();
            quieresCarneDeVacunoToolStripMenuItem = new ToolStripMenuItem();
            SinPanConCar = new ToolStripMenuItem();
            SinPanSinCar = new ToolStripMenuItem();
            tienesSedToolStripMenuItem = new ToolStripMenuItem();
            conAl = new ToolStripMenuItem();
            sinAl = new ToolStripMenuItem();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Items.AddRange(new ToolStripItem[] { comprarHamburguesaToolStripMenuItem, tienesSedToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 45);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // comprarHamburguesaToolStripMenuItem
            // 
            comprarHamburguesaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { quieresPanDeCentenoToolStripMenuItem, quieresCarneDeVacunoToolStripMenuItem });
            comprarHamburguesaToolStripMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            comprarHamburguesaToolStripMenuItem.Name = "comprarHamburguesaToolStripMenuItem";
            comprarHamburguesaToolStripMenuItem.Size = new Size(195, 41);
            comprarHamburguesaToolStripMenuItem.Text = "Hamburguesa";
            // 
            // quieresPanDeCentenoToolStripMenuItem
            // 
            quieresPanDeCentenoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ConPanConCar, ConPanSinCar });
            quieresPanDeCentenoToolStripMenuItem.Name = "quieresPanDeCentenoToolStripMenuItem";
            quieresPanDeCentenoToolStripMenuItem.Size = new Size(333, 42);
            quieresPanDeCentenoToolStripMenuItem.Text = "Con pan de centeno";
            // 
            // ConPanConCar
            // 
            ConPanConCar.AccessibleName = "";
            ConPanConCar.Name = "ConPanConCar";
            ConPanConCar.Size = new Size(342, 42);
            ConPanConCar.Text = "Con carne de vacuno";
            ConPanConCar.Click += ConPanConCar_Click;
            // 
            // ConPanSinCar
            // 
            ConPanSinCar.Name = "ConPanSinCar";
            ConPanSinCar.Size = new Size(342, 42);
            ConPanSinCar.Text = "Sin carne de vacuno";
            ConPanSinCar.Click += ConPanSinCar_Click;
            // 
            // quieresCarneDeVacunoToolStripMenuItem
            // 
            quieresCarneDeVacunoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { SinPanConCar, SinPanSinCar });
            quieresCarneDeVacunoToolStripMenuItem.Name = "quieresCarneDeVacunoToolStripMenuItem";
            quieresCarneDeVacunoToolStripMenuItem.Size = new Size(333, 42);
            quieresCarneDeVacunoToolStripMenuItem.Text = "Sin pan de centeno";
            // 
            // SinPanConCar
            // 
            SinPanConCar.Name = "SinPanConCar";
            SinPanConCar.Size = new Size(342, 42);
            SinPanConCar.Text = "Con carne de vacuno";
            SinPanConCar.Click += SinPanConCar_Click;
            // 
            // SinPanSinCar
            // 
            SinPanSinCar.Name = "SinPanSinCar";
            SinPanSinCar.Size = new Size(342, 42);
            SinPanSinCar.Text = "Sin carne de vacuno";
            SinPanSinCar.Click += SinPanSinCar_Click;
            // 
            // tienesSedToolStripMenuItem
            // 
            tienesSedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { conAl, sinAl });
            tienesSedToolStripMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tienesSedToolStripMenuItem.Name = "tienesSedToolStripMenuItem";
            tienesSedToolStripMenuItem.Size = new Size(111, 41);
            tienesSedToolStripMenuItem.Text = "Bebida";
            // 
            // conAl
            // 
            conAl.Name = "conAl";
            conAl.Size = new Size(236, 42);
            conAl.Text = "Con alcohol";
            conAl.Click += conAl_Click;
            // 
            // sinAl
            // 
            sinAl.Name = "sinAl";
            sinAl.Size = new Size(236, 42);
            sinAl.Text = "Sin alcohol";
            sinAl.Click += sinAl_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(3, 31);
            button1.Name = "button1";
            button1.Size = new Size(85, 31);
            button1.TabIndex = 2;
            button1.Text = "TERMINAR?";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = SystemColors.InfoText;
            richTextBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.ForeColor = SystemColors.HighlightText;
            richTextBox1.Location = new Point(190, 226);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(425, 143);
            richTextBox1.TabIndex = 4;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(button1);
            panel1.Location = new Point(700, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 100);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(button2);
            panel2.Location = new Point(703, 226);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 100);
            panel2.TabIndex = 6;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(3, 31);
            button2.Name = "button2";
            button2.Size = new Size(85, 31);
            button2.TabIndex = 2;
            button2.Text = "RESETEAR?";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem comprarHamburguesaToolStripMenuItem;
        private ToolStripMenuItem tienesSedToolStripMenuItem;
        private ToolStripMenuItem quieresPanDeCentenoToolStripMenuItem;
        private ToolStripMenuItem quieresCarneDeVacunoToolStripMenuItem;
        private ToolStripMenuItem conAl;
        private ToolStripMenuItem sinAl;
        private ToolStripMenuItem ConPanConCar;
        private ToolStripMenuItem ConParSinCar;
        private Button button1;
        private ToolStripMenuItem SinPanConCar;
        private ToolStripMenuItem SinPanSinCar;
        private ToolStripMenuItem ConPanSinCar;
        private RichTextBox richTextBox1;
        private Panel panel1;
        private Panel panel2;
        private Button button2;
    }
}