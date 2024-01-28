
namespace Entrega2Eval_JavierReyes
{
    public partial class UserControl3 : UserControl
    {
        // Estados de los botones
        public bool bstateCaja, bstateTarjeta;

        public UserControl3()
        {
            ResetState();
            InitializeComponent();
        }

        private void ResetState()
        {
            bstateCaja = false;
            bstateTarjeta = false;
        }

        public void btn_caja_Click_1(object sender, EventArgs e)
        {
            // Cambiar el estado del botón
            bstateCaja = !bstateCaja;

            // Cambiar el color de fondo de los botones
            btn_caja.BackColor = Color.FromArgb(29, 171, 71);
            btn_tarjeta.BackColor = Color.FromArgb(255, 152, 83);
        }

        public void btn_tarjeta_Click_1(object sender, EventArgs e)
        {
            bstateTarjeta = !bstateTarjeta;

            // Cambiar el color de fondo de los botones
            btn_caja.BackColor = Color.FromArgb(255, 152, 83);
            btn_tarjeta.BackColor = Color.FromArgb(29, 171, 71);
        }
    }
}
