using BurgerLibrary.Modelo.Productos;
using System.Text.Json;

namespace Entrega2Eval_JavierReyes
{
    public partial class Form1 : Form
    {
        // VARIABLE DE FASE 
        public int fase = 0;

        // RELACIÓN "OPCIÓN SELECCIONADA"-"FASE": INDICAN SI UNA OPCIÓN HA SIDO SELECCIONADO EN UNA FASE
        private bool o1f1 = false, o2f1 = false, o1f2 = false, o2f2 = false, o1f3 = false, o2f3 = false;

        // ARRAY DE BOOLEANOS PARA LA GESTIÓN DE LOS BOTONES DE BORRADP DE userControl2
        private bool[] slots = new bool[5];

        // LISTAS CON LOS PRODUCTOS SELECCIONADOS QUE SE INCLUIRÁN EN LA FACTURA
        private List<Producto> factura = new List<Producto>();

        // LISTA CON EL HISTÓRICO DE FACTURAS DEL PROGRAMA
        private List<Factura> historicoDeFacturas = new List<Factura>();

        // CREACIÓN DE UN CATÁLOGO DE EXTRAS
        private List<Extra> catalogoExtras = CreaExtras();

        // VARIABLE BOOLEANA PARA LA SALIDA SIN COMPRA
        private bool sinCompra;

        public Form1()
        {
            InitializeComponent();
            InitUI();
            CargarFase();
            MostrarPantallaMenu();
            SuscribirMetodosUserControl2();
        }

        // SE SUSCRIBEN LOS MÉTODOS A LOS EVENTOS BUTTONCLICK DE UserControl2
        private void SuscribirMetodosUserControl2()
        {
            userControl2.Button1Click += UserControl2_Button1Click;
            userControl2.Button3Click += UserControl2_Button3Click;
            userControl2.Button4Click += UserControl2_Button4Click;
        }

        // EVENTO BUTTONCLICK DEL Button1 EN UserControl2
        private void UserControl2_Button1Click(object sender, EventArgs e)
        {
            // SI EL BOTÓN DE CANCELACIÓN DEL PRODUCTO 1 (Comida) HA SIDO PRESIONADO
            if (userControl2.bstate1)
            {
                // LOS FONDOS DE LA INFORMACIÓN DEL PRODUCTO Y SUS EXTRAS SE VUELVEN ROJO
                pro1.BackColor = Color.FromArgb(252, 96, 96);
                pre1.BackColor = Color.FromArgb(252, 96, 96);
                pro1Extras.BackColor = Color.FromArgb(252, 96, 96);
                pre1Extras.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // LOS FONDOS DE LA INFORMACIÓN DEL PRODUCTO Y SUS EXTRAS TOMAN EL COLOR ORIGINAL
                pro1.BackColor = Color.FromArgb(255, 249, 244);
                pre1.BackColor = Color.FromArgb(255, 249, 244);
                pro1Extras.BackColor = Color.FromArgb(255, 249, 244);
                pre1Extras.BackColor = Color.FromArgb(255, 249, 244);
            }
        }

        // EVENTO BUTTONCLICK DEL Button3 EN UserControl2
        private void UserControl2_Button3Click(object sender, EventArgs e)
        {
            // SI EL BOTÓN DE CANCELACIÓN DEL PRODUCTO 2 (Bebida) HA SIDO PRESIONADO
            if (userControl2.bstate3)
            {
                // LOS FONDOS DE LA INFORMACIÓN DEL PRODUCTO SE VUELVEN ROJOS
                pro2.BackColor = Color.FromArgb(252, 96, 96);
                pre2.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // LOS FONDOS DE LA INFORMACIÓN DEL PRODUCTO TOMAN EL COLOR ORIGINAL
                pro2.BackColor = Color.FromArgb(255, 249, 244);
                pre2.BackColor = Color.FromArgb(255, 249, 244);
            }
        }

        // EVENTO BUTTONCLICK DEL Button4 EN UserControl2
        private void UserControl2_Button4Click(object sender, EventArgs e)
        {
            // SI EL BOTÓN DE CANCELACIÓN DEL PRODUCTO 3 (Complemento) HA SIDO PRESIONADO
            if (userControl2.bstate4)
            {
                // LOS FONDOS DE LA INFORMACIÓN DEL PRODUCTO Y SUS EXTRAS SE VUELVEN ROJOS
                pro3.BackColor = Color.FromArgb(252, 96, 96);
                pre3.BackColor = Color.FromArgb(252, 96, 96);
                pro3Extras.BackColor = Color.FromArgb(252, 96, 96);
                pre3Extras.BackColor = Color.FromArgb(252, 96, 96);
            }
            else
            {
                // LOS FONDOS DE LA INFORMACIÓN DEL PRODUCTO Y SUS EXTRAS TOMAN EL COLOR ORIGINAL
                pro3.BackColor = Color.FromArgb(255, 249, 244);
                pre3.BackColor = Color.FromArgb(255, 249, 244);
                pro3Extras.BackColor = Color.FromArgb(255, 249, 244);
                pre3Extras.BackColor = Color.FromArgb(255, 249, 244);
            }
        }

