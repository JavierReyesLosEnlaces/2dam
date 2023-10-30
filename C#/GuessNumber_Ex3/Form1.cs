using System.Windows.Forms.VisualStyles;

namespace GuessNumber_Ex3
{
    public partial class Form1 : Form
    {
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

            lbl_info.Text = "Introduce un número entre " + min + " y " + max;
            lbl_intentos.Text = "Intentos: " + tries;

            randomNum = rndom_Calc(min, max);
            lbl_debug.Text = Convert.ToString(randomNum);
        }

        private int rndom_Calc(int min, int max)
        {
            var random = new Random();
            int nuevoRand = random.Next(min, max);
            return nuevoRand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auxiliar = txt_bx_usuario.Text;
            //auxiliar es el texto que ha introducido el usuario
            txt_bx_usuario.PlaceholderText = "Intentalo de nuevo";

            try
            {
                answer = Convert.ToInt32(auxiliar);
                if (tries > 0)
                {
                    if (auxiliar != "")
                    {
                        if (answer == randomNum)
                        {
                            lbl_info.Text = "¡" + auxiliar + " es correcto!";
                            isGameWon = true;
                            lbl_rnd_mes.Text = animos[5];
                            ResetGame();
                        }
                        else if (answer > randomNum)
                        {
                            lbl_info.Text = auxiliar + " es mayor, prueba más bajo...";
                            txt_bx_usuario.Clear();
                            tries--;
                            lbl_intentos.Text = "Intentos " + tries.ToString();
                            lbl_rnd_mes.Text = animos[rndom_Calc(0, animos.Count - 2)];
                        }
                        else
                        {
                            lbl_info.Text = auxiliar + " es menor, prueba más alto...";
                            txt_bx_usuario.Clear();
                            tries--;
                            lbl_intentos.Text = "Intentos " + tries.ToString();
                            lbl_rnd_mes.Text = animos[rndom_Calc(0, animos.Count - 2)];
                        }
                    }
                }
                else
                {
                    ResetGame();
                }
            }
            catch (Exception ex)
            {
                status.Text = "Texto erroneo, excepcion";
                lbl_info.Text = "Texto erroneo, excepcion";
            }
        }

        private void ResetGame()
        {
            btn_Boton.Text = "¿Nuevo juego?";
            txt_bx_usuario.Clear();

            randomNum = rndom_Calc(min, max);
            lbl_debug.Text = randomNum.ToString();
            tries = 3;

            if (isGameWon)
            {
                lbl_info.Text = "Ganaste, adivina el numero entre " + max + " y " + min;
                isGameWon = false;
                lbl_intentos.Text = "Intentos: " + tries.ToString();
            }
            else
            {
                lbl_info.Text = "Perdiste, adivina el numero entre " + max + " y " + min;
                isGameWon = false;
                lbl_rnd_mes.Text = animos[6];
                lbl_intentos.Text = "Intentos: " + tries.ToString();
            }
        }

        private void btn_newForm_Click(object sender, EventArgs e)
        {
            Form2 vista = new Form2();
            vista.Show();
        }

        private List<String> animos = new List<String>
        {
            //0-4: animos
            "Animo",
            "Casi lo tienes",
            "Vamos",
            "Vamos, pringao",
            "Casi",

            //5: frase de exito
            "Has ganado",

            //6: frase de fallo
            "Has perdido"
        };
    }
}