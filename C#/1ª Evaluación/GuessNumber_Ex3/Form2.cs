using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessNumber_Ex3
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            /*
            // FORMA 1 DE LIDIAR CON IMÁGENES:
            // Carga la imagen directamente a PictureBox
            picBox_cartel.SizeMode = PictureBoxSizeMode.Zoom;

            // Bitmap es un objeto que se usa para cargar imágenes
            string ruta = "C:\\Users\\Alumno\\Pictures\\Saved Pictures\\b91eee52ea7c5005be05d58282617db8g.jpg";
            var MyImage = new Bitmap(ruta);

            picBox_cartel.Image = (Image)MyImage;
            */

            // FORMA 2 DE LIDIAR CON IMÁGENES:
            // Open file dialog
            // cuando lancemos la nueva Form, abra un recurso para encontrar la imagen
            picBox_cartel.SizeMode = PictureBoxSizeMode.StretchImage;
            OpenFileDialog ofd = new OpenFileDialog();  //OpenFileDialog es el objeto que abre el explorador

            if (ofd.ShowDialog() == DialogResult.OK) //DialogResult.OK verifica que has escogido una imagen

            {
                string ruta = ofd.FileName;
                var myImage = new Bitmap(ruta);
                picBox_cartel.Image = myImage;
            }
            else //si le das a Cancelar, por ejemplo
            {

            }
        }
    }
}