        // DEVUELVE UN CATÁLOGO DE EXTRAS 
        private static List<Extra> CreaExtras()
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
        }

        // SE INICIALIZAN PROPIEDADES GENERALES DEL FORM1
        private void InitUI()
        {
            // TAMAÑO DEL FORM FIJO, PARA QUE NO SE PUEDA VARIAR SU TAMAÑO
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // SE QUITAN LOS BOTONES DE MAXIMIZAR Y MINIMIZAR
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        // SI SE CIERRA "Form1" SE APAGA LA APLICACIÓN 
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra el Form1 se cierra la aplicación
            Application.Exit();
        }

        // SE SUMA Y CARGA UNA NUEVA FASE
        private void CargarFase()
        {
            fase++;

            /*
             * FASE 1: HAMBURGUESAS
             * FASE 2: BEBIDAS
             * FASE 3: COMPLEMENTOS
             * FASE 4: BORRADO DE PRODUCTOS
             * FASE 5: ÚLTIMOS DETALLES
             * FASE 6: FACTURA
             */

            switch (fase)
            {
                case 1:
                    // SE CARGA INFORMACIÓN SOBRE LAS HAMBURGUESAS
                    lbl_tipoProducto.Text = "Hamburguesa";
                    lbl_nombreProducto1.Text = "BurgAndrés";
                    lbl_precioProducto1.Text = "1,65€";
                    lbl_nombreProducto2.Text = "BigAdri";
                    lbl_precioProducto2.Text = "4,50€";

                    // SE CARGAN LAS IMÁGENES DE LA FASE DE LAS HAMBURGUESAS                                 
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("img\\Hamburguesas\\burgAndrés.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("img\\Hamburguesas\\bigAdri.jpg");
                    btnExtras.BackgroundImage = System.Drawing.Image.FromFile("img\\Otros\\bbqdip.jpg");
                    btnExtras.Visible = true;
                    break;

                case 2:
                    // SE CARGA INFORMACIÓN SOBRE LAS BEBIDAS
                    lbl_tipoProducto.Text = "Bebida";
                    lbl_nombreProducto1.Text = "AdriCola";
                    lbl_precioProducto1.Text = "3,00€";
                    lbl_nombreProducto2.Text = "Agua";
                    lbl_precioProducto2.Text = "1,00€";

                    // SE CARGAN LAS IMÁGENES DE LA FASE DE LAS BEBIDAS   
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("img\\Bebidas\\adricola.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("img\\Bebidas\\agua.jpg");
                    btnExtras.Visible = false;
                    break;

                case 3:
                    // SE CARGA INFORMACIÓN SOBRE LOS COMPLEMENTOS
                    lbl_tipoProducto.Text = "Complemento";
                    lbl_nombreProducto1.Text = "Croquetas";
                    lbl_precioProducto1.Text = "9,00€";
                    lbl_nombreProducto2.Text = "PoNuggets";
                    lbl_precioProducto2.Text = "9,00€";

                    // SE CARGAN LAS IMÁGENES DE LA FASE DE LOS COMPLEMENTOS   
                    btnProducto1.BackgroundImage = System.Drawing.Image.FromFile("img\\Complementos\\croquetas.jpg");
                    btnProducto2.BackgroundImage = System.Drawing.Image.FromFile("img\\Complementos\\nuggets.jpg");
                    btnExtras.BackgroundImage = System.Drawing.Image.FromFile("img\\Otros\\bbqdip.jpg");
                    btnExtras.Visible = true;
                    break;

                case 4:
                    // SI NINGUNO DE LOS ELEMENTOS DE LA FACTURA ES NULL (EXISTEN PRODUCTOS)
                    if (!(factura.All(factura => factura == null)))
                    {
                        // SE CONFIGURAN LOS ELEMENTOS PARA EL MENÚ DE BORRADO DE PRODUCTOS
                        lbl_tipoProducto.Text = "¿Quitamos algo?";
                        btn_añadirPagar.Text = "Continuar";
                        lbl_descripcionTitulo.Text = "Instrucciones";
                        lbl_descripcion.Text = "Quita aquellos productos que no te interesen de tu pedido";

                        // TLP DE BORRADO DE ITEMS VISIBLE
                        userControl2.Visible = true;
                        userControl2.BringToFront();

                        // BOTÓN DE CANCELAR VISIBLE
                        btn_cancelar.Visible = false;

                        // SE EVALUA QUÉ PRODUCTOS HAN SIDO ESCOGIDOS PARA QUE EL MENÚ DE BORRADO DE PRODUCTOS SEPA QUÉ BOTONES DE BORRADO MOSTRAR
                        ComprobarBotones();
                    }
                    // SI TODOS LOS ELEMENTOS DE LA FACTURA SON NULL (NO EXISTEN PRODUCTOS)
                    else
                    {
                        // SE MUESTRA LA PANRALLA DE SALIDA SIN COMPRA
                        MostrarPantallaSalidaSinCompra();
                    }
                    break;

                case 5:
                    // SE MUESTRA LA PANTALLA DE ÚLTIMOS DETALLES
                    MostrarPantallaUltimosDetalles();
                    break;

                case 6:
                    // SE MUESTRA LA PANTALLA DE FACTURA
                    MostrarPantallaFactura(factura);
                    break;

                // EN CUALQUIER OTRO CASO, SE MUESTRA UN MENSAJE DE ERROR EN lbl_descripcion
                default:
                    lbl_descripcion.Text = "Error";
                    break;
            }
        }

        // DEVUELVE EL PRECIO TOTAL DE "factura"
        private float calculoPrecioTotal(List<Producto> factura)
        {
            float suma = 0.00f;
            for (int i = 0; i < factura.Count; i++)
            {
                // CUANDO NO SE SELECCIONA UN PRODUCTO, SE CREA UN PRODUCTO CON VALOR NULL DE FORMA TEMPORAL
                // PARA EL CÁLCULO DEL PRECIO TOTAL SOLO SE TIENE EN CUENTA EL PRECIO DE LOS PRODUCTOS QUE NO SON NULL
                if (factura[i] != null) suma += factura[i].Precio;
            }
            return (suma);
        }

        /* EN LAS FASES 1, 2 Y 3 EXISTEN DOS OPCIONES DE PRODUCTO, CADA UNA ASIGNADA A UN BOTÓN
         * POR EJEMPLO, EN LA FASE 1 EXISTE LA "BurgAndrés" (btnProducto1) y la "BigAdri" (btnProducto2)
         * CADA UNA DE ESAS DOS OPCIONES TIENE UN EVENTO ASOCIADO */

        // AL HACER CLICK SOBRE EL BOTÓN DE PRODUCTO 1 TIENE LUGAR EL EVENTO DE SELECCIÓN DEL PRODUCTO 1
        private void btnProducto1_Click(object sender, EventArgs e) { EventoSeleccionProducto(1); }

        // AL HACER CLICK SOBRE EL BOTÓN DE PRODUCTO 2 TIENE LUGAR EL EVENTO DE SELECCIÓN DEL PRODUCTO 2
        private void btnProducto2_Click(object sender, EventArgs e) { EventoSeleccionProducto(2); }

        // EVENTO DE SELECCIÓN DEL PRODUCTO 1 O 2 (EL NÚMERO DE PRODUCTO ENTRA COMO PARÁMETRO)
        private void EventoSeleccionProducto(int opcion)
        {
            // AJUSTES DEPENDIENTES DE LA OPCIÓN ESCOGIDA
            // SI UN PRODUCTO SE HA ESCOGIDO EL COLOR DE FONDO DEL TAG DE SU NOMBRE Y PRECIO SE PONEN  
            // VERDES Y EL COLOR DE FONDO DEL TAG DEL NOMBRE Y PRECIO DEL PRODUCTO 2 SE PONEN NEGROS.           
            if (opcion == 1)
            {
                tlp6.BackColor = Color.FromArgb(22, 134, 55);
                tlp7.BackColor = Color.Black;
                if (fase == 1) o1f1 = true;
                if (fase == 2) o1f2 = true;
                if (fase == 3) o1f3 = true;
            }
            else if (opcion == 2)
            {
                tlp7.BackColor = Color.FromArgb(22, 134, 55);
                tlp6.BackColor = Color.Black;
                if (fase == 1) o2f1 = true;
                if (fase == 2) o2f2 = true;
                if (fase == 3) o2f3 = true;
            }

            // AJUSTES COMUNES EN EL EVENTO
            lbl_añadirExtras.BackColor = Color.Black;
            btn_añadirPagar.Text = "Añadir";
            btn_cancelar.Visible = true;
            lbl_descripcionTitulo.Text = "Ingredientes:";

            // AJUSTES DEPENDIENTES TANTO DE LA FASE COMO DE LA OPCIÓN ESCOGIDA
            switch (fase)
            {
                case 1:
                    lbl_descripcion.Text = (opcion == 1) ? "Pan, Carne de Vacuno, Queso Cheddar, Lechuga, Pepinillos, Ketchup." :
                                                            "Pan, Doble Carne de Vacuno, Doble Queso, Bacon, Lechuga, Cebolla, Mostaza.";
                    tlpExtras.Visible = true;

                    break;
                case 2:
                    lbl_descripcionTitulo.Text = "Descripción:";
                    lbl_descripcion.Text = (opcion == 1) ? "Un refresco 'AdriCola' de manzana refrescante (330ml)" :
                                                            "Una botella de agua (300ml)";

                    break;
                case 3:
                    lbl_descripcion.Text = (opcion == 1) ? "Leche entera, Mantequilla, Harina refinada, Jamón (25%), Huevo cocido, Pan rallado." :
                                                            "Pollo (25%), Queso crema, Ajo, Sal, Pimienta, Harina refinada, Pan rallado, Aceite de palma.";
                    tlpExtras.Visible = true;

                    break;
                default:
                    lbl_descripcion.Text = "Error";
                    break;
            }
        }

        // AL HACER CLICK SOBRE EL BOTÓN DE CANCELAR (btn_cancelar)
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // DEPENDIENDO DE LA FASE EN LA QUE SE ENCUENTRE EL USUARIO, SE PONE A FALSO AMBOS PRODUCTOS DE LA FASE
            switch (fase)
            {
                case 1:
                    o1f1 = false;
                    o2f1 = false;
                    break;
                case 2:
                    o1f2 = false;
                    o2f2 = false;
                    break;
                case 3:
                    o1f3 = false;
                    o2f3 |= false;
                    break;
                default:
                    lbl_tipoProducto.Text = "Error";
                    break;
            }

            // SE REINICIA LA PANTALLA DEL MENÚ Y DE LOS EXTRAS
            MostrarPantallaMenu();
            userControl1.ResetState();
        }

        // AL HACER CLICK SOBRE EL BOTÓN DE EXTRAS (btnExtras)
        private void btnExtras_Click(object sender, EventArgs e) { MostrarPantallaExtras(); }

        // AL HACER CLICK SOBRE EL BOTÓN VERDE INFERIOR (btn_añadirPagar)
        private void btn_añadirPagar_Click(object sender, EventArgs e)
        {
            // DEPENDIENDO DE LA FASE EN LA QUE SE ENCUENTRE EL USUARIO
            switch (fase)
            {
                case 1:
                    Comida c;
                    // OPCIÓN 1, FASE 1
                    if (o1f1)
                    {
                        List<string> ing1 = new List<string>() { "Pan", "Carne de Vacuno", "Queso Cheddar", "Lechuga", "Pepinillos", "Ketchup" };
                        c = new Comida("BurgAndrés", 1.65f, 300, ing1, "Carnivora", 150);
                        factura.Insert(0, c);
                        pro1.Text = c.Nombre;
                        pre1.Text = "+ " + c.Precio.ToString("F2") + "€";
                        slots[0] = true;
                    }
                    // OPCIÓN 2, FASE 1
                    else if (o2f1)
                    {
                        List<string> ing2 = new List<string>() { "Pan", "Doble Carne de Vacuno", "Doble Queso", "Bacon", "Lechuga", "Cebolla", "Mostaza" };
                        c = new Comida("BigAdri", 4.50f, 600, ing2, "Carnivora", 150);
                        factura.Insert(0, c);
                        pro1.Text = c.Nombre;
                        pre1.Text = "+ " + c.Precio.ToString("F2") + "€";
                        slots[0] = true;
                    }
                    else
                    {
                        // SE INSERTA UN PRODUCTO = NULL
                        factura.Insert(0, null);
                    }

                    // GESTIÓN DE LOS EXTRAS DE LA HAMBURGUESA
                    int contadorExtras1 = 0;
                    float precioExtras1 = 0.00f;
                    int caloriasExtras1 = 0;

                    if (userControl1.bstate1)
                    {
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[0].Precio;
                        caloriasExtras1 += catalogoExtras[0].Calorias;
                    }
                    if (userControl1.bstate2)
                    {
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[1].Precio;
                        caloriasExtras1 += catalogoExtras[1].Calorias;
                    }
                    if (userControl1.bstate3)
                    {
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[2].Precio;
                        caloriasExtras1 += catalogoExtras[2].Calorias;
                    }
                    if (userControl1.bstate4)
                    {
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[3].Precio;
                        caloriasExtras1 += catalogoExtras[3].Calorias;
                    }
                    if (userControl1.bstate5)
                    {
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[4].Precio;
                        caloriasExtras1 += catalogoExtras[4].Calorias;
                    }
                    if (userControl1.bstate6)
                    {
                        contadorExtras1++;
                        precioExtras1 += catalogoExtras[5].Precio;
                        caloriasExtras1 += catalogoExtras[5].Calorias;
                    }

                    if (contadorExtras1 > 0)
                    {
                        pro1Extras.Text = contadorExtras1 + " extras";
                        pre1Extras.Text = "+ " + precioExtras1.ToString("F2") + "€"; // Mostramos el precio total de los extras
                        slots[1] = true;
                        factura.Insert(1, new Extra("Extra(s) de la hamburguesa", precioExtras1, caloriasExtras1, 1));
                    }
                    else
                    {
                        factura.Insert(1, null);
                    }

                    // SE CONTINÚA MOSTRANDO LA PANTALLA DE MENÚ Y CARGANDO OTRA FASE
                    MostrarPantallaMenu();
                    CargarFase();
                    break;
                case 2:
                    Bebida b;
                    // OPCIÓN 1, FASE 2
                    if (o1f2)
                    {
                        b = new Bebida("Refrigerio 250ml", 3.00f, 400, 250);
                        factura.Insert(2, b);
                        pro2.Text = b.Nombre;
                        pre2.Text = "+ " + b.Precio.ToString("F2") + "€";
                        slots[2] = true;
                    }
                    // OPCIÓN 2, FASE 2
                    else if (o2f2)
                    {
                        b = new Bebida("Agua 300ml", 1.00f, 25, 300);
                        factura.Insert(2, b);
                        pro2.Text = b.Nombre;
                        pre2.Text = "+ " + b.Precio.ToString("F2") + "€";
                        slots[2] = true;
                    }
                    else
                    {
                        // SE INSERTA UN PRODUCTO = NULL
                        factura.Insert(2, null);
                    }

                    // SE CONTINÚA MOSTRANDO LA PANTALLA DE MENÚ Y CARGANDO OTRA FASE
                    MostrarPantallaMenu();
                    CargarFase();
                    break;

                case 3:
                    Complemento cc;
                    // OPCIÓN 1, FASE 3
                    if (o1f3)
                    {
                        List<string> comp1 = new List<string>() { "Leche entera", "Mantequilla", "Harina refinada", "Jamon (25%)", "Huevo cocido", "Pan rallado" };
                        cc = new Complemento("Croquetas", 9.00f, 600, comp1, 6);
                        factura.Insert(3, cc);
                        pro3.Text = cc.Nombre;
                        pre3.Text = "+ " + cc.Precio.ToString("F2") + "€";
                        slots[3] = true;
                    }
                    // OPCIÓN 2, FASE 3
                    else if (o2f3)
                    {
                        List<string> comp2 = new List<string>() { "Pollo (25%)", "Queso crema", "Ajo", "Sal", "Pimienta", "Harina refinada", "Pan rallado", "Aceite de palma" };
                        cc = new Complemento("PoNuggets", 9.00f, 600, comp2, 6);
                        factura.Insert(3, cc);
                        pro3.Text = cc.Nombre;
                        pre3.Text = "+ " + cc.Precio.ToString("F2") + "€";
                        slots[3] = true;
                    }
                    else
                    {
                        // SE INSERTA UN PRODUCTO = NULL
                        factura.Insert(3, null);
                    }

                    // GESTIÓN DE LOS EXTRAS DE LOS COMPLEMENTOS
                    int contadorExtras3 = 0;
                    float precioExtras3 = 0.00f;
                    int caloriasExtras3 = 0;

                    if (userControl1.bstate1)
                    {
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[0].Precio;
                        caloriasExtras3 += catalogoExtras[0].Calorias;
                    }
                    if (userControl1.bstate2)
                    {
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[1].Precio;
                        caloriasExtras3 += catalogoExtras[1].Calorias;
                    }
                    if (userControl1.bstate3)
                    {
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[2].Precio;
                        caloriasExtras3 += catalogoExtras[2].Calorias;
                    }
                    if (userControl1.bstate4)
                    {
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[3].Precio;
                        caloriasExtras3 += catalogoExtras[3].Calorias;
                    }
                    if (userControl1.bstate5)
                    {
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[4].Precio;
                        caloriasExtras3 += catalogoExtras[4].Calorias;
                    }
                    if (userControl1.bstate6)
                    {
                        contadorExtras3++;
                        precioExtras3 += catalogoExtras[5].Precio;
                        caloriasExtras3 += catalogoExtras[5].Calorias;
                    }

                    if (contadorExtras3 > 0)
                    {
                        pro3Extras.Text = contadorExtras3 + " extras";
                        pre3Extras.Text = "+ " + precioExtras3.ToString("F2") + "€";
                        slots[4] = true;

                        factura.Insert(4, new Extra("Extra(s) del complemento", precioExtras3, caloriasExtras3, 1));
                    }
                    else
                    {
                        // SE INSERTA UN PRODUCTO = NULL
                        factura.Insert(4, null);
                    }

                    // SE CONTINÚA CARGANDO OTRA FASE PERO NO SE MUESTRA LA PANTALLA DE MENÚ
                    CargarFase();
                    break;

                case 4:
                    // SI NO HAY PRODUCTOS SE CIERRA LA APLICACIÓN
                    if (sinCompra) { Application.Exit(); }
                    else
                    {
                        // NOS ENCONTRAMOS EN LA PANTALLA DE QUITAR PRODUCTOS Y AL PRESIONAR EL "btn_añadirPagar" SE VA A RECALCULAR EL PRECIO

                        // SI AL PRESIONAR "btn_añadirPagar", EL PRIMER BOTÓN DE BORRADO DE PRODUCTO ESTÁ ACTIVADO, SE PONE LA HAMBURGUESA Y SUS EXTRAS A NULL
                        if (userControl2.bstate1)
                        {
                            factura[0] = null;
                            factura[1] = null;
                        }

                        // SI AL PRESIONAR "btn_añadirPagar", EL SEGUNDO BOTÓN DE BORRADO DE PRODUCTO ESTÁ ACTIVADO, SE PONE LA BEBIDA A NULL
                        if (userControl2.bstate3)
                        {
                            factura[2] = null;

                        }

                        // SI AL PRESIONAR "btn_añadirPagar", EL TERCER BOTÓN DE BORRADO DE PRODUCTO ESTÁ ACTIVADO, SE PONE EL COMPLEMENTO Y SUS EXTRAS A NULL
                        if (userControl2.bstate4)
                        {
                            factura[3] = null;
                            factura[4] = null;
                        }

                        // SI NO TODOS LOS ELEMENTOS DE "factura" SON NULL,SE RECALCULA EL PRECIO CON LOS NUEVOS PARÁMETROS Y SE CARGA NUEVA FASE
                        if (!factura.All(factura => factura == null))
                        {
                            lbl_total2.Text = calculoPrecioTotal(factura).ToString("F2") + "€";
                            CargarFase();
                        }
                        // SI TODOS LOS ELEMENTOS DE "factura" SON NULL SE PASA A LA PANTALLA DE SALIDA SIN COMPRA
                        else
                        {
                            MostrarPantallaSalidaSinCompra();
                        }
                    }
                    break;

                case 5:
                    // SE ESTÁ MOSTRANDO LA PANTALLA DE "ÚLTIMOS DETALLES", SI SE PRESIONA "btn_añadirPagar" SE CARGA UNA NUEVA FASE 
                    CargarFase();
                    break;

                case 6:
                    // SE ESTÁ MOSTRANDO LA PANTALLA DE "FACTURA", SI SE PRESIONA "btn_añadirPagar" SE CIERRA LA APLICACIÓN
                    Application.Exit();
                    break;

                default: break;
            }
            // SE RESETEA EL COMPONENTE DE EXTRAS PARA QUE SE DESELECCIONEN LOS PANELES
            userControl1.ResetState();
        }

        // SE MUESTRA LA PANTALLA EN LA QUE SE SELECCIONAN LOS PRODUCTOS DEL MENÚ
        private void MostrarPantallaMenu()
        {
            // ELEMENTOS DE "PRODUCTOS" VISIBLES
            tlp5.Visible = true;
            tlp5.BringToFront();

            // ELEMENTOS DE "EXTRAS" INVISIBLES
            userControl1.Visible = false;
            userControl1.SendToBack();
            tlpExtras.Visible = false;

            // ELEMENTOS DE "BORRADO" INVISIBLES
            userControl2.Visible = false;
            userControl2.SendToBack();

            // BOTÓN DE CANCELAR INVISIBLE
            btn_cancelar.Visible = false;

            // SE INICIALIZAN ELEMENTOS COMUNES
            tlp6.BackColor = Color.Black;
            tlp7.BackColor = Color.Black;
            lbl_añadirExtras.BackColor = Color.Black;
            lbl_descripcionTitulo.Text = "Instrucciones";
            lbl_descripcion.Text = "Selecciona un producto y presiona el botón de \"Añadir\" para agregarlo a tu pedido o continúa sin pedir nada seleccionando \"No quiero, gracias\"";
            btn_añadirPagar.Text = "No quiero, gracias";

            // DEPENDIENDO DE LA FASE, SE INICIALIZA EL TEXTO DE "lbl_tipoProducto"
            switch (fase)
            {
                case 1:
                    lbl_tipoProducto.Text = "Hamburguesa";
                    break;
                case 2:
                    lbl_tipoProducto.Text = "Bebida";
                    break;
                case 3:
                    lbl_tipoProducto.Text = "Complemento";
                    break;
                default:
                    lbl_tipoProducto.Text = "Error";
                    break;
            }
        }

        // SE MUESTRA LA PANTALLA EN LA QUE SE SELECCIONAN LOS EXTRAS DE UN PRODUCTO
        private void MostrarPantallaExtras()
        {
            userControl1.ResetState();

            // ELEMENTOS DE "EXTRAS" VISIBLES
            userControl1.Visible = true;
            userControl1.BringToFront();
            tlpExtras.Visible = true;

            // ELEMENTOS DE "PRODUCTOS" INVISIBLES
            tlp5.Visible = false;
            tlp5.SendToBack();

            // ELEMENTOS DE "BORRADO" INVISIBLES
            userControl2.Visible = false;
            userControl2.SendToBack();

            // BOTÓN DE CANCELAR VISIBLE
            btn_cancelar.Visible = true;

            //SE INICIALIZAN ELEMENTOS COMUNES
            userControl1.labelExtras1.BackColor = Color.Black;
            userControl1.labelExtras2.BackColor = Color.Black;
            userControl1.labelExtras3.BackColor = Color.Black;
            userControl1.labelExtras4.BackColor = Color.Black;
            userControl1.labelExtras5.BackColor = Color.Black;
            userControl1.labelExtras6.BackColor = Color.Black;
            userControl1.panelColor1.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor2.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor3.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor4.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor5.BackColor = Color.FromArgb(255, 152, 83);
            userControl1.panelColor6.BackColor = Color.FromArgb(255, 152, 83);
            btn_añadirPagar.Text = "Añadir";
            lbl_descripcionTitulo.Text = "Extra-rico";

            // SE CARGAN LAS IMÁGENES
            userControl1.buttonExtras1.Image = System.Drawing.Image.FromFile("img\\Extras\\extraPatty.jpg");
            userControl1.buttonExtras2.Image = System.Drawing.Image.FromFile("img\\Extras\\extraBacon.jpg");
            userControl1.buttonExtras3.Image = System.Drawing.Image.FromFile("img\\Extras\\extraLechuga.jpg");
            userControl1.buttonExtras4.Image = System.Drawing.Image.FromFile("img\\Extras\\extraOnion.jpg");
            userControl1.buttonExtras5.Image = System.Drawing.Image.FromFile("img\\Extras\\extraQueso.jpg");
            userControl1.buttonExtras6.Image = System.Drawing.Image.FromFile("img\\Extras\\bbqdip.jpg");

            // SE CARGAN LOS TEXTOS
            lbl_tipoProducto.Text = "Extras";
            userControl1.labelExtras1.Text = catalogoExtras[0].Nombre;
            userControl1.labelExtras2.Text = catalogoExtras[1].Nombre;
            userControl1.labelExtras3.Text = catalogoExtras[2].Nombre;
            userControl1.labelExtras4.Text = catalogoExtras[3].Nombre;
            userControl1.labelExtras5.Text = catalogoExtras[4].Nombre;
            userControl1.labelExtras6.Text = catalogoExtras[5].Nombre;

            // SE CARGAN LOS PRECIOS
            userControl1.precioExtras1.Text = catalogoExtras[0].Precio.ToString("F2") + " €";
            userControl1.precioExtras2.Text = catalogoExtras[1].Precio.ToString("F2") + " €";
            userControl1.precioExtras3.Text = catalogoExtras[2].Precio.ToString("F2") + " €"; ;
            userControl1.precioExtras4.Text = catalogoExtras[3].Precio.ToString("F2") + " €";
            userControl1.precioExtras5.Text = catalogoExtras[4].Precio.ToString("F2") + " €";
            userControl1.precioExtras6.Text = catalogoExtras[5].Precio.ToString("F2") + " €";

            // DEPENDIENDO DE LA FASE, SE INICIALIZA EL TEXTO DE "lbl_descripcion"
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

        // SE MUESTRA LA PANTALLA DE SALIDA SIN COMPRA
        private void MostrarPantallaSalidaSinCompra()
        {
            // SE CARGAN UNA SERIE DE TEXTOS PARA LA PANTALLA DE SALIDA SIN COMPRA
            lbl_tipoProducto.Text = "Compra cancelada";
            lbl_descripcionTitulo.Text = "Adiós";
            lbl_descripcion.Text = "¡Una pena, esperamos verte pronto!";
            btn_añadirPagar.Text = "Salir";

            // SE INVISIBILIZAN UNA SERE DE ELEMENTOS PARA FORMAR LA PANTALLA DE SALIDA SIN COMPRA
            lbl_total1.Visible = false;
            lbl_total2.Visible = false;
            tlpProducto1.Visible = false;
            tlpProducto2.Visible = false;
            tlpExtras.Visible = false;
            userControl2.tableLayoutGeneral.Visible = false;
            userControl2.pictureBanner.Visible = false;
            userControl3.btn_caja.Visible = false;
            userControl3.btn_tarjeta.Visible = false;
            userControl3.tb_observaciones.Visible = false;
            userControl3.lb_observaciones.Visible = false;

            // SE PONE LA VARIABLE "sinCompra" A TRUE
            sinCompra = true;
        }

        // SE MUESTRA LA PANRALLA DE ÚLTIMOS DETALLES
        private void MostrarPantallaUltimosDetalles()
        {
            // ELEMENTOS DE "ÚLTIMOS DETALLES" VISIBLES

            userControl3.Visible = true;
            userControl3.BringToFront();

            // ELEMENTOS DE "BORRADO" INVISIBLES
            userControl2.Visible = false;
            userControl2.SendToBack();

            // ELEMENTOS DE "PRODUCTOS" INVISIBLES
            tlp5.Visible = false;
            tlp5.SendToBack();

            // ELEMENTOS DE "EXTRAS" INVISIBLES
            userControl1.Visible = false;
            userControl1.SendToBack();

            // BOTÓN DE CANCELAR INVISIBLE
            btn_cancelar.Visible = false;

            // "TOTAL" Y PRECIO TOTAL VISIBLES
            lbl_total1.Visible = true;
            lbl_total2.Visible = true;

            // SE INICIALIZAN ELEMENTOS COMUNES
            btn_añadirPagar.Text = "Pagar e imprimir ticket";
            lbl_tipoProducto.Text = "Últimos detalles";
            lbl_descripcionTitulo.Text = "Instrucciones";
            lbl_descripcion.Text = "Selecciona un método de pago y añade una observación a tu pedido'";
            btn_añadirPagar.Text = "Aceptar";

            // SE VISIBILIZAN LOS BOTONES DE "PAGAR EN CAJA" Y "PAGAR CON TARJETA"
            // POR DEFECTO SE ACTIVA EL BOTÓN DE PAGAR EN CAJA Y SE PONE DE COLOR VERDE
            userControl3.btn_caja.Visible = true;
            userControl3.btn_tarjeta.Visible = true;
            userControl3.bstateCaja = true;
            userControl3.bstateTarjeta = false;
            userControl3.btn_caja.BackColor = Color.FromArgb(29, 171, 71);
        }

        // SE MUESTRA LA PANTALLA DE FACTURA
        public void MostrarPantallaFactura(List<Producto> factura)
        {
            // PANTALLA DE "FACTURA" VISIBLE
            userControl4.Visible = true;

            // ELEMENTOS DE "PRODUCTOS" INVISIBLES
            tlp5.Visible = false;
            tlp5.SendToBack();

            // ELEMENTOS DE "EXTRAS" INVISIBLES
            userControl1.Visible = false;
            userControl1.SendToBack();

            // ELEMENTOS DE "BORRADO" INVISIBLES
            userControl2.Visible = false;
            userControl2.SendToBack();

            // ELEMENTOS DE "ÚLTIMOS DETALLES" INVISIBLES
            userControl3.Visible = false;
            userControl3.SendToBack();

            // BOTÓN DE CANCELAR 
            btn_cancelar.Visible = false;

            // SE INICIALIZAN ELEMENTOS COMUNES
            lbl_tipoProducto.Text = "Tu pedido se ha realizado";
            btn_añadirPagar.Text = "Pagar";
            lbl_tipoProducto.Text = "Se ha generado tu factura";
            lbl_descripcionTitulo.Text = "¡Listo!";
            lbl_descripcion.Text = "Dale al botón de 'Pagar' para terminar";

            // SE RECOGE EL TEXTO DE "OBSERVACIONES" Y SE PASA COMO PARÁMETRO AL MÉTODO "GenerarFactura" JUNTO A LA FACTURA
            String observaciones = userControl3.tb_observaciones.Text;
            GenerarFactura(factura, observaciones);
        }

        // SE EVALUA QUÉ PRODUCTOS HAN SIDO ESCOGIDOS PARA QUE EL MENÚ DE BORRADO DE PRODUCTOS SEPA QUÉ BOTONES DE BORRADO MOSTRAR
        private void ComprobarBotones()
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
                userControl2.pb2.Visible = true;
            }
            else
            {
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
                userControl2.pb5.Visible = true;
            }
            else
            {
                userControl2.pb5.Visible = false;
            }
        }

