namespace Entrega2Eval_JavierReyes
{
    public partial class userControl3 : UserControl
    {
        // VARIABLES DE ESTADO PARA LOS BOTONES
        public bool bstateCaja { get; set; }
        public bool bstateTarjeta { get; set; }

        public userControl3()
        {
            ResetState();
            InitializeComponent();
        }

        // PONE LOS ESTADOS DE LOS BOTONES A FALSO
        private void ResetState()
        {
            bstateCaja = true;
            bstateTarjeta = false;
        }
        public void btn_caja_Click_1(object sender, EventArgs e)
        {
            // CAMBIAR EL ESTADO DEL BOTÓN DE "PAGAR EN CAJA"
            bstateCaja = true;
            bstateTarjeta = false;

            // DEPENDIENDO DEL ESTADO DEL BOTÓN, CAMBIA SU COLOR
            if (bstateCaja)
            {
                btn_caja.BackColor = Color.FromArgb(29, 171, 71);
                btn_tarjeta.BackColor = Color.FromArgb(255, 152, 83);
            }
            else
            {
                btn_caja.BackColor = Color.FromArgb(255, 152, 83);
                btn_tarjeta.BackColor = Color.FromArgb(29, 171, 71);
            }

        }
        public void btn_tarjeta_Click_1(object sender, EventArgs e)
        {
            // CAMBIAR EL ESTADO DEL BOTÓN DE "PAGAR CON TARJETA"
            bstateCaja = false;
            bstateTarjeta = true;

            // DEPENDIENDO DEL ESTADO DEL BOTÓN, CAMBIA SU COLOR
            if (bstateTarjeta)
            {
                btn_tarjeta.BackColor = Color.FromArgb(29, 171, 71);
                btn_caja.BackColor = Color.FromArgb(255, 152, 83);
            }
            else
            {
                btn_tarjeta.BackColor = Color.FromArgb(255, 152, 83);
                btn_caja.BackColor = Color.FromArgb(29, 171, 71);
            }
        }
    }
}