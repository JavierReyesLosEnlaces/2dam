using Microsoft.Data.SqlClient;
using System.Data;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String connectionString = "Data Source = DESKTOP-F7EQIKK; "+"Initial Catalog=taller_msql; Encrypt=False; Integrated Security=true";
            String sqlQuery = "SELECT * FROM Books";

            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;

                MessageBox.Show("Exito");

                //llenar el datatable con la info que ha cogido adapter despues de ejecutar la instruccion de la linea 20

            }catch(Exception)
            {
                MessageBox.Show("Falló");
                throw;
            }
        }
    }
}
