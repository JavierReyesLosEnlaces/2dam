using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography.Pkcs;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Empleado : Form
    {
        // aquí se está referenciando al App.xml 
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_Empleado()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String sqlQuery = "SELECT * FROM Books";
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connectionString);
                SqlConnection connection = new SqlConnection(connectionString);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                //dataGridView1.DataSource = dt;

                MessageBox.Show("Exito");

                //llenar el datatable con la info que ha cogido adapter despues de ejecutar la instruccion de la linea 20

            }
            catch (Exception)
            {
                MessageBox.Show("Falló");
                throw;
            }
        }

        /*
                private void button1_Click_1(object sender, EventArgs e)
                {
                    //string sqlQuery = "INSERT INTO clientes(a, b) VALUES(" + textBox1 + ", " + textBox2 + ");";
                    string sqlQuery = "INSERT INTO Books (tittle," +
                        " author) VALUES(@param1, @param2);";



                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);

                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlQuery, connection);


                        var bookTitleParameter = new SqlParameter("param1", System.Data.SqlDbType.VarChar);
                        bookTitleParameter.Value = textBox1.Text;
                        cmd.Parameters.Add(bookTitleParameter);

                        var bookAuthorParameter = new SqlParameter("param2", System.Data.SqlDbType.VarChar);
                        bookAuthorParameter.Value = textBox2.Text;
                        cmd.Parameters.Add(bookAuthorParameter);

                        cmd.ExecuteNonQuery();
                        connection.Close();
                        MessageBox.Show("Exito");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Fallo");
                        throw;
                    }


                }
        */

        // AQUÍ VAMOS A LLAMAR AL PROCEDIMIENTO ALMACENADO
        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();
                SqlCommand cmd = new SqlCommand("SaveBook", connection);

                // Indicamos que el comando es un procedimiento almacenado
                cmd.CommandType = CommandType.StoredProcedure;
                /*
                string bookTitle = textBox1.Text;
                string bookAuthor = textBox2.Text;
                

                cmd.Parameters.Add(new SqlParameter("@bookTitle", bookTitle));
                cmd.Parameters.Add(new SqlParameter("@bookAuthor", bookAuthor));
                */

                cmd.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Exito");

            }
            catch (Exception) { }

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgv_consultaRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
