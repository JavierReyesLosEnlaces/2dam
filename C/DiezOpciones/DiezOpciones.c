#include <stdio.h>
#include <stdlib.h>

int main()
{
    int opcion;
    do
    {
        printf("\nMenu:\n");
        printf("1. Opcion 1: \n");
        printf("2. Opcion 2\n");
        printf("3. Opcion 3\n");
        printf("4. Opcion 4\n");
        printf("5. Opcion 5\n");
        printf("6. Opcion 6\n");
        printf("7. Opcion 7\n");
        printf("8. Opcion 8\n");
        printf("9. Opcion 9\n");
        printf("10. Opcion 10\n");
        printf("0. Salir\n");
        printf("Selecciona una opcion: \n");
        scanf("%d", &opcion); //%d -> lee y recoge: lo mete en %opcion

        // Procesar la selección del usuario
        switch (opcion)
        {
        case 1:
            opcion1();
            break;
        case 2:
            //opcion2;
            break;
        case 3:
            //opcion3;
            break;
        case 4:
            //opcion4;
            break;
        case 5:
            //opcion5;
            break;
        case 6:
            //opcion6;
            break;
        case 7:
            //opcion7;
            break;
        case 8:
            //opcion8;
            break;
        case 9:
            //opcion9;
            break;
        case 10:
            //opcion10;
            break;
        case 0:
            printf("Saliendo del programa. Hasta luego!\n\n");
            break;
        default:
            printf("Opcion invalida. Por favor, selecciona una opcion valida.\n\n");
            break;
        }
    } while (opcion != 0);
    return 0;
}

// Opción 1: Abrir el notepad, pedir que escribas algo y te lo guarde dentro de f_opcion1.txt
void opcion1()
{
    //char nombreFichero[100];
    //printf("%d", &nombreFichero);
    printf("Introduce texto dentro del editor si quieres...");
    printf("%d", system("notepad > f_opcion1.txt"));
}

