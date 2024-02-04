
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
            // Cambiar el estado del botón 1
            bstate1 = !bstate1;

            // Si se suscribe algún método al evento Button1Click, activarlo
           // Button1Click?.Invoke(this, EventArgs.Empty);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Cambiar el estado del botón 2
            bstate2 = !bstate2;

            // Si se suscribe algún método al evento Button2Click, activarlo
           // Button2Click?.Invoke(this, EventArgs.Empty);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Cambiar el estado del botón 3
            bstate3 = !bstate3;

            // Si se suscribe algún método al evento Button3Click, activarlo
           // Button3Click?.Invoke(this, EventArgs.Empty);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Cambiar el estado del botón 4
            bstate4 = !bstate4;

            // Si se suscribe algún método al evento Button4Click, activarlo
            //Button4Click?.Invoke(this, EventArgs.Empty);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Cambiar el estado del botón 5
            bstate5 = !bstate5;

            // Si se suscribe algún método al evento Button5Click, activarlo
           // Button5Click?.Invoke(this, EventArgs.Empty);
        }

    }
}
