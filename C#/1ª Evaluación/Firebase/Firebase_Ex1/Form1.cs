using Firebase_Ex3;
using Firebase_Ex3.Model;
using Firebase_Ex3.Service;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using System.Data;

namespace Firebase_Ex1
{

    public partial class Form1 : Form

    {
        DataTable dt = new DataTable();
        Form2 newWin = new Form2();


        //2. auth y config
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "UoZGTsXfoAQ9BqZolxQy0ZnHZujgdrML7othEZn7",
            BasePath = "https://fir-ex1-7c595-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        //3. lo cambio a static
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //4.
            client = new FireSharp.FirebaseClient(config);
            if (client != null)
            {
                MessageBox.Show("Conexión establecida");
            }
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Dirección");
            dt.Columns.Add("Edad");

            dataGridView1.DataSource = dt;


        }

        private async void button1_Click(object sender, EventArgs e)
        {
            /*
            //5. Lo comantamos para 9.
            var data = new Data
            {
                Id = textBox1.Text,
                Name = textBox2.Text,
                Address = textBox3.Text,
                Age = textBox4.Text
            };

            //Pasamos el nodo de los padres donde quieres insertarlo
            SetResponse response = await client.SetTaskAsync("Information/" + textBox1.Text, data);
            // await -> asíncrono -> lo envías pero no saber cuando lo recibes
            // lanza una petición de inserción de información y te devuelve un response
            // el response (por parte del servido de google) te da el ok

            Data result = response.ResultAs<Data>(); // exploramos la respuesta

            MessageBox.Show("Datos insertados con Id: " + result.Id);
            */
            FirebaseResponse resp = await client.GetTaskAsync("Contador/node");
            Counter_class get = resp.ResultAs<Counter_class>();
            MessageBox.Show("El numero de elementos actual es " + get.Cnt);

            //Preparamos el dato a insertar en la DB
            var data = new Data
            {
                Id = ((Convert.ToInt32(get.Cnt)) + 1).ToString(), //el id + 1+
                Name = textBox2.Text,
                Address = textBox3.Text,
                Age = textBox4.Text
            };

            SetResponse response = await client.SetTaskAsync("Information/" + data.Id, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Datos insertados con Id: " + data.Id);

            var obj = new Counter_class
            {
                Cnt = data.Id
            };

            SetResponse response1 = await client.SetTaskAsync("Contador/node", obj);

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.GetTaskAsync("Information/" + textBox1.Text);

            Data obj = response.ResultAs<Data>();
            //Show the values of the retrieved information
            textBox1.Text = obj.Id;
            textBox2.Text = obj.Name;
            textBox3.Text = obj.Address;
            textBox4.Text = obj.Age;
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            var data = new Data
            {
                Id = textBox1.Text,
                Name = textBox2.Text,
                Address = textBox3.Text,
                Age = textBox4.Text
            };
            FirebaseResponse response = await client.UpdateTaskAsync("Information//" + textBox1.Text, data);
            Data result = response.ResultAs<Data>();

            MessageBox.Show("Datos actualizados con id " + result.Id);

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            FirebaseResponse response = await client.DeleteTaskAsync("Information/" + textBox1.Text);
            MessageBox.Show("Información eliminada con éxito con Id " + textBox1.Text);
        }

        private async void bringData() //podemos linkarlo con el botón de añ
        {
            //limpiamos el dt
            dt.Rows.Clear();
            //preguntamos a la base de datos
            FirebaseResponse resp1 = await client.GetTaskAsync("Contador/node");
            Counter_class obj1 = resp1.ResultAs<Counter_class>();

            int cont = Convert.ToInt32(obj1.Cnt);
            int i = 0;
            while (true)
            {
                if (i == cont)
                {
                    break;
                }
                i++;
                try
                {
                    FirebaseResponse resp2 = await client.GetTaskAsync("Information/" + i);
                    Data obj2 = resp2.ResultAs<Data>();

                    DataRow row = dt.NewRow();
                    row["Id"] = obj2.Id;
                    row["Nombre"] = obj2.Name;
                    row["Dirección"] = obj2.Address;
                    row["Edad"] = obj2.Age;

                    dt.Rows.Add(row);
                }
                catch
                {
                    MessageBox.Show("Algo ha fallado.");
                }
            }
            MessageBox.Show("Información transferida con éxito");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bringData();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            newWin.Show();
        }
    }
}