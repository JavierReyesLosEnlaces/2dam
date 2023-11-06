#include <stdio.h>
#include <stdlib.h>
void main()
{
    printf("Ejemplo de uso de system():");
    printf("\nListado del directorio actual y envio a un fichero:");
    printf("%d", system("dir > ficsalida"));
    printf("\nAbrimos con el gedit (o notepad) el fichero...\n");
    printf("%d", system("notepad ficsalida"));
    printf("\nEste comando es erroneo: %d", system("ged"));
    printf("\nFin de programa...\n");
}
// Opción 1: Abrir el notepad, pedir que escribas algo y te lo guarde como un nuevo fichero.
void opcion1()
{
    int nombreFichero;
    printf("Introduce un nombre para el archivo: ");
    printf("%d", &nombreFichero);
    printf("Introduce texto dentro del editor si quieres...");
    printf("%d", system("notepad > ", &nombreFichero));
}