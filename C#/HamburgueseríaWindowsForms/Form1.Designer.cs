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
            tienesSedToolStripMenuItem = new ToolStripMenuItem();
            quieresPanDeCentenoToolStripMenuItem = new ToolStripMenuItem();
            quieresCarneDeVacunoToolStripMenuItem = new ToolStripMenuItem();
            coToolStripMenuItem = new ToolStripMenuItem();
            sinAlcoholToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
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
            comprarHamburguesaToolStripMenuItem.Click += comprarHamburguesaToolStripMenuItem_Click;
            // 
            // tienesSedToolStripMenuItem
            // 
            tienesSedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { coToolStripMenuItem, sinAlcoholToolStripMenuItem });
            tienesSedToolStripMenuItem.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            tienesSedToolStripMenuItem.Name = "tienesSedToolStripMenuItem";
            tienesSedToolStripMenuItem.Size = new Size(111, 41);
            tienesSedToolStripMenuItem.Text = "Bebida";
            // 
            // quieresPanDeCentenoToolStripMenuItem
            // 
            quieresPanDeCentenoToolStripMenuItem.Name = "quieresPanDeCentenoToolStripMenuItem";
            quieresPanDeCentenoToolStripMenuItem.Size = new Size(342, 42);
            quieresPanDeCentenoToolStripMenuItem.Text = "Con pan de centeno";
            // 
            // quieresCarneDeVacunoToolStripMenuItem
            // 
            quieresCarneDeVacunoToolStripMenuItem.Name = "quieresCarneDeVacunoToolStripMenuItem";
            quieresCarneDeVacunoToolStripMenuItem.Size = new Size(342, 42);
            quieresCarneDeVacunoToolStripMenuItem.Text = "Con carne de vacuno";
            // 
            // coToolStripMenuItem
            // 
            coToolStripMenuItem.Name = "coToolStripMenuItem";
            coToolStripMenuItem.Size = new Size(236, 42);
            coToolStripMenuItem.Text = "Con alcohol";
            // 
            // sinAlcoholToolStripMenuItem
            // 
            sinAlcoholToolStripMenuItem.Name = "sinAlcoholToolStripMenuItem";
            sinAlcoholToolStripMenuItem.Size = new Size(236, 42);
            sinAlcoholToolStripMenuItem.Text = "Sin alcohol";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem comprarHamburguesaToolStripMenuItem;
        private ToolStripMenuItem tienesSedToolStripMenuItem;
        private ToolStripMenuItem quieresPanDeCentenoToolStripMenuItem;
        private ToolStripMenuItem quieresCarneDeVacunoToolStripMenuItem;
        private ToolStripMenuItem coToolStripMenuItem;
        private ToolStripMenuItem sinAlcoholToolStripMenuItem;
    }
}