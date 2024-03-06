
using Microsoft.Data.SqlClient;
using System.Configuration;
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Login : Form
    {
        public static String decusr, encpss = "", encusr;
        public static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public static UsuarioLogueado usuarioLogueado;

        public Form_Login()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            tb_contraseña.UseSystemPasswordChar = true;
        }

        private void btn_crear_cuenta_Click(object sender, EventArgs e)
        {
            Form_SignupCliente fs = new Form_SignupCliente();
            fs.Show();
            Hide();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            // Check if username or password is too short
            if (tb_usuario.Text.Length < 3 || tb_contraseña.Text.Length < 5)
            {
                MessageBox.Show("Username or password is too short.");
            }
            else
            {
                string dir = tb_usuario.Text;

                // Check if user directory exists
                if (!Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                {
                    MessageBox.Show("User not registered.");
                }
                else
                {
                    // Check if user is a client
                    if (Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                    {
                        string filePath = "data\\clientes\\" + dir + "\\data.ls";

                        // Check if data file exists for the client
                        if (File.Exists(filePath))
                        {
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                string encusr = sr.ReadLine();
                                string encpss = sr.ReadLine();

                                string decusr = AesCryp.Decrypt(encusr);
                                string decpss = AesCryp.Decrypt(encpss);

                                // Check if entered username and password match decrypted values
                                if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                                {
                                    // Execute SQL query to fetch client ID
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
                                                MessageBox.Show("No se han encontrado datos del cliente. ");
                                            }
                                        }
                                    }

                                    // Show client form and hide current form
                                    Form_Cliente fc = new Form_Cliente();
                                    fc.Show();
                                    Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect client password.");
                                }
                            }
                        }
                    }
                    // Check if user is an employee
                    else if (!Directory.Exists("data\\clientes\\" + dir) && (Directory.Exists("data\\empleados\\" + dir)))
                    {
                        string filePath = "data\\empleados\\" + dir + "\\data.ls";
                        // Check if data file exists for the employee
                        if (File.Exists(filePath))
                        {
                            using (StreamReader sr = new StreamReader(filePath))
                            {
                                string encusr = sr.ReadLine();
                                string encpss = sr.ReadLine();

                                string decusr = AesCryp.Decrypt(encusr);
                                string decpss = AesCryp.Decrypt(encpss);

                                // Check if entered username and password match decrypted values
                                if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                                {
                                    // Show employee form and hide current form
                                    Form_Empleado fe = new Form_Empleado();
                                    fe.Show();
                                    Hide();
                                }
                                else
                                {
                                    MessageBox.Show("Incorrect employee password.");
                                }
                            }
                        }
                    }
                }
            }
        }


        public string getEncusr()
        {
            return encusr;
        }

        public string getEncpss()
        {
            return encpss;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox_contraseña_CheckedChanged(object sender, EventArgs e)
        {
            tb_contraseña.UseSystemPasswordChar = !tb_contraseña.UseSystemPasswordChar;
        }

    }
}
