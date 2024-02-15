
namespace Entrega2Eval_JavierReyes
{
    partial class UserControl_UltimosDetalles
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            btn_caja = new Button();
            btn_tarjeta = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            lb_observaciones = new Label();
            tb_observaciones = new TextBox();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_caja
            // 
            btn_caja.BackColor = Color.FromArgb(255, 152, 83);
            btn_caja.BackgroundImageLayout = ImageLayout.None;
            btn_caja.FlatStyle = FlatStyle.Flat;
            btn_caja.Font = new Font("Ink Free", 14F, FontStyle.Bold);
            btn_caja.ForeColor = SystemColors.ControlLightLight;
            btn_caja.Location = new Point(62, 26);
            btn_caja.Margin = new Padding(3, 2, 3, 2);
            btn_caja.Name = "btn_caja";
            btn_caja.Size = new Size(288, 89);
            btn_caja.TabIndex = 0;
            btn_caja.Text = "Pagar en caja";
            btn_caja.UseVisualStyleBackColor = false;
            btn_caja.Click += btn_caja_Click_1;
            // 
            // btn_tarjeta
            // 
            btn_tarjeta.BackColor = Color.FromArgb(255, 152, 83);
            btn_tarjeta.BackgroundImageLayout = ImageLayout.None;
            btn_tarjeta.FlatStyle = FlatStyle.Flat;
            btn_tarjeta.Font = new Font("Ink Free", 14F, FontStyle.Bold);
            btn_tarjeta.ForeColor = SystemColors.ControlLightLight;
            btn_tarjeta.Location = new Point(62, 129);
            btn_tarjeta.Margin = new Padding(3, 2, 3, 2);
            btn_tarjeta.Name = "btn_tarjeta";
            btn_tarjeta.Size = new Size(288, 89);
            btn_tarjeta.TabIndex = 1;
            btn_tarjeta.Text = "Pagar con tarjeta";
            btn_tarjeta.UseVisualStyleBackColor = false;
            btn_tarjeta.Click += btn_tarjeta_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tb_observaciones, 0, 1);
            tableLayoutPanel1.Controls.Add(lb_observaciones, 0, 0);
            tableLayoutPanel1.Location = new Point(62, 239);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.Size = new Size(288, 126);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // lb_observaciones
            // 
            lb_observaciones.AutoSize = true;
            lb_observaciones.BackColor = Color.Black;
            lb_observaciones.Dock = DockStyle.Fill;
            lb_observaciones.Font = new Font("Ink Free", 13F, FontStyle.Bold);
            lb_observaciones.ForeColor = Color.White;
            lb_observaciones.Location = new Point(0, 0);
            lb_observaciones.Margin = new Padding(0);
            lb_observaciones.Name = "lb_observaciones";
            lb_observaciones.Size = new Size(288, 25);
            lb_observaciones.TabIndex = 4;
            lb_observaciones.Text = "Observaciones sobre el pedido";
            lb_observaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tb_observaciones
            // 
            tb_observaciones.BackColor = Color.FromArgb(255, 249, 244);
            tb_observaciones.Dock = DockStyle.Fill;
            tb_observaciones.Font = new Font("Ink Free", 12F, FontStyle.Bold);
            tb_observaciones.Location = new Point(0, 25);
            tb_observaciones.Margin = new Padding(0);
            tb_observaciones.Multiline = true;
            tb_observaciones.Name = "tb_observaciones";
            tb_observaciones.Size = new Size(288, 101);
            tb_observaciones.TabIndex = 5;
            // 
            // userControl3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 152, 83);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btn_tarjeta);
            Controls.Add(btn_caja);
            Margin = new Padding(3, 2, 3, 2);
            Name = "userControl3";
            Size = new Size(415, 384);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        private void btn_tarjeta_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btn_caja_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        public Button btn_caja;
        public Button btn_tarjeta;
        private TextBox textBox1;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        public TextBox tb_observaciones;
        public Label lb_observaciones;
    }
}
