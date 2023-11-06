#include <stdio.h>
#include <stdlib.h>
#include <math.h>
// Ejercicio resuelto aprenderaprogramar.com
int main() {
    const double Pi = 3.141593; //Número pi como constante
    double D, H, R, V;
//  Datos
    printf ("Introduzca el diametro, en metros: "); scanf ("%lf", &D);
    printf ("Introduzca la altura, en metros: "); scanf ("%lf", &H);
//Cálculo
    double potencia = 0;
    
    R = D/2; 
    potencia = pow(R, 2.0);
    V = Pi * potencia * H;
    printf ("El volumen del cilindro es de %lf metros cubicos\n", V);
   return 0;
}