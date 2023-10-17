namespace HamburgueseríaWindowsForms
{
    public partial class Form1 : Form
    {
        float factura = 0.0f;
        int contador = 1;
        bool control = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //HAMBURGUESA
        private void ConPanSinCar_Click(object sender, EventArgs e)
        {
            if (control)
            {
                richTextBox1.Clear();
                contador = 1;
                control = false;
            }
            Hamburguesa h = new Hamburguesa(true, false);
            richTextBox1.Text += contador + ". Hamburguesa con pan de centeno y sin carne de vacuno -> " + h.PrecioFinal + "$" + Environment.NewLine;
            factura += h.PrecioFinal;
            contador += 1;

        }

        private void SinPanConCar_Click(object sender, EventArgs e)
        {
            if (control)
            {
                richTextBox1.Clear();
                contador = 1;
                control = false;
            }
            Hamburguesa h = new Hamburguesa(false, true);
            richTextBox1.Text += contador + ". Hamburguesa sin pan de centeno y con carne de vacuno -> " + h.PrecioFinal + "$" + Environment.NewLine;
            factura += h.PrecioFinal;
            contador += 1;
        }

        private void SinPanSinCar_Click(object sender, EventArgs e)
        {
            if (control)
            {
                richTextBox1.Clear();
                contador = 1;
                control = false;
            }
            Hamburguesa h = new Hamburguesa(false, false);
            richTextBox1.Text += contador + ". Hamburguesa sin pan de centeno y sin carne de vacuno -> " + h.PrecioFinal + "$" + Environment.NewLine;
            factura += h.PrecioFinal;
            contador += 1;
        }

        private void ConPanConCar_Click(object sender, EventArgs e)
        {
            if (control)
            {
                richTextBox1.Clear();
                contador = 1;
                control = false;
            }
            Hamburguesa h = new Hamburguesa(true, true);
            richTextBox1.Text += contador + ". Hamburguesa con pan de centeno y con carne de vacuno -> " + h.PrecioFinal + "$" + Environment.NewLine;
            factura += h.PrecioFinal;
            contador += 1;
        }

        //BEBIDA
        private void conAl_Click(object sender, EventArgs e)
        {
            if (control)
            {
                richTextBox1.Clear();
                contador = 1;
                control = false;
            }
            Bebida b = new Bebida(true);
            richTextBox1.Text += contador + ". Bebida con alcohol -> " + b.Precio + "$" + Environment.NewLine;
            factura += b.Precio;
            contador += 1;
        }

        private void sinAl_Click(object sender, EventArgs e)
        {
            if (control)
            {
                richTextBox1.Clear();
                contador = 1;
                control = false;
            }
            Bebida b = new Bebida(false);
            richTextBox1.Text += contador + ". Bebida con alcohol -> " + b.Precio + "$" + Environment.NewLine;
            factura += b.Precio;
            contador += 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "=============================================" + Environment.NewLine;
            richTextBox1.Text += "TOTAL: " + factura + " $";
            control = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

    }
}