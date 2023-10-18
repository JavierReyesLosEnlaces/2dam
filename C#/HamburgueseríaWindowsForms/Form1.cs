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

        //BOTÓN DE TERMINAR
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += "=============================================" + Environment.NewLine;
            richTextBox1.Text += "TOTAL: " + factura + " $";
            factura = 0.0f;
            control = true;
            button1.Visible = false;
            panel1.Visible = false;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            richTextBox1.Text += "=============================================" + Environment.NewLine;
            richTextBox1.Text += "TOTAL: " + factura + " $";
            factura = 0.0f;
            control = true;
            button1.Visible = false;
            panel1.Visible = false;
        }

        //BOTÓN DE RESETEO
        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            factura = 0.0f;
            button1.Visible = true;
            panel1.Visible = true;
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            richTextBox1.Clear();
            factura = 0.0f;
            button1.Visible = true;
            panel1.Visible = true;
        }
    }
}