using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        float precioTotal = 0.0f;
        int opc;

        do
        {
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("SELECCIONA EL NÚMERO CON LA OPCIÓN DESEADA: ");
            Console.WriteLine("1. Comprar hamburguesa (4$) ");
            Console.WriteLine("2. Comprar bebida (3$)");
            Console.WriteLine("0. Finalizar compra y pagar");
            Console.WriteLine("-------------------------------------------\n");

            opc = Int32.Parse(Console.ReadLine());

            switch (opc)
            {
                case 1:
                    precioTotal += ComprarHamburguesa();
                    break;
                case 2:
                    precioTotal += ComprarBebida();
                    break;
                case 0:
                    Console.WriteLine("Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelve a intentarlo\n");
                    break;
            }
        } while (opc != 0);
        Console.WriteLine("PRECIO TOTAL = " + precioTotal + " $");
    }
    private static float ComprarBebida()
    {
        bool conAlcohol = false;
        int x;

        // TIENE ALCOHOL?

        do
        {
            Console.WriteLine("¿Cómo quieres tu bebida?");
            Console.WriteLine("¿La quieres con alcohol? (+0.5$)");
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
                    Console.WriteLine("Opción no válida, vuelve a intentarlo");
                    break;
            }

        } while (x != 1 && x != 2);
        Bebida b = new Bebida(conAlcohol);
        statusBebida(b);



        Console.WriteLine("(+" + b.Precio + " $)\n");
        return b.Precio;

    }



    private static float ComprarHamburguesa()
    {
        bool panCenteno = false, conQueso = false;
        int x;
        
        // PAN DE CENTENO

        do
        {
            Console.WriteLine("¿Cómo quieres tu hamburguesa?");
            Console.WriteLine("¿La quieres con pan de centeno? (+0.5$)");
            Console.WriteLine("1. Si ");
            Console.WriteLine("2. No");

            x = Int32.Parse(Console.ReadLine());

            switch(x)
            {
                case 1:
                    panCenteno = true;
                    break;
                case 2:
                    panCenteno = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelve a intentarlo");
                    break;
            }
        } while (x != 1 && x != 2);

        // QUESO

        do
        {
            Console.WriteLine("¿La quieres con queso? (+1.0$)");
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
                    Console.WriteLine("Opción no válida, vuelve a intentarlo");
                    break;
            }
        } while (x != 1 && x != 2);

        Hamburguesa h = new Hamburguesa(panCenteno, conQueso);
        statusHamburguesa(h);
        Console.WriteLine("\n");
        return h.PrecioFinal;

    }

    private static void insertarHamburguesa()
    {
       Console.WriteLine("          _..----.._        ");
       Console.WriteLine("        .'     o    '.      ");
       Console.WriteLine("       /   o       o  \\    ");
       Console.WriteLine("      |o        o     o|    ");
       Console.WriteLine("      /'-.._o     __.-'\\   ");
       Console.WriteLine("      \\      `````     /   ");
       Console.WriteLine("      |``--........--'`|    ");
       Console.WriteLine("       \\              /    ");
       Console.WriteLine("        `'----------'`      ");
    }

    private static void insertarBebidaConAlcohol()
    {
        Console.WriteLine("  \"\"\"\"\"\"\"\"/.       ");
        Console.WriteLine("   \\`\\-------'`/         ");
        Console.WriteLine("    \\ \\__ o . /          ");
        Console.WriteLine("     \\/  \\  o/           ");
        Console.WriteLine("      \\__/. /             ");
        Console.WriteLine("       \\_ _/              ");
        Console.WriteLine("         YY                ");
        Console.WriteLine("         ||                ");
        Console.WriteLine("         ||                ");
        Console.WriteLine("    __.-' '-.__            ");
        Console.WriteLine("    `----------`           ");
    }

    private static void insertarBebidaSinAlcohol()
    {
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣶⣶⣶⣶⣶⣶⣶⣶⣶⣶⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠚⠛⠛⠛⠛⠛⠛⠛⠛⠛⠛⠓⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿ SODA ⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⣤⡤⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⠿⠿⠿⠿⠿⠿⠿⠿⠿⠿⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀");
        Console.WriteLine("⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀");
    }

    private static void statusHamburguesa(Hamburguesa h)
    {
        String status;
        if (h.PanCenteno && h.Queso) { status = "(+) Hamburguesa con queso y pan de centeno"; }
        else if (h.PanCenteno && !h.Queso) { status = "(+) Hamburguesa sin queso y con pan de centeno"; }
        else if (!h.PanCenteno && h.Queso) { status = "(+) Hamburguesa con queso y sin pan de centeno"; }
        else { status = "(+) Hamburguesa sin queso y sin pan de centeno"; }
        insertarHamburguesa();
        Console.WriteLine(status);
    }
    private static void statusBebida(Bebida b)
    {
        String status;
        if (b.ConAlcohol) {
            status = "(+) Bebida con alcohol";
            insertarBebidaConAlcohol();
        }
        else {
            status = "(+) Bebida sin alcohol";
            insertarBebidaSinAlcohol();
        }
    }


}
