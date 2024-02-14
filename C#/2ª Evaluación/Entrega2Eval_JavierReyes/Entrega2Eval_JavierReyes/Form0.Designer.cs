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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form0));
            tlp_general = new TableLayoutPanel();
            btnEmpezar = new Button();
            btnUltimoPedido = new Button();
            label1 = new Label();
            label2 = new Label();
            tlp_titulo = new TableLayoutPanel();
            tlp_general.SuspendLayout();
            tlp_titulo.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_general
            // 
            tlp_general.BackColor = Color.Transparent;
            tlp_general.ColumnCount = 1;
            tlp_general.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_general.Controls.Add(btnEmpezar, 0, 3);
            tlp_general.Controls.Add(btnUltimoPedido, 0, 2);
            tlp_general.Dock = DockStyle.Fill;
            tlp_general.Location = new Point(0, 0);
            tlp_general.Name = "tlp_general";
            tlp_general.RowCount = 4;
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 62.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_general.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp_general.Size = new Size(651, 932);
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
            btnEmpezar.Location = new Point(0, 814);
            btnEmpezar.Margin = new Padding(0);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(651, 118);
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
            btnUltimoPedido.Location = new Point(0, 698);
            btnUltimoPedido.Margin = new Padding(0);
            btnUltimoPedido.Name = "btnUltimoPedido";
            btnUltimoPedido.Size = new Size(651, 116);
            btnUltimoPedido.TabIndex = 6;
            btnUltimoPedido.Text = "Pedir lo de ayer";
            btnUltimoPedido.UseVisualStyleBackColor = false;
            btnUltimoPedido.Visible = false;
            btnUltimoPedido.Click += btnPedidoAyer_Click;
            btnUltimoPedido.MouseEnter += btnUltimoPedido_MouseEnter;
            btnUltimoPedido.MouseLeave += btnUltimoPedido_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Jokerman", 15F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Padding = new Padding(0, 8, 0, 0);
            label1.Size = new Size(651, 61);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO A LA HAMBURGUESERÍA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Jokerman", 30F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 61);
            label2.Name = "label2";
            label2.Size = new Size(645, 75);
            label2.TabIndex = 1;
            label2.Text = "'LOS ENLACES'";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlp_titulo
            // 
            tlp_titulo.ColumnCount = 1;
            tlp_titulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_titulo.Controls.Add(label2, 0, 1);
            tlp_titulo.Controls.Add(label1, 0, 0);
            tlp_titulo.Dock = DockStyle.Top;
            tlp_titulo.Location = new Point(0, 0);
            tlp_titulo.Margin = new Padding(3, 4, 3, 4);
            tlp_titulo.Name = "tlp_titulo";
            tlp_titulo.RowCount = 2;
            tlp_titulo.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlp_titulo.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlp_titulo.Size = new Size(651, 136);
            tlp_titulo.TabIndex = 1;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(651, 932);
            Controls.Add(tlp_titulo);
            Controls.Add(tlp_general);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburguesería 'Los Enlaces'";
            FormClosed += Form0_FormClosed;
            tlp_general.ResumeLayout(false);
            tlp_titulo.ResumeLayout(false);
            tlp_titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_general;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tlp_titulo;
        private Button btnEmpezar;
        private Button btnUltimoPedido;
    }
}