namespace Entrega2Eval_JavierReyes
{
    public partial class UserControl_QuitamosAlgo : UserControl
    {
        // DECLARACIÓN DE EVENTOS QUE SE ACTIVARÁN AL PRESIONAR LOS BOTONES
        public event EventHandler Button1Click;
        public event EventHandler Button3Click;
        public event EventHandler Button4Click;

        // VARIABLES DE ESTADO PARA LOS BOTONES
        public bool bstate1, bstate2, bstate3, bstate4, bstate5;

        public UserControl_QuitamosAlgo()
        {
            ResetState();
            InitializeComponent();
        }

        // PONE LOS ESTADOS DE LOS BOTONES A FALSO
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
            // CAMBIAR EL ESTADO DEL BOTÓN 1
            bstate1 = !bstate1;

            // SI SE SUSCRIBE ALGÚN MÉTODO AL EVENTO Button1Click, SE ACTIVA
            Button1Click?.Invoke(this, EventArgs.Empty);

            // CAMBIAR EL ESTADO DEL BOTÓN 2
            bstate2 = !bstate2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            // CAMBIAR EL ESTADO DEL BOTÓN 3
            bstate3 = !bstate3;

            // SI SE SUSCRIBE ALGÚN MÉTODO AL EVENTO Button3Click, SE ACTIVA
            Button3Click?.Invoke(this, EventArgs.Empty);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            // CAMBIAR EL ESTADO DEL BOTÓN 4
            bstate4 = !bstate4;

            // SI SE SUSCRIBE ALGÚN MÉTODO AL EVENTO Button4Click, SE ACTIVA
            Button4Click?.Invoke(this, EventArgs.Empty);

            // CAMBIAR EL ESTADO DEL BOTÓN 5
            bstate5 = !bstate5;
        }
    }
}