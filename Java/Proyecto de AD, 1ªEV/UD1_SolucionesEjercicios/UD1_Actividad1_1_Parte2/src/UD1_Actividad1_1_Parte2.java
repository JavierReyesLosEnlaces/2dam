/* Muestra los ficheros (archivos o directorios) de
 * un determinado directorio que se cargan en 
 * un array de elementos tipo String usando el m�todo list()
 * El nombre del directorio a listar se pasa 
 * como par�metro al m�todo main
 */


import java.io.File;

public class UD1_Actividad1_1_Parte2 {
	public static void main(String[] args) {
		if (args.length != 1) {
			System.out.println("HAY QUE INTRODUCIR UN ARGUMENTO...");
			System.exit(0);
		}
		//String dir = args[0];
		String dir = "C:\\Users\\javir\\Desktop\\random";

		System.out.println("Archivos en el directorio " + dir);
		File f = new File(dir);
		if (f.exists()) {
			String[] archivos = f.list();
			for (int i = 0; i < archivos.length; i++) {
				System.out.println(archivos[i]);
			}
		} else
			System.out.println("DIRECTORIO INEXISTENTE");

	}
}
