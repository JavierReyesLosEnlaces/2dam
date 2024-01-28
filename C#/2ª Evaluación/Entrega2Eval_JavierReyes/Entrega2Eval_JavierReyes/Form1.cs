
using BurgerLibrary.Modelo.Productos;

namespace Entrega2Eval_JavierReyes
{
    public partial class Form1 : Form
    {
        // VARIABLES 
        private int fase = 0;
        private bool p1f1 = false, p2f1 = false, p1f2 = false, p2f2 = false, p1f3 = false, p2f3 = false;
        private bool[] slots = new bool[5];
        private float pExtras1 = 0.00f, pExtras3 = 0.00f;
        private List<Producto> listaProductos = new List<Producto>();
        
        private List<Extra> listaExtras1 = new List<Extra>();
        private List<Extra> listaExtras3 = new List<Extra>();


        private List<Extra> catalogoExtras = creaExtras();

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
                    if (listaProductos.Count > 0)
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
                        MostrarPantallaFinal();
                    }


                    break;
                case 5:
                    MostrarPantallaFinal();

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
        private float calculoPrecioTotal(List<Producto> listaProductos, float pExtras1, float pExtras3)
        {
            float suma = 0.00f;
            for (int i = 0; i < listaProductos.Count; i++)
            {
                suma += listaProductos[i].Precio;
            }

            //return (suma + pExtras1 + pExtras3).ToString("F2");
            return (suma + pExtras1 + pExtras3);
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
            MostrarProducto(1);
        }
        private void btnProducto2_Click(object sender, EventArgs e)
        {
            MostrarProducto(2);
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
            MostrarExtras();
        }

        // MOSTRAR
        private void MostrarProducto(int producto)
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
        private void MostrarExtras()
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
        private void MostrarPantallaFinal()
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


            userControl3.Visible = true;
            userControl3.BringToFront();


            lbl_total1.Visible = true;
            lbl_total2.Visible = true;
            btn_añadirPagar.Enabled = false;
            btn_añadirPagar.Text = "Pagar e imprimir ticket";

            lbl_descripcionTitulo.Text = "Instrucciones";

