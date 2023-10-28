package ad1_ejecutables;  // Paquete - nos encontramos dentro de un paquete llamado "ad1_ejecutable"

public class Ejecutable_ad1 {
    /*
	     Clase pública llamada "Ejecutable_ad1". Esta clase contiene el método principal "main"
	     que se ejecutará al iniciar la aplicación.
     */

    public static void main(String[] args) {
        /*
	         Método principal - "main". Este método es el punto de entrada de la aplicación.
	         que no devuelve ningún valor (void)

	         Variable utilizada: argumentos (variable)
	         Tipo de la variable: String[] (array de cadenas)
	         Valor de la variable: constante (contiene una cadena "C:\\" como valor inicial)
         */
        String[] argumentos = { "C:\\" };

        /*
	         Llamada a un método estático de otra clase
	         Método: Clase_ad1.metodo
	         Clase: Clase_ad1
	         Paquete: ad1_clases
	         
	         La línea de código está llamando al método metodo() de la clase Clase_ad1 en el
	         paquete ad1_clases, y le está pasando el array de cadenas argumentos como argumento. 
	         
        */
        ad1_clases.Clase_ad1.metodo(argumentos);
    }
}


