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
            tlp_botones = new TableLayoutPanel();
            btnUltimoPedido = new Button();
            btnEmpezar = new Button();
            tlp_titulo = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            tlp_botones.SuspendLayout();
            tlp_titulo.SuspendLayout();
            SuspendLayout();
            // 
            // tlp_botones
            // 
            tlp_botones.BackColor = Color.Transparent;
            tlp_botones.ColumnCount = 1;
            tlp_botones.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_botones.Controls.Add(btnUltimoPedido, 0, 1);
            tlp_botones.Controls.Add(btnEmpezar, 0, 0);
            tlp_botones.Dock = DockStyle.Bottom;
            tlp_botones.Location = new Point(0, 502);
            tlp_botones.Margin = new Padding(3, 2, 3, 2);
            tlp_botones.Name = "tlp_botones";
            tlp_botones.RowCount = 2;
            tlp_botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tlp_botones.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlp_botones.Size = new Size(559, 104);
            tlp_botones.TabIndex = 0;
            // 
            // btnUltimoPedido
            // 
            btnUltimoPedido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnUltimoPedido.BackColor = Color.Black;
            btnUltimoPedido.BackgroundImageLayout = ImageLayout.Zoom;
            btnUltimoPedido.FlatAppearance.BorderColor = Color.White;
            btnUltimoPedido.FlatAppearance.BorderSize = 0;
            btnUltimoPedido.FlatStyle = FlatStyle.Flat;
            btnUltimoPedido.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            btnUltimoPedido.ForeColor = Color.White;
            btnUltimoPedido.Location = new Point(101, 51);
            btnUltimoPedido.Margin = new Padding(0);
            btnUltimoPedido.Name = "btnUltimoPedido";
            btnUltimoPedido.Size = new Size(357, 53);
            btnUltimoPedido.TabIndex = 4;
            btnUltimoPedido.Text = "Pedir lo de ayer";
            btnUltimoPedido.UseVisualStyleBackColor = false;
            btnUltimoPedido.Visible = false;
            btnUltimoPedido.Click += btnPedidoAyer_Click;
            btnUltimoPedido.MouseEnter += btnUltimoPedido_MouseEnter;
            btnUltimoPedido.MouseLeave += btnUltimoPedido_MouseLeave;
            // 
            // btnEmpezar
            // 
            btnEmpezar.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnEmpezar.BackColor = Color.Black;
            btnEmpezar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmpezar.FlatAppearance.BorderColor = Color.White;
            btnEmpezar.FlatAppearance.BorderSize = 0;
            btnEmpezar.FlatStyle = FlatStyle.Flat;
            btnEmpezar.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            btnEmpezar.ForeColor = Color.White;
            btnEmpezar.Location = new Point(101, 0);
            btnEmpezar.Margin = new Padding(0);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(357, 51);
            btnEmpezar.TabIndex = 2;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.MouseEnter += btnEmpezar_MouseEnter;
            btnEmpezar.MouseLeave += btnEmpezar_MouseLeave;
            // 
            // tlp_titulo
            // 
            tlp_titulo.ColumnCount = 1;
            tlp_titulo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp_titulo.Controls.Add(label2, 0, 1);
            tlp_titulo.Controls.Add(label1, 0, 0);
            tlp_titulo.Dock = DockStyle.Top;
            tlp_titulo.Location = new Point(0, 0);
            tlp_titulo.Name = "tlp_titulo";
            tlp_titulo.RowCount = 2;
            tlp_titulo.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tlp_titulo.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tlp_titulo.Size = new Size(559, 102);
            tlp_titulo.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Jokerman", 30F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(3, 45);
            label2.Name = "label2";
            label2.Size = new Size(553, 57);
            label2.TabIndex = 1;
            label2.Text = "'LOS ENLACES'";
            label2.TextAlign = ContentAlignment.MiddleCenter;
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
            label1.Padding = new Padding(0, 6, 0, 0);
            label1.Size = new Size(559, 45);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO A LA HAMBURGUESERÍA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(559, 606);
            Controls.Add(tlp_titulo);
            Controls.Add(tlp_botones);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburguesería 'Los Enlaces'";
            FormClosed += Form0_FormClosed;
            tlp_botones.ResumeLayout(false);
            tlp_titulo.ResumeLayout(false);
            tlp_titulo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_botones;
        private Button btnEmpezar;
        private Button btnUltimoPedido;
        private TableLayoutPanel tlp_titulo;
        private Label label1;
        private Label label2;
    }
}