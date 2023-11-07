#include <stdio.h>
#include <stdlib.h>

int main()
{
    char nombre[10] = "Javier";
    int edad = 29;
    double porcentaje = 0.9;

    printf("Mi nombre es %s\n", nombre); //%s recoge string
    printf("Y tengo %d anios\n", edad);  //%d recoge int
    printf("Mi porcentaje de conocimiento de C es %f", porcentaje);

    return 0;
}