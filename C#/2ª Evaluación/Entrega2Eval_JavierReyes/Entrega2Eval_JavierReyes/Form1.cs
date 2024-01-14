
using System.Drawing.Text;

namespace Entrega2Eval_JavierReyes
{
    public partial class Form1 : Form
    {
        private PrivateFontCollection privateFontCollection = new PrivateFontCollection();
        private int fase = 1;
        private bool producto1Seleccionado, producto2Seleccionado;

        public Form1()
        {
            InitializeComponent();
            InitUI();
            LoadFase();
        }

        private void LoadFase()
        {
            switch (fase)
            {
                case 1:
                    // Cargar texto
                    lbl_tipoProducto.Text = "Hamburguesas";
                    lbl_nombreProducto1.Text = "BurgAndrés";
                    lbl_precioProducto1.Text = "1,65€";
                    lbl_nombreProducto2.Text = "BigAdri";
                    lbl_precioProducto2.Text = "4,50€";
                    // Cargar fotos
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2dam\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Hamburguesas\\burgAndrés.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2da" +
                        "m\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Hamburguesas\\bigAdri.jpg");
                    btnExtras.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2dam\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Otros\\bbqdip.jpg");

                    break;
                case 2:
                    // Cargar texto
                    lbl_tipoProducto.Text = "Bebidas";
                    lbl_nombreProducto1.Text = "AdriCola";
                    lbl_precioProducto1.Text = "3,00€";
                    lbl_nombreProducto2.Text = "Agua";
                    lbl_precioProducto2.Text = "1,00€";
                    // Cargar fotos
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2dam\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Bebidas\\adricola.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2dam\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Bebidas\\agua.jpg");
                    btnExtras.Visible = false;
                    break;
                case 3:
                    // Cargar texto
                    lbl_tipoProducto.Text = "Complementos";
                    lbl_nombreProducto1.Text = "Croquetas";
                    lbl_precioProducto1.Text = "9,00€";
                    lbl_nombreProducto2.Text = "PoNuggets";
                    lbl_precioProducto2.Text = "9,00€";
                    // Cargar fotos
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2dam\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Complementos\\croquetas.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("C:\\Users\\javir\\Documents\\Github\\2dam\\C#\\2ª Evaluación\\Entrega2Eval_JavierReyes\\Entrega2Eval_JavierReyes\\img\\Complementos\\nuggets.jpg");
                    btnExtras.Visible = false;
                    break;
                default:
                    lbl_descripcion.Text = "ERROR";
                    break;
            }
        }

        // dependiendo de la fase el lbl_tipoProducto cambia
        private void InitUI()
        {
            // Tamaño del Form fijo
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            //Imágenes en Stretch
            btnProducto1.BackgroundImageLayout = ImageLayout.Stretch;
            btnProducto2.BackgroundImageLayout = ImageLayout.Stretch;
            btnExtras.BackgroundImageLayout = ImageLayout.Stretch;
            

            // Imágenes clickables y sus ClickListeners
            btnProducto1.Click += btnProducto1_Click;
            btnProducto2.Click += btnProducto2_Click;
            btnExtras.Click += btnExtras_Click;
        }

        private void btnProducto1_Click(object sender, EventArgs e)
        {
            // El fondo del nombre y el precio se vuelven verde
            tlp6.BackColor = Color.FromArgb(22, 134, 55);
            tlp7.BackColor = Color.FromArgb(0, 0, 0);

            // Se muestra la descripción del producto 1
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = "BurgAndrés\nIngredientes: Pan, Carne de Vacuno, Queso Cheddar, Lechuga, Pepinillos, Ketchup.";
                    break;
                case 2:
                    lbl_descripcion.Text = "Un refresco de AdriCola de manzana refrescante";
                    break;
                case 3:
                    lbl_descripcion.Text = "Unas ricas croquetas de jamón\nIngredientes:  Leche entera, Mantequilla, Harina refinada, Jamon (25%), Huevo cocido, Pan rallado.";
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }
            producto1Seleccionado = true;
        }

        private void btnProducto2_Click(object sender, EventArgs e)
        {
            // El fondo del nombre y el precio se vuelven verde
            tlp7.BackColor = Color.FromArgb(22, 134, 55);
            tlp6.BackColor = Color.FromArgb(0, 0, 0);

            // Se muestra la descripción del producto 1
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = "BigAdri\nIngredientes:  Pan, Doble Carne de Vacuno, Doble Queso, Bacon, Lechuga, Cebolla, Mostaza.";
                    break;
                case 2:
                    lbl_descripcion.Text = "Una botella de agua de 300ml";
                    break;
                case 3:
                    lbl_descripcion.Text = "Nuestros nuevos PoNuggets\nIngredientes: Pollo (25%), Queso crema, Ajo, Sal, Pimienta, Harina refinada, Pan rallado, Aceite de palma.";
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }
            producto1Seleccionado = true;

        }

        private void btnExtras_Click(object sender, EventArgs e)
        { 
            // Se ha seleccionado el botón de añadir extras
            // Sale un menú alternativo con el botón de añadir y un botón de salir
                // Si le das a si pasas a la siguiente fase
                // Si la das a volver, se quita la ventana 

        }

        private void btn_añadirPagar_Click(object sender, EventArgs e)
        {
            // Se pasa de fase
            fase += 1;
            // Se añade el producto a la lista del pedido con su precio

            // Cuando se va a pagar tiene que dar opcion de eliminar alguna cosa
        }
    }
}
