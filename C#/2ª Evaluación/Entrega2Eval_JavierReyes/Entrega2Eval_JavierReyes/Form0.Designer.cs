﻿namespace Entrega2Eval_JavierReyes
{
    partial class Form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            btnEmpezar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelTitulo1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEmpezar, 0, 1);
            tableLayoutPanel1.Location = new Point(0, 332);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(547, 129);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Jokerman", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(541, 64);
            label1.TabIndex = 3;
            label1.Text = "'LOS ENLACES'";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEmpezar
            // 
            btnEmpezar.BackColor = Color.Black;
            btnEmpezar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmpezar.Dock = DockStyle.Fill;
            btnEmpezar.FlatAppearance.BorderColor = Color.White;
            btnEmpezar.FlatAppearance.BorderSize = 3;
            btnEmpezar.FlatStyle = FlatStyle.Flat;
            btnEmpezar.Font = new Font("Jokerman", 24F, FontStyle.Bold);
            btnEmpezar.ForeColor = Color.White;
            btnEmpezar.Location = new Point(0, 64);
            btnEmpezar.Margin = new Padding(0);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(547, 65);
            btnEmpezar.TabIndex = 2;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.MouseEnter += btnEmpezar_MouseEnter;
            btnEmpezar.MouseLeave += btnEmpezar_MouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelTitulo1, 0, 0);
            tableLayoutPanel2.Font = new Font("Jokerman", 19.8000011F, FontStyle.Bold);
            tableLayoutPanel2.Location = new Point(0, 9);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(547, 159);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.BackColor = Color.Transparent;
            labelTitulo1.Dock = DockStyle.Fill;
            labelTitulo1.Font = new Font("Jokerman", 30F, FontStyle.Bold);
            labelTitulo1.ForeColor = Color.White;
            labelTitulo1.Location = new Point(3, 0);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(541, 159);
            labelTitulo1.TabIndex = 0;
            labelTitulo1.Text = "BIENVENIDO A LA HAMBURGUESERÍA ";
            labelTitulo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 170, 1);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(547, 461);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form0_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTitulo1;
        private Button btnEmpezar;
        private Label label1;
    }
}