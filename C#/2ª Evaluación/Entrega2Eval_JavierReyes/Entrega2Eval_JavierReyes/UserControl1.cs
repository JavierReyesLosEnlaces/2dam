
namespace Entrega2Eval_JavierReyes
{
    public partial class UserControl1 : UserControl
    {
        public bool bstate1, bstate2, bstate3, bstate4, bstate5, bstate6;
        // Variables temporales
        public int numeroExtras;

        public UserControl1()
        {
            InitializeComponent();
            ResetState();
        }

        public void ResetState()
        {
            numeroExtras = 0;
            bstate1 = false;
            bstate2 = false;
            bstate3 = false;
            bstate4 = false; 
            bstate5 = false;
            bstate6 = false;
            

            labelExtras1.BackColor = Color.Black;
            precioExtras1.BackColor = Color.Black;
            panelColor1.BackColor = Color.FromArgb(255, 152, 83);

            labelExtras2.BackColor = Color.Black;
            precioExtras2.BackColor = Color.Black;
            panelColor2.BackColor = Color.FromArgb(255, 152, 83);

            labelExtras3.BackColor = Color.Black;
            precioExtras3.BackColor = Color.Black;
            panelColor3.BackColor = Color.FromArgb(255, 152, 83);

            labelExtras4.BackColor = Color.Black;
            precioExtras4.BackColor = Color.Black;
            panelColor4.BackColor = Color.FromArgb(255, 152, 83);

            labelExtras5.BackColor = Color.Black;
            precioExtras5.BackColor = Color.Black;
            panelColor5.BackColor = Color.FromArgb(255, 152, 83);

            labelExtras6.BackColor = Color.Black;
            precioExtras6.BackColor = Color.Black;
            panelColor6.BackColor = Color.FromArgb(255, 152, 83);
        }

        // BOTONES 
        private void buttonExtras1_Click_1(object sender, EventArgs e)
        {
            if (bstate1 == false)
            {
                labelExtras1.BackColor = Color.FromArgb(22, 134, 55);
                precioExtras1.BackColor = Color.FromArgb(22, 134, 55);
                panelColor1.BackColor = Color.FromArgb(22, 171, 71);
                 
                numeroExtras++;
                bstate1 = true;
            }
            else
            {
                labelExtras1.BackColor = Color.Black;
                precioExtras1.BackColor = Color.Black;
                panelColor1.BackColor = Color.FromArgb(255, 152, 83); 
                numeroExtras--;
                bstate1 = false;
            }
        }
        private void buttonExtras2_Click_1(object sender, EventArgs e)
        {
            if(bstate2 == false)
            {
                labelExtras2.BackColor = Color.FromArgb(22, 134, 55);
                precioExtras2.BackColor = Color.FromArgb(22, 134, 55);
                panelColor2.BackColor = Color.FromArgb(22, 171, 71);
                numeroExtras++;
                bstate2 = true;
            }
            else
            {
                labelExtras2.BackColor = Color.Black;
                precioExtras2.BackColor = Color.Black;
                panelColor2.BackColor = Color.FromArgb(255, 152, 83);
                numeroExtras--;
                bstate2 = false;
            }
        }
        private void buttonExtras3_Click(object sender, EventArgs e)
        {
            if(bstate3 == false)
            {
                labelExtras3.BackColor = Color.FromArgb(22, 134, 55);
                precioExtras3.BackColor = Color.FromArgb(22, 134, 55);
                panelColor3.BackColor = Color.FromArgb(22, 171, 71);
                numeroExtras++;
                bstate3 = true;
            }
            else
            {
                labelExtras3.BackColor = Color.Black;
                precioExtras3.BackColor = Color.Black;
                panelColor3.BackColor = Color.FromArgb(255, 152, 83);
                numeroExtras--;
                bstate3 = false;
            }
        }
        private void buttonExtras4_Click(object sender, EventArgs e)
        {
            if(bstate4 == false)
            {
                labelExtras4.BackColor = Color.FromArgb(22, 134, 55);
                precioExtras4.BackColor = Color.FromArgb(22, 134, 55);
                panelColor4.BackColor = Color.FromArgb(22, 171, 71);
                numeroExtras++;
                bstate4 = true;
            }
            else
            {
                labelExtras4.BackColor = Color.Black;
                precioExtras4.BackColor = Color.Black;
                panelColor4.BackColor = Color.FromArgb(255, 152, 83);
                numeroExtras--;
                bstate4 = false;
            }
        }
        private void buttonExtras5_Click(object sender, EventArgs e)
        {
            if(bstate5 == false)
            {
                labelExtras5.BackColor = Color.FromArgb(22, 134, 55);
                precioExtras5.BackColor = Color.FromArgb(22, 134, 55);
                panelColor5.BackColor = Color.FromArgb(22, 171, 71);
                numeroExtras++;
                bstate5 = true;
            }
            else
            {
                labelExtras5.BackColor = Color.Black;
                precioExtras5.BackColor = Color.Black;
                panelColor5.BackColor = Color.FromArgb(255, 152, 83);
                numeroExtras--;
                bstate5 = false;
            }
        }
        private void buttonExtra6_Click(object sender, EventArgs e)
        {
            if (bstate6 == false)
            {
                labelExtras6.BackColor = Color.FromArgb(22, 134, 55);
                precioExtras6.BackColor = Color.FromArgb(22, 134, 55);
                panelColor6.BackColor = Color.FromArgb(22, 171, 71);
                numeroExtras++;
                bstate6 = true;
            }
            else
            {
                labelExtras6.BackColor = Color.Black;
                precioExtras6.BackColor = Color.Black;
                panelColor6.BackColor = Color.FromArgb(255, 152, 83);
                numeroExtras--;
                bstate6 = false;
            }
        }

    }
}
