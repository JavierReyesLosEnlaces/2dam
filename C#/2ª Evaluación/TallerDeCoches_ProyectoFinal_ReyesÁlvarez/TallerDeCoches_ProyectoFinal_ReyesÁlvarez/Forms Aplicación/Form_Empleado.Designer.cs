namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    partial class Form_Empleado
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
            tlp1_general = new TableLayoutPanel();
            btn_salir = new Button();
            tlp2_general = new TableLayoutPanel();
            button1 = new Button();
            bt_gestionar = new Button();
            tlp3_general = new TableLayoutPanel();
            bt_modificar = new Button();
            tlp1_general.SuspendLayout();
            tlp2_general.SuspendLayout();
            tlp3_general.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1_general
            // 
            tlp1_general.ColumnCount = 1;
            tlp1_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1_general.Controls.Add(tlp2_general, 0, 2);
            tlp1_general.Controls.Add(btn_salir, 0, 0);
            tlp1_general.Dock = DockStyle.Fill;
            tlp1_general.Location = new Point(0, 0);
            tlp1_general.Margin = new Padding(0);
            tlp1_general.Name = "tlp1_general";
            tlp1_general.RowCount = 3;
            tlp1_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp1_general.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            tlp1_general.RowStyles.Add(new RowStyle(SizeType.Percent, 92F));
            tlp1_general.Size = new Size(800, 632);
            tlp1_general.TabIndex = 0;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(117, 230, 164);
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(763, 2);
            btn_salir.Margin = new Padding(3, 2, 3, 2);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(34, 16);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // tlp2_general
            // 
            tlp2_general.BackColor = Color.White;
            tlp2_general.ColumnCount = 2;
            tlp2_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.2807F));
            tlp2_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.7193F));
            tlp2_general.Controls.Add(tlp3_general, 0, 0);
            tlp2_general.Dock = DockStyle.Fill;
            tlp2_general.Location = new Point(0, 68);
            tlp2_general.Margin = new Padding(0);
            tlp2_general.Name = "tlp2_general";
            tlp2_general.RowCount = 1;
            tlp2_general.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp2_general.Size = new Size(800, 564);
            tlp2_general.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 64);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 286);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(88, 133);
            button1.TabIndex = 5;
            button1.Text = "REGISTRAR EMPLEADO";
            button1.UseVisualStyleBackColor = false;
            // 
            // bt_gestionar
            // 
            bt_gestionar.BackColor = Color.FromArgb(0, 64, 64);
            bt_gestionar.Dock = DockStyle.Fill;
            bt_gestionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_gestionar.ForeColor = Color.White;
            bt_gestionar.Location = new Point(5, 145);
            bt_gestionar.Margin = new Padding(5, 4, 5, 4);
            bt_gestionar.Name = "bt_gestionar";
            bt_gestionar.Size = new Size(88, 133);
            bt_gestionar.TabIndex = 4;
            bt_gestionar.Text = "GESTIONAR PEDIDOS";
            bt_gestionar.UseVisualStyleBackColor = false;
            // 
            // tlp3_general
            // 
            tlp3_general.ColumnCount = 1;
            tlp3_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp3_general.Controls.Add(bt_modificar, 0, 0);
            tlp3_general.Controls.Add(bt_gestionar, 0, 1);
            tlp3_general.Controls.Add(button1, 0, 2);
            tlp3_general.Dock = DockStyle.Fill;
            tlp3_general.Location = new Point(0, 0);
            tlp3_general.Margin = new Padding(0);
            tlp3_general.Name = "tlp3_general";
            tlp3_general.RowCount = 4;
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp3_general.Size = new Size(98, 564);
            tlp3_general.TabIndex = 0;
            // 
            // bt_modificar
            // 
            bt_modificar.BackColor = Color.FromArgb(117, 230, 164);
            bt_modificar.Dock = DockStyle.Fill;
            bt_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_modificar.ForeColor = Color.White;
            bt_modificar.Location = new Point(5, 4);
            bt_modificar.Margin = new Padding(5, 4, 5, 4);
            bt_modificar.Name = "bt_modificar";
            bt_modificar.Size = new Size(88, 133);
            bt_modificar.TabIndex = 3;
            bt_modificar.Text = "BASE DE DATOS";
            bt_modificar.UseVisualStyleBackColor = false;
            // 
            // Form_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 632);
            Controls.Add(tlp1_general);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Empleado";
            Text = "Form1";
            tlp1_general.ResumeLayout(false);
            tlp2_general.ResumeLayout(false);
            tlp3_general.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1_general;
        private Button btn_salir;
        private TableLayoutPanel tlp2_general;
        private TableLayoutPanel tlp3_general;
        private Button bt_modificar;
        private Button bt_gestionar;
        private Button button1;
    }
}
