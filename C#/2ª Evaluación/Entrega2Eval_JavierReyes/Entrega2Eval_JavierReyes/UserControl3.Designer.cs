
namespace Entrega2Eval_JavierReyes
{
    partial class UserControl3
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
            SuspendLayout();
            // 
            // btn_caja
            // 
            btn_caja.BackColor = Color.FromArgb(255, 152, 83);
            btn_caja.BackgroundImageLayout = ImageLayout.None;
            btn_caja.FlatStyle = FlatStyle.Flat;
            btn_caja.Font = new Font("Ink Free", 14F, FontStyle.Bold);
            btn_caja.ForeColor = SystemColors.ControlLightLight;
            btn_caja.Location = new Point(31, 34);
            btn_caja.Name = "btn_caja";
            btn_caja.Size = new Size(415, 127);
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
            btn_tarjeta.Location = new Point(31, 193);
            btn_tarjeta.Name = "btn_tarjeta";
            btn_tarjeta.Size = new Size(415, 127);
            btn_tarjeta.TabIndex = 1;
            btn_tarjeta.Text = "Pagar con tarjeta";
            btn_tarjeta.UseVisualStyleBackColor = false;
            btn_tarjeta.Click += btn_tarjeta_Click_1;
            // 
            // UserControl3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 152, 83);
            Controls.Add(btn_tarjeta);
            Controls.Add(btn_caja);
            Name = "UserControl3";
            Size = new Size(474, 512);
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
    }
}
