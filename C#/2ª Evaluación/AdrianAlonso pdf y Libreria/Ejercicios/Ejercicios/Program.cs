using BurgerLibrary.Modelo;
using BurgerLibrary.Modelo.Productos;
using System.Text;
internal class Program
{

    private static void Main(string[] args)
    {


        //Añade codificacion UTF-8 para la salida por consola
        Console.OutputEncoding = Encoding.UTF8;

        /***************************************
         * *********************************** *
         * *                                 * *
         * * CREACION DE LISTAS DE PRODUCTOS * *
         * *                                 * *
         * *********************************** *
         ***************************************/
        //Propiedades
        int menu;

        //Listas de productos
        List<Comida> primeros = creaPrimeros();
        List<Bebida> bebidas = creaBebidas();
        List<Complemento> complementos = creaComplementos();
        List<Extra> extras = creaExtras();


        /***************************************
         * *********************************** *
         * *                                 * *
         * *        INICIO PROGROMA          * *
         * *                                 * *
         * *********************************** *
         ***************************************/


        //Mensajes de Bienvenida
        Console.WriteLine("Bienvenido a la Hamburgueseria McEnlaces! (ed. dual)");
        Ticket ticket = new Ticket();

        /***************************************
         * *********************************** *
         * *                                 * *
         * *      SELECCION PRIMEROS         * *
         * *                                 * *
         * *********************************** *
         ***************************************/

        Console.WriteLine("¿Qué vamos a querer hoy?");
        do
        {
            menu = recorrerProductos(primeros);
            if (menu < primeros.Count)
            {
                List<Extra> extrasElegidos = new List<Extra>();
                string nombre = primeros[menu].Nombre;
                float precio = primeros[menu].Precio;
                ticket.addLinea(nombre, precio);
                Console.WriteLine("¡Tu producto " + nombre + " ha sido añadido!\n");
                extrasElegidos = decisionExtras(primeros[menu], extras);
                foreach (Extra extraElegido in extrasElegidos)
                {
                    ticket.addLinea("Extra: "+extraElegido.Nombre, extraElegido.Precio);
                    
                }
                Console.WriteLine(ticket.imprimeTicket());
            }
        } while (menu < primeros.Count);
        /***************************************
         * *********************************** *
         * *                                 * *
         * *      SELECCION BEBIDAS          * *
         * *                                 * *
         * *********************************** *
         ***************************************/
        do
        {
            menu = recorrerProductos(bebidas);
            if (menu < bebidas.Count)
            {
                string nombre = bebidas[menu].Nombre;
                float precio = bebidas[menu].Precio;
                ticket.addLinea(nombre, precio);
                Console.WriteLine("¡Tu producto " + nombre + " ha sido añadido!\n");
                Console.WriteLine(ticket.imprimeTicket());
            }
        } while (menu < primeros.Count);
        /***************************************
         * *********************************** *
         * *                                 * *
         * *     SELECCION COMPLEMENTOS      * *
         * *                                 * *
         * *********************************** *
         ***************************************/
        do
        {
            menu = recorrerProductos(complementos);
            if (menu < complementos.Count)
            {
                List<Extra> extrasElegidos = new List<Extra>();
                string nombre = complementos[menu].Nombre;
                float precio = complementos[menu].Precio;
                ticket.addLinea(nombre, precio);
                Console.WriteLine("¡Tu producto " + nombre + " ha sido añadido!\n");
                extrasElegidos = decisionExtras(complementos[menu], extras);
                foreach (Extra extraElegido in extrasElegidos)
                {
                    ticket.addLinea("Extra: " + extraElegido.Nombre, extraElegido.Precio);
                    
                }
                Console.WriteLine(ticket.imprimeTicket());
            }
        } while (menu < primeros.Count);

        /***************************************
         * *********************************** *
         * *                                 * *
         * *       ELIMINACION LINEAS        * *
         * *                                 * *
         * *********************************** *
         ***************************************/
        int salir = ticket.getLineas().Count;
        do
        {
            salir = ticket.getLineas().Count;
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("¿Queremos eliminar alguna cosa?");
            Console.WriteLine(ticket.listTicket());
            Console.WriteLine(ticket.getLineas().Count + ". Salir");
            try
            {
                Console.Write("Introduzca una opción numérica: ");
                menu = int.Parse(Console.ReadLine());
                if (menu > ticket.getLineas().Count)
                {
                    throw new Exception();
                }
                else if (menu < ticket.getLineas().Count)
                {
                    ticket.delLinea(menu);
                }
            }
            catch (Exception e)
            {
                
                Console.WriteLine("Opción introducida incorreccta.");
            }
        }while (menu !=  salir);

        /***************************************
         * *********************************** *
         * *                                 * *
         * *         IMPRIMIR TICKET         * *
         * *                                 * *
         * *********************************** *
         ***************************************/
        Console.WriteLine("¡Muchas gracias por venir! ¡Que Disfrutes de tu pedido!");
        Console.WriteLine("Aquí tienes tu pedido y tu ticket");
        Console.WriteLine(ticket.imprimeTicket());
    }


