
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Login : Form
    {
        public static String decusr;
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
            if (tb_usuario.Text.Length < 3 || tb_contraseña.Text.Length < 5)
            {
                MessageBox.Show("Username or password no válido, muy corto");
            }
            else
            {
                string dir = tb_usuario.Text;

                if (!Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                {
                    MessageBox.Show("Usuario no registrado");
                }
                else if (Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                {
                    string filePath = "data\\clientes\\" + dir + "\\data.ls";
                    if (File.Exists(filePath))
                    {
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            string encusr = sr.ReadLine();
                            string encpss = sr.ReadLine();

                            string decusr = AesCryp.Decrypt(encusr);
                            string decpss = AesCryp.Decrypt(encpss);

                            if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                            {
                                MessageBox.Show("Bienvenido, cliente");
                                Form_Cliente fc = new Form_Cliente();
                                fc.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error en el password de cliente");
                            }
                            // aquí se manda el nombre al Form_Empleado
                            getNombreUsuario();
                        }


                    }
                }
                else if (!Directory.Exists("data\\clientes\\" + dir) && (Directory.Exists("data\\empleados\\" + dir)))
                {
                    string filePath = "data\\empleados\\" + dir + "\\data.ls";
                    if (File.Exists(filePath))
                    {
                        using (StreamReader sr = new StreamReader(filePath))
                        {
                            string encusr = sr.ReadLine();
                            string encpss = sr.ReadLine();

                            decusr = AesCryp.Decrypt(encusr);
                            string decpss = AesCryp.Decrypt(encpss);

                            if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                            {
                                MessageBox.Show("Bienvenido, empleado");
                                Form_Empleado fe = new Form_Empleado();
                                fe.Show();
                                Hide();
                            }
                            else
                            {
                                MessageBox.Show("Error en el password de empleado");
                            }
                        }
                    }
                }


            }
        }

        public string getNombreUsuario()
        {
            return decusr;
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
