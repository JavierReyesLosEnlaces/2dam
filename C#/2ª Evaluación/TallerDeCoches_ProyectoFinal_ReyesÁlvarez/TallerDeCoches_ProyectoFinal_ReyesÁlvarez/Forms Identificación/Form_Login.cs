using Microsoft.Data.SqlClient;
using System.Configuration;
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Login : Form
    {
        // Variables para almacenar datos de usuario
        public static String decusr, encpss = "", encusr;
        // Cadena de conexión a la base de datos
        public static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        // Objeto para almacenar información de usuario logueado
        public static UsuarioLogueado usuarioLogueado = null;

        public Form_Login()
        {
            InitializeComponent();
            InitUI();
        }

        // Inicialización de la interfaz de usuario
        private void InitUI()
        {
            tb_contraseña.UseSystemPasswordChar = true;
        }

        // Evento de clic en el botón "Crear cuenta"
        private void btn_crear_cuenta_Click(object sender, EventArgs e)
        {
            Form_SignupCliente fs = new Form_SignupCliente();
            fs.Show();
            Hide();
        }

        // Evento de clic en el botón "Entrar"
        private void btn_entrar_Click(object sender, EventArgs e)
        {
            // Comprobar si el nombre de usuario o la contraseña son demasiado cortos
            if (tb_usuario.Text.Length < 3 || tb_contraseña.Text.Length < 5)
            {
                MessageBox.Show("El nombre de usuario o la contraseña son demasiado cortos.");
            }
            else
            {
                string dir = tb_usuario.Text;

                // Comprobar si existe el directorio de usuario
                if (!Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                {
                    MessageBox.Show("Usuario no registrado.");
                }
                else
                {
                    // Comprobar si el usuario es un cliente
                    if (Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                    {
                        string filePath = "data\\clientes\\" + dir + "\\data.ls";

                        // Comprobar si existe el archivo de datos para el cliente
                        if (File.Exists(filePath))
                        {
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                string encusr = sr.ReadLine();
                                string encpss = sr.ReadLine();

                                string decusr = AesCryp.Decrypt(encusr);
                                string decpss = AesCryp.Decrypt(encpss);

                                // Comprobar si el nombre de usuario y la contraseña coinciden con los valores desencriptados
                                if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                                {
                                    // Ejecutar consulta SQL para obtener el ID del cliente
                                    string query = @"SELECT c.id_cliente AS 'Id del cliente'
                                        FROM clientes c 
                                        INNER JOIN usuarios u ON c.id_usuario = u.id_usuario
                                        WHERE u.contraseña_usuario = '" + encpss + "'";

                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand(query, connection))
                                        {
                                            SqlDataReader reader = command.ExecuteReader();
                                            if (reader.Read())
                                            {
                                                string idCliente = reader["Id del cliente"].ToString();
                                                usuarioLogueado = new UsuarioLogueado(int.Parse(idCliente));
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se han encontrado datos del cliente.");
                                            }
                                        }
                                    }

                                    // Mostrar formulario de cliente y ocultar el formulario actual
                                    Form_Cliente fc = new Form_Cliente();
                                    fc.Show();
                                    Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña de cliente incorrecta.");
                                }
                            }
                        }
                    }
                    // Comprobar si el usuario es un empleado
                    else if (!Directory.Exists("data\\clientes\\" + dir) && (Directory.Exists("data\\empleados\\" + dir)))
                    {
                        string filePath = "data\\empleados\\" + dir + "\\data.ls";
                        // Comprobar si existe el archivo de datos para el empleado
                        if (File.Exists(filePath))
                        {
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                string encusr = sr.ReadLine();
                                string encpss = sr.ReadLine();

                                string decusr = AesCryp.Decrypt(encusr);
                                string decpss = AesCryp.Decrypt(encpss);

                                // Comprobar si el nombre de usuario y la contraseña coinciden con los valores desencriptados
                                if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                                {
                                    // Ejecutar consulta SQL para obtener el ID del empleado
                                    string query = @"SELECT e.id_empleado AS 'Id del empleado'
                                        FROM empleados e 
                                        INNER JOIN usuarios u ON e.id_usuario = u.id_usuario
                                        WHERE u.contraseña_usuario = '" + encpss + "'";

                                    using (SqlConnection connection = new SqlConnection(connectionString))
                                    {
                                        connection.Open();
                                        using (SqlCommand command = new SqlCommand(query, connection))
                                        {
                                            SqlDataReader reader = command.ExecuteReader();
                                            if (reader.Read())
                                            {
                                                string idEmpleado = reader["Id del empleado"].ToString();
                                                usuarioLogueado = new UsuarioLogueado(int.Parse(idEmpleado));
                                            }
                                            else
                                            {
                                                MessageBox.Show("No se han encontrado datos del empleado.");
                                            }
                                        }
                                    }

                                    // Mostrar formulario de empleado y ocultar el formulario actual
                                    Form_Empleado fe = new Form_Empleado();
                                    fe.Show();
                                    Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Contraseña de empleado incorrecta.");
                                }
                            }
                        }
                    }
                }
            }
        }


        // Evento de cambio en el estado del checkbox para mostrar/ocultar contraseña
        private void checkBox_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            tb_contraseña.UseSystemPasswordChar = !tb_contraseña.UseSystemPasswordChar;
        }

        // Evento de clic en el botón "Salir"
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