            if (listaProductos.Count == 0)
            {
                lbl_tipoProducto.Text = "Compra cancelada";
                lbl_descripcion.Text = "¡Una pena, esperamos verte pronto!";
                lbl_total1.Text = " ";
                lbl_total2.Text = " ";
            }
            else
            {
                lbl_tipoProducto.Text = "Pantalla de pago";
                lbl_descripcion.Text = "Selecciona un método de pago y presiona 'Pagar e imprimir ticket'";
            }
        }
        private void btn_añadirPagar_Click(object sender, EventArgs e)
        {

            // Hasta la fase dos todavía se repite el ciclo una vez más
            if (fase <= 4)
            {
                switch (fase)
                {
                    case 1:
                        Comida c;
                        // Producto fase 1
                        if (p1f1)
                        {
                            List<string> ing1 = new List<string>() { "Pan", "Carne de Vacuno", "Queso Cheddar", "Lechuga", "Pepinillos", "Ketchup" };
                            c = new Comida("BurgAndrés", 1.65f, 300, ing1, "Carnivora", 150);
                            listaProductos.Add(c);
                            pro1.Text = c.Nombre;
                            pre1.Text = "+ " + c.Precio.ToString("F2") + "€";
                            slots[0] = true;
                        }
                        if (p2f1)
                        {
                            List<string> ing2 = new List<string>() { "Pan", "Doble Carne de Vacuno", "Doble Queso", "Bacon", "Lechuga", "Cebolla", "Mostaza" };
                            c = new Comida("BigAdri", 4.50f, 600, ing2, "Carnivora", 150);
                            listaProductos.Add(c);
                            pro1.Text = c.Nombre;
                            pre1.Text = "+ " + c.Precio.ToString("F2") + "€";
                            slots[0] = true;
                        }
                        // Extras fase 1
                        if (userControl1.bstate1) listaExtras1.Add(catalogoExtras[0]);
                        if (userControl1.bstate2) listaExtras1.Add(catalogoExtras[1]);
                        if (userControl1.bstate3) listaExtras1.Add(catalogoExtras[2]);
                        if (userControl1.bstate4) listaExtras1.Add(catalogoExtras[3]);
                        if (userControl1.bstate5) listaExtras1.Add(catalogoExtras[4]);
                        if (userControl1.bstate6) listaExtras1.Add(catalogoExtras[5]);

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
                        userControl1.numeroExtras = 0;
                        IrAlMenu();
                        CargarFase();
                        break;
                    case 2:
                        // Producto fase 2
                        Bebida b;
                        if (p1f2)
                        {
                            b = new Bebida("Refrigerio 250ml", 3.00f, 400, 250);
                            listaProductos.Add(b);
                            pro2.Text = b.Nombre;
                            pre2.Text = "+ " + b.Precio.ToString("F2") + "€";
                            slots[2] = true;
                        }
                        if (p2f2)
                        {
                            b = new Bebida("Agua 300ml", 1.00f, 25, 300);
                            listaProductos.Add(b);
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
                            listaProductos.Add(cc);
                            pro3.Text = cc.Nombre;
                            pre3.Text = "+ " + cc.Precio.ToString("F2") + "€";
                            slots[3] = true;
                        }
                        if (p2f3)
                        {
                            List<string> comp2 = new List<string>() { "Pollo (25%)", "Queso crema", "Ajo", "Sal", "Pimienta", "Harina refinada", "Pan rallado", "Aceite de palma" };
                            cc = new Complemento("PoNuggets", 9.00f, 600, comp2, 6);
                            listaProductos.Add(cc);
                            pro3.Text = cc.Nombre;
                            pre3.Text = "+ " + cc.Precio.ToString("F2") + "€";
                            slots[3] = true;
                        }
                        // Extras fase 4
                        if (userControl1.bstate1) listaExtras3.Add(catalogoExtras[0]);
                        if (userControl1.bstate2) listaExtras3.Add(catalogoExtras[1]);
                        if (userControl1.bstate3) listaExtras3.Add(catalogoExtras[2]);
                        if (userControl1.bstate4) listaExtras3.Add(catalogoExtras[3]);
                        if (userControl1.bstate5) listaExtras3.Add(catalogoExtras[4]);
                        if (userControl1.bstate6) listaExtras3.Add(catalogoExtras[5]);

                        for (int i = 0; i < listaExtras3.Count; i++)
                        {
                            pExtras3 += listaExtras3[i].Precio;

                            if (pExtras3 > 0)
                            {
                                pro3Extras.Text = userControl1.numeroExtras + " extras";
                                pre3Extras.Text = "+ " + pExtras3.ToString("F2") + "€";
                                slots[4] = true;
                            }
                        }

                        userControl1.numeroExtras = 0;
                        CargarFase();

                        break;
                    case 4:
                        //Nos encontramos en la pantalla de quitar productos y al presionar se va a recalcular el precio
                        // Productos

                        if (userControl2.bstate1)
                        {
                            Producto comida = listaProductos.FirstOrDefault(p => p is Comida);
                            if (comida != null)
                            {
                                listaProductos.Remove(comida);
                            }

                            pro1.Text = " ";
                            pre1.Text = " ";
                            pro1.BackColor = Color.FromArgb(255, 249, 244);
                            pre1.BackColor = Color.FromArgb(255, 249, 244);
                        }
                        if (userControl2.bstate3)
                        {
                            Producto bebida = listaProductos.FirstOrDefault(p => p is Bebida);
                            if (bebida != null)
                            {
                                listaProductos.Remove(bebida);
                            }

                            pro2.Text = " ";
                            pre2.Text = " ";
                            pro2.BackColor = Color.FromArgb(255, 249, 244);
                            pre2.BackColor = Color.FromArgb(255, 249, 244);
                        }
                        if (userControl2.bstate4)
                        {
                            Producto complemento = listaProductos.FirstOrDefault(p => p is Complemento);
                            if (complemento != null)
                            {
                                listaProductos.Remove(complemento);
                            }

                            pro3.Text = " ";
                            pre3.Text = " ";
                            pro3.BackColor = Color.FromArgb(255, 249, 244);
                            pre3.BackColor = Color.FromArgb(255, 249, 244);
                        }
                        // Extras
                        if (userControl2.bstate2)
                        {
                            pExtras1 = 0;

                            pro1Extras.Text = " ";
                            pre1Extras.Text = " ";
                            pro1Extras.BackColor = Color.FromArgb(255, 249, 244);
                            pre1Extras.BackColor = Color.FromArgb(255, 249, 244);
                        }
                        if (userControl2.bstate5)
                        {
                            pExtras3 = 0;

                            pro3Extras.Text = " ";
                            pre3Extras.Text = " ";
                            pro3Extras.BackColor = Color.FromArgb(255, 249, 244);
                            pre3Extras.BackColor = Color.FromArgb(255, 249, 244);
                        }

                        // Recalcular el precio con los nuevos parámetros
                        lbl_total2.Text = calculoPrecioTotal(listaProductos, pExtras1, pExtras3).ToString("F2") + "€";
                        CargarFase();
                        break;
                    case 5:
                        break;
                    default: break;
                }
                userControl1.ResetState();
            }
        }
    }
}
