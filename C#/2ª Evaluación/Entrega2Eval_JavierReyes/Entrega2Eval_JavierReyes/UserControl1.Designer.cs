namespace Entrega2Eval_JavierReyes
{
    partial class UserControl1
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
            uc1_tlp1 = new TableLayoutPanel();
            SuspendLayout();
            // 
            // uc1_tlp1
            // 
            uc1_tlp1.ColumnCount = 2;
            uc1_tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uc1_tlp1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            uc1_tlp1.Dock = DockStyle.Fill;
            uc1_tlp1.Location = new Point(0, 0);
            uc1_tlp1.Name = "uc1_tlp1";
            uc1_tlp1.RowCount = 3;
            uc1_tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uc1_tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uc1_tlp1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            uc1_tlp1.Size = new Size(415, 384);
            uc1_tlp1.TabIndex = 0;
            // 
            // UserControl1
            // 
            Controls.Add(uc1_tlp1);
            Name = "UserControl1";
            Size = new Size(415, 384);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel uc1_tlp1;
    }
}
