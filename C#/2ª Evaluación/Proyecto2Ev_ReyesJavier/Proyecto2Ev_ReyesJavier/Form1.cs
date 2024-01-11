using BurgerLibrary.Modelo.Productos;

namespace Proyecto2Ev_ReyesJavier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            // No se puede redimensionar el Form1
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            VisorImg visorImg = new VisorImg(); 
        }
    }
}