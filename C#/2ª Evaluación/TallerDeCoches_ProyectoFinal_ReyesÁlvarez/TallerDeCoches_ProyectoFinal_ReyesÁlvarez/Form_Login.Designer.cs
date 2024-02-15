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
            button1 = new Button();
            tlp2 = new TableLayoutPanel();
            tlp3 = new TableLayoutPanel();
            tlp4 = new TableLayoutPanel();
            lb_password = new Label();
            tb_password = new TextBox();
            tb_user = new TextBox();
            lb_user = new Label();
            panel1 = new Panel();
            label1 = new Label();
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            tlp3.SuspendLayout();
            tlp4.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp1.Controls.Add(button1, 0, 0);
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
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.FromArgb(117, 230, 164);
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1349, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // tlp2
            // 
            tlp2.BackColor = Color.White;
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp2.Controls.Add(tlp3, 0, 1);
            tlp2.Controls.Add(label1, 0, 0);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 37);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 3;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlp2.Size = new Size(1382, 716);
            tlp2.TabIndex = 1;
            // 
            // tlp3
            // 
            tlp3.BackColor = Color.FromArgb(117, 230, 164);
            tlp3.ColumnCount = 3;
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35F));
            tlp3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlp3.Controls.Add(tlp4, 1, 0);
            tlp3.Controls.Add(panel1, 0, 0);
            tlp3.Dock = DockStyle.Fill;
            tlp3.Location = new Point(0, 107);
            tlp3.Margin = new Padding(0);
            tlp3.Name = "tlp3";
            tlp3.RowCount = 1;
            tlp3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp3.Size = new Size(1382, 501);
            tlp3.TabIndex = 0;
            tlp3.Paint += this.tlp3_Paint;
            // 
            // tlp4
            // 
            tlp4.ColumnCount = 2;
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tlp4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tlp4.Controls.Add(lb_password, 0, 1);
            tlp4.Controls.Add(tb_password, 1, 1);
            tlp4.Controls.Add(tb_user, 1, 0);
            tlp4.Controls.Add(lb_user, 0, 0);
            tlp4.Dock = DockStyle.Fill;
            tlp4.Location = new Point(691, 200);
            tlp4.Margin = new Padding(0, 200, 0, 200);
            tlp4.Name = "tlp4";
            tlp4.RowCount = 2;
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp4.Size = new Size(483, 101);
            tlp4.TabIndex = 0;
            // 
            // lb_password
            // 
            lb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_password.ForeColor = Color.White;
            lb_password.Location = new Point(3, 50);
            lb_password.Name = "lb_password";
            lb_password.Padding = new Padding(0, 0, 0, 20);
            lb_password.Size = new Size(138, 51);
            lb_password.TabIndex = 3;
            lb_password.Text = "Contraseña";
            lb_password.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tb_password
            // 
            tb_password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_password.Location = new Point(164, 50);
            tb_password.Margin = new Padding(20, 0, 30, 0);
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(289, 27);
            tb_password.TabIndex = 0;
            // 
            // tb_user
            // 
            tb_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tb_user.Location = new Point(164, 0);
            tb_user.Margin = new Padding(20, 0, 30, 0);
            tb_user.Name = "tb_user";
            tb_user.Size = new Size(289, 27);
            tb_user.TabIndex = 1;
            // 
            // lb_user
            // 
            lb_user.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lb_user.AutoSize = true;
            lb_user.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lb_user.ForeColor = Color.White;
            lb_user.Location = new Point(3, 0);
            lb_user.Name = "lb_user";
            lb_user.Padding = new Padding(0, 0, 0, 20);
            lb_user.Size = new Size(138, 50);
            lb_user.TabIndex = 2;
            lb_user.Text = "Usuario";
            lb_user.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Zoom;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(691, 501);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1376, 107);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido a Reparaciones Paquito";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1382, 753);
            Controls.Add(tlp1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Login";
            Text = "Form2";
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp2.PerformLayout();
            tlp3.ResumeLayout(false);
            tlp4.ResumeLayout(false);
            tlp4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private Button button1;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp3;
        private TableLayoutPanel tlp4;
        private TextBox tb_password;
        private Label lb_password;
        private TextBox tb_user;
        private Label lb_user;
        private Panel panel1;
        private Label label1;
    }
}