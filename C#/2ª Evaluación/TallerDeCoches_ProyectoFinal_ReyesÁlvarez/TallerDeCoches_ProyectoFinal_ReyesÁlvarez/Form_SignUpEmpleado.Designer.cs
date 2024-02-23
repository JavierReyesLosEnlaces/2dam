namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    partial class Form_SignUpEmpleado : Form
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
            tlp1 = new TableLayoutPanel();
            btn_salir = new Button();
            tlp2 = new TableLayoutPanel();
            lb1 = new Label();
            tlp3 = new TableLayoutPanel();
            tlp5 = new TableLayoutPanel();
            btn_irLogin = new Button();
            lb2 = new Label();
            tb_usuario = new TextBox();
            btn_crearCuenta = new Button();
            lb3 = new Label();
            tb_contraseña = new TextBox();
            panel1 = new Panel();
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            tlp3.SuspendLayout();
            tlp5.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tlp1.Controls.Add(btn_salir, 0, 0);
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Margin = new Padding(0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlp1.Size = new Size(896, 706);
            tlp1.TabIndex = 1;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(117, 230, 164);
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(863, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(30, 29);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            // 
            // tlp2
            // 
            tlp2.BackColor = Color.White;
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 21F));
            tlp2.Controls.Add(lb1, 0, 0);
            tlp2.Controls.Add(tlp3, 0, 1);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 35);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 3;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.Size = new Size(896, 671);
            tlp2.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Dock = DockStyle.Fill;
            lb1.Font = new Font("Cooper Black", 30F);
            lb1.ForeColor = Color.FromArgb(39, 50, 56);
            lb1.Location = new Point(3, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(890, 100);
            lb1.TabIndex = 1;
            lb1.Text = "Bienvenido a Reparaciones Paquito";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp3
            // 
            tlp3.BackColor = Color.FromArgb(117, 230, 164);
            tlp3.ColumnCount = 2;
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp3.Controls.Add(tlp5, 1, 0);
            tlp3.Controls.Add(panel1, 0, 0);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(0, 100);
            tlp3.Margin = new Padding(0);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 1;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp3.Size = new Size(896, 469);
            tlp3.TabIndex = 0;
            // 
            // tlp5
            // 
            tlp5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp5.ColumnCount = 1;
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tlp5.Controls.Add(btn_irLogin, 0, 5);
            tlp5.Controls.Add(lb2, 0, 0);
            tlp5.Controls.Add(tb_usuario, 0, 1);
            tlp5.Controls.Add(btn_crearCuenta, 0, 3);
            tlp5.Controls.Add(lb3, 0, 4);
            tlp5.Controls.Add(tb_contraseña, 0, 2);
            tlp5.Location = new Point(617, 53);
            tlp5.Margin = new Padding(80, 53, 80, 53);
            tlp5.Name = "tlp5";
            tlp5.RowCount = 6;
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.Size = new Size(199, 363);
            tlp5.TabIndex = 2;
            // 
            // btn_irLogin
            // 
            btn_irLogin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_irLogin.Location = new Point(34, 313);
            btn_irLogin.Margin = new Padding(34, 13, 34, 13);
            btn_irLogin.Name = "btn_irLogin";
            btn_irLogin.Size = new Size(131, 37);
            btn_irLogin.TabIndex = 5;
            btn_irLogin.Text = "Ir a login";
            btn_irLogin.UseVisualStyleBackColor = true;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Dock = DockStyle.Fill;
            lb2.Font = new Font("Cooper Black", 15F);
            lb2.ForeColor = Color.FromArgb(39, 50, 56);
            lb2.Location = new Point(3, 0);
            lb2.Name = "lb2";
            lb2.Size = new Size(193, 60);
            lb2.TabIndex = 0;
            lb2.Text = "Nuevo empleado";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_usuario
            // 
            tb_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_usuario.Location = new Point(3, 64);
            tb_usuario.Margin = new Padding(3, 4, 3, 4);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.PlaceholderText = "Usuario";
            tb_usuario.Size = new Size(193, 27);
            tb_usuario.TabIndex = 1;
            // 
            // btn_crearCuenta
            // 
            btn_crearCuenta.Location = new Point(34, 193);
            btn_crearCuenta.Margin = new Padding(34, 13, 34, 13);
            btn_crearCuenta.Name = "btn_crearCuenta";
            btn_crearCuenta.Size = new Size(114, 34);
            btn_crearCuenta.TabIndex = 3;
            btn_crearCuenta.Text = "Crear cuenta";
            btn_crearCuenta.UseVisualStyleBackColor = true;
            // 
            // lb3
            // 
            lb3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb3.AutoSize = true;
            lb3.Font = new Font("Cooper Black", 10F);
            lb3.ForeColor = Color.FromArgb(39, 50, 56);
            lb3.Location = new Point(3, 240);
            lb3.Name = "lb3";
            lb3.Size = new Size(193, 60);
            lb3.TabIndex = 4;
            lb3.Text = "¿Ya tienes una cuenta?";
            lb3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_contraseña
            // 
            tb_contraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_contraseña.Location = new Point(3, 124);
            tb_contraseña.Margin = new Padding(3, 4, 3, 4);
            tb_contraseña.Name = "tb_contraseña";
            tb_contraseña.PlaceholderText = "Contraseña";
            tb_contraseña.Size = new Size(193, 27);
            tb_contraseña.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(537, 469);
            panel1.TabIndex = 1;
            // 
            // Form_SignUpEmpleado
            // 
            ClientSize = new Size(896, 706);
            Controls.Add(tlp1);
            Name = "Form_SignUpEmpleado";
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp2.PerformLayout();
            tlp3.ResumeLayout(false);
            tlp5.ResumeLayout(false);
            tlp5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private Button btn_salir;
        private TableLayoutPanel tlp2;
        private Label lb1;
        private TableLayoutPanel tlp3;
        private TableLayoutPanel tlp5;
        private Button btn_irLogin;
        private Label lb2;
        private TextBox tb_usuario;
        private Button btn_crearCuenta;
        private Label lb3;
        private TextBox tb_contraseña;
        private Panel panel1;
    }
}