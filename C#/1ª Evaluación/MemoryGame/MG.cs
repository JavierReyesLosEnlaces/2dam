namespace MemoryGame
{
    public partial class MG : Form
    {

        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!", "!", "b", "b", "k", "k", "r", "r",
            "c", "c", "d" , "d" , "e" , "e", "h", "h",
        };
        Label firstClicked, secondClicked;
        private int tempojuego = 0;

        public MG()
        {
            InitializeComponent();
            asignarIconos();
        }

        private void asignarIconos()
        {
            Label label;
            int rndomNumber;

            for (int i = 0; i < tbl_layout.Controls.Count; i++)
            {

                //Verificamos que los elementos del table layout 
                // que sean Label
                if (tbl_layout.Controls[i] is Label)
                {
                    label = (Label)tbl_layout.Controls[i];
                }
                else
                {
                    continue;
                }
                rndomNumber = random.Next(0, icons.Count);
                // en este momento se le asigna el valor de la posición de nuestra lista
                label.Text = icons[rndomNumber];

                //Vamos eliminando los elementos para no repetir
                icons.RemoveAt(rndomNumber);
            }
            timer2.Start();

        }



        private void lbl_Click(object sender, EventArgs e)
        {

            if (firstClicked != null && secondClicked != null) return;
            //para que clickes solo dos y no una tercera (solo puedes clickar dos)

            Label clickedLabel = sender as Label; //verifica si lo que hemos cogido es un label

            if (clickedLabel == null) return; //si clicked label == null , es decir, el click no es un label -> volder
            if (clickedLabel.ForeColor == Color.Chocolate) return;

            //if (clickedLaber.Visible == true) return;

            if (firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Chocolate;
                return;
            }

            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Chocolate;

            //comprobaremos sen este punto si has ganado
            checkForWinner();


            if (firstClicked.Text == secondClicked.Text)
            {

                firstClicked = null;
                secondClicked = null;

            }
            else
            {
                timer1.Start();
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        // tiempo en el que nuestras elecciones permanecen mostradas
        {
            timer1.Stop();

            //Pasado el tiempo devolvemos el color para ocultar y dejamos a null las label
            firstClicked.ForeColor = Color.LemonChiffon;
            secondClicked.ForeColor = Color.LemonChiffon;

            firstClicked = null; //para limpiar las variables de juego yy poder jugar de nuevo
            secondClicked = null;
        }

        private void checkForWinner()
        {
            Label label;
            for (int i = 0; i < tbl_layout.Controls.Count; i++)
            {
                label = tbl_layout.Controls[i] as Label;
                // Si en la iteracion encuentra una con el mismo
                // color de frente y de atrñas no has terminado
                if (label != null && label.ForeColor == label.BackColor) return;
                // != null que exista y la segunda parte comprueba el color
            }
            //extra
            timer2.Stop();
            MessageBox.Show("Has ganado! Has tardado " + tempojuego + " segundos!");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            tempojuego++;
            //tick es algo que utiliza el timer
            //por cada tick, intervalo de 1000ms -> 1 tick por segundo
        }

        private void juegoNuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Juego nuevo
        }
    }
}