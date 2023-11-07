#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>

int main()
{
    int id = fork();
    printf("Hello World\n");
    return 0;
}