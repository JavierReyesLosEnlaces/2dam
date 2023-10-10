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

        Console.WriteLine("SELECCIONA EL NÚMERO CON LA OPCIÓN DESEADA: ");
        Console.WriteLine("1. Comprar hamburguesa ");
        Console.WriteLine("2. Comprar bebida");
        Console.WriteLine("0. Finzalizar compra y pagar");

        int opc = Int32.Parse(Console.ReadLine());

        do
        {
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
                    Console.WriteLine("Opción no válida, vuelve a intentarlo");
                    break;
            }
        } while (opc != 0);
        Console.WriteLine("PRECIO TOTAL = " + precioTotal + " EUROS");
    }

    private static void FinCompra()
    {
    }

    private static float ComprarBebida()
    {
        bool conAlcohol = false;
        int x;

        // TIENE ALCOHOL

        do
        {
            Console.WriteLine("¿Con alcohol?");
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
        return b.Precio;

    }

    private static float ComprarHamburguesa()
    {
        bool panCenteno = false, carneVacuno = false;
        int x;

        // PAN DE CENTENO
        do
        {
            Console.WriteLine("¿Pan de centeno?");
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

        // CARNE DE VACUNO
        do
        {
            Console.WriteLine("¿Carne de vacuno?");
            Console.WriteLine("1. Si ");
            Console.WriteLine("2. No");

            x = Int32.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    carneVacuno = true;
                    break;
                case 2:
                    carneVacuno = false;
                    break;
                default:
                    Console.WriteLine("Opción no válida, vuelve a intentarlo");
                    break;
            }
        } while (x != 1 && x != 2);

        Hamburguesa h = new Hamburguesa(panCenteno, carneVacuno);
        return h.PrecioFinal;

    }
}
