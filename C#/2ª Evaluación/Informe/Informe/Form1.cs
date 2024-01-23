using System.Data;
using System.Data.SQLite;

namespace Informe
{
    public partial class Form1 : Form
    {
        Form2 ventana = new Form2();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {

            SQLiteConnection conn = new SQLiteConnection("Data source = C:\\Users\\Alumno\\Desktop\\provider_sqlite.db");

            String query = "SELECT * FROM Cliente";
            SQLiteCommand cmd = new SQLiteCommand(query, conn);

            //Datatable
            DataTable dt = new DataTable();

            //Adapter
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);

            adapter.Fill(dt);

            // Enlace datatable con gridview
            dgv_DB.DataSource = dt;
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            ventana.Show();
        }
    }
}
