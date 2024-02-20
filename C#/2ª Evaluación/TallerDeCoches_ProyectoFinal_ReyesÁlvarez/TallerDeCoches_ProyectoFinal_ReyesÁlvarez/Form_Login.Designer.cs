namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            tlp1 = new TableLayoutPanel();
            btn_salir = new Button();
            tlp2 = new TableLayoutPanel();
            lb1 = new Label();
            tlp3 = new TableLayoutPanel();
            panelImagen = new Panel();
            tlp5 = new TableLayoutPanel();
            btn_crearCuenta = new Button();
            lb2 = new Label();
            tb_usuario = new TextBox();
            btn_entrar = new Button();
            lb3 = new Label();
            tb_contraseña = new TextBox();
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
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tlp1.Controls.Add(btn_salir, 0, 0);
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Margin = new Padding(0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 95F));
            tlp1.Size = new Size(800, 565);
            tlp1.TabIndex = 0;
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
            btn_salir.Size = new Size(26, 22);
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
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tlp2.Controls.Add(lb1, 0, 0);
            tlp2.Controls.Add(tlp3, 0, 1);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 28);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 3;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.Size = new Size(800, 537);
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
            lb1.Size = new Size(794, 80);
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
            tlp3.Controls.Add(panelImagen, 0, 0);
            tlp3.Controls.Add(tlp5, 1, 0);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(0, 80);
            tlp3.Margin = new Padding(0);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 1;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp3.Size = new Size(800, 375);
            tlp3.TabIndex = 0;
            // 
            // panelImagen
            // 
            panelImagen.BackColor = Color.White;
            panelImagen.BackgroundImage = (Image)resources.GetObject("panelImagen.BackgroundImage");
            panelImagen.BackgroundImageLayout = ImageLayout.Zoom;
            panelImagen.Dock = DockStyle.Fill;
            panelImagen.Location = new Point(0, 0);
            panelImagen.Margin = new Padding(0);
            panelImagen.Name = "panelImagen";
            panelImagen.Size = new Size(480, 375);
            panelImagen.TabIndex = 1;
            // 
            // tlp5
            // 
            tlp5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tlp5.ColumnCount = 1;
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp5.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp5.Controls.Add(btn_crearCuenta, 0, 5);
            tlp5.Controls.Add(lb2, 0, 0);
            tlp5.Controls.Add(tb_usuario, 0, 1);
            tlp5.Controls.Add(btn_entrar, 0, 3);
            tlp5.Controls.Add(lb3, 0, 4);
            tlp5.Controls.Add(tb_contraseña, 0, 2);
            tlp5.Location = new Point(560, 40);
            tlp5.Margin = new Padding(80, 40, 80, 40);
            tlp5.Name = "tlp5";
            tlp5.RowCount = 6;
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.RowStyles.Add(new RowStyle(SizeType.Percent, 16.6666679F));
            tlp5.Size = new Size(160, 295);
            tlp5.TabIndex = 2;
            // 
            // btn_crearCuenta
            // 
            btn_crearCuenta.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btn_crearCuenta.Location = new Point(30, 255);
            btn_crearCuenta.Margin = new Padding(30, 10, 30, 10);
            btn_crearCuenta.Name = "btn_crearCuenta";
            btn_crearCuenta.Size = new Size(100, 30);
            btn_crearCuenta.TabIndex = 5;
            btn_crearCuenta.Text = "Crear cuenta";
            btn_crearCuenta.UseVisualStyleBackColor = true;
            btn_crearCuenta.Click += btn_crear_cuenta_Click;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.Dock = DockStyle.Fill;
            lb2.Font = new Font("Cooper Black", 15F);
            lb2.ForeColor = Color.FromArgb(39, 50, 56);
            lb2.Location = new Point(3, 0);
            lb2.Name = "lb2";
            lb2.Size = new Size(154, 49);
            lb2.TabIndex = 0;
            lb2.Text = "Entra a tu cuenta";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_usuario
            // 
            tb_usuario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_usuario.Location = new Point(3, 52);
            tb_usuario.Name = "tb_usuario";
            tb_usuario.PlaceholderText = "Usuario";
            tb_usuario.Size = new Size(154, 23);
            tb_usuario.TabIndex = 1;
            // 
            // btn_entrar
            // 
            btn_entrar.Location = new Point(30, 157);
            btn_entrar.Margin = new Padding(30, 10, 30, 10);
            btn_entrar.Name = "btn_entrar";
            btn_entrar.Size = new Size(100, 29);
            btn_entrar.TabIndex = 3;
            btn_entrar.Text = "Entrar";
            btn_entrar.UseVisualStyleBackColor = true;
            btn_entrar.Click += btn_entrar_Click;
            // 
            // lb3
            // 
            lb3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb3.AutoSize = true;
            lb3.Font = new Font("Cooper Black", 10F);
            lb3.ForeColor = Color.FromArgb(39, 50, 56);
            lb3.Location = new Point(3, 196);
            lb3.Name = "lb3";
            lb3.Size = new Size(154, 49);
            lb3.TabIndex = 4;
            lb3.Text = "¿No tienes una cuenta?";
            lb3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_contraseña
            // 
            tb_contraseña.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_contraseña.Location = new Point(3, 101);
            tb_contraseña.Name = "tb_contraseña";
            tb_contraseña.PlaceholderText = "Contraseña";
            tb_contraseña.Size = new Size(154, 23);
            tb_contraseña.TabIndex = 2;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 565);
            Controls.Add(tlp1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
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
        private TableLayoutPanel tlp3;
        private Panel panelImagen;
        private Label lb1;
        private Button button3;
        private TableLayoutPanel tlp5;
        private Label lb2;
        private TextBox tb_contraseña;
        private Button btn_entrar;
        private Label lb3;
        private Button btn_crearCuenta;
        private TextBox tb_usuario;
    }
}