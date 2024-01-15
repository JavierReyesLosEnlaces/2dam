
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
                    // Cargar información sobre los productos
                    lbl_tipoProducto.Text = "Hamburguesas";
                    lbl_nombreProducto1.Text = "BurgAndrés";
                    lbl_precioProducto1.Text = "1,65€";
                    lbl_nombreProducto2.Text = "BigAdri";
                    lbl_precioProducto2.Text = "4,50€";

                    // Cargar fotos                                  
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("img\\Hamburguesas\\burgAndrés.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("img\\Hamburguesas\\bigAdri.jpg");
                    btnExtras.BackgroundImage = System.Drawing.Image.FromFile("img\\Otros\\bbqdip.jpg");

                    break;
                case 2:
                    // Cargar texto
                    lbl_tipoProducto.Text = "Bebidas";
                    lbl_nombreProducto1.Text = "AdriCola";
                    lbl_precioProducto1.Text = "3,00€";
                    lbl_nombreProducto2.Text = "Agua";
                    lbl_precioProducto2.Text = "1,00€";

                    // Cargar fotos
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("img\\Bebidas\\adricola.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("img\\Bebidas\\agua.jpg");
                    btnExtras.Visible = false;

                    // Estado botón
                    btn_añadirPagar.Text = "Añadir";

                    break;
                case 3:
                    // Cargar texto
                    lbl_tipoProducto.Text = "Complementos";
                    lbl_nombreProducto1.Text = "Croquetas";
                    lbl_precioProducto1.Text = "9,00€";
                    lbl_nombreProducto2.Text = "PoNuggets";
                    lbl_precioProducto2.Text = "9,00€";

                    // Cargar fotos
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("img\\Complementos\\croquetas.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("img\\Complementos\\nuggets.jpg");
                    btnExtras.Visible = true;

                    // Estado botón
                    btn_añadirPagar.Text = "Pagar";

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

            // Quitar botones de maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;


            // Estado inicial del botón de añadir/pagar
            btn_añadirPagar.Text = "No quiero, gracias";

            // Esconder el botón de cancelar y table layout pannel de extras
            btn_cancelar.Visible = false;
            tlpExtras.Visible = false;
        }

        private void btnProducto1_Click(object sender, EventArgs e)
        {
            // El fondo del nombre y el precio se vuelven verde
            // El resto de labels se vuelven negros
            tlp6.BackColor = Color.FromArgb(22, 134, 55);
            tlp7.BackColor = Color.FromArgb(0, 0, 0);
            lbl_añadirExtras.BackColor = Color.FromArgb(0, 0, 0);

            // Estado del botón de añadir/pagar
            btn_añadirPagar.Text = "Añadir a la cesta";

            // Mostrar el botón de cancelar
            btn_cancelar.Visible = true;

            // Se muestra la descripción del producto 1
            lbl_descripcionTitulo.Text = "Ingredientes:";
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = "BurgAndrés\nIngredientes: Pan, Carne de Vacuno, Queso Cheddar, Lechuga, Pepinillos, Ketchup.";
                    tlpExtras.Visible = true;
                    break;
                case 2:
                    lbl_descripcion.Text = "Un refresco de AdriCola de manzana refrescante";
                    break;
                case 3:
                    lbl_descripcion.Text = "Unas ricas croquetas de jamón\nIngredientes:  Leche entera, Mantequilla, Harina refinada, Jamon (25%), Huevo cocido, Pan rallado.";
                    tlpExtras.Visible = true;
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }
        }

        private void btnProducto2_Click(object sender, EventArgs e)
        {
            // El fondo del nombre y el precio se vuelven verde
            // El resto de labels se vuelven negros
            tlp7.BackColor = Color.FromArgb(22, 134, 55);
            tlp6.BackColor = Color.FromArgb(0, 0, 0);
            lbl_añadirExtras.BackColor = Color.FromArgb(0, 0, 0);

            // Estado del botón de añadir/pagar
            btn_añadirPagar.Text = "Añadir a la cesta";

            // Mostrar el botón de cancelar
            btn_cancelar.Visible = true;

            // Se muestra la descripción del producto 1
            lbl_descripcionTitulo.Text = "Ingredientes:";
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = "BigAdri\nIngredientes:  Pan, Doble Carne de Vacuno, Doble Queso, Bacon, Lechuga, Cebolla, Mostaza.";
                    tlpExtras.Visible = true;
                    break;
                case 2:
                    lbl_descripcion.Text = "Una botella de agua de 300ml";
                    break;
                case 3:
                    lbl_descripcion.Text = "Nuestros nuevos PoNuggets\nIngredientes: Pollo (25%), Queso crema, Ajo, Sal, Pimienta, Harina refinada, Pan rallado, Aceite de palma.";
                    tlpExtras.Visible = true;
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }
        }

        private void btnExtras_Click(object sender, EventArgs e)
        {
            // El label de extras se vuelven verde
            // El resto de labels se vuelven negros
            lbl_añadirExtras.BackColor = Color.FromArgb(22, 134, 55);
            //tlp6.BackColor = Color.FromArgb(0, 0, 0);
            //tlp7.BackColor = Color.FromArgb(0, 0, 0);

            // Mostrar el botón de cancelar
            btn_cancelar.Visible = true;

            // Estado del botón de añadir/pagar
            btn_añadirPagar.Text = "Añadir a la cesta";

            // Se muestra la descripción de los extras
            lbl_descripcionTitulo.Text = "Extra-rico";
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = "Añade un extra a tu hamburguesa.";
                    break;
                case 2:
                    lbl_descripcion.Text = "";
                    break;
                case 3:
                    lbl_descripcion.Text = "Añade un extra a tu complemento.";
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }

            // Se abre un nuevo Form con la función de añadir y un botón de salir
        }

        private void btn_añadirPagar_Click(object sender, EventArgs e)
        {
            // Se pasa de fase
            fase += 1;
            //LoadFase();

            // Se añade el producto a la lista del pedido con su precio

            // Cuando se va a pagar tiene que dar opcion de eliminar alguna cosa
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            // Desselecciona los botones
            lbl_añadirExtras.BackColor = Color.FromArgb(0, 0, 0);

            tlp6.BackColor = Color.FromArgb(0, 0, 0);
            tlp7.BackColor = Color.FromArgb(0, 0, 0);

            // Botón de añadir vuelve a No quiero nada
            btn_añadirPagar.Text = "No quiero, gracias";

            // Vacía la descripción
            lbl_descripcion.Text = "";

            // Vuelve el menú de descripción al estado anterior
            lbl_descripcionTitulo.Text = "Instrucciones";
            lbl_descripcion.Text = "Selecciona un producto y presiona el botón de \"Añadir\" para añadirlo a tu pedido.";

            // Esconder el botón de cancelar y table layout pannel de extras
            btn_cancelar.Visible = false;
            tlpExtras.Visible = false;

        }
    }
}
