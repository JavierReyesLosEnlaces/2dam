#include <stdio.h>
#include <stdlib.h>

void opcion1()
{
    // Código para la opción 1
    printf("Has seleccionado la opcion 1.\n");
}

void opcion2()
{
    // Código para la opción 2
    printf("Has seleccionado la opcion 2.\n");
}

void opcion3()
{
    // Código para la opción 3
    printf("Has seleccionado la opcion 3.\n");
}

int main()
{
    int opcion;

    do
    {
        // Mostrar el menú
        printf("\nMenu:\n");
        printf("1. Opcion 1\n");
        printf("2. Opcion 2\n");
        printf("3. Opcion 3\n");
        printf("0. Salir\n");
        printf("Selecciona una opcion: \n");
        scanf("%d", &opcion);

        //%d -> lee y recoge: lo mete en %opcion

        // Procesar la selección del usuario
        switch (opcion)
        {
        case 1:
            opcion1();
            break;
        case 2:
            opcion2();
            break;
        case 3:
            opcion3();
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
