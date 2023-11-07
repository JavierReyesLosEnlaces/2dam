#include <stdio.h>
#include <stdlib.h>

int main()
{

    /*
    int age;
    printf("Introduce tu edad: \n");
    scanf("%d", &age); // aquí hay que usar el ampersand
    printf("Tienes %d anios\n", age);
    */

    char name[4];
    printf("Introduce tu nombre: ");
    scanf("%s", name);
    printf("Tu nombre es %s", name);
    return 0;
}