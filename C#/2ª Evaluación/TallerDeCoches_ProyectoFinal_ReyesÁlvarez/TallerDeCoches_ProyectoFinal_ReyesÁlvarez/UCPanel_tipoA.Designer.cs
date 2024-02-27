namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    partial class UCPanel_tipoA
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
            tlp1 = new TableLayoutPanel();
            tlp2 = new TableLayoutPanel();
            tlp1.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Dock = DockStyle.Fill;
            tlp1.Location = new Point(0, 0);
            tlp1.Margin = new Padding(0);
            tlp1.Name = "tlp1";
            tlp1.RowCount = 2;
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 90F));
            tlp1.Size = new Size(682, 400);
            tlp1.TabIndex = 0;
            // 
            // tlp2
            // 
            tlp2.ColumnCount = 2;
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlp2.Dock = DockStyle.Fill;
            tlp2.Location = new Point(0, 40);
            tlp2.Margin = new Padding(0);
            tlp2.Name = "tlp2";
            tlp2.RowCount = 1;
            tlp2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlp2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlp2.Size = new Size(682, 360);
            tlp2.TabIndex = 0;
            // 
            // UCPanel_tipoA
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(117, 230, 164);
            Controls.Add(tlp1);
            Margin = new Padding(10);
            Name = "UCPanel_tipoA";
            Size = new Size(682, 400);
            tlp1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp2;
    }
}
