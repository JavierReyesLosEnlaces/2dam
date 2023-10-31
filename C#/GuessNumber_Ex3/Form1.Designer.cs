namespace GuessNumber_Ex3
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
            lbl_info = new Label();
            lbl_intentos = new Label();
            txt_bx_usuario = new TextBox();
            btn_Boton = new Button();
            status_strip = new StatusStrip();
            lbl_debug = new ToolStripStatusLabel();
            lbl_rnd_mes = new ToolStripStatusLabel();
            btn_newForm = new Button();
            status_strip.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_info
            // 
            lbl_info.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_info.Location = new Point(102, 12);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(425, 169);
            lbl_info.TabIndex = 0;
            lbl_info.Text = "Información por pantalla";
            lbl_info.TextAlign = ContentAlignment.MiddleCenter;
            lbl_info.UseCompatibleTextRendering = true;
            // 
            // lbl_intentos
            // 
            lbl_intentos.AutoSize = true;
            lbl_intentos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_intentos.Location = new Point(265, 301);
            lbl_intentos.Name = "lbl_intentos";
            lbl_intentos.Size = new Size(110, 35);
            lbl_intentos.TabIndex = 1;
            lbl_intentos.Text = "Intentos:";
            // 
            // txt_bx_usuario
            // 
            txt_bx_usuario.Location = new Point(169, 211);
            txt_bx_usuario.Margin = new Padding(3, 4, 3, 4);
            txt_bx_usuario.Name = "txt_bx_usuario";
            txt_bx_usuario.PlaceholderText = "Introduce un número";
            txt_bx_usuario.Size = new Size(292, 27);
            txt_bx_usuario.TabIndex = 2;
            // 
            // btn_Boton
            // 
            btn_Boton.Location = new Point(248, 361);
            btn_Boton.Margin = new Padding(3, 4, 3, 4);
            btn_Boton.Name = "btn_Boton";
            btn_Boton.Size = new Size(137, 80);
            btn_Boton.TabIndex = 3;
            btn_Boton.Text = "PULSAR";
            btn_Boton.UseVisualStyleBackColor = true;
            btn_Boton.Click += button1_Click;
            // 
            // status_strip
            // 
            status_strip.ImageScalingSize = new Size(20, 20);
            status_strip.Items.AddRange(new ToolStripItem[] { lbl_debug, lbl_rnd_mes });
            status_strip.Location = new Point(0, 558);
            status_strip.Name = "status_strip";
            status_strip.Padding = new Padding(1, 0, 16, 0);
            status_strip.Size = new Size(639, 26);
            status_strip.TabIndex = 4;
            status_strip.Text = "statusStrip1";
            // 
            // lbl_debug
            // 
            lbl_debug.Name = "lbl_debug";
            lbl_debug.Size = new Size(15, 20);
            lbl_debug.Text = "-";
            // 
            // lbl_rnd_mes
            // 
            lbl_rnd_mes.Name = "lbl_rnd_mes";
            lbl_rnd_mes.Size = new Size(15, 20);
            lbl_rnd_mes.Text = "-";
            // 
            // btn_newForm
            // 
            btn_newForm.Location = new Point(539, 497);
            btn_newForm.Margin = new Padding(3, 4, 3, 4);
            btn_newForm.Name = "btn_newForm";
            btn_newForm.Size = new Size(86, 31);
            btn_newForm.TabIndex = 5;
            btn_newForm.Text = "Ver imagen";
            btn_newForm.UseVisualStyleBackColor = true;
            btn_newForm.Click += btn_newForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 584);
            Controls.Add(btn_newForm);
            Controls.Add(status_strip);
            Controls.Add(btn_Boton);
            Controls.Add(txt_bx_usuario);
            Controls.Add(lbl_intentos);
            Controls.Add(lbl_info);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            status_strip.ResumeLayout(false);
            status_strip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_info;
        private Label lbl_intentos;
        private TextBox txt_bx_usuario;
        private Button btn_Boton;
        private StatusStrip status_strip;
        private ToolStripStatusLabel lbl_debug;
        private Button btn_newForm;
        private ToolStripStatusLabel lbl_rnd_mes;
    }
}