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
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            tlp_botones.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
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
            tlp_botones.Location = new Point(0, 500);
            tlp_botones.Margin = new Padding(3, 2, 3, 2);
            tlp_botones.Name = "tlp_botones";
            tlp_botones.RowCount = 2;
            tlp_botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlp_botones.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tlp_botones.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            tlp_botones.Size = new Size(559, 106);
            tlp_botones.TabIndex = 0;
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
            btnUltimoPedido.Location = new Point(0, 52);
            btnUltimoPedido.Margin = new Padding(0);
            btnUltimoPedido.Name = "btnUltimoPedido";
            btnUltimoPedido.Size = new Size(559, 54);
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
            btnEmpezar.BackColor = Color.Black;
            btnEmpezar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmpezar.Dock = DockStyle.Fill;
            btnEmpezar.FlatAppearance.BorderColor = Color.White;
            btnEmpezar.FlatAppearance.BorderSize = 0;
            btnEmpezar.FlatStyle = FlatStyle.Flat;
            btnEmpezar.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            btnEmpezar.ForeColor = Color.White;
            btnEmpezar.Location = new Point(0, 0);
            btnEmpezar.Margin = new Padding(0);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(559, 52);
            btnEmpezar.TabIndex = 2;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.MouseEnter += btnEmpezar_MouseEnter;
            btnEmpezar.MouseLeave += btnEmpezar_MouseLeave;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 55F));
            tableLayoutPanel1.Size = new Size(559, 102);
            tableLayoutPanel1.TabIndex = 1;
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
            // Form0
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(559, 606);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(tlp_botones);
            DoubleBuffered = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburguesería 'Los Enlaces'";
            FormClosed += Form0_FormClosed;
            tlp_botones.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp_botones;
        private Button btnEmpezar;
        private Button btnUltimoPedido;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
    }
}