using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

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

            ucPanel_tipoa_empleados.tlpDatos.Enabled = false;

            // NOMBRE DE LA TABLA
            ucPanel_tipoa_clientes.label_nombreTabla.Text = "Clientes";
            ucPanel_tipoa_coches.label_nombreTabla.Text = "Coches";
            ucPanel_tipoa_empleados.label_nombreTabla.Text = "Empleados";
            ucPanel_tipoa_pedidos.label_nombreTabla.Text = "Pedidos";
            ucPanel_tipoa_roles.label_nombreTabla.Text = "Roles";
            ucPanel_tipoa_servicios.label_nombreTabla.Text = "Servicios";
            ucPanel_tipoa_talleres.label_nombreTabla.Text = "Talleres";
            ucPanel_tipoa_usuarios.label_nombreTabla.Text = "Usuarios";


            // CLIENTES
            ucPanel_tipoa_clientes.campoLabel1.Text = "cantidad_adeudada";
            ucPanel_tipoa_clientes.campoLabel2.Text = "Fecha de registro";
            ucPanel_tipoa_clientes.campoLabel3.Text = "Código postal";
            ucPanel_tipoa_clientes.campoLabel4.Text = "id_usuario";
            ucPanel_tipoa_clientes.campoLabel5.Visible = false;
            ucPanel_tipoa_clientes.campoTextbox5.Visible = false;
            ucPanel_tipoa_clientes.campoLabel6.Visible = false;
            ucPanel_tipoa_clientes.campoTextbox6.Visible = false;
            ucPanel_tipoa_clientes.campoLabel7.Visible = false;
            ucPanel_tipoa_clientes.campoTextbox7.Visible = false;
            ucPanel_tipoa_clientes.campoLabel8.Visible = false;
            ucPanel_tipoa_clientes.campoTextbox8.Visible = false;
            ucPanel_tipoa_clientes.campoLabel9.Visible = false;
            ucPanel_tipoa_clientes.campoTextbox9.Visible = false;
            ucPanel_tipoa_clientes.campoLabel10.Visible = false;
            ucPanel_tipoa_clientes.campoTextbox10.Visible = false;
            /*
            ucPanel_tipoa_clientes.campoLabel4.Text = "Nombre";
            ucPanel_tipoa_clientes.campoLabel5.Text = "Primer apellido";
            ucPanel_tipoa_clientes.campoLabel6.Text = "Segundo apellido";
            ucPanel_tipoa_clientes.campoLabel7.Text = "DNI / NIE";
            ucPanel_tipoa_clientes.campoLabel8.Text = "Teléfono";
            ucPanel_tipoa_clientes.campoLabel9.Text = "Correo electrónico";
            ucPanel_tipoa_clientes.campoLabel10.Text = "id_rol";
            */
            // el rol tendrá qie ponerse como id_rol = 2 (cliente)

            // EMPLEADOS

            ucPanel_tipoa_empleados.campoLabel1.Text = "Salario base";
            ucPanel_tipoa_empleados.campoLabel2.Text = "Salario extra";
            ucPanel_tipoa_empleados.campoLabel3.Text = "Fecha inicio contrato";
            ucPanel_tipoa_empleados.campoLabel4.Text = "Salario base";
            ucPanel_tipoa_empleados.campoLabel5.Visible = false;
            ucPanel_tipoa_empleados.campoTextbox5.Visible = false;
            ucPanel_tipoa_empleados.campoLabel6.Visible = false;
            ucPanel_tipoa_empleados.campoTextbox6.Visible = false;
            ucPanel_tipoa_empleados.campoLabel7.Visible = false;
            ucPanel_tipoa_empleados.campoTextbox7.Visible = false;
            ucPanel_tipoa_empleados.campoLabel8.Visible = false;
            ucPanel_tipoa_empleados.campoTextbox8.Visible = false;
            ucPanel_tipoa_empleados.campoLabel9.Visible = false;
            ucPanel_tipoa_empleados.campoTextbox9.Visible = false;
            ucPanel_tipoa_empleados.campoLabel10.Visible = false;
            ucPanel_tipoa_empleados.campoTextbox10.Visible = false;


            /*
            ucPanel_tipoa_empleados.campoLabel4.Text = "nombre";
            ucPanel_tipoa_empleados.campoLabel5.Text = "primer_apellido";
            ucPanel_tipoa_empleados.campoLabel6.Text = "segundo_apellido";
            ucPanel_tipoa_empleados.campoLabel7.Text = "dni";
            ucPanel_tipoa_empleados.campoLabel8.Text = "telefono";
            ucPanel_tipoa_empleados.campoLabel9.Text = "Correo electrónico";
            ucPanel_tipoa_empleados.campoTextbox10.Visible = false;
            ucPanel_tipoa_empleados.campoLabel10.Visible = false;
            */


            //USUARIOS
            ucPanel_tipoa_usuarios.campoLabel1.Text = "Nombre";
            ucPanel_tipoa_usuarios.campoLabel2.Text = "Primer apellido";
            ucPanel_tipoa_usuarios.campoLabel3.Text = "Segundo apellido";
            ucPanel_tipoa_usuarios.campoLabel4.Text = "DNI / NIE";
            ucPanel_tipoa_usuarios.campoLabel5.Text = "Teléfono";
            ucPanel_tipoa_usuarios.campoLabel6.Text = "Correo electrónico";
            ucPanel_tipoa_usuarios.campoLabel7.Text = "id_rol";
            ucPanel_tipoa_usuarios.campoLabel8.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox8.Visible = false;
            ucPanel_tipoa_usuarios.campoLabel9.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox9.Visible = false;
            ucPanel_tipoa_usuarios.campoLabel10.Visible = false;
            ucPanel_tipoa_usuarios.campoTextbox10.Visible = false;


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
            ucPanel_tipoa_roles.campoLabel1.Text = "nombre_rol";
            ucPanel_tipoa_roles.campoLabel2.Text = "permiso_lectura";
            ucPanel_tipoa_roles.campoLabel3.Text = "permiso_escritura";
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
            ucPanel_tipoa_servicios.campoLabel4.Text = "Id taller";
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
                "SELECT * FROM clientes",
                // COCHES
                "SELECT * FROM coches",
                // EMPLEADOS
                "SELECT * FROM empleados",
                // USUARIOS
                "SELECT * FROM usuarios",
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
                            ucPanel_tipoa_empleados.btn_crearRegistro.Click += btn_registrarEmpleado_Click2;
                            break;
                        case 1:
                            dgview = ucPanel_tipoa_coches.dataGridView1;
                            break;
                        case 2:
                            dgview = ucPanel_tipoa_empleados.dataGridView1;
                            break;
                        case 3:
                            dgview = ucPanel_tipoa_usuarios.dataGridView1;
                            break;
                        case 4:
                            dgview = ucPanel_tipoa_pedidos.dataGridView1;
                            break;
                        case 5:
                            dgview = ucPanel_tipoa_roles.dataGridView1;
                            break;
                        case 6:
                            dgview = ucPanel_tipoa_servicios.dataGridView1;
                            break;
                        case 7:
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

        private void btn_registrarEmpleado_Click2(object sender, EventArgs e)
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

        private void btn_registrarEmpleado_Click(object sender, EventArgs e)
        {
            if (textbox_re_nombreUsuario.Text.Length < 3 || textbox_re_contraseñaUsuario.Text.Length < 5)
            {
                MessageBox.Show("Nombre de usuario o contraseña no válidos, muy cortos");
            }
            else
            {
                string nombre = textbox_re_nombre.Text;
                string primerApellido = textbox_re_primerApellido.Text;
                string segundoApellido = textbox_re_segundoApellido.Text;
                string dni = textbox_re_dni.Text;
                string telefono = textbox_re_telefono.Text;
                string correoElectronico = textbox_re_correo.Text;
                string salarioBase = textbox_re_salarioBase.Text;
                string salarioExtra = textbox_re_salarioExtra.Text;
                string fechaInicioContrato = textbox_re_fechaInicioContrato.Text;
                string nombreUsuario = textbox_re_nombreUsuario.Text;
                string contraseñaUsuario = textbox_re_contraseñaUsuario.Text;

                // Creación del directorio que contendrá el fichero con las claves cifradas
                string dir = nombreUsuario;
                string path = "data\\empleados\\" + dir;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    string encusr = AesCryp.Encrypt(nombreUsuario);
                    string encpss = AesCryp.Encrypt(contraseñaUsuario);
                    var streamwriter = new StreamWriter(Path.Combine(path, "data.ls"));
                    streamwriter.WriteLine(encusr);
                    streamwriter.WriteLine(encpss);
                    streamwriter.Close();

                    // Inserción de datos del formulario de empleado en la base de datos
                    string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                    string queryInsertEmpleado = @"INSERT INTO empleados (salario_base, salario_extra, fecha_inicio_contrato, id_usuario) 
                                           VALUES (@SalarioBase, @SalarioExtra, @FechaInicioContrato, @IdUsuario)";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(queryInsertEmpleado, connection))
                            {
                                command.Parameters.AddWithValue("@SalarioBase", salarioBase);
                                command.Parameters.AddWithValue("@SalarioExtra", salarioExtra);
                                command.Parameters.AddWithValue("@FechaInicioContrato", fechaInicioContrato);

                                // Insertar el usuario en la tabla usuarios
                                string queryInsertUsuario = @"INSERT INTO usuarios (nombre, primer_apellido, segundo_apellido, dni, telefono, correo_electronico, id_rol) 
                                                      VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @DNI, @Telefono, @CorreoElectronico, @Rol);
                                                      SELECT SCOPE_IDENTITY()";
                                using (SqlCommand commandUsuario = new SqlCommand(queryInsertUsuario, connection))
                                {
                                    commandUsuario.Parameters.AddWithValue("@Nombre", nombre);
                                    commandUsuario.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                                    commandUsuario.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                                    commandUsuario.Parameters.AddWithValue("@DNI", dni);
                                    commandUsuario.Parameters.AddWithValue("@Telefono", telefono);
                                    commandUsuario.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                                    commandUsuario.Parameters.AddWithValue("@Rol", 2); // Id del rol, por ejemplo 2

                                    // Obtener el ID del usuario insertado
                                    int idUsuario = Convert.ToInt32(commandUsuario.ExecuteScalar());

                                    // Asignar el ID de usuario al empleado
                                    command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                                    command.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Los datos del empleado se han registrado correctamente");
                        Form_Login fl = new Form_Login();
                        fl.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos en la base de datos: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya existe.");
                }
            }
        }

    }
}
