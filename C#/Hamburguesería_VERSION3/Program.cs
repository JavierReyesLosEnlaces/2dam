using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        List<Producto> comanda = new List<Producto>();
        List<Hamburguesa> listaDeHamburguesas = GenerarHamburguesas();
        List<Bebida> listaDeBebidas = GenerarBebidas();
        List<Patatas> listaDePatatas = GenerarPatatas();

        int opcion;
        InsertarBienvenida();
        
        do
        {
            if (comanda.Count == 0) { Console.WriteLine("\nBienvenid@ a McJavis, ¿en qué puedo ayudarle?"); }
            else { Console.WriteLine("\n¿Desea algo más?"); }

            Console.WriteLine("             ______               ");
            Console.WriteLine(" ___________| MENÚ |___________   ");
            Console.WriteLine("| 1. Comprar hamburguesa       |  ");
            Console.WriteLine("| 2. Comprar bebida            |  ");
            Console.WriteLine("| 3. Comprar patatas           |  ");
            Console.WriteLine("| 0. Finalizar compra y pagar  |  ");
            Console.WriteLine("|______________________________|\n");

            if (int.TryParse(Console.ReadLine(), out opcion)) //se intenta convertir la cadena de texto en un numero entero
            {
                switch (opcion)
                {
                    case 1:
                        nuevaHamburguesa(listaDeHamburguesas, comanda);
                        break;
                    case 2:
                        nuevaBebida(listaDeBebidas, comanda);
                        break;
                    case 3:
                        nuevasPatatas(listaDePatatas, comanda);
                        break;
                    case 0:
                        mostrarComanda(comanda);
                        break;
                    default:
                        Console.WriteLine("Opción no válida, vuelva a intentarlo");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Debes introducir un número válido.");
            }
        } while (opcion != 0);
    }

    // MÉTODOS RELATIVOS A LAS COMANDAS
    private static void mostrarComanda(List<Producto> comanda)
    {
        float precioTotal = 0.0f;

        if (comanda.Count == 0)
        {
            Console.WriteLine("¿Te vas? ¡Pero si no has pedido nada! :(");
        }
        else
        {
            {
                Console.WriteLine("//////////////////| FACTURA |//////////////////\n");
                foreach (Producto p in comanda)
                {
                    if (p is Hamburguesa)
                    {

                        Console.WriteLine("(+) Hamburguesa '" + p.NombreProducto + "' (" + p.Precio + "$)\n");
                    }
                    else
                    {
                        Console.WriteLine("(+) " + p.NombreProducto + " (" + p.Precio + "$)\n");
                    }
                    precioTotal += p.Precio;
                }
                Console.WriteLine("/////////////////////////////////////////////\nTOTAL A PAGAR = " + precioTotal.ToString("0.00") + "$");
                Console.WriteLine("\n          ¡Gracias y hasta luego!");
            }
        }
    }

    // MÉTODOS RELATIVOS A LAS HAMBURGUESAS
    private static List<Hamburguesa> GenerarHamburguesas()
    {
        List<Hamburguesa> listaDeHamburguesas = new List<Hamburguesa>();

        listaDeHamburguesas.Add(new Hamburguesa("Tres cerditos", 'c', true, true, false, false, true));
        listaDeHamburguesas.Add(new Hamburguesa("Pollo especial", 'p', true, false, true, true, false));
        listaDeHamburguesas.Add(new Hamburguesa("Veggie delight", 'v', true, false, true, true, false));
        listaDeHamburguesas.Add(new Hamburguesa("Clásica con cebolla", 'c', false, false, false, true, false));
        listaDeHamburguesas.Add(new Hamburguesa("Queso y bacon", 'c', false, true, false, false, true));
        listaDeHamburguesas.Add(new Hamburguesa("Simple de pollo", 'p', false, false, false, false, false));
        listaDeHamburguesas.Add(new Hamburguesa("Vegana sencilla", 'v', false, false, false, false, false));
        listaDeHamburguesas.Add(new Hamburguesa("Cerdo con tomate", 'c', true, false, false, false, false));

        return listaDeHamburguesas;
    }
    private static void listarHamburguesas(List<Hamburguesa> listaDeHamburguesas)
    {
        int index = 1;
        Console.WriteLine("----------------| CARTA DE HAMBURGUESAS |----------------");
        foreach (Hamburguesa h in listaDeHamburguesas)
        {
            Console.WriteLine("\n" + index + ". " + h.NombreProducto);
            Console.WriteLine("-> " + h.precio + "$\n-> " + h.ListarIngredientes());
            index++;
        }
        Console.WriteLine("\n------------------------------------------------------");

    }
    private static void nuevaHamburguesa(List<Hamburguesa> listaDeHamburguesas, List<Producto> comanda)
    {
        listarHamburguesas(listaDeHamburguesas);

        bool control = false;

        while (!control)
        {
            Console.WriteLine("\nEscoge una hamburguesa o presiona 0 para volver: ");
            int opcion;

            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 0 && opcion <= listaDeHamburguesas.Count)
            {
                if (opcion != 0)
                {
                    comanda.Add(listaDeHamburguesas[opcion - 1]);
                    InsertarHamburguesa();
                    Console.WriteLine("(+) Hamburguesa '" + listaDeHamburguesas[opcion - 1].NombreProducto + "'");
                }
                control = true;
            }
            else
            {
                Console.WriteLine("La opción no es válida. Debe ser un número entre 0 y " + listaDeHamburguesas.Count);
            }
        }
    }

    //MÉTODOS RELATIVOS A LAS BEBIDAS
    private static List<Bebida> GenerarBebidas()
    {
        List<Bebida> listaDeBebidas = new List<Bebida>();

        listaDeBebidas.Add(new Bebida("Vino", true, false, "Vino"));
        listaDeBebidas.Add(new Bebida("Cerveza", true, true, "Lager"));
        listaDeBebidas.Add(new Bebida("CocaCola", false, true, "Cola"));
        listaDeBebidas.Add(new Bebida("Jugo de naranja", false, true, "Naranja"));

        return listaDeBebidas;
    }
    private static void listarBebidas(List<Bebida> listaDeBebidas)
    {
        int index = 1;
        Console.WriteLine("--| CARTA DE BEBIDAS |--");
        foreach (Bebida b in listaDeBebidas)
        {
            Console.WriteLine("\n" + index + ". " + b.NombreProducto);
            Console.WriteLine("-> " + b.precio + "$\n-> " + b.ListarIngredientes());
            index++;
        }
        Console.WriteLine("\n------------------------");
    }
    private static void nuevaBebida(List<Bebida> listaDeBebidas, List<Producto> comanda)
    {
        listarBebidas(listaDeBebidas);

        bool control = false;

        while (!control)
        {
            Console.WriteLine("\nEscoge una bebida o presiona 0 para volver: ");
            int opcion;

            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 0 && opcion <= listaDeBebidas.Count)
            {
                if (opcion != 0)
                {
                    Bebida b = listaDeBebidas[opcion - 1];
                    comanda.Add(b);
                    if (opcion <= 1)
                    {
                        InsertarBebidaConAlcohol();
                    }
                    else
                    {
                        InsertarBebidaSinAlcohol();
                    }
                    Console.WriteLine("(+) " + listaDeBebidas[opcion - 1].NombreProducto);
                }
                control = true;
            }
            else
            {
                Console.WriteLine("La opción no es válida. Debe ser un número entre 0 y " + listaDeBebidas.Count);
            }
        }
    }

    // MÉTODOS RELATIVOS A LAS PATATAS
    private static List<Patatas> GenerarPatatas()
    {
        List<Patatas> listaDePatatas = new List<Patatas>();

        listaDePatatas.Add(new Patatas("Patatas clásicas", true, "patata", "regular", "ketchup"));
        listaDePatatas.Add(new Patatas("Patatas deluxe de batata", true, "batata", "deluxe", "mayonesa"));
        listaDePatatas.Add(new Patatas("Patatas deluxe clásicas", true, "patata", "deluxe", "alioli"));
        listaDePatatas.Add(new Patatas("Batatas con queso", true, "batata", "regular", "queso fundido"));
        listaDePatatas.Add(new Patatas("Patatas sin sal picantes", false, "patata", "fino", "salsa picante"));
        listaDePatatas.Add(new Patatas("Patatas con ajo y perejil", true, "patata", "regular", "mix de ajo y perejil"));

        return listaDePatatas;
    }
    private static void listarPatatas(List<Patatas> listaDePatatas)
    {
        int index = 1;
        Console.WriteLine("--------------------------| CARTA DE PATATAS |--------------------------");
        foreach (Patatas p in listaDePatatas)
        {
            Console.WriteLine("\n" + index + ". " + p.NombreProducto);
            Console.WriteLine("-> " + p.precio + "$\n-> " + p.ListarIngredientes());
            index++;
        }
        Console.WriteLine("\n------------------------------------------------------------------------");
    }
    private static void nuevasPatatas(List<Patatas> listaDePatatas, List<Producto> comanda)
    {
        listarPatatas(listaDePatatas);
        bool control = false;

        while (!control)
        {
            Console.WriteLine("\nEscoge unas patatas o presiona 0 para volver: ");
            int opcion;

            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 0 && opcion <= listaDePatatas.Count)
            {
                if (opcion != 0)
                {
                    comanda.Add(listaDePatatas[opcion - 1]);
                    InsertarPatatas();
                    Console.WriteLine("(+) " + listaDePatatas[opcion - 1].NombreProducto);
                }
                control = true;
            }
            else
            {
                Console.WriteLine("La opción no es válida. Debe ser un número entre 0 y " + (listaDePatatas.Count));
            }
        }
    }

    // MÉTODOS RELATIVOS A LOS INSERTOS DE IMÁGENES
    private static void InsertarBienvenida()
    {
        Console.WriteLine("  __  __             _             _             ");
        Console.WriteLine(" |  \\/  |           | |           (_)           ");
        Console.WriteLine(" | \\  / | ___       | | __ ___   ___ ___        ");
        Console.WriteLine(" | |\\/| |/ __|  _   | |/ _` \\ \\ / / / __|     ");
        Console.WriteLine(" | |  | | (__  | |__| | (_| |\\ V /| \\__ \\     ");
        Console.WriteLine(" |_|  |_|\\___|  \\____/ \\__,_| \\_/ |_|___/  \n");
    }
    private static void InsertarHamburguesa()
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
    private static void InsertarBebidaConAlcohol()
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
    private static void InsertarBebidaSinAlcohol()
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
    private static void InsertarPatatas()
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
}
