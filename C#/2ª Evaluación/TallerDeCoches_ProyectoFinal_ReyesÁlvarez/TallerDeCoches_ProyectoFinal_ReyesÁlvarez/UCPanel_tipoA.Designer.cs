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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCPanel_tipoA));
            tlp1 = new TableLayoutPanel();
            tlp2 = new TableLayoutPanel();
            tlp3 = new TableLayoutPanel();
            tlp5 = new TableLayoutPanel();
            tlp6 = new TableLayoutPanel();
            btn_crearRegistro = new Button();
            btn_modificarRegistro = new Button();
            btn_borrarRegistro = new Button();
            dataGridView1 = new DataGridView();
            tlpDatos = new TableLayoutPanel();
            campoLabel1 = new Label();
            campoLabel2 = new Label();
            campoLabel3 = new Label();
            campoLabel4 = new Label();
            campoLabel5 = new Label();
            campoLabel6 = new Label();
            campoLabel7 = new Label();
            campoLabel8 = new Label();
            campoLabel9 = new Label();
            campoLabel10 = new Label();
            btn_aceptar = new Button();
            campoTextbox1 = new TextBox();
            campoTextbox2 = new TextBox();
            campoTextbox3 = new TextBox();
            campoTextbox4 = new TextBox();
            campoTextbox5 = new TextBox();
            campoTextbox6 = new TextBox();
            campoTextbox7 = new TextBox();
            campoTextbox8 = new TextBox();
            campoTextbox9 = new TextBox();
            campoTextbox10 = new TextBox();
            tlp7 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label_nombreTabla = new Label();
            imageList1 = new ImageList(components);
            tlp1.SuspendLayout();
            tlp2.SuspendLayout();
            tlp3.SuspendLayout();
            tlp5.SuspendLayout();
            tlp6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tlpDatos.SuspendLayout();
            tlp7.SuspendLayout();
            SuspendLayout();
            // 
            // tlp1
            // 
            tlp1.BackColor = Color.White;
            resources.ApplyResources(tlp1, "tlp1");
            tlp1.Controls.Add(tlp2, 0, 1);
            tlp1.Controls.Add(tlp7, 0, 0);
            tlp1.Name = "tlp1";
            // 
            // tlp2
            // 
            tlp2.BackColor = SystemColors.Control;
            resources.ApplyResources(tlp2, "tlp2");
            tlp2.Controls.Add(tlp3, 1, 0);
            tlp2.Controls.Add(tlpDatos, 0, 0);
            tlp2.Name = "tlp2";
            // 
            // tlp3
            // 
            tlp3.BackColor = SystemColors.Control;
            resources.ApplyResources(tlp3, "tlp3");
            tlp3.Controls.Add(tlp5, 0, 1);
            tlp3.Controls.Add(dataGridView1, 0, 0);
            tlp3.Name = "tlp3";
            // 
            // tlp5
            // 
            resources.ApplyResources(tlp5, "tlp5");
            tlp5.Controls.Add(tlp6, 0, 0);
            tlp5.Controls.Add(btn_borrarRegistro, 1, 0);
            tlp5.Name = "tlp5";
            // 
            // tlp6
            // 
            resources.ApplyResources(tlp6, "tlp6");
            tlp6.Controls.Add(btn_crearRegistro, 0, 0);
            tlp6.Controls.Add(btn_modificarRegistro, 0, 1);
            tlp6.Name = "tlp6";
            // 
            // btn_crearRegistro
            // 
            btn_crearRegistro.BackColor = Color.FromArgb(121, 141, 236);
            resources.ApplyResources(btn_crearRegistro, "btn_crearRegistro");
            btn_crearRegistro.FlatAppearance.BorderColor = Color.FromArgb(10, 78, 160);
            btn_crearRegistro.ForeColor = Color.FromArgb(10, 78, 160);
            btn_crearRegistro.Name = "btn_crearRegistro";
            btn_crearRegistro.UseVisualStyleBackColor = false;
            // 
            // btn_modificarRegistro
            // 
            btn_modificarRegistro.BackColor = Color.FromArgb(255, 192, 128);
            resources.ApplyResources(btn_modificarRegistro, "btn_modificarRegistro");
            btn_modificarRegistro.FlatAppearance.BorderColor = Color.FromArgb(164, 88, 19);
            btn_modificarRegistro.ForeColor = Color.FromArgb(164, 88, 19);
            btn_modificarRegistro.Name = "btn_modificarRegistro";
            btn_modificarRegistro.UseVisualStyleBackColor = false;
            btn_modificarRegistro.Click += btn_modificarRegistro_Click;
            // 
            // btn_borrarRegistro
            // 
            btn_borrarRegistro.BackColor = Color.FromArgb(255, 128, 128);
            resources.ApplyResources(btn_borrarRegistro, "btn_borrarRegistro");
            btn_borrarRegistro.FlatAppearance.BorderColor = Color.FromArgb(174, 0, 4);
            btn_borrarRegistro.ForeColor = Color.FromArgb(174, 0, 4);
            btn_borrarRegistro.Name = "btn_borrarRegistro";
            btn_borrarRegistro.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(dataGridView1, "dataGridView1");
            dataGridView1.Name = "dataGridView1";
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // tlpDatos
            // 
            tlpDatos.BackColor = SystemColors.Control;
            resources.ApplyResources(tlpDatos, "tlpDatos");
            tlpDatos.Controls.Add(campoLabel1, 0, 0);
            tlpDatos.Controls.Add(campoLabel2, 0, 2);
            tlpDatos.Controls.Add(campoLabel3, 0, 4);
            tlpDatos.Controls.Add(campoLabel4, 0, 6);
            tlpDatos.Controls.Add(campoLabel5, 0, 8);
            tlpDatos.Controls.Add(campoLabel6, 0, 10);
            tlpDatos.Controls.Add(campoLabel7, 0, 12);
            tlpDatos.Controls.Add(campoLabel8, 0, 14);
            tlpDatos.Controls.Add(campoLabel9, 0, 16);
            tlpDatos.Controls.Add(campoLabel10, 0, 18);
            tlpDatos.Controls.Add(btn_aceptar, 0, 20);
            tlpDatos.Controls.Add(campoTextbox1, 0, 1);
            tlpDatos.Controls.Add(campoTextbox2, 0, 3);
            tlpDatos.Controls.Add(campoTextbox3, 0, 5);
            tlpDatos.Controls.Add(campoTextbox4, 0, 7);
            tlpDatos.Controls.Add(campoTextbox5, 0, 9);
            tlpDatos.Controls.Add(campoTextbox6, 0, 11);
            tlpDatos.Controls.Add(campoTextbox7, 0, 13);
            tlpDatos.Controls.Add(campoTextbox8, 0, 15);
            tlpDatos.Controls.Add(campoTextbox9, 0, 17);
            tlpDatos.Controls.Add(campoTextbox10, 0, 19);
            tlpDatos.ForeColor = SystemColors.ControlText;
            tlpDatos.Name = "tlpDatos";
            // 
            // campoLabel1
            // 
            resources.ApplyResources(campoLabel1, "campoLabel1");
            campoLabel1.BackColor = SystemColors.Control;
            campoLabel1.Name = "campoLabel1";
            // 
            // campoLabel2
            // 
            resources.ApplyResources(campoLabel2, "campoLabel2");
            campoLabel2.BackColor = SystemColors.Control;
            campoLabel2.Name = "campoLabel2";
            // 
            // campoLabel3
            // 
            resources.ApplyResources(campoLabel3, "campoLabel3");
            campoLabel3.BackColor = SystemColors.Control;
            campoLabel3.Name = "campoLabel3";
            // 
            // campoLabel4
            // 
            resources.ApplyResources(campoLabel4, "campoLabel4");
            campoLabel4.BackColor = SystemColors.Control;
            campoLabel4.Name = "campoLabel4";
            // 
            // campoLabel5
            // 
            resources.ApplyResources(campoLabel5, "campoLabel5");
            campoLabel5.BackColor = SystemColors.Control;
            campoLabel5.Name = "campoLabel5";
            // 
            // campoLabel6
            // 
            resources.ApplyResources(campoLabel6, "campoLabel6");
            campoLabel6.BackColor = SystemColors.Control;
            campoLabel6.Name = "campoLabel6";
            // 
            // campoLabel7
            // 
            resources.ApplyResources(campoLabel7, "campoLabel7");
            campoLabel7.BackColor = SystemColors.Control;
            campoLabel7.Name = "campoLabel7";
            // 
            // campoLabel8
            // 
            resources.ApplyResources(campoLabel8, "campoLabel8");
            campoLabel8.BackColor = SystemColors.Control;
            campoLabel8.Name = "campoLabel8";
            // 
            // campoLabel9
            // 
            resources.ApplyResources(campoLabel9, "campoLabel9");
            campoLabel9.BackColor = SystemColors.Control;
            campoLabel9.Name = "campoLabel9";
            // 
            // campoLabel10
            // 
            resources.ApplyResources(campoLabel10, "campoLabel10");
            campoLabel10.BackColor = SystemColors.Control;
            campoLabel10.Name = "campoLabel10";
            // 
            // btn_aceptar
            // 
            btn_aceptar.BackColor = Color.LightGray;
            resources.ApplyResources(btn_aceptar, "btn_aceptar");
            btn_aceptar.FlatAppearance.BorderColor = Color.FromArgb(0, 64, 64);
            btn_aceptar.ForeColor = Color.FromArgb(0, 64, 64);
            btn_aceptar.Name = "btn_aceptar";
            btn_aceptar.UseVisualStyleBackColor = false;
            btn_aceptar.Click += btn_aceptar_Click;
            // 
            // campoTextbox1
            // 
            resources.ApplyResources(campoTextbox1, "campoTextbox1");
            campoTextbox1.Name = "campoTextbox1";
            // 
            // campoTextbox2
            // 
            resources.ApplyResources(campoTextbox2, "campoTextbox2");
            campoTextbox2.Name = "campoTextbox2";
            // 
            // campoTextbox3
            // 
            resources.ApplyResources(campoTextbox3, "campoTextbox3");
            campoTextbox3.Name = "campoTextbox3";
            // 
            // campoTextbox4
            // 
            resources.ApplyResources(campoTextbox4, "campoTextbox4");
            campoTextbox4.Name = "campoTextbox4";
            // 
            // campoTextbox5
            // 
            resources.ApplyResources(campoTextbox5, "campoTextbox5");
            campoTextbox5.Name = "campoTextbox5";
            // 
            // campoTextbox6
            // 
            resources.ApplyResources(campoTextbox6, "campoTextbox6");
            campoTextbox6.Name = "campoTextbox6";
            // 
            // campoTextbox7
            // 
            resources.ApplyResources(campoTextbox7, "campoTextbox7");
            campoTextbox7.Name = "campoTextbox7";
            // 
            // campoTextbox8
            // 
            resources.ApplyResources(campoTextbox8, "campoTextbox8");
            campoTextbox8.Name = "campoTextbox8";
            // 
            // campoTextbox9
            // 
            resources.ApplyResources(campoTextbox9, "campoTextbox9");
            campoTextbox9.Name = "campoTextbox9";
            // 
            // campoTextbox10
            // 
            resources.ApplyResources(campoTextbox10, "campoTextbox10");
            campoTextbox10.Name = "campoTextbox10";
            // 
            // tlp7
            // 
            tlp7.BackColor = Color.FromArgb(117, 230, 164);
            resources.ApplyResources(tlp7, "tlp7");
            tlp7.Controls.Add(tableLayoutPanel3, 2, 0);
            tlp7.Controls.Add(tableLayoutPanel2, 1, 0);
            tlp7.Controls.Add(label_nombreTabla, 0, 0);
            tlp7.Name = "tlp7";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = SystemColors.Control;
            resources.ApplyResources(tableLayoutPanel3, "tableLayoutPanel3");
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = SystemColors.Control;
            resources.ApplyResources(tableLayoutPanel2, "tableLayoutPanel2");
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // label_nombreTabla
            // 
            resources.ApplyResources(label_nombreTabla, "label_nombreTabla");
            label_nombreTabla.BackColor = Color.FromArgb(117, 230, 164);
            label_nombreTabla.ForeColor = Color.FromArgb(0, 64, 64);
            label_nombreTabla.Name = "label_nombreTabla";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            resources.ApplyResources(imageList1, "imageList1");
            imageList1.TransparentColor = Color.Transparent;
            // 
            // UCPanel_tipoA
            // 
            AllowDrop = true;
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlp1);
            Name = "UCPanel_tipoA";
            tlp1.ResumeLayout(false);
            tlp2.ResumeLayout(false);
            tlp3.ResumeLayout(false);
            tlp5.ResumeLayout(false);
            tlp6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tlpDatos.ResumeLayout(false);
            tlpDatos.PerformLayout();
            tlp7.ResumeLayout(false);
            tlp7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlp1;
        private TableLayoutPanel tlp7;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
        public Label label_nombreTabla;
        private TableLayoutPanel tlp2;
        private TableLayoutPanel tlp3;
        private TableLayoutPanel tlp5;
        private TableLayoutPanel tlp6;
        public DataGridView dataGridView1;
        private ImageList imageList1;
        public Label campoLabel1;
        public Label campoLabel2;
        public Label campoLabel3;
        public Label campoLabel4;
        public Label campoLabel5;
        public Label campoLabel6;
        public Label campoLabel7;
        public Label campoLabel8;
        public Label campoLabel9;
        public Label campoLabel10;
        public Button btn_aceptar;
        public TextBox campoTextbox1;
        public TextBox campoTextbox2;
        public TextBox campoTextbox3;
        public TextBox campoTextbox4;
        public TextBox campoTextbox5;
        public TextBox campoTextbox6;
        public TextBox campoTextbox7;
        public TextBox campoTextbox8;
        public TextBox campoTextbox9;
        public TextBox campoTextbox10;
        public TableLayoutPanel tlpDatos;
        public Button btn_crearRegistro;
        public Button btn_modificarRegistro;
        public Button btn_borrarRegistro;
    }
}
