
using BurgerLibrary.Modelo.Productos;
using System.Text.Json;
using System.Windows.Forms;

namespace Entrega2Eval_JavierReyes
{
    public partial class
        Form1 : Form
    {
        // VARIABLES 
        public int fase = 0;
        // RELACIÓN PRODUCTO SELECCIONADO-FASE
        private bool p1f1 = false, p2f1 = false, p1f2 = false, p2f2 = false, p1f3 = false, p2f3 = false;
        // PARA LA GESTIÓN DE LOS BOTONES DE userControl2
        private bool[] slots = new bool[5];
        // LA COMANDA
        private List<Producto> factura = new List<Producto>();
        List<Factura> facturas = new List<Factura>();



        private List<Extra> catalogoExtras = creaExtras();

        private bool sinCompra;

        // MAIN
        public Form1()
        {
            InitializeComponent();

            InitUI();
            CargarFase();
            IrAlMenu();

            // Suscribir los métodos a los eventos ButtonClick de UserControl2
            userControl2.Button1Click += UserControl2_Button1Click;
            userControl2.Button2Click += UserControl2_Button2Click;
            userControl2.Button3Click += UserControl2_Button3Click;
            userControl2.Button4Click += UserControl2_Button4Click;
            userControl2.Button5Click += UserControl2_Button5Click;
        }

        private void UserControl2_Button1Click(object sender, EventArgs e)
        {
            // Cambiar el color del botón según el estado actual
            if (userControl2.bstate1)
            {
                // Color rojo
                pro1.BackColor = Color.FromArgb(252, 96, 96);
                pre1.BackColor = Color.FromArgb(252, 96, 96);
            }

            else
            {
                // Cambiar el color de pro1 y pre1 a rojo
                pro1.BackColor = Color.FromArgb(255, 249, 244);
                pre1.BackColor = Color.FromArgb(255, 249, 244);
            }

        }
        private void UserControl2_Button2Click(object sender, EventArgs e)
        {
            // Cambiar el color de pro1Extras y pro1Extras a rojo
            if (userControl2.bstate2)
            {
                // Color rojo
                pro1Extras.BackColor = Color.FromArgb(252, 96, 96);
                pre1Extras.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // Cambiar el color de pro1 y pre1 a rojo
                pro1Extras.BackColor = Color.FromArgb(255, 249, 244);
                pre1Extras.BackColor = Color.FromArgb(255, 249, 244);
            }


        }
        private void UserControl2_Button3Click(object sender, EventArgs e)
        {
            // Cambiar el color de pro2 y pre2 a rojo

            if (userControl2.bstate3)
            {
                // Color rojo
                pro2.BackColor = Color.FromArgb(252, 96, 96);
                pre2.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // Cambiar el color de pro1 y pre1 a rojo
                pro2.BackColor = Color.FromArgb(255, 249, 244);
                pre2.BackColor = Color.FromArgb(255, 249, 244);
            }




        }
        private void UserControl2_Button4Click(object sender, EventArgs e)
        {
            // Cambiar el color de pro3 y pre3 a rojo


            if (userControl2.bstate4)
            {
                // Color rojo
                pro3.BackColor = Color.FromArgb(252, 96, 96);
                pre3.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // Cambiar el color de pro1 y pre1 a rojo
                pro3.BackColor = Color.FromArgb(255, 249, 244);
                pre3.BackColor = Color.FromArgb(255, 249, 244);
            }
        }
        private void UserControl2_Button5Click(object sender, EventArgs e)
        {
            // Cambiar el color de pro3Extras y pre3Extras a rojo


            if (userControl2.bstate5)
            {
                // Color rojo
                pro3Extras.BackColor = Color.FromArgb(252, 96, 96);
                pre3Extras.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // Cambiar el color de pro1 y pre1 a rojo
                pro3Extras.BackColor = Color.FromArgb(255, 249, 244);
                pre3Extras.BackColor = Color.FromArgb(255, 249, 244);
            }
        }
        private static List<Extra> creaExtras()
        {
            List<Extra> extra = new List<Extra>();

            //Lista de extras
            extra.Add(new Extra("Patty", 1.50f, 100, 2));
            extra.Add(new Extra("Bacon", 1.20f, 100, 2));
            extra.Add(new Extra("Lechuga", 0.60f, 100, 2));
            extra.Add(new Extra("Onion", 0.60f, 50, 1));
            extra.Add(new Extra("Queso", 0.60f, 50, 1));
            extra.Add(new Extra("Dip", 1.00f, 150, 1));

            return extra;
        }        // INITS
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
            IrAlMenu();
        }
        private void CargarFase()
        {
            fase++;

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

                    break;

                case 4:
                    if (factura.Count > 0)
                    {
                        // Menú de quitar algo
                        lbl_tipoProducto.Text = "¿Quitamos algo?";
                        btn_añadirPagar.Text = "Continuar";
                        lbl_descripcionTitulo.Text = "Instrucciones";
                        lbl_descripcion.Text = "Quita aquellos productos que no te interesen de tu pedido";

                        // Tlp de borrado de ítems 
                        userControl2.Visible = true;
                        userControl2.BringToFront();

                        // Tlp de productos invisible
                        tlp5.Visible = false;
                        tlp5.SendToBack();

                        // Tlp de extras invisible
                        userControl1.Visible = false;
                        userControl1.SendToBack();

                        // Botón de cancelar invisible
                        btn_cancelar.Visible = false;

                        comprobarBotones();
                    }
                    else
                    {
                        MostrarPantallaObservaciones();
                    }
                    break;
                case 5:
                    MostrarPantallaObservaciones();
                    break;
                case 6:
                    MostrarPantallaFactura(factura);
                    break;
                default:
                    lbl_descripcion.Text = "ERROR";
                    break;
            }
        }
        private void comprobarBotones()
        {
            if (slots[0] == true)
            {
                userControl2.b1.Visible = true;
                userControl2.pb1.Visible = true;
            }
            else
            {
                userControl2.b1.Visible = false;
                userControl2.pb1.Visible = false;
            }

            if (slots[1] == true)
            {
                userControl2.b2.Visible = true;
                userControl2.pb2.Visible = true;
            }
            else
            {
                userControl2.b2.Visible = false;
                userControl2.pb2.Visible = false;
            }

            if (slots[2] == true)
            {
                userControl2.b3.Visible = true;
                userControl2.pb3.Visible = true;
            }
            else
            {
                userControl2.b3.Visible = false;
                userControl2.pb3.Visible = false;
            }

            if (slots[3] == true)
            {
                userControl2.b4.Visible = true;
                userControl2.pb4.Visible = true;
            }
            else
            {
                userControl2.b4.Visible = false;
                userControl2.pb4.Visible = false;
            }

            if (slots[4] == true)
            {
                userControl2.b5.Visible = true;
                userControl2.pb5.Visible = true;
            }
            else
            {
                userControl2.b5.Visible = false;
                userControl2.pb5.Visible = false;
            }
        }
        private float calculoPrecioTotal(List<Producto> comanda)
        {
            float suma = 0.00f;
            for (int i = 0; i < comanda.Count; i++)
            {
                suma += comanda[i].Precio;
            }

            //return (suma + pExtras1 + pExtras3).ToString("F2");
            return (suma);
        }
        private void IrAlMenu()
        {
            // Tlp de extras invisible
            userControl1.Visible = false;
            userControl1.SendToBack();

            // Tlp de productos visible 
            tlp5.Visible = true;
            tlp5.BringToFront();

            // Tlp de borrado de ítems 
            userControl2.Visible = false;
            userControl2.SendToBack();

            // Se invisibiliza extras y el botón de cancelar
            btn_cancelar.Visible = false;
            tlpExtras.Visible = false;

            // Etiquetas del menú negros
            tlp6.BackColor = Color.Black;
            tlp7.BackColor = Color.Black;
            lbl_añadirExtras.BackColor = Color.Black;

            // Título de la descripción
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

            // Cargar descripción
            lbl_descripcionTitulo.Text = "Instrucciones";
            lbl_descripcion.Text = "Selecciona un producto y presiona el botón de \"Añadir\" para añadirlo a tu pedido o continúa sin pedir seleccionando \"No quiero, gracias\"";

            // Estado inicial del botón de añadir/pagar
            btn_añadirPagar.Text = "No quiero, gracias";
        }

        // BOTONES DE PRODUCTO
        private void btnProducto1_Click(object sender, EventArgs e)
        {
            MostrarPantallaProducto(1);
        }
        private void btnProducto2_Click(object sender, EventArgs e)
        {
            MostrarPantallaProducto(2);
        }

        // BOTONES DE OPCIONES
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            p2f1 = false;
            p2f2 = false;
            p1f3 = false;
            p2f3 = false;

            switch (fase)
            {
                case 1:
                    p1f1 = false;
                    p2f1 = false;
                    break;
                case 2:
                    p1f2 = false;
                    p2f2 |= false;
                    break;
                case 3:
                    p1f3 = false;
                    p2f3 |= false;
                    break;
                default:
                    lbl_tipoProducto.Text = "ERROR";
                    break;
            }
            IrAlMenu();

            userControl1.ResetState();
        }
        private void btnExtras_Click(object sender, EventArgs e)
        {
            MostrarPantallaExtras();
        }

        // MOSTRAR
        private void MostrarPantallaProducto(int producto)
        {
            // Establecer el color de fondo según el producto seleccionado
            if (producto == 1)
            {
                tlp6.BackColor = Color.FromArgb(22, 134, 55);
                tlp7.BackColor = Color.Black;
                if (fase == 1) p1f1 = true;
                if (fase == 2) p1f2 = true;
                if (fase == 3) p1f3 = true;
            }
            else if (producto == 2)
            {
                tlp7.BackColor = Color.FromArgb(22, 134, 55);
                tlp6.BackColor = Color.Black;
                if (fase == 1) p2f1 = true;
                if (fase == 2) p2f2 = true;
                if (fase == 3) p2f3 = true;
            }

            // Otros ajustes comunes
            lbl_añadirExtras.BackColor = Color.Black;
            btn_añadirPagar.Text = "Añadir a la cesta";
            btn_cancelar.Visible = true;

            // Configurar la descripción según el producto y la fase
            lbl_descripcionTitulo.Text = "Ingredientes:";

            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = (producto == 1) ? "BurgAndrés\nIngredientes: Pan, Carne de Vacuno, Queso Cheddar, Lechuga, Pepinillos, Ketchup." :
                                                            "BigAdri\nIngredientes: Pan, Doble Carne de Vacuno, Doble Queso, Bacon, Lechuga, Cebolla, Mostaza.";
                    tlpExtras.Visible = true;

                    break;
                case 2:
                    lbl_descripcion.Text = (producto == 1) ? "Un refresco de AdriCola de manzana refrescante" :
                                                            "Una botella de agua de 300ml";

                    break;
                case 3:
                    lbl_descripcion.Text = (producto == 1) ? "Unas ricas croquetas de jamón\nIngredientes: Leche entera, Mantequilla, Harina refinada, Jamon (25%), Eevo cocido, Pan rallado." :
                                                            "Nuestros nuevos PoNuggets\nIngredientes: Pollo (25%), Queso crema, Ajo, Sal, Pimienta, Harina refinada, Pan rallado, Aceite de palma.";
                    tlpExtras.Visible = true;

                    break;
                default:
                    lbl_descripcion.Text = "ERROR";
                    break;
            }
        }
        private void MostrarPantallaExtras()
        {
            userControl1.ResetState();

            // Tlp de productos invisible
            tlp5.Visible = false;
            tlp5.SendToBack();

            // Tlp de extras visible
            userControl1.Visible = true;
            userControl1.BringToFront();

            // Tlp de borrado de ítems 
            userControl2.Visible = false;
            userControl2.SendToBack();

            // Se invisibiliza extras y el botón de cancelar
            btn_cancelar.Visible = true;
            tlpExtras.Visible = true;

            // Etiquetas de los extras negros
            userControl1.labelExtras1.BackColor = Color.Black;
            userControl1.labelExtras2.BackColor = Color.Black;
            userControl1.labelExtras3.BackColor = Color.Black;
            userControl1.labelExtras4.BackColor = Color.Black;
            userControl1.labelExtras5.BackColor = Color.Black;
            userControl1.labelExtras6.BackColor = Color.Black;

            // Fondos de los extras naranjas
            userControl1.panelColor1.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor2.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor3.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor4.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor5.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor6.BackColor = Color.FromArgb(255, 152, 83);

            // Se cargan las imágenes
            userControl1.buttonExtras1.Image = System.Drawing.Image.FromFile("img\\Extras\\extraPatty.jpg");
            userControl1.buttonExtras2.Image = System.Drawing.Image.FromFile("img\\Extras\\extraBacon.jpg");
            userControl1.buttonExtras3.Image = System.Drawing.Image.FromFile("img\\Extras\\extraLechuga.jpg");
            userControl1.buttonExtras4.Image = System.Drawing.Image.FromFile("img\\Extras\\extraOnion.jpg");
            userControl1.buttonExtras5.Image = System.Drawing.Image.FromFile("img\\Extras\\extraQueso.jpg");
            userControl1.buttonExtras6.Image = System.Drawing.Image.FromFile("img\\Extras\\bbqdip.jpg");

            // Se carga el texto
            lbl_tipoProducto.Text = "Extras";
            userControl1.labelExtras1.Text = catalogoExtras[0].Nombre;
            userControl1.labelExtras2.Text = catalogoExtras[1].Nombre;
            userControl1.labelExtras3.Text = catalogoExtras[2].Nombre;
            userControl1.labelExtras4.Text = catalogoExtras[3].Nombre;
            userControl1.labelExtras5.Text = catalogoExtras[4].Nombre;
            userControl1.labelExtras6.Text = catalogoExtras[5].Nombre;

            userControl1.precioExtras1.Text = catalogoExtras[0].Precio.ToString("F2") + " €";
            userControl1.precioExtras2.Text = catalogoExtras[1].Precio.ToString("F2") + " €";
            userControl1.precioExtras3.Text = catalogoExtras[2].Precio.ToString("F2") + " €"; ;
            userControl1.precioExtras4.Text = catalogoExtras[3].Precio.ToString("F2") + " €";
            userControl1.precioExtras5.Text = catalogoExtras[4].Precio.ToString("F2") + " €";
            userControl1.precioExtras6.Text = catalogoExtras[5].Precio.ToString("F2") + " €";

            // Botón y Descripción
            btn_añadirPagar.Text = "Añadir a la cesta";
            lbl_descripcionTitulo.Text = "Extra-rico";
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = "Añade extras a tu hamburguesa.";
                    break;
                case 2:
                    lbl_descripcion.Text = "";
                    break;
                case 3:
                    lbl_descripcion.Text = "Añade extras a tu complemento.";
                    break;
                default:
                    lbl_descripcion.Text = "";
                    break;
            }
        }
        private void MostrarPantallaObservaciones()
        {
            // Tlp de borrado de ítems invisible 
            userControl2.Visible = false;
            userControl2.SendToBack();

            // Tlp de productos invisible
            tlp5.Visible = false;
            tlp5.SendToBack();

            // Tlp de extras invisible
            userControl1.Visible = false;
            userControl1.SendToBack();

            // Botón de cancelar invisible
            btn_cancelar.Visible = false;

            // Pantalla final visible
            userControl3.Visible = true;
            userControl3.BringToFront();

            // Situación inicial del botón
            btn_añadirPagar.Visible = true;
            btn_añadirPagar.Text = "Pagar e imprimir ticket";


            if (factura.Count == 0)
            {
                lbl_tipoProducto.Text = "Compra cancelada";
                lbl_descripcionTitulo.Text = "Adiós";
                lbl_descripcion.Text = "¡Una pena, esperamos verte pronto!";

                lbl_total1.Visible = false;
                lbl_total2.Visible = false;


                userControl3.btn_caja.Visible = false;
                userControl3.btn_tarjeta.Visible = false;

                userControl3.tb_observaciones.Visible = false;
                userControl3.lb_observaciones.Visible = false;

                btn_añadirPagar.Text = "Salir";
                sinCompra = true;
            }
            else
            {
                lbl_tipoProducto.Text = "Ultimos detalles";
                lbl_descripcionTitulo.Text = "Instrucciones";
                lbl_descripcion.Text = "Selecciona un método de pago y añade una observación a tu pedido'";
                btn_añadirPagar.Text = "Aceptar";

                lbl_total1.Visible = true;
                lbl_total2.Visible = true;

                userControl3.btn_caja.Visible = true;
                userControl3.btn_tarjeta.Visible = true;

                userControl3.bstateCaja = true;
                userControl3.bstateTarjeta = false;

                userControl3.btn_caja.BackColor = Color.FromArgb(29, 171, 71);
            }
        }
        private void btn_añadirPagar_Click(object sender, EventArgs e)
        {
            // Hasta la fase dos todavía se repite el ciclo una vez más
            switch (fase)
            {
                case 1:
                    Comida c;
                    // Producto fase 1
                    if (p1f1)
                    {
                        List<string> ing1 = new List<string>() { "Pan", "Carne de Vacuno", "Queso Cheddar", "Lechuga", "Pepinillos", "Ketchup" };
                        c = new Comida("BurgAndrés", 1.65f, 300, ing1, "Carnivora", 150);
                        factura.Add(c);
                        pro1.Text = c.Nombre;
                        pre1.Text = "+ " + c.Precio.ToString("F2") + "€";
                        slots[0] = true;
                    }
                    if (p2f1)
                    {
                        List<string> ing2 = new List<string>() { "Pan", "Doble Carne de Vacuno", "Doble Queso", "Bacon", "Lechuga", "Cebolla", "Mostaza" };
                        c = new Comida("BigAdri", 4.50f, 600, ing2, "Carnivora", 150);
                        factura.Add(c);
                        pro1.Text = c.Nombre;
                        pre1.Text = "+ " + c.Precio.ToString("F2") + "€";
                        slots[0] = true;
                    }

                    int contadorExtras1 = 0;
                    float precioExtras1 = 0.00f;

                    if (userControl1.bstate1)
                    {
                        factura.Add(catalogoExtras[0]);
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[0].Precio;
                    }
                    if (userControl1.bstate2)
                    {
                        factura.Add(catalogoExtras[1]);
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[1].Precio;
                    }
                    if (userControl1.bstate3)
                    {
                        factura.Add(catalogoExtras[2]);
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[2].Precio;
                    }
                    if (userControl1.bstate4)
                    {
                        factura.Add(catalogoExtras[3]);
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[3].Precio;
                    }
                    if (userControl1.bstate5)
                    {
                        factura.Add(catalogoExtras[4]);
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[4].Precio;
                    }
                    if (userControl1.bstate6)
                    {
                        factura.Add(catalogoExtras[5]);
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[5].Precio;
                    }

                    if (contadorExtras1 > 0)
                    {
                        pro1Extras.Text = contadorExtras1 + " extras";
                        pre1Extras.Text = "+ " + precioExtras1.ToString("F2") + "€"; // Mostramos el precio total de los extras
                        slots[1] = true;
                    }

                    for (int i = 0; i < contadorExtras1; i++)
                    {
                        //pExtras1 += listaExtras1[i].Precio;

                        if (contadorExtras1 > 0)
                        {
                            pro1Extras.Text = contadorExtras1 + " extras";
                            //pre1Extras.Text = "+ " + precioExtras.ToString("F2") + "€";
                            pre1Extras.Text = "+ " + precioExtras1.ToString("F2") + "€";
                            slots[1] = true;
                        }
                    }

                    /*
                    for (int i = 0; i < listaExtras1.Count; i++)
                    {
                        pExtras1 += listaExtras1[i].Precio;

                        if (pExtras1 > 0)
                        {
                            pro1Extras.Text = userControl1.numeroExtras + " extras";
                            pre1Extras.Text = "+ " + pExtras1.ToString("F2") + "€";
                            slots[1] = true;
                        }
                    }
                    */
                    //userControl1.numeroExtras = 0;
                    IrAlMenu();
                    CargarFase();
                    break;
                case 2:
                    // Producto fase 2
                    Bebida b;
                    if (p1f2)
                    {
                        b = new Bebida("Refrigerio 250ml", 3.00f, 400, 250);
                        factura.Add(b);
                        pro2.Text = b.Nombre;
                        pre2.Text = "+ " + b.Precio.ToString("F2") + "€";
                        slots[2] = true;
                    }
                    if (p2f2)
                    {
                        b = new Bebida("Agua 300ml", 1.00f, 25, 300);
                        factura.Add(b);
                        pro2.Text = b.Nombre;
                        pre2.Text = "+ " + b.Precio.ToString("F2") + "€";
                        slots[2] = true;
                    }
                    IrAlMenu();
                    CargarFase();
                    break;

                case 3:
                    // Producto fase 3
                    Complemento cc;
                    if (p1f3)
                    {
                        List<string> comp1 = new List<string>() { "Leche entera", "Mantequilla", "Harina refinada", "Jamon (25%)", "Huevo cocido", "Pan rallado" };
                        cc = new Complemento("Croquetas", 9.00f, 600, comp1, 6);
                        factura.Add(cc);
                        pro3.Text = cc.Nombre;
                        pre3.Text = "+ " + cc.Precio.ToString("F2") + "€";
                        slots[3] = true;
                    }
                    if (p2f3)
                    {
                        List<string> comp2 = new List<string>() { "Pollo (25%)", "Queso crema", "Ajo", "Sal", "Pimienta", "Harina refinada", "Pan rallado", "Aceite de palma" };
                        cc = new Complemento("PoNuggets", 9.00f, 600, comp2, 6);
                        factura.Add(cc);
                        pro3.Text = cc.Nombre;
                        pre3.Text = "+ " + cc.Precio.ToString("F2") + "€";
                        slots[3] = true;
                    }

                    int contadorExtras3 = 0;
                    float precioExtras3 = 0.00f;

                    if (userControl1.bstate1)
                    {
                        factura.Add(catalogoExtras[0]);
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[0].Precio;
                    }
                    if (userControl1.bstate2)
                    {
                        factura.Add(catalogoExtras[1]);
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[1].Precio;
                    }
                    if (userControl1.bstate3)
                    {
                        factura.Add(catalogoExtras[2]);
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[2].Precio;
                    }
                    if (userControl1.bstate4)
                    {
                        factura.Add(catalogoExtras[3]);
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[3].Precio;
                    }
                    if (userControl1.bstate5)
                    {
                        factura.Add(catalogoExtras[4]);
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[4].Precio;
                    }
                    if (userControl1.bstate6)
                    {
                        factura.Add(catalogoExtras[5]);
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[5].Precio;
                    }

                    if (contadorExtras3 > 0)
                    {
                        pro3Extras.Text = contadorExtras3 + " extras";
                        pre1Extras.Text = "+ " + precioExtras3.ToString("F2") + "€";
                        slots[4] = true;
                    }

                    for (int i = 0; i < contadorExtras3; i++)
                    {
                        //pExtras3 += listaExtras3[i].Precio;

                        if (contadorExtras3 > 0)
                        {
                            pro3Extras.Text = contadorExtras3 + " extras";
                            //pre1Extras.Text = "+ " + precioExtras.ToString("F2") + "€";
                            pre3Extras.Text = "+ " + precioExtras3.ToString("F2") + "€";
                            slots[4] = true;
                        }
                    }

                    CargarFase();

                    break;
                case 4:
                    //Nos encontramos en la pantalla de quitar productos y al presionar se va a recalcular el precio
                    if (sinCompra) Application.Exit();


                    // Comida
                    if (userControl2.bstate1)
                    {

                        Producto comida = factura.FirstOrDefault(p => p is Comida);
                        if (comida != null)
                        {
                            factura.Remove(comida);
                        }

                        //comanda.RemoveAt(0);

                        pro1.Text = " ";
                        pre1.Text = " ";
                        pro1.BackColor = Color.FromArgb(255, 249, 244);
                        pre1.BackColor = Color.FromArgb(255, 249, 244);
                    }

                    // Extras Comida
                    if (userControl2.bstate2)
                    {
                        Producto extras1 = factura.FirstOrDefault(p => p is Extra);
                        if (extras1 != null)
                        {
                            factura.Remove(extras1);
                        }

                        //comanda.RemoveAt(1);

                        pro1Extras.Text = " ";
                        pre1Extras.Text = " ";
                        pro1Extras.BackColor = Color.FromArgb(255, 249, 244);
                        pre1Extras.BackColor = Color.FromArgb(255, 249, 244);
                    }

                    // Bebida
                    if (userControl2.bstate3)
                    {

                        Producto bebida = factura.FirstOrDefault(p => p is Bebida);
                        if (bebida != null)
                        {
                            factura.Remove(bebida);
                        }

                        //comanda.RemoveAt(2);

                        pro2.Text = " ";
                        pre2.Text = " ";
                        pro2.BackColor = Color.FromArgb(255, 249, 244);
                        pre2.BackColor = Color.FromArgb(255, 249, 244);
                    }

                    // Complementos 

                    if (userControl2.bstate4)
                    {

                        Producto complemento = factura.FirstOrDefault(p => p is Complemento);
                        if (complemento != null)
                        {
                            factura.Remove(complemento);
                        }

                        //comanda.RemoveAt(3);
                        pro3.Text = " ";
                        pre3.Text = " ";
                        pro3.BackColor = Color.FromArgb(255, 249, 244);
                        pre3.BackColor = Color.FromArgb(255, 249, 244);
                    }

                    // Extras Complementos

                    if (userControl2.bstate5)
                    {
                        Producto extras3 = factura.FirstOrDefault(p => p is Extra);
                        if (extras3 != null)
                        {
                            factura.Remove(extras3);
                        }
                        //pExtras3 = 0;
                        //comanda.RemoveAt(4);

                        pro3Extras.Text = " ";
                        pre3Extras.Text = " ";
                        pro3Extras.BackColor = Color.FromArgb(255, 249, 244);
                        pre3Extras.BackColor = Color.FromArgb(255, 249, 244);
                    }

                    // Recalcular el precio con los nuevos parámetros
                    lbl_total2.Text = calculoPrecioTotal(factura).ToString("F2") + "€";
                    CargarFase();
                    break;
                case 5:
                    CargarFase();
                    break;
                case 6:
                    GuardarCerrar();
                    break;
                default: break;
            }
            userControl1.ResetState();
        }

        private void GuardarCerrar()
        {
            // Se guardan los cambios y se cierra la aplicación
            Application.Exit();
        }

        public void MostrarPantallaFactura(List<Producto> factura)
        {


            // Tlp de productos invisible
            tlp5.Visible = false;
            tlp5.SendToBack();

            // Tlp de extras visible
            userControl1.Visible = false;
            userControl1.SendToBack();

            // Tlp de borrado de ítems 
            userControl2.Visible = false;
            userControl2.SendToBack();

            userControl3.Visible = false;
            userControl3.SendToBack();

            // Se invisibiliza extras y el botón de cancelar
            btn_cancelar.Visible = false;
            tlpExtras.Visible = false;

            //Se visibiliza el userControl4
            userControl4.Visible = true;
            lbl_tipoProducto.Text = "Tu pedido se ha realizado";
            btn_añadirPagar.Text = "Pagar";
            lbl_tipoProducto.Text = "Se ha generado tu factura";
            lbl_descripcionTitulo.Text = "Listo!";
            lbl_descripcion.Text = "Dale al botón de 'Pagar' para terminar";

            String observaciones = userControl3.tb_observaciones.Text;
            GenerarFactura(factura, observaciones);


        }

        public void GenerarFactura(List<Producto> comanda, string observaciones)
        {
            PedidoManager pedidoManager = new PedidoManager();
            // Generar ID de pedido
            int idPedido = pedidoManager.GenerarNuevoIdPedido();

            // Limpia el listBox antes de agregar nuevos elementos
            userControl4.listBox1.Items.Clear();

            userControl4.listBox1.Items.Add($"ID Pedido: {idPedido}");
            userControl4.listBox1.Items.Add("==========================================================");
            userControl4.listBox1.Items.Add("                        FACTURA DE COMPRA        ");
            userControl4.listBox1.Items.Add("==========================================================");
            userControl4.listBox1.Items.Add("");

            // Agrega cada producto a la factura y calcula el total
            float total = 0.00f;
            foreach (var producto in comanda)
            {
                // Formatea el precio con paréntesis
                string precioFormateado = $"({producto.Precio:N2} €)";
                // Agrega el nombre del producto y el precio con paréntesis junto con el ID del pedido
                userControl4.listBox1.Items.Add($"{producto.Nombre} {precioFormateado}");
                total += producto.Precio;
            }

            // Agrega una línea de separación
            userControl4.listBox1.Items.Add("----------------------------------------------------------");

            // Agrega el total al final de la factura
            userControl4.listBox1.Items.Add($"{"TOTAL:",-20} {total,10:N2} €");

            // Agrega las observaciones al final de la factura
            userControl4.listBox1.Items.Add("");
            userControl4.listBox1.Items.Add("Observaciones:");
            if (observaciones == "")
            {
                observaciones = "Ninguna";
            }

            userControl4.listBox1.Items.Add(observaciones);



            // Crear y agregar la factura a la lista
            var factura = new Factura
            {
                IdPedido = idPedido,
                Comanda = comanda,
                Observaciones = observaciones,
                Total = total
            };
            facturas.Add(factura);

            // Guardar la factura actual en un archivo JSON
            string facturaJson = JsonSerializer.Serialize(factura);
            using (StreamWriter sw = File.AppendText("facturas.json"))
            {
                sw.WriteLine(facturaJson);
            }

            // Guardar el último ID de pedido en un archivo
            pedidoManager.GuardarUltimoIdPedido();
        }




        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra el Form1 se cierra la aplicación
            Application.Exit();
        }
    }

}
