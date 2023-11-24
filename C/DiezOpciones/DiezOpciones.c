// Importación de las librerías.
#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/wait.h>
#include <time.h>

// Declaración de las funciones principales.
void opcion1();
void opcion2();
int opcion3();
int opcion4();
void opcion5();
void opcion6();
void opcion7();
void opcion8();
int opcion9();
void opcion10();

// Declaración de las funciones auxiliares.
void limpiarBuffer();
void limpiarSaltoDeLinea(char valor[]);

// Función "main"
int main() {
    int numero;
    do {
        printf("\n");
        printf("0.  Salir\n");
        printf("1.  Sumar dos números\n");
        printf("2.  Operación de calculadora\n");
        printf("3.  Generar un número aleatorio\n");
        printf("4.  Cuenta atrás\n");
        printf("5.  Familia de procesos\n");
        printf("6.  Mensaje entre padre e hijo\n");
        printf("7.  Crear lista de amigos\n");
        printf("8.  Invertir tu nombre\n");
        printf("9.  Escribir un fichero de texto\n");
        printf("10. Borrar todos los ficheros de texto\n");
        printf("--> Selecciona una opcion: \n");

        scanf("%d", &numero);
        limpiarBuffer();

        switch (numero) {
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
                printf("Saliendo del programa. ¡Hasta luego!\n\n");
                break;
            default:
                printf("Opcion invalida. Por favor, selecciona una opcion valida.\n");
                break;
        }
    } while (numero != 0);
    // El programa se ejecutó correctamente.
    return 0;
}

// Opción 1:
// Esta función toma dos números por consola, los suma y muestra el resultado.
void opcion1() {
    // Se declaran las variables.
    float n1, n2, suma;

    // Se pide un primer número por consola y se limpia el buffer.
    printf("Introduce el primer número: ");
    scanf("%f", &n1);
    limpiarBuffer();

    // Se pide un segundo número por consola y se limpia el buffer.
    printf("Introduce el segundo número: ");
    scanf("%f", &n2);
    limpiarBuffer();

    // Se lleva a cabo la suma y se muestra el resultado con un formato de dos decimales.
    suma = n1 + n2;
    printf("Resultado de la suma: %.2f\n", suma);
}

