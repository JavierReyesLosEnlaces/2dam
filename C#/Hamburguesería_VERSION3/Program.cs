class Program
{
    static void Main(string[] args)
    {
        List<Producto> comanda = new List<Producto>();
        int opcion;

        InsertarImagen("bienvenida");
        do
        {
            if (comanda.Count == 0) { Console.WriteLine("\nBienvenid@ a McJavis, ¿en qué puedo ayudarle?"); }
            else { Console.WriteLine("\n¿Desea algo más?"); }

            Console.WriteLine("             ______                ");
            Console.WriteLine(" ___________| MENÚ |____________   ");
            Console.WriteLine("| 1. Leer carta de hamburguesas |  ");
            Console.WriteLine("| 2. Leer carta de bebidas      |  ");
            Console.WriteLine("| 3. Leer carta de patatas      |  ");
            Console.WriteLine("| 0. Finalizar compra y pagar   |  ");
            Console.WriteLine("|_______________________________|\n");

            if (int.TryParse(Console.ReadLine(), out opcion)) // SE INTENTA CONVERTIR LA CADENA DE TEXTO EN UN NÚMERO ENTERO Y ALMACENARLA EN LA VARIABLE "OPCIÓN"
            {
                switch (opcion)
                {
                    case 1:
                        NuevoProducto("hamburguesa", comanda);
                        break;
                    case 2:
                        NuevoProducto("bebida", comanda);
                        break;
                    case 3:
                        NuevoProducto("patatas", comanda);
                        break;
                    case 0:
                        MostrarComanda(comanda);
                        break;
                    default:
                        Console.WriteLine("La opción no es válida, debes introducir un número entre 0 y 3.");
                        break;
                }
            }
            else Console.WriteLine("Debes introducir un número.");
        } while (opcion != 0);
    }
    private static List<Producto> GenerarProductos(string x)
    {
        if (x == "hamburguesa")
        {
            List<Producto> listaDeHamburguesas = new List<Producto>();

            listaDeHamburguesas.Add(new Hamburguesa("Tres cerditos", 'c', true, true, false, false, true));
            listaDeHamburguesas.Add(new Hamburguesa("Pollo especial", 'p', true, false, true, true, false));
            listaDeHamburguesas.Add(new Hamburguesa("Veggie delight", 'v', true, false, false, true, false));
            listaDeHamburguesas.Add(new Hamburguesa("Clásica con cebolla", 'c', false, false, false, true, false));
            listaDeHamburguesas.Add(new Hamburguesa("Queso y bacon", 'c', false, true, false, false, true));
            listaDeHamburguesas.Add(new Hamburguesa("Simple de pollo", 'p', false, false, false, false, false));
            listaDeHamburguesas.Add(new Hamburguesa("Vegana sencilla", 'v', false, false, false, false, false));
            listaDeHamburguesas.Add(new Hamburguesa("Cerdo con tomate", 'c', true, false, false, false, false));

            return listaDeHamburguesas;
        }
        else if (x == "bebida")
        {
            List<Producto> listaDeBebidas = new List<Producto>();

            listaDeBebidas.Add(new Bebida("Vino", true, false, "Vino"));
            listaDeBebidas.Add(new Bebida("Cerveza", true, true, "Lager"));
            listaDeBebidas.Add(new Bebida("CocaCola", false, true, "Cola"));
            listaDeBebidas.Add(new Bebida("Jugo de naranja", false, false, "Naranja"));

            return listaDeBebidas;
        }
        else if ((x == "patatas"))
        {
            List<Producto> listaDePatatas = new List<Producto>();

            listaDePatatas.Add(new Patatas("Patatas clásicas", true, "patata", "regular", "ketchup"));
            listaDePatatas.Add(new Patatas("Patatas deluxe de batata", true, "batata", "deluxe", "mayonesa"));
            listaDePatatas.Add(new Patatas("Patatas deluxe clásicas", true, "patata", "deluxe", "alioli"));
            listaDePatatas.Add(new Patatas("Batatas con queso", true, "batata", "regular", "queso fundido"));
            listaDePatatas.Add(new Patatas("Patatas sin sal picantes", false, "patata", "fino", "salsa picante"));
            listaDePatatas.Add(new Patatas("Patatas con ajo y perejil", true, "patata", "regular", "mix de ajo y perejil"));

            return listaDePatatas;
        }
        else return null;
    }
    private static void ListarProductos(string x)
    {
        int index = 1;
        if (x == "hamburguesa")
        {
            Console.WriteLine("----------------| CARTA DE HAMBURGUESAS |----------------");
            foreach (Hamburguesa h in GenerarProductos("hamburguesa"))
            {
                Console.WriteLine("\n" + index + ". " + h.NombreProducto);
                Console.WriteLine("-> " + h.precio + "$\n-> " + h.ListarIngredientes());
                index++;
            }
            Console.WriteLine("\n------------------------------------------------------");
        }
        else if (x == "bebida")
        {
            Console.WriteLine("--| CARTA DE BEBIDAS |--");
            foreach (Bebida b in GenerarProductos("bebida"))
            {
                Console.WriteLine("\n" + index + ". " + b.NombreProducto);
                Console.WriteLine("-> " + b.precio + "$\n-> " + b.ListarIngredientes());
                index++;
            }
            Console.WriteLine("\n------------------------");
        }
        else if ((x == "patatas"))
        {
            Console.WriteLine("--------------------------| CARTA DE PATATAS |--------------------------");
            foreach (Patatas p in GenerarProductos("patatas"))
            {
                Console.WriteLine("\n" + index + ". " + p.NombreProducto);
                Console.WriteLine("-> " + p.precio + "$\n-> " + p.ListarIngredientes());
                index++;
            }
            Console.WriteLine("\n------------------------------------------------------------------------");
        }
        else Console.WriteLine("Error en el parámetro introducido. ");

    }
    private static void NuevoProducto(string x, List<Producto> comanda)
    {
        List<Producto> listaDeProductos = GenerarProductos(x);
        ListarProductos(x);
        bool control = false;

        while (!control)
        {
            Console.WriteLine("\nEscoge " + x + " o presiona 0 para volver: ");
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 0 && opcion <= listaDeProductos.Count)
            {
                if (opcion != 0)
                {
                    comanda.Add(listaDeProductos[opcion - 1]);
                    if (x == "bebida")
                    {
                        string y = listaDeProductos[opcion - 1].NombreProducto;
                        InsertarImagen(y);
                    }
                    else InsertarImagen(x);

                    Console.WriteLine("(+) " + (x.First().ToString().ToUpper() + x.Substring(1)) + " '" + listaDeProductos[opcion - 1].NombreProducto + "'(" + listaDeProductos[opcion - 1].Precio + "$)");

                    // (x.First().ToString().ToUpper() + x.Substring(1))
                    // Aquí estamos tomando la primera letra del string en minúsculas, convirtiéndola a mayúsculas usando ToUpper, y luego concatenándola con el resto del string utilizando Substring(1)
                }
                control = true;
            }
            else Console.WriteLine("La opción no es válida, debes introducir un número entre 0 y " + listaDeProductos.Count);
        }
    }
    private static void MostrarComanda(List<Producto> comanda)
    {
        float precioTotal = 0.0f;

        if (comanda.Count == 0) Console.WriteLine("¿Te vas? ¡Pero si no has pedido nada! :(");
        else
        {
            {
                Console.WriteLine("//////////////| TICKET DE COMPRA |//////////////\n");
                foreach (Producto p in comanda)
                {
                    if (p is Hamburguesa) Console.WriteLine("(+) Hamburguesa '" + p.NombreProducto + "' (" + p.Precio + "$)\n");
                    else Console.WriteLine("(+) " + p.NombreProducto + " (" + p.Precio + "$)\n");
                    precioTotal += p.Precio;
                }
                Console.WriteLine("////////////////////////////////////////////////\nTOTAL A PAGAR = " + precioTotal.ToString("0.00") + "$");
                // precioTotal.ToString("0.00") MUESTRA EL PRECIO TOTAL CON UN FORMATO DE DOS DECIMALES
                Console.WriteLine("\n          ¡Gracias y hasta luego!");
            }
        }
    }
    private static void InsertarImagen(string x)
    {
        if (x == "bienvenida")
        {
            Console.WriteLine("  __  __             _             _             ");
            Console.WriteLine(" |  \\/  |           | |           (_)           ");
            Console.WriteLine(" | \\  / | ___       | | __ ___   ___ ___        ");
            Console.WriteLine(" | |\\/| |/ __|  _   | |/ _` \\ \\ / / / __|     ");
            Console.WriteLine(" | |  | | (__  | |__| | (_| |\\ V /| \\__ \\     ");
            Console.WriteLine(" |_|  |_|\\___|  \\____/ \\__,_| \\_/ |_|___/  \n");
        }
        else if (x == "hamburguesa")
        {
            Console.WriteLine("");
            Console.WriteLine("          _..----.._       ");
            Console.WriteLine("        .'     o    '.     ");
            Console.WriteLine("       /   o       o  \\   ");
            Console.WriteLine("      |o        o     o|   ");
            Console.WriteLine("      /'-.._o     __.-'\\  ");
            Console.WriteLine("      \\      `````     /  ");
            Console.WriteLine("      |``--........--'`|   ");
            Console.WriteLine("       \\              /   ");
            Console.WriteLine("        `'----------'`     MARCHANDO!");
            Console.WriteLine("");
        }
        else if (x == "patatas")
        {
            Console.WriteLine("");
            Console.WriteLine("       |\\ / | /|_/|||              ");
            Console.WriteLine("       |\\||-|\\||-/|/ |            ");
            Console.WriteLine("      \\\\|||\\||//||///            ");
            Console.WriteLine("       |\\/\\||//||||||             ");
            Console.WriteLine("       ||| \\|| \\||/\\|            ");
            Console.WriteLine("       |   './/\\_/.'|              ");
            Console.WriteLine("       |            |               ");
            Console.WriteLine("       |            |               ");
            Console.WriteLine("       '.__________.'     MARCHANDO!");
            Console.WriteLine("");
        }
        else if (x == "Vino")
        {
            Console.WriteLine("");
            Console.WriteLine("       \\             / ");
            Console.WriteLine("        \\`\\-------'`/ ");
            Console.WriteLine("         \\ \\__ o . /  ");
            Console.WriteLine("          \\/  \\  o/   ");
            Console.WriteLine("           \\__/. /      ");
            Console.WriteLine("            \\_ _/      ");
            Console.WriteLine("             YY         ");
            Console.WriteLine("             ||         ");
            Console.WriteLine("             ||         ");
            Console.WriteLine("         __.-' '-.__    ");
            Console.WriteLine("         `----------`   MARCHANDO!");
            Console.WriteLine("");
        }
        else if (x == "Cerveza")
        {
            Console.WriteLine("");
            Console.WriteLine("                          ");
            Console.WriteLine("        ,-'''------___    ");
            Console.WriteLine("       (              )   ");
            Console.WriteLine("       |`-...____  ___/   ");
            Console.WriteLine("       |              |   ");
            Console.WriteLine("       |              |   ");
            Console.WriteLine("       |`-...____  ___´   ");
            Console.WriteLine("       |     AMBAR    |   ");
            Console.WriteLine("       |`-...___ ___,'|   ");
            Console.WriteLine("       |         '_ | |   ");
            Console.WriteLine("       | -'  ~~     | |   ");
            Console.WriteLine("       (   ~      ~   |  ");
            Console.WriteLine("        `-..._______,/    MARCHANDO!");
            Console.WriteLine("");
        }
        else if (x == "CocaCola")
        {
            Console.WriteLine("");
            Console.WriteLine("                          ");
            Console.WriteLine("        ,-'''------___    ");
            Console.WriteLine("       (              )   ");
            Console.WriteLine("       |`-...____  ___/   ");
            Console.WriteLine("       |              |   ");
            Console.WriteLine("       |              |   ");
            Console.WriteLine("       |`-...____  ___´   ");
            Console.WriteLine("       |  COCA-COLA   |   ");
            Console.WriteLine("       |`-...___ ___,'|   ");
            Console.WriteLine("       |         '_ | |   ");
            Console.WriteLine("       | -'  ~~     | |   ");
            Console.WriteLine("       (   ~      ~   |  ");
            Console.WriteLine("        `-..._______,/    MARCHANDO!");
            Console.WriteLine("");
        }
        else if (x == "Jugo de naranja")
        {
            Console.WriteLine("");
            Console.WriteLine("                   //     ");
            Console.WriteLine("                  //      ");
            Console.WriteLine("                 //       ");
            Console.WriteLine("             ____||       ");
            Console.WriteLine("        ,-'''    ||`-.    ");
            Console.WriteLine("       (         ||   )   ");
            Console.WriteLine("       |`-...____'|___|   ");
            Console.WriteLine("       |         ||   |   ");
            Console.WriteLine("       |     ____||   |   ");
            Console.WriteLine("       |,-'''_ _ ||`-.|   ");
            Console.WriteLine("       |  ~ / `-\\ ,- |   ");
            Console.WriteLine("       |`-...___/___,'|   ");
            Console.WriteLine("       |    `-./-'_ | |   ");
            Console.WriteLine("       | -'  ~~     |||   ");
            Console.WriteLine("       (   ~      ~   )   ");
            Console.WriteLine("        `-..._______,-    MARCHANDO!");
            Console.WriteLine("");
        }
    }
}
