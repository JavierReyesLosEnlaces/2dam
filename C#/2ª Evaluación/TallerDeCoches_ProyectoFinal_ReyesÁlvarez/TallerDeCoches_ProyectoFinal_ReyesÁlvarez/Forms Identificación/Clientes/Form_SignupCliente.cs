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

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_SignupCliente : Form
    {
        public Form_SignupCliente()
        {
            InitializeComponent();
        }

        private void btn_irLogin_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            fl.Show();
            this.Hide();
        }

        private void btn_crearCuenta_Click(object sender, EventArgs e)
        {
            if (tb_usuario.Text.Length < 3 || tb_contraseña.Text.Length < 5)
            {
                MessageBox.Show("Username or password no válido, muy corto");

            }
            else
            {
                // Creacion del directorio que contendrá el fichero con las claves cifradas
                string dir = tb_usuario.Text;
                if (!Directory.Exists("data\\" + dir))
                {
                    MessageBox.Show("Usuario no registrado");
                }
                else
                {
                    var sr = new StreamReader("data\\" + dir + "\\data.ls");

                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if (decusr == tb_usuario.Text && decpss == tb_contraseña.Text)
                    {
                        MessageBox.Show("Bienevenido");
                    }
                    else
                    {
                        MessageBox.Show("Error en el password");
                    }
                }

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