    /// <summary>
    /// Devuelve una lista de objetos Complemento.
    /// La lista es nuestra base de datos para el buen funcionamiento del programa
    /// </summary>
    /// <returns>Lista de objetos Complemento</returns>
    private static List<Complemento> creaComplementos()
    {
        List<Complemento> complementos = new List<Complemento>();

        //Ingredientes complementos
        List<string> comp1 = new List<string>() { "Leche entera", "Mantequilla", "Harina refinada", "Jamon (25%)", "Huevo cocido", "Pan rallado" };
        List<string> comp2 = new List<string>() { "Pollo (25%)", "Queso crema", "Ajo", "Sal", "Pimienta", "Harina refinada", "Pan rallado", "Aceite de palma" };

        //Lista de complementos
        complementos.Add(new Complemento("Croquetas", 9.00f, 600, comp1, 6));
        complementos.Add(new Complemento("PoNuggets", 9.00f, 600, comp2, 6));
        return complementos;

    }
    /// <summary>
    /// Devuelve una lista de objetos Bebida.
    /// La lista es nuestra base de datos para el buen funcionamiento del programa
    /// </summary>
    /// <returns>Lista de objetos Bebida</returns>
    private static List<Bebida> creaBebidas()
    {
        List<Bebida> bebidas = new List<Bebida>();

        //Lista de bebidas
        bebidas.Add(new Bebida("Refrigerio 250ml", 3.00f, 400, 250));
        bebidas.Add(new Bebida("Agua 300ml", 1.00f, 25, 300));

        return bebidas;
    }
    /// <summary>
    /// Devuelve una lista de objetos Comida.
    /// La lista es nuestra base de datos para el buen funcionamiento del programa
    /// </summary>
    /// <returns>Lista de objetos Comida</returns>
    private static List<Comida> creaPrimeros()
    {
        List<Comida> primeros = new List<Comida>();

        //Ingredientes primeros
        List<string> ing1 = new List<string>() { "Pan", "Carne de Vacuno", "Queso Cheddar", "Lechuga", "Pepinillos", "Ketchup" };
        List<string> ing2 = new List<string>() { "Pan", "Doble Carne de Vacuno", "Doble Queso", "Bacon", "Lechuga", "Cebolla", "Mostaza" };

        //Lista de primeros
        primeros.Add(new Comida("BurgAndrés", 1.65f, 300, ing1, "Carnivora", 150));
        primeros.Add(new Comida("BigAdri", 4.50f, 600, ing2, "Carnivora", 150));
        return primeros;
    }
    /// <summary>
    /// Devuelve una lista de objetos Extra.
    /// La lista es nuestra base de datos para el buen funcionamiento del programa
    /// </summary>
    /// <returns>Lista de objetos Extra</returns>
    private static List<Extra> creaExtras()
    {
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

        return extra;
    }
    /// <summary>
    /// Recorre la lista que pasamos como parametro y nos pide que seleccionemos a traves
    /// de la introducción de un entero un producto de la lista.
    /// </summary>
    /// <param name="primeros">Lista de objetos Comida a recorrer por el método</param>
    /// <returns>Posicón del producto elegido dentro de la lista de objetos Comida</returns>
    private static int recorrerProductos(List<Comida> primeros)
    {

        int menu = 0;
        Console.WriteLine("-------------------------");
        Console.WriteLine("-------------------------\n");
        for (int i = 0; i < primeros.Count; i++)
        {
            string texto = "";
            texto += i + ". " + primeros[i].Nombre;
            while (texto.Length < 25)
            {
                texto += " ";
            }
            string precio = primeros[i].Precio.ToString("0.00");
            texto += precio + "€\n\t";
            List<string> ingredientes = primeros[i].getIngredientes();
            for (int j = 0; j < ingredientes.Count; j++)
            {
                int finalPos = ingredientes.Count - 1;

                if (ingredientes[j] == ingredientes[finalPos])
                {
                    texto += ingredientes[j] + ".";
                }
                else
                {
                    texto += ingredientes[j] + ", ";
                }
            }
            Console.WriteLine(texto);
        }
        Console.WriteLine(primeros.Count + ". Salir");
        while (true)
        {
            try
            {
                Console.Write("Introduzca una opción numérica: ");
                menu = int.Parse(Console.ReadLine());
                if (menu > primeros.Count)
                {
                    throw new Exception();
                }
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Opción introducida incorreccta.");
            }
        }
        if (menu < primeros.Count)
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Has seleccionado: " + primeros[menu].Nombre);
        }
        return menu;
    }
    /// <summary>
    /// Recorre la lista que pasamos como parametro y nos pide que seleccionemos a traves
    /// de la introducción de un entero un producto de la lista.
    /// </summary>
    /// <param name="bebidas">Lista de objetos Bebida a recorrer por el método</param>
    /// <returns>Posicón del producto elegido dentro de la lista de objetos Bebida</returns>
    private static int recorrerProductos(List<Bebida> bebidas)
    {
        int menu = 0;
        Console.WriteLine("-------------------------");
        Console.WriteLine("-------------------------\n");
        for (int i = 0; i < bebidas.Count; i++)
        {
            string texto = "";
            texto += i + ". " + bebidas[i].Nombre;
            while (texto.Length < 25)
            {
                texto += " ";
            }
            string precio = bebidas[i].Precio.ToString("0.00");
            texto += precio + "€";
            Console.WriteLine(texto);
        }
        Console.WriteLine(bebidas.Count + ". Salir");
        while (true)
        {
            try
            {
                Console.Write("Introduzca una opción numérica: ");
                menu = int.Parse(Console.ReadLine());
                if (menu > bebidas.Count)
                {
                    throw new Exception();
                }
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Opción introducida incorreccta.");
            }
        }
        if (menu < bebidas.Count)
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Has seleccionado: " + bebidas[menu].Nombre);
        }
        return menu;
    }
    /// <summary>
    /// Recorre la lista que pasamos como parametro y nos pide que seleccionemos a traves
    /// de la introducción de un entero un producto de la lista.
    /// </summary>
    /// <param name="complementos">Lista de objetos Complemento a recorrer por el método</param>
    /// <returns>Posicón del producto elegido dentro de la lista de objetos Complemento</returns>
    private static int recorrerProductos(List<Complemento> complementos)
    {

        int menu = 0;
        Console.WriteLine("-------------------------");
        Console.WriteLine("-------------------------\n");
        for (int i = 0; i < complementos.Count; i++)
        {
            string texto = "";
            texto += i + ". " + complementos[i].Nombre;
            while (texto.Length < 25)
            {
                texto += " ";
            }
            string precio = complementos[i].Precio.ToString("0.00");
            texto += precio + "€\n\t";
            List<string> ingredientes = complementos[i].getIngredientes();
            for (int j = 0; j < ingredientes.Count; j++)
            {
                int finalPos = ingredientes.Count - 1;

                if (ingredientes[j] == ingredientes[finalPos])
                {
                    texto += ingredientes[j] + ".";
                }
                else
                {
                    texto += ingredientes[j] + ", ";
                }
            }
            Console.WriteLine(texto);
        }
        Console.WriteLine(complementos.Count + ". Salir");
        while (true)
        {
            try
            {
                Console.Write("Introduzca una opción numérica: ");
                menu = int.Parse(Console.ReadLine());
                if (menu > complementos.Count)
                {
                    throw new Exception();
                }
                break;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Opción introducida incorreccta.");
            }
        }
        if (menu < complementos.Count)
        {
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("-------------------------\n");
            Console.WriteLine("Has seleccionado: " + complementos[menu].Nombre);
        }
        return menu;
    }
    /// <summary>
    /// Se decide si queremos objetos Extra que añadir a nuestro objeto Comida, de ser sí
    /// se invocará el método addExtras con la lista de extras que hemos pasado por parametro
    /// </summary>
    /// <param name="comida">Objeto comida seleccionado previamente</param>
    /// <param name="extras">Lista de objetos Extra de donde elegiremos</param>
    /// <returns>Lista de objetos extra elegidos para nuestro producto Comida</returns>
    private static List<Extra> decisionExtras(Comida comida, List<Extra> extras)
    {
        List<Extra> extrasElegidos = new List<Extra>();
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("¿Añadimos algun extra a " + comida.Nombre + "?");
            Console.WriteLine("0. Si");
            Console.WriteLine("1. No");
            Console.Write("Introduzca una opción numérica: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (opcion == 0)
            {
                extrasElegidos = addExtras(extras);
            }
            salir = true;
            
        }
        return extrasElegidos;
    }
    /// <summary>
    /// Se decide si queremos objetos Extra que añadir a nuestro objeto Complemento, de ser sí
    /// se invocará el método addExtras con la lista de extras que hemos pasado por parametro
    /// </summary>
    /// <param name="complemento">Objeto comida seleccionado previamente</param>
    /// <param name="extras">Lista de objetos Extra de donde elegiremos</param>
    /// <returns>Lista de objetos extra elegidos para nuestro producto Complemento</returns>
    private static List<Extra> decisionExtras(Complemento complemento, List<Extra> extras)
    {
        List<Extra> extrasElegidos = new List<Extra>();
        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("-------------------------");
            Console.WriteLine("¿Añadimos algun extra a " + complemento.Nombre + "?");
            Console.WriteLine("0. Si");
            Console.WriteLine("1. No");
            Console.Write("Introduzca una opción numérica: ");
            int opcion = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (opcion == 0)
            {
                extrasElegidos = addExtras(extras);
                salir = true;
            }
            else
            {
                salir = true;
            }
        }
        return extrasElegidos;
    }
    /// <summary>
    /// Elegimos nuestros objetos Extra que queremos en nuestro producto
    /// </summary>
    /// <param name="extras">Lista de objetos Extra entre los que elegir para crear nuestra propia lista</param>
    /// <returns>Lista de objetos Extra ya elegidos</returns>
    private static List<Extra> addExtras(List<Extra> extras)
    {
        List<Extra> extrasElegidos = new List<Extra>();
        int opcion;
        do
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("------------------------------");
            Console.WriteLine("¿Que ingrediente querremos añadir?");
            for (int i = 0; i < extras.Count; i++)
            {

                string nombre = extras[i].Nombre;
                string precio = extras[i].Precio.ToString("0.00");
                string texto = i + ". " + nombre;
                while (texto.Length < 25)
                {
                    texto += " ";
                }
                texto += precio + "€";
                Console.WriteLine(texto);
            }
            Console.WriteLine(extras.Count + ". Salir\n");
            while (true)
            {
                try
                {
                    Console.Write("Introduzca una opción numérica: ");
                    opcion = int.Parse(Console.ReadLine());
                    if (opcion > extras.Count)
                    {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                    Console.WriteLine("Opción introducida incorreccta.");
                }
            }
            if (opcion < extras.Count)
            {
                Console.WriteLine("\nHas seleccionado: " + extras[opcion].Nombre + "\n");
                extrasElegidos.Add(extras[opcion]);

            }

        } while (opcion != extras.Count);

        return extrasElegidos;
    }

}