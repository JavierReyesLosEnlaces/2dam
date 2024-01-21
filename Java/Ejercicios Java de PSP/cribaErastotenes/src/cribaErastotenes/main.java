package cribaErastotenes;

public class main {

    public static void main(String[] args) {
        int numero = 100;
        System.out.println("El numero " + numero + " contiene " + cribaErastotenes(numero) + " numeros primos. ");
    }

    public static int cribaErastotenes(int n) {
    	
        // Inicializamos un arreglo de booleanos para representar números primos.
    	
        boolean[] lista = new boolean[n + 1];
        for (int i = 2; i <= n; i++) {
            lista[i] = true; // Suponer que todos son primos inicialmente.
        }
        /*
        La lista es un array de booleanos del 2 al 10, por ahora todos son true (todos son primos)
        boolean[] lista = [true, true, true, true, true, true, true, true, true];

        Eliminamos múltiplos de números primos marcándolos como compuestos.
        Si cogemos un numero primo y vemos todos sus multiplos, estos múltiplos no pueden ser primos porque 
        tendrían como divisor al primer numero primo
        */
        
        for (int p = 2; p * p <= n; p++) {
            if (lista[p]) {
                for (int i = p * p; i <= n; i += p) {
                    lista[i] = false;
                }
            }
        }

        int contador = 0;
        
        // Contar y devolver la cantidad de números primos.
        for (int i = 2; i <= n; i++) {
            if (lista[i]) {
                contador++;
            }
        }

        return contador;
    }
}

					//El numero 100 contiene 25 numeros primos. 





