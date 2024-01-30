namespace Entrega2Eval_JavierReyes
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            // Tamaño del Form fijo
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Quitar botones de maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            // Abrir Form1
            Form1 f1 = new Form1();
            f1.Show();

            // Cerrar Form0
            this.Hide();
        }
    }
}
