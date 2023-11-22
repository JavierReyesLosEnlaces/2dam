#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h> 
#include <sys/types.h>
#include <sys/wait.h>
#include <time.h>

void opcion1();
int opcion2();
void opcion3();
void opcion4();
int opcion5();
int opcion6();
void opcion7();
void opcion8();
int opcion9();
int opcion10();

void limpiarBuffer();

void mostrar();

int main()
{
    char opcion[50];
    int numero;
    do
    {
        printf("\n");
        printf("0.  Salir (Terminado)\n");
        printf("1.  Sumar dos números (Terminado)\n");
        printf("2.  Cuenta atrás (Terminado)\n");
        printf("3.  Familia de procesos (Terminado)\n");
        printf("4.  Mejores amigos (Terminado)\n");
        printf("5.  Escribir un fichero de texto (Terminado)\n");
        printf("6.  Borrar todos los ficheros de texto (Terminado)\n");
        printf("7.  Calculadora (Terminado)\n");
        printf("8.  Invertir tu nombre (Terminado)\n");
        printf("9.  Opcion 9\n");
        printf("10. Número aleatorio\n");
        printf("Selecciona una opcion: \n");
        fgets(opcion, sizeof(opcion), stdin);
        numero = atoi(opcion);

        switch (numero)
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
            case 4:
                opcion4();
                break;
            case 5:
                opcion5();
                break;
            case 6:
                opcion6();
                break;
            case 7:
                opcion7();
                break;
            case 8:
                opcion8();
                break;
            case 9:
                opcion9();
                break;
            case 10:
                opcion10();
                break;
            case 0:
                printf("Saliendo del programa. Hasta luego!\n\n");
                break;
            default:
                printf("Opcion invalida. Por favor, selecciona una opcion valida.\n");
                break;
        }
    } while (numero != 0);
    return 0;
}

// Opción 1: Suma de números
void opcion1(){
    int n1, n2, suma;

    printf("Introduce el primer número:\n");
    scanf("%d", &n1);
    limpiarBuffer();

    printf("Introduce el segundo número:\n");
    scanf("%d", &n2);
    limpiarBuffer();

    suma = n1 + n2;
    printf("Resultado de la suma: %d\n", suma);
}

// Opción 2: dame un numero de segundos entre 0 y 10 segundos para la cuenta atrás
int opcion2() {

    int segundos;  
    printf("Introduce un número entre 1 y 10 segundos para la cuenta atrás:\n");
    scanf("%d", &segundos);
    limpiarBuffer();

    printf("Empezando la cuenta atrás.\n");

    if(segundos <1 || segundos > 10){
        printf("El número introducido no es válido.\n");
        return 1;
    }else{
        for (int i = segundos; i >= 0; i--){
            printf("%d\n", i);
            fflush(stdout);
            sleep(1);
        }    
        printf("Cuenta atrás terminada.\n");
        return 0;
    }
}

// Opción 3: crear un proceso hijo y sacar sus ids
void opcion3() {
    pid_t pid1;
    switch (pid1 = fork()) {
        case -1:
            printf("Error creando el hijo.\n");
            exit(EXIT_FAILURE);
            break;
        case 0:
            printf("\nSe ha creado el hijo, su ID es %d\n", getpid());
            pid_t pid2;
            switch (pid2 = fork()) {
                case -1:
                    printf("Error creando el nieto.\n");
                    exit(EXIT_FAILURE);
                    break;
                case 0:
                    printf("Se ha creado el nieto, su ID es %d\n", getpid());
                    exit(EXIT_SUCCESS);
                    break;
                default:
                    wait(NULL);  // Espera al nieto
                    printf("He terminado el nieto y nos encontramos con el hijo...\n");
            }
            exit(EXIT_SUCCESS);
            break;
        default:
            wait(NULL);  // Espera al hijo
            printf("He terminado el hijo y nos encontramos con el padre...\n");
            printf("El ID del padre es %d\n", getpid());
            break;
    }
}

// Opción 4: mejores amigos
void opcion4(){
    struct Amigo
    {
        char nombre[100];
        int edad;
    };

    struct Amigo mejoresAmigos[2];

    printf("Quiero saber de tus dos mejores amigos...\n");
    
    printf("Introduce el nombre de tu primer amigo:\n");
    fgets(mejoresAmigos[0].nombre, sizeof(mejoresAmigos[0].nombre), stdin);

    printf("Introduce la edad de tu primer amigo:\n");
    scanf("%d", &mejoresAmigos[0].edad);
    limpiarBuffer();

    printf("Introduce el nombre de tu segundo amigo:\n");
    fgets(mejoresAmigos[1].nombre, sizeof(mejoresAmigos[1].nombre), stdin);

    printf("Introduce la edad de tu segundo amigo:\n");
    scanf("%d", &mejoresAmigos[1].edad);
    limpiarBuffer();

    printf("\nTus mejores amigos:\n");
    for (int i = 0; i < 2; i++)
    {
        printf("Amigo %d:\n", i+1);
        printf("-> Nombre: %s", mejoresAmigos[i].nombre);
        printf("-> Edad: %d\n", mejoresAmigos[i].edad);
    }
    printf("Juntos suman una edad de %d\n", (mejoresAmigos[0].edad+mejoresAmigos[1].edad));
}

