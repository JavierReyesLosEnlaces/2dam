#include <stdio.h>
#include <unistd.h>
#include <string.h>

int main() {
    int fd[2]; // fd[0] es para lectura, fd[1] es para escritura
    char mensaje_padre[] = "Hola hijo!";
    char mensaje_hijo[50];

    // Crear el pipe
    if (pipe(fd) == -1) {
        perror("pipe");
        return 1;
    }

    // Crear el proceso hijo
    pid_t pid = fork();

    if (pid == -1) {
        perror("fork");
        return 1;
    }

    if (pid == 0) {
        // Estamos en el proceso hijo
        close(fd[1]); // Cerrar el extremo de escritura

        // Leer desde el pipe
        read(fd[0], mensaje_hijo, sizeof(mensaje_hijo));
        printf("Proceso hijo: Mensaje recibido: %s\n", mensaje_hijo);

        close(fd[0]); // Cerrar el extremo de lectura
    } else {
        // Estamos en el proceso padre
        close(fd[0]); // Cerrar el extremo de lectura

        // Escribir en el pipe
        write(fd[1], mensaje_padre, strlen(mensaje_padre) + 1);

        close(fd[1]); // Cerrar el extremo de escritura
    }

    return 0;
}
