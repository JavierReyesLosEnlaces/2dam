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
            btn_Boton.Text = "PULSAR";

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
            auxiliar = txt_bx_usuario.Text; //auxiliar es el texto que ha introducido el usuario

            try
            {
                answer = Convert.ToInt32(auxiliar);
                btn_Boton.Text = "PULSAR";
                if (tries > 1)
                {
                    if (auxiliar != "")
                    {
                        if (answer == randomNum)
                        {
                            //lbl_info.Text = "¡" + auxiliar + " es correcto!";
                            isGameWon = true;
                            lbl_rnd_mes.Text = mensajesParaUsuario[8];
                            ResetGame();
                        }
                        else if (answer > randomNum)
                        {
                            txt_bx_usuario.PlaceholderText = "Intentalo de nuevo";
                            lbl_info.Text = auxiliar + " es mayor, prueba más bajo...";
                            txt_bx_usuario.Clear();
                            tries--;
                            lbl_intentos.Text = "Intentos " + tries.ToString();
                            lbl_rnd_mes.Text = mensajesParaUsuario[rndom_Calc(0, mensajesParaUsuario.Count - 2)];
                        }
                        else
                        {
                            txt_bx_usuario.PlaceholderText = "Intentalo de nuevo";
                            lbl_info.Text = auxiliar + " es menor, prueba más alto...";
                            txt_bx_usuario.Clear();
                            tries--;
                            lbl_intentos.Text = "Intentos " + tries.ToString();
                            lbl_rnd_mes.Text = mensajesParaUsuario[rndom_Calc(0, mensajesParaUsuario.Count - 2)];
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
                lbl_info.Text = "Texto erroneo, excepcion";
            }
        }

        private void ResetGame()
        {
            btn_Boton.Text = "¿Nuevo intento?";
            txt_bx_usuario.Clear();

            randomNum = rndom_Calc(min, max);
            lbl_debug.Text = randomNum.ToString();
            tries = 3;

            if (isGameWon)
            {
                lbl_info.Text = "Ganaste, ¿volver a jugar?";
                isGameWon = false;
                lbl_intentos.Text = "Intentos: " + tries.ToString();
            }
            else
            {
                lbl_info.Text = "Perdiste, ¿volver a jugar?";
                isGameWon = false;
                lbl_rnd_mes.Text = mensajesParaUsuario[9];
                lbl_intentos.Text = "Intentos: " + tries.ToString();
            }
        }

        private void btn_newForm_Click(object sender, EventArgs e)
        {
            Form2 vista = new Form2();
            vista.Show();
        }

        private List<String> mensajesParaUsuario = new List<String>
        {
            //0-7: mensajesParaUsuario
            "Animo",
            "Casi lo tienes",
            "Vamos",
            "Vuelve a intentarlo",
            "Tu puedes",
            "Dale, que casi lo tienes",
            "Estás cerca",
            "Casi",

            //8: frase de exito
            "Has ganado",

            //9: frase de fallo
            "Has perdido"
        };
    }
}