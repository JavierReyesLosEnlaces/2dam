/* Muestra los ficheros (archivos o directorios) 
 * de un determinado directorio que se cargan en
 * un array de elementos tipo File usando el método list()
 */

import java.io.File;

public class UD1_Actividad1_1_Parte1 {
	public static void main(String[] args) {
		String dir = ".";
		File f = new File(dir);
		File[] listaficheros= f.listFiles();		
		System.out.printf("Ficheros en el directorio actual: %d %n", 
                     listaficheros.length);
		for (int i = 0; i < listaficheros.length; i++) {
			File f2 = listaficheros[i];
			System.out.printf("Nombre: %s, es fichero?: %b, es directorio?: %b %n", 
					f2.getName(), f2.isFile(),f2.isDirectory());
		}
	}
}
