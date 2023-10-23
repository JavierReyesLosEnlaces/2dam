namespace GuessNumber_Ex3
{
    public partial class NuevoJuegoDeAdivinar : Form
    {
        //Declaración de componentes
        private string auxiliar = "";
        private int min = 0;
        private int max = 10;
        private int tries = 3;
        private int answer = 0;
        private bool isGameWon = false;
        private int randomNum;
        public NuevoJuegoDeAdivinar()
        {
            InitializeComponent();
            //ahora especificamos lo que aparece al iniciar al juego
            lbl_info.Text = "Introduce un número entre " + min + " y " + max;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}