// Opción 2:
// Esta función realiza operaciones básicas (+, -, *, /) con dos números introducidos por el usuario.
void opcion2() {
    // Se declara un array de caracteres en donde se incluyen los distintos operadores.
    char listaOperadores[] = {'+', '-', '*', '/'};
    // Se declaran el resto de variables.
    char operador;
    int input;
    float numero1, numero2, resultado;

    // Se pide un primer número por consola y se limpia el buffer.
    printf("Número 1: ");
    scanf("%f", &numero1);
    limpiarBuffer();

    // Se pide un segundo número por consola y se limpia el buffer.
    printf("Número 2: ");
    scanf("%f", &numero2);
    limpiarBuffer();

    // Se lleva a cabo un do-while junto a un switch-case para pedir el valor "input" por consola.
    // La variable "input" debe ser un número entre 1 y 4. 
    do {
        printf("1. +\n2. -\n3. *\n4. /\nOperador:");
        // Se pide un número por consola y se limpia el buffer.
        scanf("%d", &input);
        limpiarBuffer();
        // Cada número asigna un operador distinto y un modelo de cálculo distinto para el resultado.
        switch (input) {
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
    } while (input < 1 || input > 4);
    // Se muestra la operación completa con un formato de dos decimales.
    printf("%.2f %c %.2f = %.2f\n", numero1, operador, numero2, resultado);
}

// Opción 3:
// Esta función genera un número aleatorio dentro de un rango definido por el usuario.
int opcion3() {
    // Se inicializa la semilla para la generación de números aleatorios.
    srand(time(NULL));
    // Se declaran las variables
    int numeroMin, numeroMax, rango, numeroAleatorio;

    // Se pide un número mínimo por consola y se limpia el buffer.
    printf("Escoge un número mínimo: ");
    scanf("%d", &numeroMin);
    limpiarBuffer();

    // Se pide un número máximo por consola y se limpia el buffer.
    printf("Escoge un número máximo: ");
    scanf("%d", &numeroMax);
    limpiarBuffer();
    
    //Se genera el rango de números posibles y el número aleatorio dentro del rango.
    rango = numeroMax - numeroMin + 1;
    numeroAleatorio = rand() % rango + numeroMin;

    // Se verifica que el número máximo sea mayor que el mínimo y se muestran los resultados correspondientes.
    if (numeroMax > numeroMin) {
        printf("Número aleatorio = %d\n", numeroAleatorio);
        // El programa se ejecutó correctamente.
        return 0;
    } else {
        printf("El número máximo debe ser mayor que el número mínimo, vuelve a intentarlo.\n");
        // El programa no se ejecutó correctamente.
        return 1;
    }
}

// Opción 4:
// Esta función pide al usuario introducir un número entre 1 y 10.
// Acto seguido se realiza una cuenta atrás desde el número introducido hasta el 0.
int opcion4() {
    // Se declara la variable
    int segundos;

    // Se pide un número entre por consola  y se limpia el buffer.
    printf("Introduce un número entre 1 y 10 segundos para la cuenta atrás: ");
    scanf("%d", &segundos);
    limpiarBuffer();

    // Se verifica que el número se encuentra en el rango de 1 y 10 y se muestran los resultados correspondientes.
    if (segundos < 1 || segundos > 10) {
        printf("El número introducido no es válido.\n");
        // El programa no se ejecutó correctamente.
        return 1;
    } else {
        printf("Empezando la cuenta atrás.\n");
        // Se crea un loop descendiente desde el número de segundos establecido a 0.
        // En cada iteración se muestra el segundo, se fuerza la salida del buffer de salida y se pausa la ejecución durante 1 segundo.
        for (int i = segundos; i >= 0; i--) {
            printf("%d\n", i);
            fflush(stdout);
            sleep(1);
        }
        // Cuando se llega al final del bucle, se muestra un mensaje.
        printf("Cuenta atrás terminada.\n");
        // El programa se ejecutó correctamente.
        return 0;
    }
}

// Opción 5:
// Esta función crea un proceso padre, un proceso hijo y un proceso nieto.
// La función también muestra sus ids e indica cuando se pasa de un proceso a otro.
void opcion5() {
    // Se declaran las variables para almacenar los IDs de procesos.
    pid_t pid1, pid2;

    // Se crea el primer hijo.
    switch (pid1 = fork()) {
        case -1:
            // Si hay un fallo al crear el hijo, se imprime un mensaje de error y se finaliza la ejecución.
            perror("Error creando el hijo");
            exit(EXIT_FAILURE);
        case 0:
            // Código ejecutado por el primer hijo.
            printf("Se ha creado el hijo, su ID es %d\n", getpid());

            // Se crea el nieto dentro del primer hijo.
            switch (pid2 = fork()) {
                case -1:
                    // Si hay un fallo al crear el nieto, se imprime un mensaje de error y se finaliza la ejecución.
                    perror("Error creando el nieto");
                    exit(EXIT_FAILURE);
                case 0:
                    // Código ejecutado por el nieto: se muestra su id y se termina su ejecución con éxito.
                    printf("Se ha creado el nieto, su ID es %d\n", getpid());
                    exit(EXIT_SUCCESS);
                default:
                    // El primer hijo espera a que el nieto termine.
                    wait(NULL);
                    printf("He terminado el nieto y nos encontramos con el hijo...\n");
            }
            // El primer hijo sale del programa con éxito.
            exit(EXIT_SUCCESS);
        default:
            // El proceso padre espera a que el primer hijo termine.
            wait(NULL);
            printf("He terminado el hijo y nos encontramos con el padre...\n");
            printf("El ID del padre es %d\n", getpid());
    }
}

// Opción 6:
// Esta función implementa la comunicación entre un proceso padre y un proceso hijo mediante la creación de una pipe.
void opcion6() {
    // Se declara un array para almacenar los descriptores de la pipe.
    int pipe_fd[2];

    // Se crea la pipe y se verifica si hay algún error.
    if (pipe(pipe_fd) == -1) {
        perror("Error creando el pipe");
        exit(EXIT_FAILURE);
    }

    // Se crea un nuevo proceso hijo.
    pid_t pid = fork();

    // Se verifica si hubo algún error al crear el proceso hijo.
    if (pid == -1) {
        perror("Error creando el proceso hijo");
        exit(EXIT_FAILURE);
    }
    // El siguiente código es ejecutado por el proceso hijo.
    if (pid == 0) {
        // Se cierra el extremo de escritura ya que no se usará
        close(pipe_fd[1]); 

        // Se lee el mensaje enviado por el proceso padre desde la pipe.
        char mensajeRecibido[50];
        read(pipe_fd[0], &mensajeRecibido, sizeof(char[50]));

        // Se muestra el mensaje recibido por el proceso hijo.
        printf("Proceso hijo recibió '%s' y se emocionó.\n", mensajeRecibido);

        // Se cierra el extremo de lectura
        close(pipe_fd[0]); 
    // El siguiente código es ejecutado por el proceso hijo.
    } else {
        // Se cierra el extremo de lectura ya que no se usará
        close(pipe_fd[0]); 

        // Se declara el mensaje que el proceso padre enviará al proceso hijo.
        char mensajeParaHijo[50] = "¡Te quiero hijo!";

        // Se escribe el mensaje en la pipe para que el proceso hijo lo reciba.
        write(pipe_fd[1], &mensajeParaHijo, sizeof(char[50]));

        // Se muestra el mensaje enviado por el proceso padre.
        printf("Proceso padre dijo '%s'\n", mensajeParaHijo);

        // Se cierra el extremo de escritura y se espera a que el hijo termine
        close(pipe_fd[1]); 
        wait(NULL); 
    }
}

   

// Opción 7:
// Esta función solicita información por consola: número de amigos, nombres y edades de amigos.
// Luego, muestra una lista con la información proporcionada y la suma total de las edades.
void opcion7() {
    // Se define una estructura para almacenar información de un amigo.
    struct Amigo {
        char nombre[100];
        int edad;
    };
    // Se declara un arreglo de estructuras para almacenar información de hasta 10 amigos.
    struct Amigo amigo[20];  
    // Se declaran el resto de variables
    int numeroAmigos, edadTotal = 0;

    // Se pide al usuario ingresar la cantidad de amigos por consola y se limpia el buffer.
    printf("Vamos a crear una lista de tus amigos.\n¿Cuántos amigos tienes? ");
    scanf("%d", &numeroAmigos);
    limpiarBuffer();

    // Se emplea un bucle para recopilar información de cada amigo y meterlo en las distintas instancias de la estructura.
    for (int i = 0; i < numeroAmigos; i++) {
        printf("--------------------------------------------\n");
        printf("Introduce el nombre de tu amigo nº%d: ", i + 1);

        // Se pide el nombre con "fgets()" y "limpiarSaltoDeLinea()" para evitar problemas con la entrada y el salto de línea.
        fgets(amigo[i].nombre, sizeof(amigo[i].nombre), stdin);
        limpiarSaltoDeLinea(amigo[i].nombre);

        // Se pide la edad, se actualiza la suma total de edades y se limpia el buffer.
        printf("Introduce la edad de tu amigo nº%d: ", i + 1);
        scanf("%d", &amigo[i].edad);
        edadTotal += amigo[i].edad;
        limpiarBuffer();
    }

    // Se muestra una lista con la información de cada instancia y la suma total de edades.
    printf("--------------------------------------------\n");
    printf("LISTA DE TUS MEJORES AMIGOS\n");
    for (int i = 0; i < numeroAmigos; i++) {
        printf("Amigo nº%d:\n", i + 1);
        printf("- Nombre: %s\n", amigo[i].nombre);
        printf("- Edad: %d\n", amigo[i].edad);
    }
    printf("Tus amigos suman una edad total de %d.\n", edadTotal);
}

// Opción 8:
// La función pide el nombre de usuario y lo muestra invertido.
void opcion8() {
    // Se declaran las variables
    char nombre[50];
    char nombreInverso[50];
      
    // Se pide el nombre con "fgets()" y "limpiarSaltoDeLinea()" para evitar problemas con la entrada y el salto de línea.
    printf("Introduce tu nombre: ");
    fgets(nombre, sizeof(nombre), stdin);
    limpiarSaltoDeLinea(nombre);

    // Se recorre un bucle con un número de iteraciones igual a la longitud del nombre introducido
    // Por cada iteración, se toma la última letra de "nombre" y se añade en orden a "nombreInverso"
    for (int i = strlen(nombre) - 1, j = 0; i >= 0; i--, j++) {
        nombreInverso[j] = nombre[i];
    }

    // Se agrega el carácter nulo al final de "nombreInverso" para asegurar que sea una cadena de caracteres válida
    nombreInverso[strlen(nombre)] = '\0';

    // Se muestran los resultados
    printf("Nombre original: %s\n", nombre);
    printf("Nombre inverso: %s\n", nombreInverso);
}

// Opción 9:
// La función solicita al usuario un nombre de fichero y un texto.
// Luego, crea un fichero de texto en la ubicación actual con el nombre y el texto introducidos.

int opcion9() {
    // Se declaran las variables
    char nombreFichero[50];
    char texto[50];
    char comando[100];

    // Se pide el nombre del fichero con "fgets()" y "limpiarSaltoDeLinea()" para evitar problemas con la entrada y el salto de línea.
    printf("Introduce el nombre del fichero:\n");
    fgets(nombreFichero, sizeof(nombreFichero), stdin);
    limpiarSaltoDeLinea(nombreFichero); 

    // Se pide el texto a escribir en el fichero con "fgets()" y "limpiarSaltoDeLinea()" para evitar problemas con la entrada y el salto de línea.
    printf("Escribe lo que quieras:\n");
    fgets(texto, sizeof(texto), stdin);
    limpiarSaltoDeLinea(texto); 

    // Se utiliza "snprintf" para construir el comando del sistema que se usará para crear el fichero.
    snprintf(comando, sizeof(comando), "echo \"%s\" >> \"%s.txt\"", texto, nombreFichero);
    // Se ejecuta el comando del sistema utilizando la función system().
    system(comando);
    // El programa se ejecutó correctamente.
    return 0;
}


// Opción 10:
// La función borra todos los ficheros de texto en la ubicación actual.
// Si no existen ficheros de texto, muestra un mensaje informando de ello.
void opcion10() {
    // Se concatenan los comandos "ls" para listar los archivos y "grep -c '.txt'" para contar el número de archivos que contienen ".txt".
    // El resultado (un número) se mete dentro de un fichero temporal llamado "contador.md" de nueva creación.
    system("(ls | grep -c '.txt') > contador.md");

    // Se intenta abrir el archivo 'contador.md' para leer el valor.
    FILE *archivo = fopen("contador.md", "r");

    // Se verifica si se ha abierto correctamente el archivo.
    if (archivo == NULL) {
        printf("No se ha abierto correctamente.");
    } else {
        // Se declara la variable "valor"
        int valor;
      
        // Se lee el número dentro de 'contador.md' y se almacena en la variable "valor".
        fscanf(archivo, "%d", &valor);
        // Se cierra el archivo.
        fclose(archivo);

        // Se verifica si existe o no algún fichero ".txt" por medio de la variable "valor" (valor es igual o distinto de cero). 
        // Si no hay ninguno, se muestra un mensaje. Si lo hay, se muestra otro distinto y se borran todos los archivos ".txt".
        // En ambos casos, se ejecuta un comando para borrar "comando.md".
        if (valor == 0) {
            printf("No hay ningún fichero '.txt'\n");
            system("rm contador.md");
        } else {
            // Se utiliza el comando "rm" para borrar todos los archivos con extensión ".txt".
            system("rm *.txt");
            printf("Se ha(n) borrado con éxito\n");
            // Se elimina el archivo 'contador.md' después de la operación.
            system("rm contador.md");
        }
    }
}

// limpiarBuffer():
// Esta función auxiliar vacía el buffer de entrada. Sirve para descartar caracteres restantes en el buffer después de la lectura.
// Se utiliza para evitar problemas al utilizar "scanf()".
void limpiarBuffer() {
    int caracter;
    // Se utiliza un bucle while para leer y descartar caracteres hasta llegar a un salto de línea o el final del archivo.
    // getchar() lee un caracter del buffer de entrada.
    // El bucle se ejecuta mientras el caracter no sea un salto de línea o el final del archivo (EOF).
    while ((caracter = getchar()) != '\n' && caracter != EOF);
}

// limpiarSaltoDeLinea(char valor[]):
// Esta función elimina el salto de línea de la variable "valor" introducida como parámetro.
// Se utiliza para evitar problemas con el salto de línea al utilizar "fgets()".
void limpiarSaltoDeLinea(char valor[]) {
    // Se verifica si la longitud de la cadena es mayor que cero y si el último caracter es un salto de línea.
    if ((strlen(valor) > 0) && (valor[strlen(valor) - 1] == '\n')) {
        // Si se cumple la condición, se reemplaza el salto de línea por el carácter nulo '\0'.
        valor[strlen(valor) - 1] = '\0';  
    }
}