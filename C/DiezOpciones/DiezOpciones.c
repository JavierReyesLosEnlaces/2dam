#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h> 
#include <sys/types.h>
#include <sys/wait.h>

void opcion1();
int opcion2();
void opcion3();
void opcion4();

void mostrar();

int main()
{
    char opcion[50];
    int numero;
    do
    {
        printf("\n1. Escribir un fichero\n");
        printf("2. Cuenta atrás\n");
        printf("3. Familia de procesos\n");
        printf("4. Mejores amigos\n");
        printf("5. Opcion 5\n");
        printf("6. Opcion 6\n");
        printf("7. Opcion 7\n");
        printf("8. Opcion 8\n");
        printf("9. Opcion 9\n");
        printf("10. Opcion 10\n");
        printf("0. Salir\n");
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
                //opcion5;
                break;
            case 6:
                //opcion6;
                break;
            case 7:
                //opcion7;
                break;
            case 8:
                //opcion8;
                break;
            case 9:
                //opcion9;
                break;
            case 10:
                //opcion10;
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

// HAY QUE SOLUCIONAR EL PROBLEMA DE LA DETECCIÓN DE ESPACIOS EN BLANCO

// Opción 1: introducir un nombre de fichero, un texto y te crea el fichero con el texto dentro
void opcion1() {
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

// Opción 2: dame un numero de segundos entre 0 y 10 segundos para la cuenta atrás
int opcion2() {
    int segundos;  
    printf("Introduce un número entre 1 y 10 segundos para la cuenta atrás:\n");
    scanf("%d", &segundos);

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

void opcion4(){
    struct Amigo
    {
        char nombre[100];
        int edad;
    };

    struct Amigo mejoresAmigos[2];

    printf("Quiero saber de tus dos mejores amigos...\n");
    
    printf("Introduce el nombre de tu primer amigo:\n");
    scanf("%s", &mejoresAmigos[0].nombre);

    printf("Introduce la edad de tu primer amigo:\n");
    scanf("%d", &mejoresAmigos[0].edad);

    printf("Introduce el nombre de tu segundo amigo:\n");
    scanf("%s", &mejoresAmigos[1].nombre);

    printf("Introduce la edad de tu segundo amigo:\n");
    scanf("%d", &mejoresAmigos[1].edad);

    printf("Tus mejores amigos:\n");
    for (int i = 0; i < 2; i++)
    {
        printf("Amigo %d:\n", i+1);
        printf("-> Nombre: %s\n", mejoresAmigos[i].nombre);
        printf("-> Edad: %d\n", mejoresAmigos[i].edad);
    }
}