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
            tlp1 = new TableLayoutPanel();
            btn_salir = new Button();
            tlp2 = new TableLayoutPanel();
            tlp3 = new TableLayoutPanel();
            bt_consultar = new Button();
            bt_insertar = new Button();
            bt_borrar = new Button();
            bt_modificar = new Button();
            bt_gestionar = new Button();
            tc_consulta = new TabControl();
            tp_roles = new TabPage();
            dgv_consultaRoles = new DataGridView();
            tp_usuarios = new TabPage();
            tp_clientes = new TabPage();
            tp_empleados = new TabPage();
            tp_talleres = new TabPage();
            tp_coches = new TabPage();
            tp_servicios = new TabPage();
            tp_pedidos = new TabPage();
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            tlp3.SuspendLayout();
            tc_consulta.SuspendLayout();
            tp_roles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_consultaRoles).BeginInit();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.Controls.Add(btn_salir, 0, 0);
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Margin = new Padding(0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlp1.Size = new Size(1382, 753);
            tlp1.TabIndex = 0;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(117, 230, 164);
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(1349, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(30, 29);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // tlp2
            // 
            tlp2.BackColor = Color.White;
            tlp2.ColumnCount = 2;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.2807F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.7193F));
            tlp2.Controls.Add(tlp3, 0, 0);
            tlp2.Controls.Add(tc_consulta, 1, 0);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 37);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 1;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp2.Size = new Size(1382, 716);
            tlp2.TabIndex = 2;
            // 
            // tlp3
            // 
            tlp3.ColumnCount = 1;
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp3.Controls.Add(bt_consultar, 0, 1);
            tlp3.Controls.Add(bt_insertar, 0, 2);
            tlp3.Controls.Add(bt_borrar, 0, 3);
            tlp3.Controls.Add(bt_modificar, 0, 4);
            tlp3.Controls.Add(bt_gestionar, 0, 5);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(0, 0);
            tlp3.Margin = new Padding(0);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 7;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5121956F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1951218F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1951218F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1951218F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1951218F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1951218F));
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.5121956F));
            tlp3.Size = new Size(169, 716);
            tlp3.TabIndex = 0;
            // 
            // bt_consultar
            // 
            bt_consultar.BackColor = Color.FromArgb(117, 230, 164);
            bt_consultar.Dock = DockStyle.Fill;
            bt_consultar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_consultar.ForeColor = Color.White;
            bt_consultar.Location = new Point(6, 144);
            bt_consultar.Margin = new Padding(6, 5, 6, 5);
            bt_consultar.Name = "bt_consultar";
            bt_consultar.Size = new Size(157, 77);
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
            bt_insertar.Location = new Point(6, 231);
            bt_insertar.Margin = new Padding(6, 5, 6, 5);
            bt_insertar.Name = "bt_insertar";
            bt_insertar.Size = new Size(157, 77);
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
            bt_borrar.Location = new Point(6, 318);
            bt_borrar.Margin = new Padding(6, 5, 6, 5);
            bt_borrar.Name = "bt_borrar";
            bt_borrar.Size = new Size(157, 77);
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
            bt_modificar.Location = new Point(6, 405);
            bt_modificar.Margin = new Padding(6, 5, 6, 5);
            bt_modificar.Name = "bt_modificar";
            bt_modificar.Size = new Size(157, 77);
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
            bt_gestionar.Location = new Point(6, 492);
            bt_gestionar.Margin = new Padding(6, 5, 6, 5);
            bt_gestionar.Name = "bt_gestionar";
            bt_gestionar.Size = new Size(157, 77);
            bt_gestionar.TabIndex = 4;
            bt_gestionar.Text = "GESTIONAR PEDIDOS";
            bt_gestionar.UseVisualStyleBackColor = false;
            // 
            // tc_consulta
            // 
            tc_consulta.Controls.Add(tp_roles);
            tc_consulta.Controls.Add(tp_usuarios);
            tc_consulta.Controls.Add(tp_clientes);
            tc_consulta.Controls.Add(tp_empleados);
            tc_consulta.Controls.Add(tp_talleres);
            tc_consulta.Controls.Add(tp_coches);
            tc_consulta.Controls.Add(tp_servicios);
            tc_consulta.Controls.Add(tp_pedidos);
            tc_consulta.Dock = DockStyle.Fill;
            tc_consulta.Location = new Point(169, 15);
            tc_consulta.Margin = new Padding(0, 15, 5, 15);
            tc_consulta.Name = "tc_consulta";
            tc_consulta.SelectedIndex = 0;
            tc_consulta.Size = new Size(1208, 686);
            tc_consulta.TabIndex = 1;
            // 
            // tp_roles
            // 
            tp_roles.Controls.Add(dgv_consultaRoles);
            tp_roles.Location = new Point(4, 29);
            tp_roles.Name = "tp_roles";
            tp_roles.Padding = new Padding(3, 3, 3, 3);
            tp_roles.Size = new Size(1200, 653);
            tp_roles.TabIndex = 0;
            tp_roles.Text = "ROLES";
            tp_roles.UseVisualStyleBackColor = true;
            tp_roles.Click += tabPage1_Click;
            // 
            // dgv_consultaRoles
            // 
            dgv_consultaRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_consultaRoles.Dock = DockStyle.Fill;
            dgv_consultaRoles.Location = new Point(3, 3);
            dgv_consultaRoles.Margin = new Padding(0);
            dgv_consultaRoles.Name = "dgv_consultaRoles";
            dgv_consultaRoles.RowHeadersWidth = 51;
            dgv_consultaRoles.Size = new Size(1194, 647);
            dgv_consultaRoles.TabIndex = 0;
            dgv_consultaRoles.CellContentClick += dgv_consultaRoles_CellContentClick;
            // 
            // tp_usuarios
            // 
            tp_usuarios.Location = new Point(4, 29);
            tp_usuarios.Name = "tp_usuarios";
            tp_usuarios.Padding = new Padding(3, 3, 3, 3);
            tp_usuarios.Size = new Size(1200, 654);
            tp_usuarios.TabIndex = 1;
            tp_usuarios.Text = "USUARIOS";
            tp_usuarios.UseVisualStyleBackColor = true;
            // 
            // tp_clientes
            // 
            tp_clientes.Location = new Point(4, 29);
            tp_clientes.Name = "tp_clientes";
            tp_clientes.Padding = new Padding(3, 3, 3, 3);
            tp_clientes.Size = new Size(1200, 654);
            tp_clientes.TabIndex = 2;
            tp_clientes.Text = "CLIENTES";
            tp_clientes.UseVisualStyleBackColor = true;
            // 
            // tp_empleados
            // 
            tp_empleados.Location = new Point(4, 29);
            tp_empleados.Name = "tp_empleados";
            tp_empleados.Padding = new Padding(3, 3, 3, 3);
            tp_empleados.Size = new Size(1200, 654);
            tp_empleados.TabIndex = 3;
            tp_empleados.Text = "EMPLEADOS";
            tp_empleados.UseVisualStyleBackColor = true;
            // 
            // tp_talleres
            // 
            tp_talleres.Location = new Point(4, 29);
            tp_talleres.Name = "tp_talleres";
            tp_talleres.Padding = new Padding(3, 3, 3, 3);
            tp_talleres.Size = new Size(1200, 654);
            tp_talleres.TabIndex = 4;
            tp_talleres.Text = "TALLERES";
            tp_talleres.UseVisualStyleBackColor = true;
            // 
            // tp_coches
            // 
            tp_coches.Location = new Point(4, 29);
            tp_coches.Name = "tp_coches";
            tp_coches.Padding = new Padding(3, 3, 3, 3);
            tp_coches.Size = new Size(1200, 654);
            tp_coches.TabIndex = 5;
            tp_coches.Text = "COCHES";
            tp_coches.UseVisualStyleBackColor = true;
            // 
            // tp_servicios
            // 
            tp_servicios.Location = new Point(4, 29);
            tp_servicios.Name = "tp_servicios";
            tp_servicios.Padding = new Padding(3, 3, 3, 3);
            tp_servicios.Size = new Size(1200, 654);
            tp_servicios.TabIndex = 6;
            tp_servicios.Text = "SERVICIOS";
            tp_servicios.UseVisualStyleBackColor = true;
            // 
            // tp_pedidos
            // 
            tp_pedidos.Location = new Point(4, 29);
            tp_pedidos.Name = "tp_pedidos";
            tp_pedidos.Padding = new Padding(3, 3, 3, 3);
            tp_pedidos.Size = new Size(1200, 654);
            tp_pedidos.TabIndex = 7;
            tp_pedidos.Text = "PEDIDOS";
            tp_pedidos.UseVisualStyleBackColor = true;
            // 
            // Form_Empleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(tlp1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form_Empleado";
            Text = "Form1";
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp3.ResumeLayout(false);
            tc_consulta.ResumeLayout(false);
            tp_roles.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_consultaRoles).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private Button btn_salir;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp3;
        private TabControl tc_consulta;
        private TabPage tp_roles;
        private TabPage tp_usuarios;
        private TabPage tp_clientes;
        private TabPage tp_empleados;
        private TabPage tp_talleres;
        private TabPage tp_coches;
        private TabPage tp_servicios;
        private TabPage tp_pedidos;
        private DataGridView dgv_consultaRoles;
        private Button bt_consultar;
        private Button bt_insertar;
        private Button bt_borrar;
        private Button bt_modificar;
        private Button bt_gestionar;
    }
}
