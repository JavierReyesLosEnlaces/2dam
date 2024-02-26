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
            tlp3_general = new TableLayoutPanel();
            bt_consultar = new Button();
            bt_insertar = new Button();
            bt_borrar = new Button();
            bt_modificar = new Button();
            bt_gestionar = new Button();
            button1 = new Button();
            tlp1_general.SuspendLayout();
            tlp2_general.SuspendLayout();
            tlp3_general.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1_general
            // 
            tlp1_general.ColumnCount = 1;
            tlp1_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1_general.Controls.Add(btn_salir, 0, 0);
            tlp1_general.Controls.Add(tlp2_general, 0, 1);
            tlp1_general.Dock = DockStyle.Fill;
            tlp1_general.Location = new Point(0, 0);
            tlp1_general.Margin = new Padding(0);
            tlp1_general.Name = "tlp1_general";
            tlp1_general.RowCount = 2;
            tlp1_general.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp1_general.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlp1_general.Size = new Size(800, 442);
            tlp1_general.TabIndex = 0;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(117, 230, 164);
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(771, 2);
            btn_salir.Margin = new Padding(3, 2, 3, 2);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(26, 18);
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
            tlp2_general.Location = new Point(0, 22);
            tlp2_general.Margin = new Padding(0);
            tlp2_general.Name = "tlp2_general";
            tlp2_general.RowCount = 1;
            tlp2_general.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp2_general.Size = new Size(800, 420);
            tlp2_general.TabIndex = 2;
            // 
            // tlp3_general
            // 
            tlp3_general.ColumnCount = 1;
            tlp3_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp3_general.Controls.Add(bt_consultar, 0, 1);
            tlp3_general.Controls.Add(bt_insertar, 0, 2);
            tlp3_general.Controls.Add(bt_borrar, 0, 3);
            tlp3_general.Controls.Add(bt_modificar, 0, 4);
            tlp3_general.Controls.Add(bt_gestionar, 0, 5);
            tlp3_general.Controls.Add(button1, 0, 6);
            tlp3_general.Dock = DockStyle.Fill;
            tlp3_general.Location = new Point(0, 0);
            tlp3_general.Margin = new Padding(0);
            tlp3_general.Name = "tlp3_general";
            tlp3_general.RowCount = 8;
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp3_general.Size = new Size(98, 420);
            tlp3_general.TabIndex = 0;
            // 
            // bt_consultar
            // 
            bt_consultar.BackColor = Color.FromArgb(117, 230, 164);
            bt_consultar.Dock = DockStyle.Fill;
            bt_consultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_consultar.ForeColor = Color.White;
            bt_consultar.Location = new Point(5, 56);
            bt_consultar.Margin = new Padding(5, 4, 5, 4);
            bt_consultar.Name = "bt_consultar";
            bt_consultar.Size = new Size(88, 44);
            bt_consultar.TabIndex = 0;
            bt_consultar.Text = "CONSULTAR";
            bt_consultar.UseVisualStyleBackColor = false;
            // 
            // bt_insertar
            // 
            bt_insertar.BackColor = Color.FromArgb(117, 230, 164);
            bt_insertar.Dock = DockStyle.Fill;
            bt_insertar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_insertar.ForeColor = Color.White;
            bt_insertar.Location = new Point(5, 108);
            bt_insertar.Margin = new Padding(5, 4, 5, 4);
            bt_insertar.Name = "bt_insertar";
            bt_insertar.Size = new Size(88, 44);
            bt_insertar.TabIndex = 1;
            bt_insertar.Text = "INSERTAR";
            bt_insertar.UseVisualStyleBackColor = false;
            // 
            // bt_borrar
            // 
            bt_borrar.BackColor = Color.FromArgb(117, 230, 164);
            bt_borrar.Dock = DockStyle.Fill;
            bt_borrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_borrar.ForeColor = Color.White;
            bt_borrar.Location = new Point(5, 160);
            bt_borrar.Margin = new Padding(5, 4, 5, 4);
            bt_borrar.Name = "bt_borrar";
            bt_borrar.Size = new Size(88, 44);
            bt_borrar.TabIndex = 2;
            bt_borrar.Text = "BORRAR";
            bt_borrar.UseVisualStyleBackColor = false;
            // 
            // bt_modificar
            // 
            bt_modificar.BackColor = Color.FromArgb(117, 230, 164);
            bt_modificar.Dock = DockStyle.Fill;
            bt_modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_modificar.ForeColor = Color.White;
            bt_modificar.Location = new Point(5, 212);
            bt_modificar.Margin = new Padding(5, 4, 5, 4);
            bt_modificar.Name = "bt_modificar";
            bt_modificar.Size = new Size(88, 44);
            bt_modificar.TabIndex = 3;
            bt_modificar.Text = "MODIFICAR";
            bt_modificar.UseVisualStyleBackColor = false;
            // 
            // bt_gestionar
            // 
            bt_gestionar.BackColor = Color.FromArgb(117, 230, 164);
            bt_gestionar.Dock = DockStyle.Fill;
            bt_gestionar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            bt_gestionar.ForeColor = Color.White;
            bt_gestionar.Location = new Point(5, 264);
            bt_gestionar.Margin = new Padding(5, 4, 5, 4);
            bt_gestionar.Name = "bt_gestionar";
            bt_gestionar.Size = new Size(88, 44);
            bt_gestionar.TabIndex = 4;
            bt_gestionar.Text = "GESTIONAR PEDIDOS";
            bt_gestionar.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(117, 230, 164);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(5, 316);
            button1.Margin = new Padding(5, 4, 5, 4);
            button1.Name = "button1";
            button1.Size = new Size(88, 44);
            button1.TabIndex = 5;
            button1.Text = "REGISTRAR EMPLEADO";
            button1.UseVisualStyleBackColor = false;
            // 
            // Form_Empleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 442);
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
        private Button bt_consultar;
        private Button bt_insertar;
        private Button bt_borrar;
        private Button bt_modificar;
        private Button bt_gestionar;
        private Button button1;
    }
}
