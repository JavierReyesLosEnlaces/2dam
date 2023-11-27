using Firebase_Ex3.Model;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Firebase_Ex3
{
    public partial class Form2 : Form
    {

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "UoZGTsXfoAQ9BqZolxQy0ZnHZujgdrML7othEZn7",
            BasePath = "https://fir-ex1-7c595-default-rtdb.europe-west1.firebasedatabase.app/"
        };
        //3. lo cambio a static
        IFirebaseClient client;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load_1(object sender, EventArgs e)
        {
            //4.
            client = new FireSharp.FirebaseClient(config);
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Selecciona imagen";
            ofd.Filter = "(*.png)|*.png|(*.jpg)|*.jpg|(*.jpeg)|*.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Image img = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                //pbox.Image = img.GetGumbnailImage(514,310,null,new IntPtr());
                pictureBox1.Image = img;
            }
        }

        private async void button2_ClickAsync(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, ImageFormat.Png);


            byte[] arr = ms.GetBuffer();
            string output = Convert.ToBase64String(arr);
            var data = new Image_model
            {
                Img = output
            };

            SetResponse response = await client.SetTaskAsync("Image/", data);

            Image_model result = response.ResultAs<Image_model>();

            MessageBox.Show("Imagen insertada con éxito. ");

            pictureBox1.Image = null;

        }


    }

}
