#include <unistd.h>
#include <stdlib.h>
#include <stdio.h>
 
int main(int argc, char *argv[])
{
    char *args[] = { "/bin/ip", "-br","a",NULL};
 
    sleep(10);
    printf("Soy el primer hijo (%d, hijo de %d)\n",  getpid(), getppid());
    execv("/bin/ip", args);
 
    printf("Se ha producido un error al ejecutar execv.\n");
 
    return 0;
}