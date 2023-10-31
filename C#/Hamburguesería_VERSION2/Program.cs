class Program
{
    static List<string> comanda = new List<string>();
    static void Main(string[] args)
    {
        float precioTotal = 0.0f;
        int opcion;

        insertarBienvenida();

        do
        {
            if (comanda.Count == 0) { Console.WriteLine("Bienvenid@ a McJavis, ¿en qué puedo ayudarle?"); }
            else { Console.WriteLine("¿Desea algo más?"); }

            Console.WriteLine("             ______             ");
            Console.WriteLine(" ___________| MENÚ |___________ ");
            Console.WriteLine("| 1. Comprar hamburguesa... 4$ |");
            Console.WriteLine("| 2. Comprar bebida........ 3$ |");
            Console.WriteLine("| 0. Finalizar compra y pagar  |");
            Console.WriteLine("|______________________________|\n");

            if (int.TryParse(Console.ReadLine(), out opcion)) //se intenta convertir la cadena de texto en un numero entero
            {
                switch (opcion)
                {
                case 1:
                    precioTotal += nuevaHamburguesa().Precio;
                    break;
                case 2:
                    precioTotal += nuevaBebida().Precio;
                    break;
                case 0:
                    mostrarComanda(precioTotal);
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelva a intentarlo\n");
                    break;
                }
            } 
            else
            {
                Console.WriteLine("Debes introducir un número válido.");
            }
        } while (opcion != 0);
    }

    private static void mostrarComanda(float precioTotal)
    {
        if (comanda.Count == 0)
        {
            Console.WriteLine("¿Te vas? ¡Pero si no has pedido nada! :(");
        }
        else
        {
            {
                Console.WriteLine("----------------------| FACTURA |----------------------");
                foreach (String s in comanda)
                {
                    Console.WriteLine(s);
                }
                Console.WriteLine("-------------------------------------------------------\nTOTAL A PAGAR = " + precioTotal + "$");
                Console.WriteLine("¡Gracias y hasta luego!");
            }
        }
    }
    private static Bebida nuevaBebida()
    {
        bool conAlcohol = false;
        int x;

        // TIENE ALCOHOL?

        do
        {
            Console.WriteLine("¿Cómo quiere su bebida?");
            Console.WriteLine("¿La quiere con alcohol? (+0.5$)");
            Console.WriteLine("1. Si ");
            Console.WriteLine("2. No");

            x = Int32.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    conAlcohol = true;
                    break;
                case 2:
                    conAlcohol = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelva a intentarlo");
                    break;
            }

        } while (x != 1 && x != 2);
        Bebida b = new Bebida(conAlcohol);
        statusBebida(b);
        return b;
    }
    private static Hamburguesa nuevaHamburguesa()
    {
        bool panCenteno = false, conQueso = false;
        int x;

        // PAN DE CENTENO

        do
        {
            Console.WriteLine("¿Cómo quiere su hamburguesa?");
            Console.WriteLine("¿La quiere con pan de centeno? (+0.5$)");
            Console.WriteLine("1. Si ");
            Console.WriteLine("2. No");

            x = Int32.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    panCenteno = true;
                    break;
                case 2:
                    panCenteno = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelva a intentarlo\n");
                    break;
            }
        } while (x != 1 && x != 2);

        // QUESO

        do
        {
            Console.WriteLine("¿La quiere con queso? (+1.0$)");
            Console.WriteLine("1. Si ");
            Console.WriteLine("2. No");

            x = Int32.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    conQueso = true;
                    break;
                case 2:
                    conQueso = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelva a intentarlo\n");
                    break;
            }
        } while (x != 1 && x != 2);

        Hamburguesa h = new Hamburguesa(panCenteno, conQueso);
        statusHamburguesa(h);
        return h;

    }
    private static void statusHamburguesa(Hamburguesa h)
    {
        String status;
        if (h.ConPanCenteno && h.ConQueso) { status = "(+) Hamburguesa con queso y con pan de centeno"; }
        else if (h.ConPanCenteno && !h.ConQueso) { status = "(+) Hamburguesa sin queso y con pan de centeno"; }
        else if (!h.ConPanCenteno && h.ConQueso) { status = "(+) Hamburguesa con queso y sin pan de centeno"; }
        else { status = "(+) Hamburguesa sin queso y sin pan de centeno"; }
        insertarHamburguesa();
        status += " --> " + h.Precio + "$";
        Console.WriteLine(status);
        comanda.Add(status);
    }

    private static void statusBebida(Bebida b)
    {
        String status;
        if (b.ConAlcohol)
        {
            insertarBebidaConAlcohol();
            status = "(+) Bebida con alcohol";
        }
        else
        {
            insertarBebidaSinAlcohol();
            status = "(+) Bebida sin alcohol";
        }
        status += " --> " + b.Precio + "$";
        Console.WriteLine(status);
        comanda.Add(status);

    }

    // IMÁGENES

    private static void insertarBienvenida()
    {
        Console.WriteLine("  __  __             _             _             ");
        Console.WriteLine(" |  \\/  |           | |           (_)           ");
        Console.WriteLine(" | \\  / | ___       | | __ ___   ___ ___        ");
        Console.WriteLine(" | |\\/| |/ __|  _   | |/ _` \\ \\ / / / __|     ");
        Console.WriteLine(" | |  | | (__  | |__| | (_| |\\ V /| \\__ \\     ");
        Console.WriteLine(" |_|  |_|\\___|  \\____/ \\__,_| \\_/ |_|___/  \n");
    }
    private static void insertarHamburguesa()
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

    private static void insertarBebidaConAlcohol()
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

    private static void insertarBebidaSinAlcohol()
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
