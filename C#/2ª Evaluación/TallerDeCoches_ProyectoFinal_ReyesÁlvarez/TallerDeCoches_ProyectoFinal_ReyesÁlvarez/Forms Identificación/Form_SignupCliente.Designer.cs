namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    partial class Form_SignupCliente : Form
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
            btn_crearCuenta = new Button();
            textbox_nombreUsuario = new TextBox();
            lb3 = new Label();
            textbox_contraseña = new TextBox();
            checkBox1 = new CheckBox();
            tlp6 = new TableLayoutPanel();
            lbl_nombre = new Label();
            lbl_primerApellido = new Label();
            lbl_segundoApellido = new Label();
            lbl_dni = new Label();
            lbl_numeroTelefono = new Label();
            lbl_correoElectronico = new Label();
            textbox_nombre = new TextBox();
            textbox_primerApellido = new TextBox();
            textbox_segundoApellido = new TextBox();
            textbox_dni = new TextBox();
            textbox_numeroTelefono = new TextBox();
            textbox_correoElectronico = new TextBox();
            tlp4 = new TableLayoutPanel();
            tb_password = new TextBox();
            tb_user = new TextBox();
            tlp0 = new TableLayoutPanel();
            textBox2 = new TextBox();
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            tlp3.SuspendLayout();
            tlp5.SuspendLayout();
            tlp6.SuspendLayout();
            tlp4.SuspendLayout();
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
            tlp1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp1.Size = new Size(914, 589);
            tlp1.TabIndex = 0;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(117, 230, 164);
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(881, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(30, 23);
            btn_salir.TabIndex = 0;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // tlp2
            // 
            tlp2.BackColor = Color.White;
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.Controls.Add(lb1, 0, 0);
            tlp2.Controls.Add(tlp3, 0, 1);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 29);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 2;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 17.6470585F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 82.35294F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp2.Size = new Size(914, 560);
            tlp2.TabIndex = 1;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.Dock = DockStyle.Fill;
            lb1.Font = new Font("Cooper Black", 25F);
            lb1.ForeColor = Color.FromArgb(39, 50, 56);
            lb1.Location = new Point(3, 0);
            lb1.Name = "lb1";
            lb1.Size = new Size(908, 98);
            lb1.TabIndex = 1;
            lb1.Text = "Sign up";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp3
            // 
            tlp3.BackColor = Color.FromArgb(117, 230, 164);
            tlp3.ColumnCount = 2;
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp3.Controls.Add(tlp5, 0, 0);
            tlp3.Controls.Add(tlp6, 1, 0);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(0, 98);
            tlp3.Margin = new Padding(0);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 1;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp3.Size = new Size(914, 462);
            tlp3.TabIndex = 0;
            // 
            // tlp5
            // 
            tlp5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp5.ColumnCount = 1;
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp5.Controls.Add(btn_irLogin, 0, 6);
            tlp5.Controls.Add(lb2, 0, 0);
            tlp5.Controls.Add(btn_crearCuenta, 0, 4);
            tlp5.Controls.Add(textbox_nombreUsuario, 0, 1);
            tlp5.Controls.Add(lb3, 0, 5);
            tlp5.Controls.Add(textbox_contraseña, 0, 2);
            tlp5.Controls.Add(checkBox1, 0, 3);
            tlp5.Location = new Point(50, 27);
            tlp5.Margin = new Padding(50, 27, 50, 27);
            tlp5.Name = "tlp5";
            tlp5.RowCount = 7;
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7591343F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.82946444F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 7.82946444F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 9.304532F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7591381F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7591381F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7591381F));
            tlp5.Size = new Size(265, 408);
            tlp5.TabIndex = 2;
            // 
            // btn_irLogin
            // 
            btn_irLogin.BackColor = Color.FromArgb(223, 248, 229);
            btn_irLogin.Dock = DockStyle.Fill;
            btn_irLogin.FlatAppearance.BorderSize = 0;
            btn_irLogin.FlatStyle = FlatStyle.Flat;
            btn_irLogin.Font = new Font("Cascadia Mono SemiLight", 10F);
            btn_irLogin.Location = new Point(50, 347);
            btn_irLogin.Margin = new Padding(50, 20, 50, 20);
            btn_irLogin.Name = "btn_irLogin";
            btn_irLogin.Size = new Size(165, 41);
            btn_irLogin.TabIndex = 5;
            btn_irLogin.Text = "Ir a login";
            btn_irLogin.UseVisualStyleBackColor = false;
            btn_irLogin.Click += btn_irLogin_Click;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Dock = DockStyle.Fill;
            lb2.Font = new Font("Cooper Black", 12F);
            lb2.ForeColor = Color.FromArgb(39, 50, 56);
            lb2.Location = new Point(3, 0);
            lb2.Name = "lb2";
            lb2.Size = new Size(259, 76);
            lb2.TabIndex = 0;
            lb2.Text = "Tus credenciales";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn_crearCuenta
            // 
            btn_crearCuenta.BackColor = Color.FromArgb(223, 248, 229);
            btn_crearCuenta.Dock = DockStyle.Fill;
            btn_crearCuenta.FlatAppearance.BorderSize = 0;
            btn_crearCuenta.FlatStyle = FlatStyle.Flat;
            btn_crearCuenta.Font = new Font("Cascadia Mono SemiLight", 10F);
            btn_crearCuenta.Location = new Point(50, 195);
            btn_crearCuenta.Margin = new Padding(50, 20, 50, 20);
            btn_crearCuenta.Name = "btn_crearCuenta";
            btn_crearCuenta.Size = new Size(165, 36);
            btn_crearCuenta.TabIndex = 3;
            btn_crearCuenta.Text = "Crear cuenta";
            btn_crearCuenta.UseVisualStyleBackColor = false;
            btn_crearCuenta.Click += btn_crearCuenta_Click;
            // 
            // textbox_nombreUsuario
            // 
            textbox_nombreUsuario.Dock = DockStyle.Fill;
            textbox_nombreUsuario.Location = new Point(34, 76);
            textbox_nombreUsuario.Margin = new Padding(34, 0, 34, 0);
            textbox_nombreUsuario.Name = "textbox_nombreUsuario";
            textbox_nombreUsuario.PlaceholderText = "Nombre de usuario";
            textbox_nombreUsuario.Size = new Size(197, 27);
            textbox_nombreUsuario.TabIndex = 1;
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Dock = DockStyle.Bottom;
            lb3.Font = new Font("Cooper Black", 10F);
            lb3.ForeColor = Color.FromArgb(39, 50, 56);
            lb3.Location = new Point(3, 307);
            lb3.Name = "lb3";
            lb3.Size = new Size(259, 20);
            lb3.TabIndex = 4;
            lb3.Text = "¿Ya tienes una cuenta?";
            lb3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textbox_contraseña
            // 
            textbox_contraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textbox_contraseña.Location = new Point(34, 107);
            textbox_contraseña.Margin = new Padding(34, 0, 34, 0);
            textbox_contraseña.Name = "textbox_contraseña";
            textbox_contraseña.PlaceholderText = "Contraseña";
            textbox_contraseña.Size = new Size(197, 27);
            textbox_contraseña.TabIndex = 2;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Dock = DockStyle.Fill;
            checkBox1.Font = new Font("Cooper Black", 10F);
            checkBox1.Location = new Point(21, 141);
            checkBox1.Margin = new Padding(21, 3, 21, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(223, 31);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Ocultar contraseña";
            checkBox1.TextAlign = ContentAlignment.MiddleCenter;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // tlp6
            // 
            tlp6.ColumnCount = 2;
            tlp6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tlp6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tlp6.Controls.Add(lbl_nombre, 0, 0);
            tlp6.Controls.Add(lbl_primerApellido, 0, 1);
            tlp6.Controls.Add(lbl_segundoApellido, 0, 2);
            tlp6.Controls.Add(lbl_dni, 0, 3);
            tlp6.Controls.Add(lbl_numeroTelefono, 0, 4);
            tlp6.Controls.Add(lbl_correoElectronico, 0, 5);
            tlp6.Controls.Add(textbox_nombre, 1, 0);
            tlp6.Controls.Add(textbox_primerApellido, 1, 1);
            tlp6.Controls.Add(textbox_segundoApellido, 1, 2);
            tlp6.Controls.Add(textbox_dni, 1, 3);
            tlp6.Controls.Add(textbox_numeroTelefono, 1, 4);
            tlp6.Controls.Add(textbox_correoElectronico, 1, 5);
            tlp6.Dock = DockStyle.Fill;
            tlp6.Location = new Point(368, 27);
            tlp6.Margin = new Padding(3, 27, 3, 27);
            tlp6.Name = "tlp6";
            tlp6.RowCount = 6;
            tlp6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tlp6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tlp6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tlp6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tlp6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tlp6.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666641F));
            tlp6.Size = new Size(543, 408);
            tlp6.TabIndex = 3;
            // 
            // lbl_nombre
            // 
            lbl_nombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_nombre.AutoSize = true;
            lbl_nombre.Font = new Font("Cooper Black", 12F);
            lbl_nombre.ForeColor = Color.FromArgb(39, 50, 56);
            lbl_nombre.Location = new Point(3, 0);
            lbl_nombre.Name = "lbl_nombre";
            lbl_nombre.Size = new Size(211, 68);
            lbl_nombre.TabIndex = 0;
            lbl_nombre.Text = "Nombre";
            lbl_nombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_primerApellido
            // 
            lbl_primerApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_primerApellido.AutoSize = true;
            lbl_primerApellido.Font = new Font("Cooper Black", 12F);
            lbl_primerApellido.ForeColor = Color.FromArgb(39, 50, 56);
            lbl_primerApellido.Location = new Point(3, 68);
            lbl_primerApellido.Name = "lbl_primerApellido";
            lbl_primerApellido.Size = new Size(211, 68);
            lbl_primerApellido.TabIndex = 1;
            lbl_primerApellido.Text = "Primer apellido";
            lbl_primerApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_segundoApellido
            // 
            lbl_segundoApellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_segundoApellido.AutoSize = true;
            lbl_segundoApellido.Font = new Font("Cooper Black", 12F);
            lbl_segundoApellido.ForeColor = Color.FromArgb(39, 50, 56);
            lbl_segundoApellido.Location = new Point(3, 136);
            lbl_segundoApellido.Name = "lbl_segundoApellido";
            lbl_segundoApellido.Size = new Size(211, 68);
            lbl_segundoApellido.TabIndex = 2;
            lbl_segundoApellido.Text = "Segundo apellido";
            lbl_segundoApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_dni
            // 
            lbl_dni.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_dni.AutoSize = true;
            lbl_dni.Font = new Font("Cooper Black", 12F);
            lbl_dni.ForeColor = Color.FromArgb(39, 50, 56);
            lbl_dni.Location = new Point(3, 204);
            lbl_dni.Name = "lbl_dni";
            lbl_dni.Size = new Size(211, 68);
            lbl_dni.TabIndex = 3;
            lbl_dni.Text = "DNI";
            lbl_dni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_numeroTelefono
            // 
            lbl_numeroTelefono.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_numeroTelefono.AutoSize = true;
            lbl_numeroTelefono.Font = new Font("Cooper Black", 12F);
            lbl_numeroTelefono.ForeColor = Color.FromArgb(39, 50, 56);
            lbl_numeroTelefono.Location = new Point(3, 272);
            lbl_numeroTelefono.Name = "lbl_numeroTelefono";
            lbl_numeroTelefono.Size = new Size(211, 68);
            lbl_numeroTelefono.TabIndex = 4;
            lbl_numeroTelefono.Text = "Número de teléfono";
            lbl_numeroTelefono.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbl_correoElectronico
            // 
            lbl_correoElectronico.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_correoElectronico.AutoSize = true;
            lbl_correoElectronico.Font = new Font("Cooper Black", 12F);
            lbl_correoElectronico.ForeColor = Color.FromArgb(39, 50, 56);
            lbl_correoElectronico.Location = new Point(3, 340);
            lbl_correoElectronico.Name = "lbl_correoElectronico";
            lbl_correoElectronico.Size = new Size(211, 68);
            lbl_correoElectronico.TabIndex = 5;
            lbl_correoElectronico.Text = "Correo electrónico";
            lbl_correoElectronico.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textbox_nombre
            // 
            textbox_nombre.Dock = DockStyle.Fill;
            textbox_nombre.Location = new Point(217, 27);
            textbox_nombre.Margin = new Padding(0, 27, 34, 0);
            textbox_nombre.Name = "textbox_nombre";
            textbox_nombre.Size = new Size(292, 27);
            textbox_nombre.TabIndex = 6;
            textbox_nombre.TextChanged += textbox_nombre_TextChanged;
            // 
            // textbox_primerApellido
            // 
            textbox_primerApellido.Dock = DockStyle.Fill;
            textbox_primerApellido.Location = new Point(217, 95);
            textbox_primerApellido.Margin = new Padding(0, 27, 34, 0);
            textbox_primerApellido.Name = "textbox_primerApellido";
            textbox_primerApellido.Size = new Size(292, 27);
            textbox_primerApellido.TabIndex = 7;
            // 
            // textbox_segundoApellido
            // 
            textbox_segundoApellido.Dock = DockStyle.Fill;
            textbox_segundoApellido.Location = new Point(217, 163);
            textbox_segundoApellido.Margin = new Padding(0, 27, 34, 0);
            textbox_segundoApellido.Name = "textbox_segundoApellido";
            textbox_segundoApellido.Size = new Size(292, 27);
            textbox_segundoApellido.TabIndex = 8;
            // 
            // textbox_dni
            // 
            textbox_dni.Dock = DockStyle.Fill;
            textbox_dni.Location = new Point(217, 231);
            textbox_dni.Margin = new Padding(0, 27, 34, 0);
            textbox_dni.Name = "textbox_dni";
            textbox_dni.Size = new Size(292, 27);
            textbox_dni.TabIndex = 9;
            // 
            // textbox_numeroTelefono
            // 
            textbox_numeroTelefono.Dock = DockStyle.Fill;
            textbox_numeroTelefono.Location = new Point(217, 299);
            textbox_numeroTelefono.Margin = new Padding(0, 27, 34, 0);
            textbox_numeroTelefono.Name = "textbox_numeroTelefono";
            textbox_numeroTelefono.Size = new Size(292, 27);
            textbox_numeroTelefono.TabIndex = 10;
            // 
            // textbox_correoElectronico
            // 
            textbox_correoElectronico.Dock = DockStyle.Fill;
            textbox_correoElectronico.Location = new Point(217, 367);
            textbox_correoElectronico.Margin = new Padding(0, 27, 34, 0);
            textbox_correoElectronico.Name = "textbox_correoElectronico";
            textbox_correoElectronico.Size = new Size(292, 27);
            textbox_correoElectronico.TabIndex = 11;
            // 
            // tlp4
            // 
            tlp4.ColumnCount = 1;
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp4.Controls.Add(tb_password, 0, 1);
            tlp4.Dock = DockStyle.Fill;
            tlp4.Location = new Point(0, 0);
            tlp4.Margin = new Padding(100, 0, 100, 0);
            tlp4.Name = "tlp4";
            tlp4.RowCount = 2;
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp4.Size = new Size(200, 100);
            tlp4.TabIndex = 0;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_password.Location = new Point(18, 20);
            tb_password.Margin = new Padding(18, 0, 26, 0);
            tb_password.Name = "tb_password";
            tb_password.PlaceholderText = "Contraseña";
            tb_password.Size = new Size(156, 27);
            tb_password.TabIndex = 0;
            // 
            // tb_user
            // 
            tb_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_user.Location = new Point(18, 0);
            tb_user.Margin = new Padding(18, 0, 26, 0);
            tb_user.Name = "tb_user";
            tb_user.PlaceholderText = "Usuario";
            tb_user.Size = new Size(156, 27);
            tb_user.TabIndex = 1;
            // 
            // tlp0
            // 
            tlp0.ColumnCount = 1;
            tlp0.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp0.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp0.Dock = DockStyle.Fill;
            tlp0.Location = new Point(0, 0);
            tlp0.Margin = new Padding(100, 0, 100, 0);
            tlp0.Name = "tlp0";
            tlp0.RowCount = 2;
            tlp0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp0.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp0.Size = new Size(200, 100);
            tlp0.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox2.Location = new Point(18, 0);
            textBox2.Margin = new Padding(18, 0, 26, 0);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Usuario";
            textBox2.Size = new Size(10000, 27);
            textBox2.TabIndex = 1;
            // 
            // Form_SignupCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 589);
            Controls.Add(tlp1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_SignupCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp2.PerformLayout();
            tlp3.ResumeLayout(false);
            tlp5.ResumeLayout(false);
            tlp5.PerformLayout();
            tlp6.ResumeLayout(false);
            tlp6.PerformLayout();
            tlp4.ResumeLayout(false);
            tlp4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private Button btn_salir;
        private TableLayoutPanel tlp4;
        private TextBox tb_password;
        private TextBox tb_user;
        private TableLayoutPanel tlp0;
        private TextBox textBox2;
        private Button button3;
        private TableLayoutPanel tlp2;
        private Label lb1;
        private TableLayoutPanel tlp3;
        private TableLayoutPanel tlp5;
        private Button btn_irLogin;
        private Label lb2;
        private Button btn_crearCuenta;
        private TextBox textbox_nombreUsuario;
        private Label lb3;
        private TextBox textbox_contraseña;
        private CheckBox checkBox1;
        private TableLayoutPanel tlp6;
        private Label lbl_nombre;
        private Label lbl_primerApellido;
        private Label lbl_segundoApellido;
        private Label lbl_dni;
        private Label lbl_numeroTelefono;
        private Label lbl_correoElectronico;
        private TextBox textbox_nombre;
        private TextBox textbox_primerApellido;
        private TextBox textbox_segundoApellido;
        private TextBox textbox_dni;
        private TextBox textbox_numeroTelefono;
        private TextBox textbox_correoElectronico;
    }
}