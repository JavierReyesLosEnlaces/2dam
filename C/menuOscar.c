#include <stdio.h>
#include <stdlib.h>

void sumaDe1y1()
{
    int a = 1;
    int b = 1;
    int resultado = a + b;
    printf("Resultado = %d", resultado);
    printf("\n");
}

void opcion1()
{
    printf("Has seleccionado la opcion 1.\n");
}

void opcion2()
{
    printf("Has seleccionado la opcion 2.\n");
    // añadir una subrutina (no funcion) -> subrutina no devuelve nada / función devuelve algo
    sumaDe1y1();
}
void opcion3()
{

    const int numeroFijo = 3;
    const int resultado = (numeroFijo * numeroFijo);
    printf("Has seleccionado la opcion 3.\n");
    // usar una constante
    printf("Valor de la constante al cuadrado = %d", resultado);
    printf("\n");
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
