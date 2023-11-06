#include <stdio.h>
#include <stdlib.h>
// Ejercicios resueltos aprenderaprogramar.com
int main() {
    int turismos, todoterrenos;    
    int capTurismos, capTodot;
    int necesidadesCom;

//  Numero de vehículos y capacidades
    printf ("Introduce el numero de turismos: ");
    scanf ("%d", &turismos);
    printf ("Introduce el numero de todoterrenos: ");
    scanf ("%d", &todoterrenos);
    printf ("Introduce la capacidad de los turismos (litros): ");
    scanf ("%d", &capTurismos);
    printf ("Introduce la capacidad de los todoterrenos (litros): ");
    scanf ("%d", &capTodot);

//Cálculo de necesidades de combustible
    necesidadesCom = turismos * capTurismos + todoterrenos * capTodot;
    printf ("Las necesidades de combustible totales son (litros): %d \n", necesidadesCom);
    return 0;
}