
namespace Entrega2Eval_JavierReyes
{
    public partial class userControl3 : UserControl
    {
        // Estados de los botones
        public bool bstateCaja { get; set; }
        public bool bstateTarjeta { get; set; }

        public userControl3()
        {
            ResetState();
            InitializeComponent();
        }


        private void ResetState()
        {
            bstateCaja = true;
            bstateTarjeta = false;

        }


        public void btn_caja_Click_1(object sender, EventArgs e)
        {
            // Cambiar el estado del botón
            bstateCaja = true;
            bstateTarjeta = false;

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
            // Cambiar el estado del botón
            bstateCaja = false;
            bstateTarjeta = true;

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
