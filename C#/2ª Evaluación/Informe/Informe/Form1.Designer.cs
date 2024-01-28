namespace Informe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgv_DB = new DataGridView();
            btn_conectar = new Button();
            btn_report = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_DB).BeginInit();
            SuspendLayout();
            // 
            // dgv_DB
            // 
            dgv_DB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_DB.Location = new Point(27, 147);
            dgv_DB.Name = "dgv_DB";
            dgv_DB.Size = new Size(701, 219);
            dgv_DB.TabIndex = 0;
            // 
            // btn_conectar
            // 
            btn_conectar.Location = new Point(43, 86);
            btn_conectar.Name = "btn_conectar";
            btn_conectar.Size = new Size(75, 23);
            btn_conectar.TabIndex = 1;
            btn_conectar.Text = "Conectar";
            btn_conectar.UseVisualStyleBackColor = true;
            btn_conectar.Click += btn_conectar_Click;
            // 
            // btn_report
            // 
            btn_report.Location = new Point(677, 405);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(75, 23);
            btn_report.TabIndex = 2;
            btn_report.Text = "Report";
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_report);
            Controls.Add(btn_conectar);
            Controls.Add(dgv_DB);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgv_DB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_DB;
        private Button btn_conectar;
        private Button btn_report;
    }
}
