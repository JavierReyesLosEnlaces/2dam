using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Empleado : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_Empleado()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            ucPanel_tipoa_empleados.tlpDatos.Enabled = false;

            btn_aceptarPedidoPendiente.BackColor = Color.LightGray;
            btn_aceptarPedidoPendiente.Enabled = false;

            btn_rechazarPedidoPendiente.BackColor = Color.LightGray;
            btn_rechazarPedidoPendiente.Enabled = false;

            Form_Login loginForm = new Form_Login();
            String nombreUsuario = conseguirNombre(loginForm.getEncPass());
            label_nombreUsuario.Text = nombreUsuario;



            label_bienvenida.Text = "¡Hola " + nombreUsuario + "!";


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

            initDatagridViews();
        }

        private string conseguirNombre(string encpss)
        {
            string nombreUsuario = "";

            string query = "SELECT nombre FROM usuarios WHERE contraseña_usuario = @ContraseñaUsuario";

            try
            {
                using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@ContraseñaUsuario", encpss);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                nombreUsuario = reader["nombre"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("No se encontró ningún usuario con esa contraseña.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier excepción
                MessageBox.Show("Error al obtener el nombre de usuario: " + ex.Message);
            }

            return nombreUsuario;
        }




        private void initDatagridViews()
        {


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
                "SELECT * FROM talleres",
                //PEDIDOS PENDIENTES
                "SELECT pr.id_pedidoRevision, pr.id_pedido, p.importe_bruto, p.tipo_impositivo, p.importe_neto, p.fecha, p.id_servicio \r\nFROM pedidosRevision pr\r\nJOIN pedidos p ON pr.id_pedido = p.id_pedido;\r\n"};

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
                        case 8:
                            dgview = dataGridView_pedidosPendientes;
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
            menuGestionarPedidos.Visible = false;
            initDatagridViews();
        }

        private void btn_registrarEmpleado_Click2(object sender, EventArgs e)
        {
            menuRegistrarEmpleado.Visible = true;
            menuRegistrarEmpleado.BringToFront();
            menuBaseDeDatos.Visible = false;
            menuBaseDeDatos.SendToBack();
            menuGestionarPedidos.Visible = false;
            panelBienvenida.Visible = false;
            panelBienvenida.SendToBack();
        }

        private void btn_salirAlLogin_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            fl.Show();
            this.Hide();
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
                    string queryInsertUsuario = @"INSERT INTO usuarios (nombre, primer_apellido, segundo_apellido, dni, telefono, correo_electronico, nombre_usuario, contraseña_usuario, id_rol) 
                                           VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @DNI, @Telefono, @CorreoElectronico, @NombreUsuario, @ContraseñaUsuario, @Rol)";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(queryInsertUsuario, connection))
                            {
                                command.Parameters.AddWithValue("@Nombre", nombre);
                                command.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                                command.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                                command.Parameters.AddWithValue("@DNI", dni);
                                command.Parameters.AddWithValue("@Telefono", telefono);
                                command.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                                command.Parameters.AddWithValue("@NombreUsuario", encusr);
                                command.Parameters.AddWithValue("@ContraseñaUsuario", encpss);
                                command.Parameters.AddWithValue("@Rol", 1); // Id del rol 1 = rol de empleado

                                // Ejecutar la inserción del usuario
                                command.ExecuteNonQuery();
                                String idUsuario;

                                string queryGetUserId = "SELECT id_usuario FROM usuarios WHERE nombre_usuario = @NombreUsuario AND contraseña_usuario = @ContraseñaUsuario";
                                using (SqlCommand getUserIdCommand = new SqlCommand(queryGetUserId, connection))
                                {
                                    getUserIdCommand.Parameters.AddWithValue("@NombreUsuario", encusr);
                                    getUserIdCommand.Parameters.AddWithValue("@ContraseñaUsuario", encpss);

                                    object result = getUserIdCommand.ExecuteScalar();

                                    if (result != null && result != DBNull.Value)
                                    {
                                        idUsuario = Convert.ToInt32(result).ToString();
                                    }
                                    else
                                    {
                                        throw new Exception("No se pudo obtener el ID del usuario insertado");
                                    }
                                }


                                // Insertar datos del empleado
                                string queryInsertEmpleado = @"INSERT INTO empleados (salario_base, salario_extra, fecha_inicio_contrato, id_usuario) 
                                                       VALUES (@SalarioBase, @SalarioExtra, @FechaInicioContrato, @IdUsuario)";
                                using (SqlCommand commandEmpleado = new SqlCommand(queryInsertEmpleado, connection))
                                {
                                    commandEmpleado.Parameters.AddWithValue("@SalarioBase", salarioBase);
                                    commandEmpleado.Parameters.AddWithValue("@SalarioExtra", salarioExtra);
                                    commandEmpleado.Parameters.AddWithValue("@FechaInicioContrato", fechaInicioContrato);
                                    commandEmpleado.Parameters.AddWithValue("@IdUsuario", idUsuario);

                                    // Ejecutar la inserción del empleado
                                    commandEmpleado.ExecuteNonQuery();
                                }
                            }
                        }

                        MessageBox.Show("Los datos del empleado se han registrado correctamente");

                        textbox_re_nombre.Text="";
                        textbox_re_primerApellido.Text = "";
                       textbox_re_segundoApellido.Text = "";
                        textbox_re_dni.Text = "";
                        textbox_re_telefono.Text = "";
                        textbox_re_correo.Text = "";
                        textbox_re_salarioBase.Text = "";
                        textbox_re_salarioExtra.Text = "";
                        textbox_re_fechaInicioContrato.Text = "";
                        textbox_re_nombreUsuario.Text = "";
                        textbox_re_contraseñaUsuario.Text = "";


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


        private void btn_gestionarPedidos_Click(object sender, EventArgs e)
        {
            menuGestionarPedidos.Visible = true;
            menuGestionarPedidos.BringToFront();
            actualizarPedidosPendientesRevision();

        }

        private void actualizarPedidosPendientesRevision()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

                // Construir la consulta SQL para seleccionar todos los registros de la tabla pedidosRevision
                string query = "SELECT pr.id_pedidoRevision, pr.id_pedido, p.importe_bruto, p.tipo_impositivo, p.importe_neto, p.fecha, p.id_servicio \r\nFROM pedidosRevision pr\r\nJOIN pedidos p ON pr.id_pedido = p.id_pedido;\r\n";

                // Crear un DataTable para almacenar los datos de la consulta
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta SQL y llenar el DataTable con los resultados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }

                // Asignar el DataTable como la fuente de datos del DataGridView
                dataGridView_pedidosPendientes.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en los encabezados)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_pedidosPendientes.Rows[e.RowIndex];

                // Si se hace clic en los encabezados o fuera del área de las celdas, deshabilitar los botones y ponerlos grises
                btn_aceptarPedidoPendiente.BackColor = Color.LightGray;
                btn_aceptarPedidoPendiente.Enabled = false;
                btn_rechazarPedidoPendiente.BackColor = Color.LightGray;
                btn_rechazarPedidoPendiente.Enabled = false;
            }
            else
            {
                // Cambiar el color de fondo de los botones al color original y habilitarlos
                btn_aceptarPedidoPendiente.BackColor = Color.FromArgb(255, 192, 128);
                btn_aceptarPedidoPendiente.Enabled = true;
                btn_rechazarPedidoPendiente.BackColor = Color.FromArgb(255, 128, 128);
                btn_rechazarPedidoPendiente.Enabled = true;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Verificar si hay al menos una fila seleccionada
            if (dataGridView_pedidosPendientes.SelectedRows.Count > 0)
            {
                // Cambiar el color de fondo de los botones al color original y habilitarlos
                btn_aceptarPedidoPendiente.BackColor = Color.FromArgb(255, 192, 128);
                btn_aceptarPedidoPendiente.Enabled = true;
                btn_rechazarPedidoPendiente.BackColor = Color.FromArgb(255, 128, 128);
                btn_rechazarPedidoPendiente.Enabled = true;
            }
            else
            {
                // Si no hay filas seleccionadas, deshabilitar los botones y ponerlos grises
                btn_aceptarPedidoPendiente.BackColor = Color.LightGray;
                btn_aceptarPedidoPendiente.Enabled = false;
                btn_rechazarPedidoPendiente.BackColor = Color.LightGray;
                btn_rechazarPedidoPendiente.Enabled = false;
            }
        }

        private void btn_aceptarPedidoPendiente_Click(object sender, EventArgs e)
        {
            if (dataGridView_pedidosPendientes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres aceptar el pedido?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idPedidoRevision = (int)dataGridView_pedidosPendientes.SelectedRows[0].Cells["id_pedidoRevision"].Value;

                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        SqlCommand command = new SqlCommand("DELETE FROM pedidosRevision WHERE id_pedidoRevision = @idPedidoRevision", connection);
                        command.Parameters.AddWithValue("@idPedidoRevision", idPedidoRevision);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        MessageBox.Show(command.ToString());
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Pedido aceptado correctamente.");
                            actualizarPedidosPendientesRevision();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo aceptar el pedido.");
                        }

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al aceptar el pedido: " + ex.Message);
                    }
                }
            }
        }

        private void btn_rechazarPedidoPendiente_Click(object sender, EventArgs e)
        {
            if (dataGridView_pedidosPendientes.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quieres rechazar el pedido?", "Confirmar Acción", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    int idPedidoRevision = (int)dataGridView_pedidosPendientes.SelectedRows[0].Cells["id_pedidoRevision"].Value;

                    try
                    {
                        SqlConnection connection = new SqlConnection(connectionString);
                        connection.Open();

                        SqlCommand command2 = new SqlCommand("DELETE FROM pedidos WHERE id_pedido = (SELECT id_pedido FROM pedidosRevision WHERE id_pedidoRevision = @idPedidoRevision)", connection);
                        command2.Parameters.AddWithValue("@idPedidoRevision", idPedidoRevision);
                        command2.ExecuteNonQuery();

                        SqlCommand command1 = new SqlCommand("DELETE FROM pedidosRevision WHERE id_pedidoRevision = @idPedidoRevision", connection);
                        command1.Parameters.AddWithValue("@idPedidoRevision", idPedidoRevision);
                        //int rowsAffected1 = command1.ExecuteNonQuery();
                        command1.ExecuteNonQuery();

                        MessageBox.Show("Pedido rechazado correctamente.");
                        actualizarPedidosPendientesRevision();

                        connection.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al rechazar el pedido: " + ex.Message);
                    }
                }
            }
        }
    }
}
