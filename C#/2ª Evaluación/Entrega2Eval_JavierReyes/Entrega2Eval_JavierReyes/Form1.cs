
using BurgerLibrary.Modelo.Productos;

namespace Entrega2Eval_JavierReyes
{
    public partial class Form1 : Form
    {
        private int fase = 1;
        private bool p1f1, p2f1, p1f2, p2f2, p1f3, p2f3;   
        public Form1()
        {
            InitializeComponent();

            InitUI();
            InitSeleccion();
            InitDatosFase();
        }

        private void InitSeleccion()
        {
            p1f1 = false;
            p2f1 = false;
            p1f2 = false;
            p2f2 = false;
            p1f3 = false;
            p2f3 = false;
        }

        // Inits
        private void InitDatosFase()
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

                    // Estado botón
                    btn_añadirPagar.Text = "Añadir";
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

            // Inicializar main menu
            mostrarMainTlp();
        }

        // Botones
        private void btnProducto1_Click(object sender, EventArgs e)
        {
            // Producto 1 en verde, Producto 2 y Extras en negro
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
                    p1f1 = true;
                    p2f2 = false;
                    break;
                case 2:
                    lbl_descripcion.Text = "Un refresco de AdriCola de manzana refrescante";
                    p1f2 = true;
                    p2f2 = false;
                    break;
                case 3:
                    lbl_descripcion.Text = "Unas ricas croquetas de jamón\nIngredientes:  Leche entera, Mantequilla, Harina refinada, Jamon (25%), Huevo cocido, Pan rallado.";
                    tlpExtras.Visible = true;
                    p1f3 = true;
                    p2f3 = false;
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
                    p2f1 = true;
                    p1f1 = false;
                    break;
                case 2:
                    lbl_descripcion.Text = "Una botella de agua de 300ml";
                    p2f2 = true;
                    p1f2 = false;
                    break;
                case 3:
                    lbl_descripcion.Text = "Nuestros nuevos PoNuggets\nIngredientes: Pollo (25%), Queso crema, Ajo, Sal, Pimienta, Harina refinada, Pan rallado, Aceite de palma.";
                    tlpExtras.Visible = true;
                    p2f3 = true;
                    p1f3 = false;
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }
        }
        private void btnExtras_Click(object sender, EventArgs e)
        {
            mostrarExtrasTlp();

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
            InitDatosFase();

            // Se añade el producto a la lista del pedido con su precio

            // Cuando se va a pagar tiene que dar opcion de eliminar alguna cosa
        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            mostrarMainTlp();
            // Tlp de productos visible
            tlp6.BackColor = Color.Black;
            tlp7.BackColor = Color.Black;




            // Botón de añadir vuelve a No quiero nada
            btn_añadirPagar.Text = "No quiero, gracias";

            // Vacía la descripción
            lbl_descripcion.Text = "";

            // Vuelve el menú de descripción al estado anterior
            lbl_descripcionTitulo.Text = "Instrucciones";
            lbl_descripcion.Text = "Selecciona un producto y presiona el botón de \"Añadir\" para añadirlo a tu pedido o continúa sin pedir seleccionando \"No quiero, gracias\"";

            // Esconder el botón de cancelar y table layout pannel de extras
            //btn_cancelar.Visible = false;
            //tlpExtras.Visible = false;

            //mostrarMainTlp();
            userControl1.ResetState();

            switch (fase)
            {
                case 1:
                    lbl_tipoProducto.Text = "Hamburguesa";
                    break;
                case 3:
                    lbl_tipoProducto.Text = "Complementos";
                    break;
                default:
                    lbl_tipoProducto.Text = "ERROR";
                    break;
            }

        }
        private void btn_añadirPagar_Click_1(object sender, EventArgs e)
        {
            fase++;
            InitDatosFase();
            mostrarMainTlp();
            // Tlp negros
            tlp6.BackColor = Color.Black;
            tlp7.BackColor = Color.Black;
            lbl_añadirExtras.BackColor = Color.FromArgb(0, 0, 0);

            switch (fase)
            {
                case 1:
                    List<string> ing1 = new List<string>() { "Pan", "Carne de Vacuno", "Queso Cheddar", "Lechuga", "Pepinillos", "Ketchup" };
                    Comida c = new Comida("BurgAndrés", 1.65f, 300, ing1, "Carnivora", 150);
                    break;
                case 2:
                    Bebida b = new Bebida("Adricola", 3.00f, 400, 250);
                    break;
                case 3:
                    List<string> comp1 = new List<string>() { "Leche entera", "Mantequilla", "Harina refinada", "Jamon (25%)", "Huevo cocido", "Pan rallado" };
                    Complemento cm = new Complemento("Croquetas", 9.00f, 600, comp1, 6);
                    break;
                default:
                    Console.WriteLine("Ha tenido lugar un error.");
                    break;
            }
        }

        /*       
        List<Extra> extra = new List<Extra>();
        //Lista de extras
        extra.Add(new Extra("Bacon", 1.50f, 100, 2));
        extra.Add(new Extra("Queso", 1.20f, 100, 2));
        extra.Add(new Extra("Lechuga", 0.60f, 100, 2));
        extra.Add(new Extra("Cebolla", 0.60f, 50, 1));
        extra.Add(new Extra("Pan", 0.60f, 50, 1));
        extra.Add(new Extra("Salsa BBQ", 1.00f, 150, 1));
        extra.Add(new Extra("Carne de Vacuno", 2.00f, 200, 1));
        extra.Add(new Extra("Carne de Seitán", 2.00f, 100, 1));
        */


        // Otros
        private void mostrarMainTlp()
        {
            // Tlp de extras invisible
            userControl1.Visible = false;
            userControl1.SendToBack();

            // Tlp de productos visible visible
            tlp5.Visible = true;
            tlp5.BringToFront();

            // Se invisibiliza extras y el botón de cancelar
            btn_cancelar.Visible = false;
            tlpExtras.Visible = false;

            // Tlp negros
            tlp6.BackColor = Color.Black;
            tlp7.BackColor = Color.Black;
            lbl_añadirExtras.BackColor = Color.FromArgb(0, 0, 0);

            // Cargar descripción
            lbl_descripcionTitulo.Text = "Instrucciones";
            lbl_descripcion.Text = "Selecciona un producto y presiona el botón de \"Añadir\" para añadirlo a tu pedido o continúa sin pedir seleccionando \"No quiero, gracias\"";

            // Estado inicial del botón de añadir/pagar
            btn_añadirPagar.Text = "No quiero, gracias";
        }
        private void mostrarExtrasTlp()
        {
            // Se carga la información del menú de extras
            LoadExtras();

            // Tlp de productos invisible
            tlp5.Visible = false;
            tlp5.SendToBack();

            // Tlp de extras visible
            userControl1.Visible = true;
            userControl1.BringToFront();
        }
        private void LoadExtras()
        {
            // Se cargan las imágenes
            userControl1.buttonExtras1.Image = System.Drawing.Image.FromFile("img\\Extras\\extraPatty.jpg");
            userControl1.buttonExtras2.Image = System.Drawing.Image.FromFile("img\\Extras\\extraBacon.jpg");
            userControl1.buttonExtras3.Image = System.Drawing.Image.FromFile("img\\Extras\\extraLechuga.jpg");
            userControl1.buttonExtras4.Image = System.Drawing.Image.FromFile("img\\Extras\\extraOnion.jpg");
            userControl1.buttonExtras5.Image = System.Drawing.Image.FromFile("img\\Extras\\extraQueso.jpg");
            userControl1.buttonExtras6.Image = System.Drawing.Image.FromFile("img\\Extras\\bbqdip.jpg");

            // Se carga el texto
            lbl_tipoProducto.Text = "Extras";
            userControl1.labelExtras1.Text = "Extra patty";
            userControl1.labelExtras2.Text = "Extra bacon";
            userControl1.labelExtras3.Text = "Extra lechuga";
            userControl1.labelExtras4.Text = "Extra onion";
            userControl1.labelExtras5.Text = "Extra queso";
            userControl1.labelExtras6.Text = "Extra dip";
        }
    }
}
