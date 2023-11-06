#include <stdio.h>
#include <stdlib.h>

int funcion2( int entra) {

	int sale = 0;

	return sale = entra * 2;
}


int main() {

	int numero_aliados = 54;

	printf("Hola Mundo \n");
	printf ("Actualmente, nos quedan %d aliados \n",  numero_aliados);


	printf ("Pero ayer teniamos %d aliados, que es el doble \n",  funcion2(numero_aliados));


	return 0;
}
