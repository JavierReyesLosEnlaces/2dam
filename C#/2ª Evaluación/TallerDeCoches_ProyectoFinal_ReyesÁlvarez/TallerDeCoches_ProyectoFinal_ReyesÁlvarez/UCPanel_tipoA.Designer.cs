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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tlp1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.ColumnCount = 1;
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Controls.Add(tabControl1, 0, 0);
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(145, 34);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(137, 6);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(192, 6);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
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
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}
