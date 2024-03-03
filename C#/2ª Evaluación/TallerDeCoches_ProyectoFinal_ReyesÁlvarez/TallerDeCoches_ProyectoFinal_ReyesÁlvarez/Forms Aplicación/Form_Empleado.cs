using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Security.Cryptography.Pkcs;
using System.Windows.Forms;

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


            
            // ADAPTAR LOS CONTENIDOS A LA TABLA SELECCIONADA

            // NOMBRE DE LA TABLA
            ucPanel_tipoa_clientes.label_nombreTabla.Text = "Clientes";
            ucPanel_tipoa_coches.label_nombreTabla.Text = "Coches";
            ucPanel_tipoa_empleados.label_nombreTabla.Text = "Empleados";
            ucPanel_tipoa_pedidos.label_nombreTabla.Text = "Pedidos";
            ucPanel_tipoa_roles.label_nombreTabla.Text = "Roles";
            ucPanel_tipoa_servicios.label_nombreTabla.Text = "Servicios";
            ucPanel_tipoa_talleres.label_nombreTabla.Text = "Talleres";
            //ucPanel_tipoa_usuarios.label_nombreTabla.Text = "Usuarios";


            // CLIENTES
            ucPanel_tipoa_clientes.campoLabel1.Text = "Cantidad adeudada: ";
            ucPanel_tipoa_clientes.campoLabel2.Text = "Fecha de registro";
            ucPanel_tipoa_clientes.campoLabel3.Text = "Código postal";
            ucPanel_tipoa_clientes.campoLabel4.Text = "Nombre";
            ucPanel_tipoa_clientes.campoLabel5.Text = "Primer apellido";
            ucPanel_tipoa_clientes.campoLabel6.Text = "Segundo apellido";
            ucPanel_tipoa_clientes.campoLabel7.Text = "Segundo apellido";
            ucPanel_tipoa_clientes.campoLabel8.Text = "DNI / NIE";
            ucPanel_tipoa_clientes.campoLabel9.Text = "Teléfono";
            ucPanel_tipoa_clientes.campoLabel10.Text = "Correo electrónico";

            // el rol tendrá qie ponerse como id_rol = 2 (cliente)

            // EMPLEADOS

            ucPanel_tipoa_empleados.campoLabel1.Text = "Salario base";
            ucPanel_tipoa_empleados.campoLabel2.Text = "Salario extra";
            ucPanel_tipoa_empleados.campoLabel3.Text = "Fecha inicio contrato";
            ucPanel_tipoa_empleados.campoLabel4.Text = "Nombre";
            ucPanel_tipoa_empleados.campoLabel5.Text = "Primer apellido";
            ucPanel_tipoa_empleados.campoLabel6.Text = "Segundo apellido";
            ucPanel_tipoa_empleados.campoLabel7.Text = "Segundo apellido";
            ucPanel_tipoa_empleados.campoLabel8.Text = "DNI / NIE";
            ucPanel_tipoa_empleados.campoLabel9.Text = "Teléfono";
            ucPanel_tipoa_empleados.campoLabel10.Text = "Correo electrónico";


            /* USUARIOS
            ucPanel_tipoa_usuarios.campoLabel1.Text = "Nombre";
            ucPanel_tipoa_usuarios.campoLabel2.Text = "Primer apellido";
            ucPanel_tipoa_usuarios.campoLabel3.Text = "Segundo apellido";
            ucPanel_tipoa_usuarios.campoLabel4.Text = "DNI / NIE";
            ucPanel_tipoa_usuarios.campoLabel5.Text = "Teléfono";
            ucPanel_tipoa_usuarios.campoLabel6.Text = "Correo electrónico";
            ucPanel_tipoa_usuarios.campoLabel7.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox7.Visible = false;
            ucPanel_tipoa_usuarios.campoLabel8.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox8.Visible = false;
            ucPanel_tipoa_usuarios.campoLabel9.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox9.Visible = false;
            ucPanel_tipoa_usuarios.campoLabel10.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox10.Visible = false;
            */


            // COCHES
            ucPanel_tipoa_coches.campoLabel1.Text = "Modelo";
            ucPanel_tipoa_coches.campoLabel2.Text = "Color";
            ucPanel_tipoa_coches.campoLabel3.Text = "Peso";
            ucPanel_tipoa_coches.campoLabel4.Visible = false;
            ucPanel_tipoa_coches.campoTextbox4.Visible = false;
            ucPanel_tipoa_coches.campoLabel5.Visible = false;
            ucPanel_tipoa_coches.campoTextbox5.Visible = false;
            ucPanel_tipoa_coches.campoLabel6.Visible = false;
            ucPanel_tipoa_coches.campoTextbox6.Visible = false;
            ucPanel_tipoa_coches.campoLabel7.Visible = false;
            ucPanel_tipoa_coches.campoTextbox7.Visible = false;
            ucPanel_tipoa_coches.campoLabel8.Visible = false;
            ucPanel_tipoa_coches.campoTextbox8.Visible = false;
            ucPanel_tipoa_coches.campoLabel9.Visible = false;
            ucPanel_tipoa_coches.campoTextbox9.Visible = false;
            ucPanel_tipoa_coches.campoLabel10.Visible = false;
            ucPanel_tipoa_coches.campoTextbox10.Visible = false;

            // PEDIDOS
            ucPanel_tipoa_pedidos.campoLabel1.Text = "Importe bruto";
            ucPanel_tipoa_pedidos.campoLabel2.Text = "Tipo impositivo";
            ucPanel_tipoa_pedidos.campoLabel3.Text = "Importe neto";
            ucPanel_tipoa_pedidos.campoLabel4.Text = "fecha";
            ucPanel_tipoa_pedidos.campoLabel5.Text = "Id del coche";
            ucPanel_tipoa_pedidos.campoLabel6.Text = "Id del servicio";
            ucPanel_tipoa_pedidos.campoLabel7.Visible = false;
            ucPanel_tipoa_pedidos.campoTextbox7.Visible = false;
            ucPanel_tipoa_pedidos.campoLabel8.Visible = false;
            ucPanel_tipoa_pedidos.campoTextbox8.Visible = false;
            ucPanel_tipoa_pedidos.campoLabel9.Visible = false;
            ucPanel_tipoa_pedidos.campoTextbox9.Visible = false;
            ucPanel_tipoa_pedidos.campoLabel10.Visible = false;
            ucPanel_tipoa_pedidos.campoTextbox10.Visible = false;

            // ROLES
            ucPanel_tipoa_roles.campoLabel1.Text = "Nombre del rol";
            ucPanel_tipoa_roles.campoLabel2.Text = "Permiso de lectura";
            ucPanel_tipoa_roles.campoLabel3.Text = "Permiso de escritura";
            ucPanel_tipoa_roles.campoLabel4.Visible = false;
            ucPanel_tipoa_roles.campoTextbox4.Visible = false;
            ucPanel_tipoa_roles.campoLabel5.Visible = false;
            ucPanel_tipoa_roles.campoTextbox5.Visible = false;
            ucPanel_tipoa_roles.campoLabel6.Visible = false;
            ucPanel_tipoa_roles.campoTextbox6.Visible = false;
            ucPanel_tipoa_roles.campoLabel7.Visible = false;
            ucPanel_tipoa_roles.campoTextbox7.Visible = false;
            ucPanel_tipoa_roles.campoLabel8.Visible = false;
            ucPanel_tipoa_roles.campoTextbox8.Visible = false;
            ucPanel_tipoa_roles.campoLabel9.Visible = false;
            ucPanel_tipoa_roles.campoTextbox9.Visible = false;
            ucPanel_tipoa_roles.campoLabel10.Visible = false;
            ucPanel_tipoa_roles.campoTextbox10.Visible = false;

            // SERVICIOS    
            ucPanel_tipoa_servicios.campoLabel1.Text = "Precio";
            ucPanel_tipoa_servicios.campoLabel2.Text = "Familia de servicio";
            ucPanel_tipoa_servicios.campoLabel3.Text = "Descripción del servicio";
            ucPanel_tipoa_servicios.campoLabel4.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox4.Visible = false;
            ucPanel_tipoa_servicios.campoLabel5.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox5.Visible = false;
            ucPanel_tipoa_servicios.campoLabel6.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox6.Visible = false;
            ucPanel_tipoa_servicios.campoLabel7.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox7.Visible = false;
            ucPanel_tipoa_servicios.campoLabel8.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox8.Visible = false;
            ucPanel_tipoa_servicios.campoLabel9.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox9.Visible = false;
            ucPanel_tipoa_servicios.campoLabel10.Visible = false;
            ucPanel_tipoa_servicios.campoTextbox10.Visible = false;

            // TALLERES
            ucPanel_tipoa_talleres.campoLabel1.Text = "Dirección";
            ucPanel_tipoa_talleres.campoLabel2.Text = "Especialización";
            ucPanel_tipoa_talleres.campoLabel3.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox3.Visible = false;
            ucPanel_tipoa_talleres.campoLabel4.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox4.Visible = false;
            ucPanel_tipoa_talleres.campoLabel5.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox5.Visible = false;
            ucPanel_tipoa_talleres.campoLabel6.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox6.Visible = false;
            ucPanel_tipoa_talleres.campoLabel7.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox7.Visible = false;
            ucPanel_tipoa_talleres.campoLabel8.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox8.Visible = false;
            ucPanel_tipoa_talleres.campoLabel9.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox9.Visible = false;
            ucPanel_tipoa_talleres.campoLabel10.Visible = false;
            ucPanel_tipoa_talleres.campoTextbox10.Visible = false;


            // RELLENAR LOS DATAGRIDVIEWS CON LOS DATOS DE LA BASE DE DATOS
            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            string[] consultasSql = { 
                // CLIENTES
                "SELECT clientes.id_cliente, clientes.cantidad_adeudada, clientes.fecha_registro, clientes.codigo_postal, usuarios.id_usuario, usuarios.nombre, usuarios.primer_apellido, usuarios.segundo_apellido, usuarios.dni, usuarios.telefono, usuarios.correo_electronico, usuarios.id_rol FROM clientes JOIN usuarios ON clientes.id_usuario = usuarios.id_usuario;",
                // COCHES
                "SELECT * FROM coches",
                // EMPLEADOS
                "SELECT empleados.id_empleado, empleados.salario_base, empleados.salario_extra, empleados.fecha_inicio_contrato, usuarios.id_usuario, usuarios.nombre, usuarios.primer_apellido, usuarios.segundo_apellido, usuarios.dni, usuarios.telefono, usuarios.correo_electronico, usuarios.id_rol FROM empleados JOIN usuarios ON empleados.id_usuario = usuarios.id_usuario;",
                // PEDIDOS
                "SELECT * FROM pedidos",
                // ROLES
                "SELECT * FROM roles",
                //SERVICIOS
                "SELECT * FROM servicios",
                //TALLERES
                "SELECT * FROM talleres" };
            for (int i = 0; i < consultasSql.Length; i++)
            {
                DataGridView dgview;

                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    SqlCommand comando = new SqlCommand(consultasSql[i], conexion);
                    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
                    DataTable tablaClientes = new DataTable();

                    conexion.Open();
                    adaptador.Fill(tablaClientes);

                    dgview = null;
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
                    }

                    dgview.DataSource = tablaClientes;
                    dgview.ReadOnly = true;



                }
                foreach (DataGridViewColumn columna in dgview.Columns)
                {
                    // Establece el modo de ajuste automático para todas las celdas en la columna
                    columna.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
            menuBaseDeDatos.Visible = true;
            menuBaseDeDatos.BringToFront();
            ucPanel_tipoa_empleados.Visible = true;
            ucPanel_tipoa_empleados.BringToFront();
            tlpIntro.Visible = false;


        }

        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            menuRegistrarEmpleado.Visible = true;
            menuRegistrarEmpleado.BringToFront();
            menuBaseDeDatos.Visible = false;
            menuBaseDeDatos.SendToBack();
            tlpIntro.Visible = false;
        }

        private void btn_salirAlLogin_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            fl.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void ucPanel_tipoa_empleados_Load(object sender, EventArgs e)
        {

        }
    }
}
