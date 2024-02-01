namespace Entrega2Eval_JavierReyes
{
    partial class form0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form0));
            tableLayoutPanel1 = new TableLayoutPanel();
            btnUltimoPedido = new Button();
            label1 = new Label();
            btnEmpezar = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelTitulo1 = new Label();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(btnUltimoPedido, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(btnEmpezar, 0, 1);
            tableLayoutPanel1.Location = new Point(96, 485);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(450, 263);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnUltimoPedido
            // 
            btnUltimoPedido.BackColor = Color.Black;
            btnUltimoPedido.BackgroundImageLayout = ImageLayout.Zoom;
            btnUltimoPedido.Dock = DockStyle.Fill;
            btnUltimoPedido.FlatAppearance.BorderColor = Color.White;
            btnUltimoPedido.FlatAppearance.BorderSize = 3;
            btnUltimoPedido.FlatStyle = FlatStyle.Flat;
            btnUltimoPedido.Font = new Font("Jokerman", 24F, FontStyle.Bold);
            btnUltimoPedido.ForeColor = Color.White;
            btnUltimoPedido.Location = new Point(6, 180);
            btnUltimoPedido.Margin = new Padding(6);
            btnUltimoPedido.Name = "btnUltimoPedido";
            btnUltimoPedido.Size = new Size(438, 77);
            btnUltimoPedido.TabIndex = 4;
            btnUltimoPedido.Text = "Pedir lo de ayer";
            btnUltimoPedido.UseVisualStyleBackColor = false;
            btnUltimoPedido.Click += btnPedidoAyer_Click;
            btnUltimoPedido.MouseEnter += btnUltimoPedido_MouseEnter;
            btnUltimoPedido.MouseLeave += btnUltimoPedido_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Jokerman", 30F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(444, 87);
            label1.TabIndex = 3;
            label1.Text = "'LOS ENLACES'";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEmpezar
            // 
            btnEmpezar.BackColor = Color.Black;
            btnEmpezar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmpezar.Dock = DockStyle.Fill;
            btnEmpezar.FlatAppearance.BorderColor = Color.White;
            btnEmpezar.FlatAppearance.BorderSize = 3;
            btnEmpezar.FlatStyle = FlatStyle.Flat;
            btnEmpezar.Font = new Font("Jokerman", 24F, FontStyle.Bold);
            btnEmpezar.ForeColor = Color.White;
            btnEmpezar.Location = new Point(6, 93);
            btnEmpezar.Margin = new Padding(6);
            btnEmpezar.Name = "btnEmpezar";
            btnEmpezar.Size = new Size(438, 75);
            btnEmpezar.TabIndex = 2;
            btnEmpezar.Text = "Empezar";
            btnEmpezar.UseVisualStyleBackColor = false;
            btnEmpezar.Click += btnEmpezar_Click;
            btnEmpezar.MouseEnter += btnEmpezar_MouseEnter;
            btnEmpezar.MouseLeave += btnEmpezar_MouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(labelTitulo1, 0, 0);
            tableLayoutPanel2.Font = new Font("Jokerman", 19.8000011F, FontStyle.Bold);
            tableLayoutPanel2.Location = new Point(0, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(625, 212);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // labelTitulo1
            // 
            labelTitulo1.AutoSize = true;
            labelTitulo1.BackColor = Color.Transparent;
            labelTitulo1.Dock = DockStyle.Fill;
            labelTitulo1.Font = new Font("Jokerman", 30F, FontStyle.Bold);
            labelTitulo1.ForeColor = Color.White;
            labelTitulo1.Location = new Point(3, 0);
            labelTitulo1.Name = "labelTitulo1";
            labelTitulo1.Size = new Size(619, 212);
            labelTitulo1.TabIndex = 0;
            labelTitulo1.Text = "BIENVENIDO A LA HAMBURGUESERÍA ";
            labelTitulo1.TextAlign = ContentAlignment.TopCenter;
            // 
            // form0
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 170, 1);
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(635, 665);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            DoubleBuffered = true;
            Name = "form0";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            FormClosed += Form0_FormClosed;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelTitulo1;
        private Button btnEmpezar;
        private Label label1;
        private Button btnUltimoPedido;
    }
}