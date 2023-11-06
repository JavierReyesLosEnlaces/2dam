#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <sys/types.h>
#include <sys/ipc.h>
#include <sys/sem.h>

int main() {
    key_t key = ftok("semaphore_key", 'S'); // Genera una clave única
    int sem_id = semget(key, 1, IPC_CREAT | 0666); // Crea un semáforo

    if (sem_id == -1) {
        perror("semget");
        return 1;
    }

    struct sembuf sem_op;

    // Inicializa el semáforo a 1
    sem_op.sem_num = 0;
    sem_op.sem_op = 1;
    sem_op.sem_flg = 0;
    semctl(sem_id, 0, SETVAL, 1);

    pid_t pid = fork();

    if (pid == -1) {
        perror("fork");
        return 1;
    }

    if (pid == 0) {
        // Estamos en el proceso hijo
        sem_op.sem_op = -1; // Espera hasta que el semáforo sea 1
        semop(sem_id, &sem_op, 1);

        printf("Proceso hijo: Entrando en la sección crítica.\n");
        sleep(2); // Simula trabajo en la sección crítica

        sem_op.sem_op = 1; // Libera el semáforo
        semop(sem_id, &sem_op, 1);
    } else {
        // Estamos en el proceso padre
        sem_op.sem_op = -1; // Espera hasta que el semáforo sea 1
        semop(sem_id, &sem_op, 1);

        printf("Proceso padre: Entrando en la sección crítica.\n");
        sleep(2); // Simula trabajo en la sección crítica

        sem_op.sem_op = 1; // Libera el semáforo
        semop(sem_id, &sem_op, 1);
    }

    // Elimina el semáforo
    semctl(sem_id, 0, IPC_RMID);

    return 0;
}
