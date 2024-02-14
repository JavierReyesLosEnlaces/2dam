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
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUltimoPedido = new Button();
            btnEmpezar = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnUltimoPedido, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEmpezar, 0, 0);
            tableLayoutPanel1.Location = new Point(158, 617);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.0000076F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(331, 124);
            tableLayoutPanel1.TabIndex = 0;
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
            btnUltimoPedido.Location = new Point(6, 67);
            btnUltimoPedido.Margin = new Padding(6);
            btnUltimoPedido.Name = "btnUltimoPedido";
            btnUltimoPedido.Size = new Size(319, 51);
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
            btnEmpezar.Location = new Point(6, 6);
            btnEmpezar.Margin = new Padding(6);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(319, 49);
            btnEmpezar.TabIndex = 2;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.MouseEnter += btnEmpezar_MouseEnter;
            btnEmpezar.MouseLeave += btnEmpezar_MouseLeave;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.Size = new Size(639, 113);
            panel1.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Black;
            label3.Font = new Font("Jokerman", 24F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(139, 52);
            label3.Name = "label3";
            label3.Size = new Size(350, 58);
            label3.TabIndex = 2;
            label3.Text = "'LOS ENLACES'";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(314, 9);
            label2.Name = "label2";
            label2.Size = new Size(322, 43);
            label2.TabIndex = 1;
            label2.Text = "HAMBURGUESERÍA";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Jokerman", 18F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(318, 43);
            label1.TabIndex = 0;
            label1.Text = "BIENVENIDO A LA ";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(639, 753);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "Form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hamburguesería 'Los Enlaces'";
            FormClosed += Form0_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Button btnEmpezar;
        private Button btnUltimoPedido;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
    }
}