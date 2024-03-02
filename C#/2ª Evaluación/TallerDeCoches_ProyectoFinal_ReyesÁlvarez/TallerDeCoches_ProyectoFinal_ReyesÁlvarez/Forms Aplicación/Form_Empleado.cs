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
            InitUI();
        }

        private void InitUI()
        {
            ucPanel_tipoa_clientes.label_nombreTabla.Text = "Clientes";
            ucPanel_tipoa_coches.label_nombreTabla.Text = "Coches";
            ucPanel_tipoa_empleados.label_nombreTabla.Text = "Empleados";
            ucPanel_tipoa_pedidos.label_nombreTabla.Text = "Pedidos";
            ucPanel_tipoa_roles.label_nombreTabla.Text = "Roles";
            ucPanel_tipoa_servicios.label_nombreTabla.Text = "Servicios";
            ucPanel_tipoa_talleres.label_nombreTabla.Text = "Talleres";
            ucPanel_tipoa_usuarios.label_nombreTabla.Text = "Usuarios";


            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

            string[] consultasSql = { "SELECT * FROM clientes", "SELECT * FROM coches", "SELECT * FROM empleados", "SELECT * FROM pedidos", "SELECT * FROM roles", "SELECT * FROM servicios", "SELECT * FROM talleres", "SELECT * FROM usuarios" };
            //string consultaSql = "SELECT * FROM Clientes";

            for (int i = 0; i < consultasSql.Length; i++)
            {
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlCommand comando = new SqlCommand(consultasSql[i], conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaClientes = new DataTable();

                    conexion.Open();
                    adaptador.Fill(tablaClientes);

                    DataGridView dgview = null;
                    switch (i)
                    {
                        case 0:
                            dgview = ucPanel_tipoa_clientes.dataGridView1;
                            break;
                        case 1:
                            dgview = ucPanel_tipoa_coches.dataGridView1;
                            break;
                        case 2:
                            dgview = ucPanel_tipoa_empleados.dataGridView1;
                            break;
                        case 3:
                            dgview = ucPanel_tipoa_pedidos.dataGridView1;
                            break;
                        case 4:
                            dgview = ucPanel_tipoa_roles.dataGridView1;
                            break;
                        case 5:
                            dgview = ucPanel_tipoa_servicios.dataGridView1;
                            break;
                        case 6:
                            dgview = ucPanel_tipoa_talleres.dataGridView1;
                            break;
                        case 7:
                            dgview = ucPanel_tipoa_usuarios.dataGridView1;
                            break;

                    }

                    dgview.DataSource = tablaClientes;
                }
            }
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

        private void timer1_tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void btn_baseDeDatos_Click(object sender, EventArgs e)
        {
            panel_baseDeDatos.Visible = true;
        }
    }
}
