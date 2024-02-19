using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_SignUp : Form
    {
        public Form_SignUp()
        {
            InitializeComponent();
        }


        private void btn_registrarse_Click(object sender, EventArgs e)
        {
            if(tb1.Text.Length < 3 || tb2.Text.Length < 5 )
            {
                MessageBox.Show("Username or password no válido, muy corto");

            }
            else
            {
                // Creacion del directorio que contendrá el fichero con las claves cifradas
                string dir = tb1.Text;
                Directory.CreateDirectory("data\\" + dir);
                var sw = new StreamWriter("data\\" + dir + "\\data.ls");

                // Creamos las string de encriptado en nuestra clave aescrypt
                string encusr = AesCryp.Encrypt(tb1.Text);
                string encpss = AesCryp.Encrypt(tb2.Text);

                // Una vez llamadas a los metodos estatics para encriptar
                sw.WriteLine(encusr);
                sw.WriteLine(encpss);
                sw.Close();

                MessageBox.Show("Usuario creado correctamente");
                this.Close();
            }
        }
    }
}
