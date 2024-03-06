namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Aplicación
{
    partial class Form_Cliente_DatosCoche
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
            components = new System.ComponentModel.Container();
            tlp1 = new TableLayoutPanel();
            tlp2 = new TableLayoutPanel();
            btn_continuar = new Button();
            label1 = new Label();
            tlpTarjeta = new TableLayoutPanel();
            tableLayoutPanel7 = new TableLayoutPanel();
            tableLayoutPanel8 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            textBox_modelo = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            label3 = new Label();
            textBox_color = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label4 = new Label();
            textBox_peso = new TextBox();
            label5 = new Label();
            checkbox_condiciones = new CheckBox();
            btn_salir = new Button();
            toolTip1 = new ToolTip(components);
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            tlpTarjeta.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.AllowDrop = true;
            tlp1.BackColor = Color.FromArgb(117, 230, 164);
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Controls.Add(btn_salir, 0, 0);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Margin = new Padding(0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 4F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 96F));
            tlp1.Size = new Size(1122, 990);
            tlp1.TabIndex = 2;
            // 
            // tlp2
            // 
            tlp2.BackColor = SystemColors.Control;
            tlp2.ColumnCount = 1;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp2.Controls.Add(btn_continuar, 0, 2);
            tlp2.Controls.Add(label1, 0, 0);
            tlp2.Controls.Add(tlpTarjeta, 0, 1);
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 39);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 3;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlp2.Size = new Size(1122, 951);
            tlp2.TabIndex = 2;
            // 
            // btn_continuar
            // 
            btn_continuar.BackColor = Color.FromArgb(0, 64, 64);
            btn_continuar.Dock = DockStyle.Fill;
            btn_continuar.FlatAppearance.BorderSize = 0;
            btn_continuar.FlatStyle = FlatStyle.Flat;
            btn_continuar.Font = new Font("Cooper Black", 15F);
            btn_continuar.ForeColor = Color.White;
            btn_continuar.Location = new Point(300, 760);
            btn_continuar.Margin = new Padding(300, 0, 300, 100);
            btn_continuar.Name = "btn_continuar";
            btn_continuar.Size = new Size(522, 91);
            btn_continuar.TabIndex = 4;
            btn_continuar.Text = "CONTINUAR";
            btn_continuar.UseVisualStyleBackColor = false;
            btn_continuar.Click += btn_continuar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Cooper Black", 30F);
            label1.ForeColor = Color.FromArgb(39, 50, 56);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(1116, 190);
            label1.TabIndex = 0;
            label1.Text = "Introduce los datos de tu coche";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tlpTarjeta
            // 
            tlpTarjeta.ColumnCount = 1;
            tlpTarjeta.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpTarjeta.Controls.Add(tableLayoutPanel7, 1, 0);
            tlpTarjeta.Controls.Add(checkbox_condiciones, 0, 1);
            tlpTarjeta.Dock = DockStyle.Fill;
            tlpTarjeta.Location = new Point(200, 220);
            tlpTarjeta.Margin = new Padding(200, 30, 200, 40);
            tlpTarjeta.Name = "tlpTarjeta";
            tlpTarjeta.RowCount = 2;
            tlpTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlpTarjeta.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpTarjeta.Size = new Size(722, 500);
            tlpTarjeta.TabIndex = 3;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel7.Controls.Add(tableLayoutPanel8, 0, 0);
            tableLayoutPanel7.Controls.Add(label5, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(0, 0);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 83.33F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 16.67F));
            tableLayoutPanel7.Size = new Size(722, 450);
            tableLayoutPanel7.TabIndex = 4;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 1;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel8.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel2, 0, 1);
            tableLayoutPanel8.Controls.Add(tableLayoutPanel3, 1, 2);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(0, 0);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 3;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel8.Size = new Size(722, 374);
            tableLayoutPanel8.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(textBox_modelo, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(722, 124);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(117, 230, 164);
            label2.CausesValidation = false;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Cooper Black", 15F);
            label2.ForeColor = Color.FromArgb(39, 50, 56);
            label2.Location = new Point(100, 0);
            label2.Margin = new Padding(100, 0, 100, 0);
            label2.Name = "label2";
            label2.Size = new Size(522, 62);
            label2.TabIndex = 1;
            label2.Text = "Modelo";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            toolTip1.SetToolTip(label2, "Introduce el modelo de tu coche");
            // 
            // textBox_modelo
            // 
            textBox_modelo.Dock = DockStyle.Fill;
            textBox_modelo.Location = new Point(100, 62);
            textBox_modelo.Margin = new Padding(100, 0, 100, 0);
            textBox_modelo.Name = "textBox_modelo";
            textBox_modelo.Size = new Size(522, 27);
            textBox_modelo.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(textBox_color, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 124);
            tableLayoutPanel2.Margin = new Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(722, 124);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(117, 230, 164);
            label3.CausesValidation = false;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Cooper Black", 15F);
            label3.ForeColor = Color.FromArgb(39, 50, 56);
            label3.Location = new Point(100, 0);
            label3.Margin = new Padding(100, 0, 100, 0);
            label3.Name = "label3";
            label3.Size = new Size(522, 62);
            label3.TabIndex = 2;
            label3.Text = "Color";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_color
            // 
            textBox_color.Dock = DockStyle.Fill;
            textBox_color.Location = new Point(100, 62);
            textBox_color.Margin = new Padding(100, 0, 100, 0);
            textBox_color.Name = "textBox_color";
            textBox_color.Size = new Size(522, 27);
            textBox_color.TabIndex = 3;
            toolTip1.SetToolTip(textBox_color, "Introduce el color de tu coche");
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label4, 0, 0);
            tableLayoutPanel3.Controls.Add(textBox_peso, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 248);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(722, 126);
            tableLayoutPanel3.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(117, 230, 164);
            label4.CausesValidation = false;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Cooper Black", 15F);
            label4.ForeColor = Color.FromArgb(39, 50, 56);
            label4.Location = new Point(100, 0);
            label4.Margin = new Padding(100, 0, 100, 0);
            label4.Name = "label4";
            label4.Size = new Size(522, 63);
            label4.TabIndex = 3;
            label4.Text = "Peso";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox_peso
            // 
            textBox_peso.Dock = DockStyle.Fill;
            textBox_peso.Location = new Point(100, 63);
            textBox_peso.Margin = new Padding(100, 0, 100, 0);
            textBox_peso.Name = "textBox_peso";
            textBox_peso.Size = new Size(522, 27);
            textBox_peso.TabIndex = 4;
            toolTip1.SetToolTip(textBox_peso, "Introduce el peso de tu coche");
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Italic);
            label5.ForeColor = Color.FromArgb(39, 50, 56);
            label5.Location = new Point(3, 374);
            label5.Name = "label5";
            label5.Size = new Size(716, 76);
            label5.TabIndex = 1;
            label5.Text = "* Sus datos serán recogidos para valorar la viabilidad del pedido, será usted contactado o contactada por teléfono o correo electrónico en un plazo de 1-3 días";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkbox_condiciones
            // 
            checkbox_condiciones.AutoSize = true;
            checkbox_condiciones.Dock = DockStyle.Fill;
            checkbox_condiciones.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            checkbox_condiciones.Location = new Point(15, 453);
            checkbox_condiciones.Margin = new Padding(15, 3, 0, 3);
            checkbox_condiciones.Name = "checkbox_condiciones";
            checkbox_condiciones.Size = new Size(707, 44);
            checkbox_condiciones.TabIndex = 5;
            checkbox_condiciones.Text = "Entiendo las condiciones y acepto";
            toolTip1.SetToolTip(checkbox_condiciones, "Es necesario aceptar las condiciones");
            checkbox_condiciones.UseVisualStyleBackColor = true;
            checkbox_condiciones.CheckedChanged += checkbox_condiciones_CheckedChanged;
            // 
            // btn_salir
            // 
            btn_salir.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_salir.BackColor = Color.FromArgb(117, 230, 164);
            btn_salir.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btn_salir.ForeColor = Color.White;
            btn_salir.Location = new Point(1085, 3);
            btn_salir.Name = "btn_salir";
            btn_salir.Size = new Size(34, 31);
            btn_salir.TabIndex = 1;
            btn_salir.Text = "X";
            btn_salir.UseVisualStyleBackColor = false;
            btn_salir.Click += btn_salir_Click;
            // 
            // Form_Cliente_DatosCoche
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 990);
            Controls.Add(tlp1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form_Cliente_DatosCoche";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp2.PerformLayout();
            tlpTarjeta.ResumeLayout(false);
            tlpTarjeta.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp2;
        private Label label1;
        private TableLayoutPanel tlpTarjeta;
        private Button btn_salir;
        private TableLayoutPanel tableLayoutPanel7;
        private TableLayoutPanel tableLayoutPanel8;
        private Button btn_continuar;
        private Label label5;
        private CheckBox checkbox_condiciones;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private TextBox textBox_modelo;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label3;
        private TextBox textBox_color;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label4;
        private TextBox textBox_peso;
        private ToolTip toolTip1;
    }
}