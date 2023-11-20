using Firebase_Ex3.Model;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Firebase_Ex1
{
    public partial class Form1 : Form
    {
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
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //5. Lo comantamos para 9.
            var data = new Data
            {
                Id = textBox1.Text,
                Name = textBox2.Text,
                Address = textBox3.Text,
                Age = textBox4.Text
            };

            //Pasamos el nodo de los padres donde quieres insertarlo
            SetResponse response = await client.SetTaskAsync("Information/"+textBox1.Text, data);
                // await -> asíncrono -> lo envías pero no saber cuando lo recibes
                // lanza una petición de inserción de información y te devuelve un response
                // el response (por parte del servido de google) te da el ok
            
            Data result = response.ResultAs<Data>(); // exploramos la respuesta

            MessageBox.Show("Datos insertados con Id: "+result.Id);
        }
    }
}