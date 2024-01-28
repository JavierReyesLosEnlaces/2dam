
namespace Entrega2Eval_JavierReyes
{
    public partial class UserControl2 : UserControl
    {
        // Declaración de un evento que se activará cuando se presione el botón 1
        public event EventHandler Button1Click;
        public event EventHandler Button2Click;
        public event EventHandler Button3Click;
        public event EventHandler Button4Click;
        public event EventHandler Button5Click;

        public bool bstate1, bstate2, bstate3, bstate4, bstate5;
        public UserControl2()
        {
            ResetState();
            InitializeComponent();
        }

        private void ResetState()
        {
            bstate1 = false;
            bstate2 = false;
            bstate3 = false;
            bstate4 = false;
            bstate5 = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            if (bstate1)
            {
                b1.BackColor = Color.Black;
                bstate1 = false;
            }
            else
            {
                b1.BackColor = Color.FromArgb(172, 0, 0);
                bstate1 = true;
            }
            */
            // Cambiar el estado del botón 1
            bstate1 = !bstate1;

            // Cambiar el color del botón 1
            //b1.BackColor = bstate1 ? Color.FromArgb(172, 0, 0) : Color.Black;

            // Si se suscribe algún método al evento Button1Click, activarlo
            Button1Click?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*
            if (bstate2)
            {
                b2.BackColor = Color.Black;
                bstate2 = false;
            }
            else
            {
                b2.BackColor = Color.FromArgb(172, 0, 0);
                bstate2 = true;
            }
            */
            // Cambiar el estado del botón 2
            bstate2 = !bstate2;

            // Cambiar el color del botón 2
            //b2.BackColor = bstate2 ? Color.FromArgb(172, 0, 0) : Color.Black;

            // Si se suscribe algún método al evento Button2Click, activarlo
            Button2Click?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
            if (bstate3)
            {
                b3.BackColor = Color.Black;
                bstate3 = false;
            }
            else
            {
                b3.BackColor = Color.FromArgb(172, 0, 0);
                bstate3 = true;
            }
            */
            // Cambiar el estado del botón 3
            bstate3 = !bstate3;

            // Cambiar el color del botón 3
            //b3.BackColor = bstate3 ? Color.FromArgb(172, 0, 0) : Color.Black;

            // Si se suscribe algún método al evento Button3Click, activarlo
            Button3Click?.Invoke(this, EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            if (bstate4)
            {
                b4.BackColor = Color.Black;
                bstate4 = false;
            }
            else
            {
                b4.BackColor = Color.FromArgb(172, 0, 0);
                bstate4 = true;
            }
            */
            // Cambiar el estado del botón 4
            bstate4 = !bstate4;

            // Cambiar el color del botón 4
            //b4.BackColor = bstate4 ? Color.FromArgb(172, 0, 0) : Color.Black;

            // Si se suscribe algún método al evento Button4Click, activarlo
            Button4Click?.Invoke(this, EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            /*
            if (bstate5)
            {
                b5.BackColor = Color.Black;
                bstate5 = false;
            }
            else
            {
                b5.BackColor = Color.FromArgb(172, 0, 0);
                bstate5 = true;
            }
            */
            // Cambiar el estado del botón 5
            bstate5 = !bstate5;

            // Cambiar el color del botón 5
            //b5.BackColor = bstate5 ? Color.FromArgb(172, 0, 0) : Color.Black;

            // Si se suscribe algún método al evento Button5Click, activarlo
            Button5Click?.Invoke(this, EventArgs.Empty);
        }

    }
}
