using System.Windows.Forms.VisualStyles;

namespace GuessNumber_Ex3
{
    public partial class Form1 : Form
    {
        //Declaración de componentes
        private string auxiliar = "";
        private int min = 0;
        private int max = 10;
        private int tries = 3;
        private int answer = 0;
        private bool isGameWon = false;
        private int randomNum;
        public Form1()
        {
            InitializeComponent();
            //Inicializar variables

            //ahora especificamos lo que aparece al iniciar al juego
            lbl_info.Text = "Introduce un número entre " + min + " y " + max;
            lbl_intentos.Text = "Intentos: " + tries;

            //Estableces el valor de numero a descubrir
            randomNum = rndom_Calc(min, max);
            lbl_debug.Text = Convert.ToString(randomNum);


        }

        //Declaración de funciones. Una función que inicialice el numero a descubrir.
        private int rndom_Calc(int min, int max)
        {
            var random = new Random();
            int nuevoRand = random.Next(min, max);
            return nuevoRand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_Boton.Text = "Pulsar";
            auxiliar = txt_bx_usuario.Text;
            txt_bx_usuario.PlaceholderText = "Intentalo de nuevo";

            try
            {
                answer = Convert.ToInt32(auxiliar);
            }
            catch (Exception ex)
            {
                status_strip.Text = "Texto erroneo. Excepcion";
            }

            if (tries > 0)
            {
                if (auxiliar != "")
                {
                    if (answer == randomNum)
                    {
                        lbl_info.Text = "¡" + auxiliar + " es correcto!";
                        isGameWon = true;
                        ResetGame();
                    }
                    else if (answer > randomNum)
                    {
                        lbl_info.Text = auxiliar + "es mayor, prueba más bajo...";
                        txt_bx_usuario.Clear();
                        tries--;
                        lbl_intentos.Text = "Intentos " + tries.ToString();

                        //la mofa
                        //lbl_rnd_mes.Text = animos [rndomCalc(0, animos.Count -3)];
                    }
                    else
                    {
                        lbl_info.Text = auxiliar + "es menor, prueba más alto...";
                        txt_bx_usuario.Clear();
                        tries--;
                        lbl_intentos.Text = "Intentos " + tries.ToString();

                        //la mofa
                        //lbl_rnd_mes.Text = animos [rndomCalc(0, animos.Count -3)];
                    }
                }
            }
            else
            {
                ResetGame();
            }
        }

        private void ResetGame()
        {
            btn_Boton.Text = "¿Nuevo juego?";
            txt_bx_usuario.Clear();

            randomNum = rndom_Calc(min, max);
            tries = 3;
            //lbl_info.Text = "";

            if (isGameWon)
            {
                lbl_info.Text = "Ganaste, adivina el numero entre " + max + " y " + min;
                isGameWon = false;
                lbl_intentos.Text = "Intentos: " + tries.ToString();
            }
            else
            {
                lbl_info.Text = "Ganaste, adivina el numero entre " + max + " y " + min;
                isGameWon = false;
                lbl_intentos.Text = "Intentos: " + tries.ToString();
            }
        }

        private void btn_newForm_Click(object sender, EventArgs e)
        {
            Form2 vista = new Form2();
            vista.Show(); 
        }
    }
}