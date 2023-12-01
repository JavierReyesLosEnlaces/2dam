import java.io.File;

public class main {

	public static void main(String[] args) {		
		String ruta;
		int opcion;
		
		do {
			
			
			
		}while(x != =);
		
		mostrarInfo(ruta);

	}

	private static void mostrarInfo(String ruta) {
		File f = new File(ruta);
		
		// El método .listFiles() lista todos los archivos incluidos dentro del path especificado en "dir"
		// Se utiliza el método "listFiles()" del objeto "f" para almacenar en un array los nombres de los archivos contenidos en el path
		File[] listaFicheros = f.listFiles();		
		
		// Se muestra por consola el número de ficheros, que es igual a la longitud del array generado
		System.out.printf("Ficheros en el directorio actual: %d %n", listaFicheros.length);
		
		// Se recorre "listaFicheros" mediante un bucle for
		// En cada iteración del bucle se selecciona uno de los ficheros
		// Se obtiene la siguiente información de cada fichero: su nombre, si es un fichero o si es un directorio 
		// Esta información se muestra por consola
		for (int i = 0; i < listaFicheros.length; i++) {
			File f2 = listaFicheros[i];
			System.out.printf("Nombre: %s, es fichero?: %b, es directorio?: %b %n", 
					f2.getName(), f2.isFile(), f2.isDirectory());
		}		
		
	}

}
