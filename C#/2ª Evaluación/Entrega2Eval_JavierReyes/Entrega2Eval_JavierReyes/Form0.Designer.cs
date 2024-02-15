namespace Entrega2Eval_JavierReyes
{
    partial class Form0
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
            tlp_general = new TableLayoutPanel();
            btnEmpezar = new Button();
            btnUltimoPedido = new Button();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tlp_general.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_general
            // 
            tlp_general.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp_general.BackColor = Color.Transparent;
            tlp_general.ColumnCount = 1;
            tlp_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_general.Controls.Add(btnEmpezar, 0, 3);
            tlp_general.Controls.Add(btnUltimoPedido, 0, 2);
            tlp_general.Controls.Add(panel1, 0, 1);
            tlp_general.Controls.Add(tableLayoutPanel1, 0, 0);
            tlp_general.Dock = DockStyle.Fill;
            tlp_general.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tlp_general.Location = new Point(0, 0);
            tlp_general.Margin = new Padding(3, 2, 3, 2);
            tlp_general.Name = "tlp_general";
            tlp_general.RowCount = 4;
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlp_general.Size = new Size(570, 699);
            tlp_general.TabIndex = 0;
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
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(30, 117);
            panel1.Margin = new Padding(30);
            panel1.Name = "panel1";
            panel1.Size = new Size(510, 376);
            panel1.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(570, 87);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(570, 43);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO A LA HAMBURGUESERÍA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 43);
            label2.Margin = new Padding(0);
            label2.Name = "label2";
            label2.Size = new Size(570, 44);
            label2.TabIndex = 1;
            label2.Text = "'LOS ENLACES'";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form0
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            BackColor = Color.RoyalBlue;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(570, 699);
            Controls.Add(tlp_general);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburguesería 'Los Enlaces'";
            FormClosed += Form0_FormClosed;
            tlp_general.ResumeLayout(false);
            tlp_general.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_general;
        private Button btnEmpezar;
        private Button btnUltimoPedido;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
    }
}