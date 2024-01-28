package listadodirectorio; // Paquete

import java.io.File; // Importación de la clase File del paquete java.io

public class ListadoDirectorio {

    public static void main(String[] args) {
        // Método principal - "main"
        
        // PARTE 1: ARGUMENTOS
        // Variables utilizadas: ruta 
        // Tipo de la variable: String 
        // Valor de la variable: cambiante (dependiendo de si se proporcionan argumentos)
		String ruta=".";
		
		// String ruta="C:\\ZZ-DATOS";
    	 
        // Si se proporcionan argumentos [if(args.length >= 1)], se usa el primer argumento como "ruta."
        // De lo contrario, se establece la ruta actual como "ruta."
    	 if(args.length>=1) ruta=args[0];

        // PARTE 2: CREACIÓN DEL OBJETO "fich"
        // Variables utilizadas: fich
        // Tipo de la variable: File
        // Valor de la variable: cambiante (dependiendo de la ruta especificada)

        // Se crea un objeto "fich" de la clase "File" con la ruta especificada.
        File fich = new File(ruta);

        // PARTE 3: CONDICIONES
        // Variables utilizadas: fich, ruta
        // Tipo de las variables: File, String
        // Valor de las variables: cambiante (dependiendo de la ruta especificada y si el archivo/directorio existe)

        // Si el archivo o directorio no existe [if (!fich.exists())]...
        if (!fich.exists()) {
            // ...se muestra un mensaje por consola.
            System.out.println("No existe el fichero o directorio (" + ruta + ").");
        }
        // En caso de que exista...
        else {
            // Variables utilizadas: fich , ruta 
            // Tipo de las variables: File, String
            // Valor de las variables: cambiante (dependiendo de la ruta especificada y si el archivo/directorio existe)

            // ...se verifica si es un fichero o un directorio utilizando ".isFile()".
            // Si "fich" es un fichero...
            if (fich.isFile()) {
                // ...se muestra un mensaje indicando que es un fichero.
                System.out.println(ruta + " es un fichero.");
            }
            // Si "fich" no es un fichero (por lo tanto, es un directorio)...
            else {
                // ...se muestra un mensaje indicando que es un directorio y se listan los contenidos.
                System.out.println(ruta + " es un directorio. Contenidos: ");
                
                // Variables utilizadas: ficheros, f, textoDescr 
                // Tipo de las variables: File[] (array de objetos File), File, String
                // Valor de las variables: cambiante (dependiendo de los contenidos del directorio)

                // Se obtiene una lista de ficheros con ".listFiles()" y se almacena en un array llamado "ficheros."
                File[] ficheros = fich.listFiles();

                // Se recorren los elementos de "ficheros" usando un bucle "for each."
                for (File f : ficheros) {
                    // Variables utilizadas: f , textoDescr 
                    // Tipo de las variables: File, String
                    // Valor de las variables: cambiante (dependiendo de si el elemento es un directorio o un fichero)

                    // Se determina el tipo de elemento (directorio o fichero) y se crea "textoDescr" en consecuencia.
                    String textoDescr=f.isDirectory() ? "/" :
                        f.isFile() ? "_" : "?";                    
                    // Se muestra el nombre del elemento precedido por "textoDescr" para indicar su tipo.
                    System.out.println("(" + textoDescr + ") " + f.getName());
                }
            }
        }
    }
}



