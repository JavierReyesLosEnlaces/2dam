namespace Firebase_Ex3
{
    partial class Form2
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
            tableLayoutPanel1 = new TableLayoutPanel();
            Abrir = new Button();
            button2 = new Button();
            button3 = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(Abrir, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button3, 1, 1);
            tableLayoutPanel1.Location = new Point(50, 33);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(333, 71);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // Abrir
            // 
            Abrir.Location = new Point(3, 3);
            Abrir.Name = "Abrir";
            Abrir.Size = new Size(75, 23);
            Abrir.TabIndex = 0;
            Abrir.Text = "Abrir";
            Abrir.UseVisualStyleBackColor = true;
            Abrir.Click += Abrir_Click;
            // 
            // button2
            // 
            button2.Location = new Point(169, 3);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Insertar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_ClickAsync;
            // 
            // button3
            // 
            button3.Location = new Point(169, 38);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Recupar";
            button3.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(50, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(696, 287);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load_1;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button Abrir;
        private Button button2;
        private Button button3;
        private PictureBox pictureBox1;
    }
}