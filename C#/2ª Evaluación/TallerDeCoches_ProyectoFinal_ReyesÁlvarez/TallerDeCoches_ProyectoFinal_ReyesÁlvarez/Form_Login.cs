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
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form_SignUp fs = new Form_SignUp();
            fs.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tb1.Text.Length < 3 || tb_contraseña.Text.Length < 5)
            {
                MessageBox.Show("Username or password no válido, muy corto");

            }
            else
            {
                // Creacion del directorio que contendrá el fichero con las claves cifradas
                string dir = tb1.Text;
                if(!Directory.Exists("data\\"+dir))
                {
                    MessageBox.Show("Usuario no registrado");
                }
                else
                {
                    var sr = new StreamReader("data\\"+dir+"\\data.ls");
                   
                    string encusr = sr.ReadLine();
                    string encpss = sr.ReadLine();
                    sr.Close();

                    string decusr = AesCryp.Decrypt(encusr);
                    string decpss = AesCryp.Decrypt(encpss);

                    if(decusr == tb1.Text && decpss == tb_contraseña.Text)
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
    }
}