// Opción 5: introducir un nombre de fichero, un texto y te crea el fichero con el texto dentro
int opcion5() {
    char nombreFichero[50];
    char texto[50];
    char comando[100];

    printf("Introduce el nombre del fichero:\n");
    fgets(nombreFichero, sizeof(nombreFichero), stdin);
    if ((strlen(nombreFichero) > 0) && (nombreFichero[strlen(nombreFichero) - 1] == '\n'))
    {
        nombreFichero[strlen(nombreFichero) - 1] = '\0';
    }

    printf("Escribe lo que quieras:\n");
    fgets(texto, sizeof(texto), stdin);
    if ((strlen(texto) > 0) && (texto[strlen(texto) - 1] == '\n'))
    {
        texto[strlen(texto) - 1] = '\0';
    } 
    snprintf(comando, sizeof(comando), "echo \"%s\" >> \"%s.txt\"", texto, nombreFichero);
    system(comando);    
}

// Opción 6: borrar todos los ficheros.txt
int opcion6(){

    system("(ls | grep -c '.txt')>contador.md"); //ls + contar archivos que contengan *.txt + meter el valor en contador.md
    FILE *archivo = fopen("contador.md", "r"); //se intenta abrir contador.md

    if(archivo==NULL){
        printf("No se ha abierto correctamente.");
        return 1;
    }else{
        int valor;
        fscanf(archivo, "%d", &valor); //se lee el número de contador.md y se mete dentro de la variable valor
        if(valor == 0){
            printf("No hay ningún fichero '.txt'\n");
            return 1;
        } else { //2>/dev/null elimina el mensaje de error
            system("rm *.txt");
            printf("Se ha(n) borrado con éxito\n");
            return 0;
        }
    }
} 

// Opción 7: Calculadora
void opcion7(){
    char listaOperadores[] = {'+', '-', '*', '/'};
    char operador;
    int input;
    float numero1, numero2, resultado;

    printf("Número 1: ");
    scanf("%f", &numero1);
    limpiarBuffer();

    printf("Número 2: "); 
    scanf("%f", &numero2);
    limpiarBuffer();

    do{
        printf("1. +\n2. -\n3. *\n4. /\nOperador:");
        scanf("%d", &input);
        limpiarBuffer();

        switch(input){
            case 1: 
                operador = listaOperadores[0];
                resultado = numero1 + numero2;
                break;
            case 2: 
                operador = listaOperadores[1];
                resultado = numero1 - numero2;
                break;
            case 3: 
                operador = listaOperadores[2];
                resultado = numero1 * numero2;
                break;
            case 4: 
                operador = listaOperadores[3];
                resultado = numero1 / numero2;
                break;
            default:
                printf("Opción inválida\n");
                break;
        }
    }while(input<1 || input>4);  
    printf("%.2f %c %.2f = %.2f\n", numero1, operador, numero2, resultado);
}

// Opción 8: Introduce un nombre y te lo invierte
void opcion8(){
    char nombre[50];
    char nombreInverso[50] = "";

    printf("Introduce tu nombre: ");
    fgets(nombre, sizeof(nombre), stdin);
    
    for (int i = strlen(nombre)-1, j=0; i >= 0 ; i--, j++)
    {
        nombreInverso[j] = nombre[i];
    }
    
    nombreInverso[sizeof(nombreInverso)] = '\0';  

    printf("Nombre %s", nombre);
    printf("Nombre inverso: %s", nombreInverso);
}

int opcion9(){
// Declare the pipe outside the function
    int tuberia[2];
    char mensaje[50];

    // Create the pipe
    if (pipe(tuberia) == -1) {
        perror("Error creating pipe");
        return -1;
    }

    strcpy(mensaje, "Hola! Soy el padre hablando por la tubería!");

    write(tuberia[1], mensaje, strlen(mensaje));
    close(tuberia[1]);
    return 0;
}

int opcion10(){
    srand(time(NULL));
    int numeroMin, numeroMax, rango, numeroAleatorio;

    printf("Escoge un número mínimo:");
    scanf("%d", &numeroMin);
    limpiarBuffer();

    printf("Escoge un número máximo:");
    scanf("%d", &numeroMax);
    limpiarBuffer();

    rango = numeroMax-numeroMin+1;
    numeroAleatorio = rand()%rango+numeroMin;
    printf("Número aleatorio = %d", numeroAleatorio);
    return 0;
}

// función auxiliar, limpiarBuffer() 
void limpiarBuffer(){
    int c;
    while ((c=getchar()) != '\n' && c!=EOF);
}