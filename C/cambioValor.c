#include <stdio.h>
#include <stdlib.h>

void opcion1()
{

    int numero1, numero2, numero3;

    printf("Introduce un numero 1: \n");
    scanf("%d", &numero1);

    printf("Introduce un numero 2: \n");
    scanf("%d", &numero2);

    numero3 = numero2;
    numero2 = numero1;
    numero1 = numero3;

    printf("Valor del numero 1: %d\n", numero1);
    printf("Valor del numero 2: %d\n", numero2, "\n");
}

int main()
{
    int opcion;
    int numero1, numero2, numero3;

    do
    {
        // Mostrar el menú
        printf("\nMenu:\n");
        printf("1. Hacer cambio de valor de dos numeros\n");
        printf("0. Salir\n");
        printf("Selecciona una opcion: ");
        scanf("%d", &opcion);

        //%d -> lee y recoge: lo mete en

        // Procesar la selección del usuario
        switch (opcion)
        {
        case 1:
            opcion1();
            break;
        case 0:
            printf("Saliendo del programa, hasta luego!\n");
            break;
        default:
            printf("Opcion invalida. Por favor, selecciona una opcion valida.\n");
            break;
        }
    } while (opcion != 0);

    return 0;
}
