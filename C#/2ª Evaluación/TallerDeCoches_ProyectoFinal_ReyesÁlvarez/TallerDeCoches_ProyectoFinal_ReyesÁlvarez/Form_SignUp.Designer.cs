namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    partial class Form_SignUp
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
            tb2 = new TextBox();
            tb1 = new TextBox();
            btn_registrarse = new Button();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tb2
            // 
            tb2.Dock = DockStyle.Fill;
            tb2.Location = new Point(22, 40);
            tb2.Margin = new Padding(22, 0, 22, 0);
            tb2.Name = "tb2";
            tb2.PlaceholderText = "Contraseña";
            tb2.Size = new Size(156, 23);
            tb2.TabIndex = 0;
            // 
            // tb1
            // 
            tb1.Dock = DockStyle.Fill;
            tb1.Location = new Point(22, 0);
            tb1.Margin = new Padding(22, 0, 22, 0);
            tb1.Name = "tb1";
            tb1.PlaceholderText = "Usuario";
            tb1.Size = new Size(156, 23);
            tb1.TabIndex = 1;
            // 
            // btn_registrarse
            // 
            btn_registrarse.Dock = DockStyle.Fill;
            btn_registrarse.Location = new Point(20, 83);
            btn_registrarse.Margin = new Padding(20, 3, 20, 3);
            btn_registrarse.Name = "btn_registrarse";
            btn_registrarse.Size = new Size(160, 29);
            btn_registrarse.TabIndex = 2;
            btn_registrarse.Text = "Registrarse";
            btn_registrarse.UseVisualStyleBackColor = true;
            btn_registrarse.Click += btn_registrarse_Click;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(tb2, 0, 1);
            tableLayoutPanel3.Controls.Add(tb1, 0, 0);
            tableLayoutPanel3.Controls.Add(btn_registrarse, 0, 2);
            tableLayoutPanel3.Location = new Point(272, 148);
            tableLayoutPanel3.Margin = new Padding(100, 130, 100, 130);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(200, 115);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // Form_SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(745, 410);
            Controls.Add(tableLayoutPanel3);
            Name = "Form_SignUp";
            Text = "Form1";
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox tb2;
        private TextBox tb1;
        private Button btn_registrarse;
        private TableLayoutPanel tableLayoutPanel3;
    }
}