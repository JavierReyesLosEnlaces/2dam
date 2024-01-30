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

        private void btnEmpezar_MouseEnter(object sender, EventArgs e)
        {
            btnEmpezar.BackColor = Color.FromArgb(45, 123, 60);
        }

        private void btnEmpezar_MouseLeave(object sender, EventArgs e)
        {
            btnEmpezar.BackColor = Color.Black;
        }

        private void Form0_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra el Form0 se cierra la aplicación
            Application.Exit();
        }
    }
}
