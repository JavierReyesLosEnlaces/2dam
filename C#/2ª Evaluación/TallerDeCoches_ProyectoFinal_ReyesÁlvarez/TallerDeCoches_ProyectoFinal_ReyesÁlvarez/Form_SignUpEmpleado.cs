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
    public partial class Form_SignUpEmpleado : Form
    {
        public Form_SignUpEmpleado()
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
                    MessageBox.Show("Usuario no registrado, creando directorio");
                    // Creación del directorio
                    Directory.CreateDirectory("data\\" + dir);
                    string encusr = AesCryp.Encrypt(tb_usuario.Text);
                    string encpss = AesCryp.Encrypt(tb_contraseña.Text);
                    var streamwriter = new StreamWriter("data\\" + dir +"\\data.ls");
                    streamwriter.WriteLine(encusr);
                    streamwriter.WriteLine(encpss);
                    streamwriter.Close();
                    MessageBox.Show("El usuario se ha registrado correctamente");

                }
                else
                {
                    MessageBox.Show("El usuario ya existe. ");
                }

            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
