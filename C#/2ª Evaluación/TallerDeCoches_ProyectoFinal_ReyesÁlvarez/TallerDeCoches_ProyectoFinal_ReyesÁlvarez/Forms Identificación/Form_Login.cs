using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void btn_crear_cuenta_Click(object sender, EventArgs e)
        {
            Form_SignupCliente fs = new Form_SignupCliente();
            fs.Show();
            this.Hide();
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
                // no existe ninguno
                if (!Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                {
                    MessageBox.Show("Usuario no registrado");
                }
                // existe solo cliente
                else if (Directory.Exists("data\\clientes\\" + dir) && (!Directory.Exists("data\\empleados\\" + dir)))
                {
                    var sr = new StreamReader("data\\clientes\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();

                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                    {
                        MessageBox.Show("Bienvenido, cliente");
                    }
                    else
                    {
                        MessageBox.Show("Error en el password de cliente");
                    }

                    // Abrir la interfaz de cliente
                    Form_Cliente fc = new Form_Cliente();
                    fc.Show();
                    this.Hide();

                }
                // existe solo empleado
                else if (!Directory.Exists("data\\clientes\\" + dir) && (Directory.Exists("data\\empleados\\" + dir)))
                {
                    var sr = new StreamReader("data\\empleados\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();

                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                    {
                        MessageBox.Show("Bienvenido, empleado");
                    }
                    else
                    {
                        MessageBox.Show("Error en el password de empleado");
                    }

                    // Abrir la interfaz de empleados
                    Form_Empleado fe = new Form_Empleado();
                    fe.Show();
                    this.Hide();
                }

            }
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
