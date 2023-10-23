namespace GuessNumber_Ex3
{
    partial class NuevoJuegoDeAdivinar
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
            button1 = new Button();
            lbl_debug = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lbl_debug.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_info
            // 
            lbl_info.AutoSize = true;
            lbl_info.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_info.Location = new Point(112, 65);
            lbl_info.Name = "lbl_info";
            lbl_info.Size = new Size(338, 37);
            lbl_info.TabIndex = 0;
            lbl_info.Text = "Información por pantalla";
            // 
            // lbl_intentos
            // 
            lbl_intentos.AutoSize = true;
            lbl_intentos.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_intentos.Location = new Point(232, 226);
            lbl_intentos.Name = "lbl_intentos";
            lbl_intentos.Size = new Size(87, 28);
            lbl_intentos.TabIndex = 1;
            lbl_intentos.Text = "Intentos:";
            // 
            // txt_bx_usuario
            // 
            txt_bx_usuario.Location = new Point(148, 158);
            txt_bx_usuario.Name = "txt_bx_usuario";
            txt_bx_usuario.PlaceholderText = "Introduce un número";
            txt_bx_usuario.Size = new Size(256, 23);
            txt_bx_usuario.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(217, 271);
            button1.Name = "button1";
            button1.Size = new Size(120, 60);
            button1.TabIndex = 3;
            button1.Text = "PULSAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lbl_debug
            // 
            lbl_debug.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            lbl_debug.Location = new Point(0, 416);
            lbl_debug.Name = "lbl_debug";
            lbl_debug.Size = new Size(559, 22);
            lbl_debug.TabIndex = 4;
            lbl_debug.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(85, 17);
            toolStripStatusLabel1.Text = "numeroOculto";
            // 
            // NuevoJuegoDeAdivinar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 438);
            Controls.Add(lbl_debug);
            Controls.Add(button1);
            Controls.Add(txt_bx_usuario);
            Controls.Add(lbl_intentos);
            Controls.Add(lbl_info);
            Name = "NuevoJuegoDeAdivinar";
            Text = "Form1";
            lbl_debug.ResumeLayout(false);
            lbl_debug.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_info;
        private Label lbl_intentos;
        private TextBox txt_bx_usuario;
        private Button button1;
        private StatusStrip lbl_debug;
        private ToolStripStatusLabel toolStripStatusLabel1;
    }
}