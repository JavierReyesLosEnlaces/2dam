#include <stdio.h>
#include <stdlib.h>
#include <fcntl.h>
#include <unistd.h>
#include <string.h>

int main()
{
    int fd;
    char mensaje[] = "Hola desde el escritor!\n";

    // Abre el FIFO en modo escritura
    fd = open("myfifo", O_WRONLY);

    if (fd < 0)
    {
        perror("open");
        return 1;
    }

    // Escribe en el FIFO
    write(fd, mensaje, strlen(mensaje) + 1);

    // Cierra el descriptor de archivo
    close(fd);

    return 0;
}
