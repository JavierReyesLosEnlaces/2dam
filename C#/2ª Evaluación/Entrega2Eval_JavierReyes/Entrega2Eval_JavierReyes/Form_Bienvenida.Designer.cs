namespace Entrega2Eval_JavierReyes
{
    partial class Form_Bienvenida
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
            tlp2 = new TableLayoutPanel();
            btnEmpezar = new Button();
            btnUltimoPedido = new Button();
            panel1 = new Panel();
            tlp1 = new TableLayoutPanel();
            lb1 = new Label();
            lb2 = new Label();
            tlp2.SuspendLayout();
            tlp1.SuspendLayout();
            SuspendLayout();
            // 
            // tlp2
            // 
            tlp2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp2.BackColor = Color.Transparent;
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.Controls.Add(btnEmpezar, 0, 3);
            tlp2.Controls.Add(btnUltimoPedido, 0, 2);
            tlp2.Controls.Add(panel1, 0, 1);
            tlp2.Controls.Add(tlp1, 0, 0);
            tlp2.Dock = DockStyle.Fill;
            tlp2.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlp2.Location = new Point(0, 0);
            tlp2.Margin = new Padding(3, 2, 3, 2);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 4;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlp2.Size = new Size(570, 699);
            tlp2.TabIndex = 0;
            // 
            // btnEmpezar
            // 
            btnEmpezar.BackColor = Color.Black;
            btnEmpezar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmpezar.Dock = DockStyle.Fill;
            btnEmpezar.FlatAppearance.BorderColor = Color.White;
            btnEmpezar.FlatAppearance.BorderSize = 0;
            btnEmpezar.FlatStyle = FlatStyle.Flat;
            btnEmpezar.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            btnEmpezar.ForeColor = Color.White;
            btnEmpezar.Location = new Point(0, 610);
            btnEmpezar.Margin = new Padding(0);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(570, 89);
            btnEmpezar.TabIndex = 10;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.MouseEnter += btnEmpezar_MouseEnter;
            btnEmpezar.MouseLeave += btnEmpezar_MouseLeave;
            // 
            // btnUltimoPedido
            // 
            btnUltimoPedido.BackColor = Color.Black;
            btnUltimoPedido.BackgroundImageLayout = ImageLayout.Zoom;
            btnUltimoPedido.Dock = DockStyle.Fill;
            btnUltimoPedido.FlatAppearance.BorderColor = Color.White;
            btnUltimoPedido.FlatAppearance.BorderSize = 0;
            btnUltimoPedido.FlatStyle = FlatStyle.Flat;
            btnUltimoPedido.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            btnUltimoPedido.ForeColor = Color.White;
            btnUltimoPedido.Location = new Point(0, 523);
            btnUltimoPedido.Margin = new Padding(0);
            btnUltimoPedido.Name = "btnUltimoPedido";
            btnUltimoPedido.Size = new Size(570, 87);
            btnUltimoPedido.TabIndex = 6;
            btnUltimoPedido.Text = "Pedir lo de ayer";
            btnUltimoPedido.UseVisualStyleBackColor = false;
            btnUltimoPedido.Visible = false;
            btnUltimoPedido.Click += btnPedidoAyer_Click;
            btnUltimoPedido.MouseEnter += btnUltimoPedido_MouseEnter;
            btnUltimoPedido.MouseLeave += btnUltimoPedido_MouseLeave;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackgroundImage = Properties.Resources.burguer3;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 87);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(570, 436);
            panel1.TabIndex = 11;
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp1.Controls.Add(lb1, 0, 0);
            tlp1.Controls.Add(lb2, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Margin = new Padding(0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp1.Size = new Size(570, 87);
            tlp1.TabIndex = 12;
            // 
            // lb1
            // 
            lb1.AutoSize = true;
            lb1.BackColor = Color.Black;
            lb1.Dock = DockStyle.Fill;
            lb1.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            lb1.ForeColor = Color.White;
            lb1.Location = new Point(0, 0);
            lb1.Margin = new Padding(0);
            lb1.Name = "lb1";
            lb1.Size = new Size(570, 43);
            lb1.TabIndex = 0;
            lb1.Text = "BIENVENIDO A LA HAMBURGUESERÍA";
            lb1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lb2
            // 
            lb2.AutoSize = true;
            lb2.BackColor = Color.Black;
            lb2.Dock = DockStyle.Fill;
            lb2.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            lb2.ForeColor = Color.White;
            lb2.Location = new Point(0, 43);
            lb2.Margin = new Padding(0);
            lb2.Name = "lb2";
            lb2.Size = new Size(570, 44);
            lb2.TabIndex = 1;
            lb2.Text = "'LOS ENLACES'";
            lb2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form_Bienvenida
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(570, 699);
            Controls.Add(tlp2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form_Bienvenida";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburguesería 'Los Enlaces'";
            FormClosed += Form0_FormClosed;
            tlp2.ResumeLayout(false);
            tlp2.PerformLayout();
            tlp1.ResumeLayout(false);
            tlp1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp2;
        private Button btnEmpezar;
        private Button btnUltimoPedido;
        private Panel panel1;
        private TableLayoutPanel tlp1;
        private Label lb1;
        private Label lb2;
    }
}