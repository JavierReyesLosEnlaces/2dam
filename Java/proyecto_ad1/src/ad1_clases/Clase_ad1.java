package ad1_clases; 	 // Paquete - nos encontramos dentro de un paquete llamado "ad1_clases"

import java.io.File; 	 // Importación de la clase "File", la cual proviene de un paquete llamado "java.io"

public class Clase_ad1 { // Clase pública llamada "Clase_ad1"

    public static void metodo(String[] args) {
	/*
    	Método público y estático llamado "metodo" que no devuelve ningún valor (void)

        Se instancia un objeto llamado "file" de la clase "File"
        Variable utilizada: file (variable)
        Tipo de la variable: File (objeto)
        Valor de la variable: cambiante (dependiendo del argumento pasado como "args[0]")
      
        En este objeto "file" metemos como parámetro "args[0]", el cual representa el primer argumento pasado
        desde la línea de comandos al programa. En este caso, se está utilizando para proporcionar una 
        ruta de directorio como argumento al constructor de la clase File para crear un objeto File que
        representa un directorio en el sistema de archivos.
    */
        File file = new File(args[0]);

    /*
         En el caso de que el objeto "file" sea un directorio...
         
         Variable utilizada: file (variable)   
         Tipo de la variable: File (objeto)
         Valor de la variable: cambiante (dependiendo del argumento pasado como "args[0]")
     */

        if (file.isDirectory()) {
        /*
            ... se crea un array de ficheros formado por los elementos que devuelve file.listFiles()
            file.listFiles() lista los archivos y directorios que se encuentran dentro del directorio representado por "file"
            Variable utilizada: ficheros (variable)
            Tipo de la variable: File[] (array de objetos File)
            Valor de la variable: cambiante (dependiendo de los archivos y directorios dentro del directorio "file")
        */

            File[] ficheros = file.listFiles();

            /*
	            Se recorren los elementos del array "ficheros" utilizando un bucle "for each".
	             
	            Variable utilizada: f (variable)
	            Tipo de la variable: File (objeto)
	            Valor de la variable: cambiante (dependiendo de los elementos en "ficheros")
            */

            for (File f : ficheros) {
                System.out.println(f.getName());  // Se muestra el nombre del archivo o directorio
            }
        }
    }
}




