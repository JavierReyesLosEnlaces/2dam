#include <stdio.h>
#include <stdlib.h>

// definición de una constante
const int VERDADERO = 1;
const int FALSO = 0;

int es_cierto(){
    return VERDADERO;
}

int funcion_devolver(int lo_que_entra)
{
    int lo_que_sale;
    return lo_que_sale = lo_que_entra+1;
}

void subprograma_no_devolvible(int lo_que_entra)
{
    int lo_que_se_hace = lo_que_entra+1;
    printf("Hago lo que quiero con lo que entra:\n ");
}

int suma(int numero1, int numero2){
    return numero1+numero2;
}

int main(int argc, char *argv[])
{
    /*    
    int lo_que_entra = 0;
    printf("El valor devuelto por la funcion devolver es %d\n",funcion_devolver(lo_que_entra));
    */

    if(es_cierto()){
        printf("Es verdadero. ");
    }else{
        printf("Es falso ");
    }
    printf("\n");
    subprograma_no_devolvible(3);
    return 0;
}