        /*SE HA CREADO LA CLASE "PedidoManager" Y LA CLASE "Factura" PARA 
        GESTIONAR LAS FACTURAS Y EL REGISTRO DE LAS DISTINTAS FACTURAS */

        // SE HACE USO DE LA NUEVA CLASE "PedidoManager" PARA CREAR UN NUEVO REGISTRO EN facturas.json
        public void GenerarFactura(List<Producto> seleccionDeProductos, string observaciones)
        {
            PedidoManager pedidoManager = new PedidoManager();

            // SE GENERA UN ID DE PEDIDO
            int idPedido = pedidoManager.GenerarNuevoIdPedido();

            // SE ELIMINAN LOS ELEMENTOS NULOS DE LOS PRODUCTOS SELECCIONADOS
            seleccionDeProductos.RemoveAll(producto => producto == null);

            // SE LIMPIA EL LISTBOX ANTES DE AGREGAR NUEVOS ELEMENTOS
            userControl4.listBox1.Items.Clear();

            userControl4.listBox1.Items.Add($"ID Pedido: {idPedido}");
            userControl4.listBox1.Items.Add("==========================================================");
            userControl4.listBox1.Items.Add("                        FACTURA DE COMPRA        ");
            userControl4.listBox1.Items.Add("==========================================================");
            userControl4.listBox1.Items.Add("");

            // AGREGA CADA PRODUCTO A LA FACTURA Y CALCULA EL TOTAL
            float total = 0.00f;
            foreach (var producto in seleccionDeProductos)
            {
                // FORMATEA EL PRECIO CON PARÉNTESIS
                string precioFormateado = $"({producto.Precio:N2} €)";
                // AGREGA EL NOMBRE DEL PRODUCTO Y EL PRECIO CON PARÉNTESIS JUNTO CON EL ID DEL PEDIDO
                userControl4.listBox1.Items.Add($"{producto.Nombre} {precioFormateado}");
                total += producto.Precio;
            }

            userControl4.listBox1.Items.Add("----------------------------------------------------------");

            // AGREGA EL TOTAL AL FINAL DE LA FACTURA
            userControl4.listBox1.Items.Add($"{"TOTAL:",-20} {total,10:N2} €");

            // AGREGA LAS OBSERVACIONES AL FINAL DE LA FACTURA
            userControl4.listBox1.Items.Add("");
            userControl4.listBox1.Items.Add("OBSERVACIONES:");

            // SI NO SE HA INTRODUCIDO NINGUNA INTRODUCCIÓN SE ESCRIBE "Ninguna"
            if (observaciones == "")
            {
                observaciones = "Ninguna";
            }

            userControl4.listBox1.Items.Add(observaciones);

            // CREAR Y AGREGAR LA FACTURA A LA LISTA
            var factura = new Factura
            {
                IdPedido = idPedido,
                Comanda = seleccionDeProductos,
                Observaciones = observaciones,
                Total = total
            };

            // SE AÑADE LA FACTURA AL HISTÓRICO DE FACTURAS
            historicoDeFacturas.Add(factura);

            // SE GUARDA LA FACTURA ACTUAL EN UN "facturas.json"
            string facturaJson = JsonSerializer.Serialize(factura);
            using (StreamWriter sw = File.AppendText("facturas.json"))
            {
                sw.WriteLine(facturaJson);
            }

            // GUARDAR EL ÚLTIMO ID DE PEDIDO EN UN ARCHIVO
            pedidoManager.GuardarUltimoIdPedido();
        }
    }
}