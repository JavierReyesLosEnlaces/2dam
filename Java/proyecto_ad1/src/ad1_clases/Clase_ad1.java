package ad1_clases; // nos encontramos dentro de un paquete llamado "ad1_clases"

import java.io.File; // se importa la clase "File", la cuál proviene de un paquete llamado "java.io"

public class Clase_ad1 { // clase pública llamada "Clase_ad1"

	public static void metodo(String[] args) //se declara un método público, estático y que no devuelve ningún valor (void)
	{
		//Se instancia un objeto llamado "file" de la clase "File"
		/*
		 * En este objeto metemos como parámetro "args[0], el cual representa el primer argumento pasado
		 * desde la línea de comandos al programa. En este caso, se está utilizando para proporcionar una 
		 * ruta de directorio como argumento al constructor de la clase File para crear un objeto File que
		 *  representa un directorio en el sistema de archivos.
		 * */
		File file = new File(args[0]);
		
		//En el caso de que el objeto "file" sea un directorio...
		if(file.isDirectory()) {
			//... se crea un array de ficheros formado por los elementos que devuelve file.listFiles()
			// file.listFiles() lista los archivos y directorios que se encuentran dentro de 
			File[] ficheros = file.listFiles();
			
			for(File f: ficheros) System.out.println(f.getName());
		}
	}
}
