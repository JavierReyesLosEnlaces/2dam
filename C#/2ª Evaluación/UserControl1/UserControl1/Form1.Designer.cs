namespace UserControl1
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
            botonLabelCheck1 = new BotonLabelCheck();
            uCboton1 = new UCboton();
            visualizadorImagenes1 = new VisualizadorImagenes();
            textBox1 = new TextBox();
            buttonOpen = new Button();
            label_visualizador = new Label();
            SuspendLayout();
            // 
            // botonLabelCheck1
            // 
            botonLabelCheck1.Location = new Point(116, 91);
            botonLabelCheck1.Name = "botonLabelCheck1";
            botonLabelCheck1.Size = new Size(129, 23);
            botonLabelCheck1.TabIndex = 0;
            botonLabelCheck1.Text = "botonLabelCheck1";
            botonLabelCheck1.UseVisualStyleBackColor = true;
            // 
            // uCboton1
            // 
            uCboton1.Location = new Point(383, 91);
            uCboton1.Name = "uCboton1";
            uCboton1.Size = new Size(260, 230);
            uCboton1.TabIndex = 1;
            // 
            // visualizadorImagenes1
            // 
            visualizadorImagenes1.Location = new Point(97, 330);
            visualizadorImagenes1.Name = "visualizadorImagenes1";
            visualizadorImagenes1.Size = new Size(426, 128);
            visualizadorImagenes1.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 288);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(304, 23);
            textBox1.TabIndex = 3;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(416, 287);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(75, 23);
            buttonOpen.TabIndex = 4;
            buttonOpen.Text = "open";
            buttonOpen.UseVisualStyleBackColor = true;
            // 
            // label_visualizador
            // 
            label_visualizador.AutoSize = true;
            label_visualizador.Location = new Point(99, 258);
            label_visualizador.Name = "label_visualizador";
            label_visualizador.Size = new Size(139, 15);
            label_visualizador.TabIndex = 5;
            label_visualizador.Text = "visualizador de imágenes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(911, 697);
            Controls.Add(label_visualizador);
            Controls.Add(buttonOpen);
            Controls.Add(textBox1);
            Controls.Add(visualizadorImagenes1);
            Controls.Add(uCboton1);
            Controls.Add(botonLabelCheck1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private BotonLabelCheck botonLabelCheck1;
        private UCboton uCboton1;
        private VisualizadorImagenes visualizadorImagenes1;
        private TextBox textBox1;
        private Button buttonOpen;
        private Label label_visualizador;
    }
}