#include <stdio.h>                                  holamundo.c                                                   #include <stdio.h>
#include <stdlib.h>

void opcion1() {
    // Opción 1: cambio de números

    printf("Introduce un número 1: \n");
    scanf("%d", &numero1);

    printf("Introduce un número 2: \n");
    scanf("%d", &numero2);

    &numero3 = &numero2;
    &numero2 = &numero1;
    &numero1 = &numero3;

    printf("Valor del numero 1: "+&numero1);
    printf("Valor del numero 2: "+&numero2);
    printf("Valor del numero 3: "+&numero3);
}

void opcion2() {
    // Código para la opción 2
    printf("Has seleccionado la opción 2.\n");
}

void opcion3() {
    // Código para la opción 3
    printf("Has seleccionado la opción 3.\n");
}

int main() {
    int opcion;
    int numero1, numero2, numero3;

    do {
        // Mostrar el menú
        printf("Menú:\n");
        printf("1. Hacer cambio de números\n");
        printf("2. Opción 2\n");
        printf("3. Opción 3\n");
        printf("0. Salir\n");
        printf("Selecciona una opción: ");
        scanf("%d", &opcion);

        //%d -> lee y recoge: lo mete en 

        // Procesar la selección del usuario
        switch(opcion) {
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
                printf("Saliendo del programa. ¡Hasta luego!\n");
                break;
            default:
                printf("Opción inválida. Por favor, selecciona una opción válida.\n");
                break;
        }
    } while(opcion != 0);

    return 0;
}
