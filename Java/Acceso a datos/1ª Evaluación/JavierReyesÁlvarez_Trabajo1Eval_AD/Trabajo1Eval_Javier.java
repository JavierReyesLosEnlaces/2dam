
// Imports necesarios para el programa
import java.io.*;
import java.util.Scanner;
import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.transform.Transformer;
import javax.xml.transform.TransformerFactory;
import javax.xml.transform.dom.DOMSource;
import javax.xml.transform.stream.StreamResult;

import org.w3c.dom.Document;
import org.w3c.dom.Element;

public class Trabajo1Eval {
	// Esta es la función "main"
	public static void main(String[] args) {
		// teclado -> objeto de la clase "Scanner" que uso para pedir input del usuario por consola
		Scanner teclado = new Scanner(System.in); 
		// opcion -> entero que se utiliza para la elección del subprograma en el menú
		int opcion; 
		do {
			// Menú de subprogramas dentro de un do-while para que se siga pidiendo
			// introducir una opción hasta introducir un 0 y finalizar el programa
			System.out.println("0. Salir");
			System.out.println("1. Ver Directorio (VerDir)");
			System.out.println("2. Ver Informacion (VerInf)");
			System.out.println("3. Leer Fichero de Texto (LeerFichTextoBuff)");
			System.out.println("4. Escribir Fichero de Texto (EscribirFichtextoBuff)");
			System.out.println("5. Leer Objeto Persona (LeerFichObject)");
			System.out.println("6. Escribir Objeto Persona (EscribirFichObject)");
			System.out.println("7. Leer Fichero Aleatorio (LeerFichAleatorio)");
			System.out.println("8. Escribir Fichero Aleatorio (EscribirFichAleatorio)");
			System.out.println("9. Leer Registro Específico de Fichero Aleatorio (LeerFichAleatorioUnReg)");
			System.out.println("10. Insertar Registro en Fichero Aleatorio (EscribirFichAleatorioUnReg)");
			System.out.println("11. Crear un fichero XML a partir de los datos de un fichero aleatorio existente (CrearEmpleadoXml)");
			System.out.println(" ");
			System.out.println("Introduce un num: ");
			// Se pide un entero por consola y se introduce dentro de la variable "opcion"
			opcion = teclado.nextInt();
			// switch-case -> dependiendo del valor de "opcion" tiene lugar un evento u otro
			// Si "opcion" es distinto de 0, se vuelve a mostrar el menú, si "opcion" es 0 se sale del programa
			switch (opcion) {
			case 0:
				// Se sale del programa
				System.out.println("Has salido. ");
				break;
			case 1:
				// Se pide la ruta de un fichero y se mete como parámetro en el método
				// "VerDir()"
				System.out.println("Introduce la ruta del directorio: ");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				VerDir(teclado.next());
				System.out.println(" ");
				break;
			case 2:
				// Se pide la ruta de un fichero y se mete como parámetro en el método
				// "VerInf()"
				System.out.println("Introduce la ruta del directorio: ");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				VerInf(teclado.next());
				System.out.println(" ");
				break;
			case 3:
				// Se pide la ruta del fichero y se mete como parámetro en el método
				// "LeerFichTextoBuff()"
				System.out.println("Introduce la ruta del fichero de texto para escribir: ");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				LeerFichTextoBuff(teclado.next());
				System.out.println(" ");
				break;
			case 4:
				// Se pide la ruta del fichero y se mete como parámetro en el método
				// "EscribirFichTextoBuff()"
				System.out.println("Introduce la ruta del fichero de texto para leer:");
				EscribirFichTextoBuff(teclado.next());
				System.out.println(" ");
				break;
			case 5:
				// Se pide la ruta del fichero y se mete como parámetro en el método
				// "LeerFichObject()"
				System.out.println("Introduce la ruta del fichero para leer objetos Persona:");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				LeerFichObject(teclado.next());
				System.out.println(" ");
				break;
			case 6:
				// Se pide la ruta del fichero y se mete como parámetro en el método
				// "EscribirFichObject()"
				System.out.println("Introduce la ruta del fichero para escribir objetos Persona:");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				EscribirFichObject(teclado.next());
				System.out.println(" ");
				break;
			case 7:
				// Se pide la ruta del fichero aleatorio y se mete como parámetro en el método
				// "LeerFichAleatorio()"
				System.out.println("Introduce la ruta del fichero aleatorio para escribir datos: ");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				LeerFichAleatorio(teclado.next());
				System.out.println(" ");
				break;
			case 8:
				// Se pide la ruta del fichero aleatorio y se mete como parámetro en el método
				// "EscribirFichAleatorio()"
				System.out.println("Introduce la ruta del fichero aleatorio para leer datos: ");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				EscribirFichAleatorio(teclado.next());
				System.out.println(" ");
				break;
			case 9:
				// Se pide las rutas del fichero aleatorio y el número de registro a leer y se
				// meten como parámetros en el método "LeerFichAleatorioUnReg()"
				System.out.println("Introduce la ruta del fichero aleatorio para leer un registro: ");
				String rutaFichero = teclado.next();
				System.out.println("Introduce el número del registro a leer: ");
				int numeroRegistro = teclado.nextInt();
				// Se ejecuta el método con los parámetros indicados y se hace un salto de línea
				LeerFichAleatorioUnReg(rutaFichero, numeroRegistro);
				System.out.println(" ");
				break;
			case 10:
				// Se pide la ruta del fichero aleatorio y se mete como parámetro en el método
				// "EscribirFichAleatorioUnReg()"
				System.out.println("Introduce la ruta del fichero aleatorio para insertar un registro: ");
				// Se ejecuta el método con el parámetro indicado y se hace un salto de línea
				EscribirFichAleatorioUnReg(teclado.next());
				System.out.println(" ");
				break;
			case 11:
				// Se piden las rutas del fichero de entrada y la ruta del fichero de salida y
				// se meten como parámetro en el método "convertirAXml()"
				System.out.println("Introduce la ruta del fichero aleatorio que quieres usar: ");
				String inputPath = teclado.next(); // Lee la ruta de entrada desde la consola
				System.out.println("Introduce la ruta del archivo XML de salida: ");
				String outputPath = teclado.next(); // Lee la ruta de salida desde la consola
				// Se ejecuta el método con los parámetros indicados y se hace un salto de línea
				convertirAXml(inputPath, outputPath);
				System.out.println(" ");
				break;
			default:
				// Cualquier otro input que no haya sido indicado anteriormente -> se muestra "Opción inválida"
				System.out.println("Opcion invalida");
				break;
			}
		// Mientras la opción sea 0, se seguirá preguntando
		} while (opcion != 0); 
		// Se cierra el teclado
		teclado.close();
	}

	private static void VerDir(String ruta) {
		// Con la ruta de directorio introducida, se crea un objeto de la clase File
		// llamado directorio que apunta a dicha ruta
		File directorio = new File(ruta);
		// Si "directorio" existe y es un directorio
		if (directorio.exists() && directorio.isDirectory()) {
			// Se obtiene la lista de ficheros (archivos o directorios) en el directorio y
			// se mete en un array de Strings
			String[] listaFicheros = directorio.list();
			// Si la lista no está vacia y tiene uno o más elementos, se listan dichos elementos
			if (listaFicheros != null && listaFicheros.length > 0) {
				System.out.println("Archivos en el directorio:");
				// Se itera sobre la lista, por cada nombre de archivo dentro de la lista
				for (String nombreFichero : listaFicheros) {
					// Se construye la ruta completa del archivo y se mete dentro de la variable "rutaCompleta"
					String rutaCompleta = directorio.getAbsolutePath() + File.separator + nombreFichero;

					// Se verifica si es un fichero o un directorio por medio de un operador ternario
					File fichero = new File(rutaCompleta);
					String tipo = fichero.isFile() ? "Fichero" : "Directorio";
					// Se muestra por pantalla el nombre del archivo y si es fichero o directorio
					// dentro de un paréntesis
					System.out.printf("%s (%s)%n", nombreFichero, tipo);
				}
				// Si la lista está vacia o tiene 0 elementos, se muestra este mensaje
			} else {
				System.out.println("El directorio está vacío.");
			}
			// Si el directorio no existe o "directorio" no es un directorio, se muestra este mensaje
		} else {
			System.out.println("La ruta no es un directorio válido.");
		}
	}

	private static void VerInf(String ruta) {
		// Con la ruta de fichero introducida, se crea un objeto de la clase File
		// llamado fichero que apunta a dicha ruta
		File fichero = new File(ruta);
		// Si el fichero existe, se muestra la siguiente información del fichero por medio de los siguientes métodos
		// Hay más pero he puesto estos porque considero que son suficientes para mostrar que los entiendo, están explicados en las siguientes líneas
		if (fichero.exists()) {
			System.out.println("Atributos del fichero:");
			System.out.println("Nombre: " + fichero.getName());
			System.out.println("Ruta: " + fichero.getPath());
			System.out.println("Ruta Absoluta: " + fichero.getAbsolutePath());
			System.out.println("Es un archivo?: " + fichero.isFile());
			System.out.println("Es un directorio?: " + fichero.isDirectory());
			System.out.println("Puede leerse?: " + fichero.canRead());
			System.out.println("Puede escribirse?: " + fichero.canWrite());
			System.out.println("Tamanyo en bytes: " + fichero.length() + " bytes");
			// Si el fichero no existe se muestra el siguiente mensaje
		} else {
			System.out.println("El fichero no existe.");
		}
	}

	private static void LeerFichTextoBuff(String ruta) {
		// Se intenta crear un objeto "br" de la clase "BufferedReader" por medio de un try-catch
		// Un BufferedReader necesita de un objeto de la clase "FileReader" y este a su
		// vez necesita de otro de la clase "File"
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (BufferedReader br = new BufferedReader(new FileReader(new File(ruta)))) {
			String linea;
			// Un while loop
			// Se crea la variable "linea" que equivale a una línea que lee el búffer en
			// cada iteración (linea = br.readLine())
			// El BufferedReader se va a dedicar a leer líneas hasta que se encuentre con
			// una línea vacía, cuando esto ocurra el BufferReader se cerrará
			while ((linea = br.readLine()) != null) {
				// Cada vez que se muestra una línea, se muestra por pantalla. De esa manera
				// estamos "leyendo" el documento
				System.out.println(linea);
			}
			// Se cierra el BufferedReader
			br.close();
			// En el caso de no poder crearse el BufferedReader, se lanza una excepción
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	private static void EscribirFichTextoBuff(String ruta) {
		// Se abre el teclado
		Scanner teclado = new Scanner(System.in);
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		File file = new File(ruta);
		// Se intenta crear un objeto "bw" de la clase "BufferedWriter" por medio de un try-catch
		// Un BufferedWriter necesita de un objeto de la clase "FileWriter" y este a su
		// vez necesita de otro de la clase "File"
		try (BufferedWriter bw = new BufferedWriter(new FileWriter(file))) {
			// Se pide introducir el texto por consola. Para terminar de escribir se pide
			// poner un punto y presionar "Enter"
			System.out.println(
					"Introduce el texto a escribir en el fichero:\nPara terminar de escribir, pon punto final y presiona 'Enter'");
			// Se crea la variable "linea" que equivale a una línea que escribe el búffer en cada iteración (linea = teclado.nextLine())
			String linea;
			// Se crea la variable booleana "control" que nos ayudará a desempenyar la lógica del subprograma
			boolean control = false;

			do {
				// Mientras control sea "false", se pide introducir texto por consola y se
				// introduce dentro de la variable "linea"
				linea = teclado.nextLine();
				// Se escribe el contenido de "linea" dentro del fichero
				bw.write(linea);
				// Se empieza una nueva línea (salto de linea)
				bw.newLine();
				// Si el contenido de "linea" es un punto, la variable control se vuelve "true"
				// y se deja de escribir (se sale del do-while)
				if (linea.endsWith(".")) {
					control = true;
				}
			} while (!control);
			// Mensaje de confirmación y se cierra el BufferedWriter
			System.out.println("Texto escrito en el fichero.");
			bw.close();
			// En el caso de no poder crearse el BufferedWriter, se lanza una excepción
		} catch (Exception e) {
			e.printStackTrace();
		}
		// Se cierra el teclado
		teclado.close();
	}

	private static void LeerFichObject(String ruta) {
		// Se intenta crear un objeto "ois" de la clase "ObjectInputStream" por medio de un try-catch
		// Un ObjectInputStream necesita de un objeto de la clase "FileInputStream" y
		// este a su vez necesita de otro de la clase "File"
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream(new File(ruta)))) {
			// Se crea un bucle infinito para leer objetos hasta que se alcance el final del archivo
			while (true) {
				try {
					// Se intenta leer un objeto de tipo Persona desde el flujo de entrada
					Persona persona = (Persona) ois.readObject();
					// Se imprime en consola la información del objeto Persona leído
					System.out.println("Objeto Persona leído del fichero: " + persona);
				} catch (EOFException e) {
					// En el caso de no poder leerse más, se lanza una excepción EOF (End of file) y
					// se muestra un mensaje avisando de ello
					System.out.println("Fin del archivo.");
					// Se sale del bucle
					break;
				}
			}
			// En el caso de no poder crearse el ObjectInputStream, se lanza una excepción
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	private static void EscribirFichObject(String ruta) {
		// Se abre el teclado
		Scanner teclado = new Scanner(System.in);
		// Se intenta crear un objeto "oos" de la clase "ObjectOutputStream" por medio
		// de un try-catch
		// Un ObjectOutputStream necesita de un objeto de la clase "FileOutputStream" y
		// este a su vez necesita de otro de la clase "File"
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (ObjectOutputStream oos = new MiObjectOutputStream(new FileOutputStream(new File(ruta), true))) {
			// Se abre un objeto "teclado" de la clase Scanner para que el usuario escriba por consola
			// Acto seguido, se piden introducir los datos "nombre" y "edad" del 			
			// objeto de la clase "Persona", se guardan dentro de variables
			System.out.println("Introduce los datos de la Persona:");
			System.out.print("Nombre: ");
			String nombre = teclado.nextLine();
			System.out.print("Edad: ");
			int edad = teclado.nextInt();
			// Se crea un objeto "persona" de la clase "Persona" con esos parámetros
			Persona persona = new Persona(nombre, edad);
			// El ObjectOutputStream escribe el objeto dentro del fichero y se lanza un
			// mensaje de confirmación
			oos.writeObject(persona);
			System.out.println("Objeto Persona escrito en el fichero.");
			// En el caso de no poder crearse el ObjectOutputStream, se lanza una excepción
		} catch (IOException e) {
			e.printStackTrace();
		}
		// Se cierra el teclado
		teclado.close();
	}

	private static void LeerFichAleatorio(String ruta) {
		// Se intenta crear un objeto "raf" de la clase "RandomAccessFile" por medio de
		// un try-catch de lectura "r"
		// "RandomAccessFile" proporciona métodos para leer y escribir datos en un
		// archivo de manera no secuencial (permite acceder a cualquier posición en el archivo)
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "r")) {
			// Definimos el tamanyo de cada registro en bytes
			int tamanyoRegistro = 36;
			// Obtenemos el tamanyo total del fichero mediante un ".length()"
			long tamanyoFichero = raf.length();
			// Leemos registros desde el fichero aleatorio
			// Mientras la posición del puntero sea menor al tamanyo del fichero (la opción
			// contraria es imposible) se llevan a cabo una serie de lecturas
			while (raf.getFilePointer() < tamanyoFichero) {
				// Se lee el identificador del empleado y se guarda dentro de la variable "identificador"
				int identificador = raf.readInt();
				// Se lee el apellido del empleado y se guarda dentro de la variable "apellido"
				// Para esta lectura he creado el método leerCadenaConBuffer() que se encuentra
				// al final del documento y que se emplea en otros subprogramas más adelante
				String apellido = leerCadenaConBuffer(raf, 10);
				// Se lee el numero de departamento del empleado y se guarda dentro de la
				// variable "numeroDepartamento"
				int numeroDepartamento = raf.readInt();
				// Se lee el salario del empleado y se guarda dentro de la variable "salario"
				double salario = raf.readDouble();
				// Por último, se muestran los resultados obtenidos en una línea
				System.out.printf("Identificador: %d, Apellido: %s, Número de Departamento: %d, Salario: %.2f%n", identificador, apellido.trim(), numeroDepartamento, salario);
			}
			// En el caso de no poder crearse el RandomAccessFile, se lanza una excepción
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	private static void EscribirFichAleatorio(String ruta) {
		// Se intenta crear un objeto "raf" de la clase "RandomAccessFile" por medio de
		// un try-catch de lectura y escritura ("rw")
		// "RandomAccessFile" nos ofrece métodos para leer y escribir datos en un
		// archivo de manera no secuencial (permite acceder a cualquier posición en el archivo)
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "rw")) {
			// Creamos datos de ejemplo para que se generen datos aleatorios en el fichero
			int[] identificadores = { 1, 2, 3, 4, 5 };
			String[] nombres = { "Javier", "Carlos", "Nadia", "Ionut", "Lily" };
			int[] numerosDepartamento = { 101, 102, 103, 104, 105 };
			double[] salarios = { 30000.0, 40000.0, 50000.0, 1000000.0, 90000.0 };
			// Hay que definir un número de bytes para el tamanyoi del registro
			// Creamos una variable "tamanyoRegistro" que almacenarnya el tamanyo total de
			// cada registro en bytes
			int tamanyoRegistro = 36;
			// Iteramos sobre los identificadores, uno a uno
			// En cada iteración se hace lo siguiente: 
			for (int i = 0; i < identificadores.length; i++) {
				// Movemos el puntero al inicio del registro actual multiplicando el índice por
				// el tamanyo del registro
				raf.seek(i * tamanyoRegistro);
				// Escribimos cada campo del registro en el archivo
				raf.writeInt(identificadores[i]); // Se escribe el identificador del empleado
				// Se escribe el nombre del empleado, para ello he creado el método
				// escribirCadenaConBuffer()
				// El método puede encontrarse al final del documento en la parte de "MÉTODOS
				// AUXILIARES" y se usa en otros subprogramas
				escribirCadenaConBuffer(raf, nombres[i], 10);
				// Se escribe el número del departamento
				raf.writeInt(numerosDepartamento[i]); 
				// Se escribe el salario
				raf.writeDouble(salarios[i]); 
			}
			// Se informa de que los registros han sido escritos
			System.out.println("Registros escritos en el fichero aleatorio.");
			// En el caso de no poder crearse el RandomAccessFile, se lanza una excepción
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	private static void LeerFichAleatorioUnReg(String ruta, int numeroRegistro) {
		// Se intenta crear un objeto "raf" de la clase "RandomAccessFile" por medio de
		// un try-catch de lectura y escritura ("rw"), como en el método anterior
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "rw")) {
			// Creamos una variable "tamanyoRegistro" que almacenará el tamanyo total de
			// cada registro en bytes
			int tamanyoRegistro = 36;
			// Se calcula la posición y nos posicionamos allí
			long posicion = (numeroRegistro - 1) * tamanyoRegistro;
			raf.seek(posicion);
			// Se leen los datos del registro
			int identificador = raf.readInt();
			String apellido = leerCadenaConBuffer(raf, 10);
			int numeroDepartamento = raf.readInt();
			double salario = raf.readDouble();
			// y se muestran en un print
			System.out.printf(
					"Registro %d: Identificador: %d, Apellido: %s, Número de Departamento: %d, Salario: %.2f%n",
					numeroRegistro, identificador, apellido.trim(), numeroDepartamento, salario);
			// En el caso de no poder crearse el RandomAccessFile, se lanza una excepción
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	private static void EscribirFichAleatorioUnReg(String ruta) {
		// Se intenta crear un objeto "raf" de la clase "RandomAccessFile" por medio de
		// un try-catch de lectura y escritura ("rw"), como en el método anterior
		// Pasamos la ruta del fichero introducida como parámetro al objeto de clase "File"
		try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "rw")) {
			// Ahora creamos algunos datos de ejemplo para escribir en el fichero aleatorio
			// Identificador, nombre, numero de departamento y salario
			int identificador = 6;
			String nombre = "Javier";
			int numeroDepartamento = 106;
			double salario = 100000.0;

			// De nuevo, una variable "tamanyoRegistro" que almacenará el tamanyo total de
			// cada registro en bytes
			int tamanyoRegistro = 36; // Tamanyo de cada registro en bytes
			// Se calcula la posición y nos posicionamos allí
			long posicion = (identificador - 1) * tamanyoRegistro;
			raf.seek(posicion);
			// Por último se escriben estos datos en el fichero aleatorio
			raf.writeInt(identificador);
			escribirCadenaConBuffer(raf, nombre, 10);
			raf.writeInt(numeroDepartamento);
			raf.writeDouble(salario);
			// Se informa de que los registros han sido escritos
			System.out.println("Registro insertado en el fichero aleatorio.");
		} catch (IOException e) {
			e.printStackTrace();
		}
	}

	/*
	 * He creado el método "convertirAXml()" para transformar un archivo de texto
	 * que contenga nombres y edades como este:
	 
	 * Juan 25 María 30 Pedro 22 Ana 28
	 * 
	 * en un fichero XML:
	 * 
	 *		<?xml version="1.0" encoding="UTF-8" standalone="no"?>
	 *		<Personas>
	 *			<Persona>
	 *				<Nombre>Juan</Nombre>
	 *				<Edad>25</Edad>
	 *			</Persona>
	 *			<Persona>
	 *				<Nombre>María</Nombre>
	 *				<Edad>30</Edad>
	 *			</Persona>
	 *			<Persona>
	 *				<Nombre>Pedro</Nombre>
	 *				<Edad>22</Edad>
	 *			</Persona>
	 *			<Persona>
	 *				<Nombre>Ana</Nombre>
	 *				<Edad>28</Edad>
	 *			</Persona>
	 *		</Personas>
	 */

	public static void convertirAXml(String inputPath, String outputPath) {
		// Comenzamos con un try-catch para capturar posibles excepciones
		try {
			// Hay que crear un objeto de la clase "DocumentBuilderFactory"
			DocumentBuilderFactory documentBuilderFactory = DocumentBuilderFactory.newInstance();

			// A raiz de "documentBuilderFactory" creamos otro objeto de la clase "DocumentBuilder"

			DocumentBuilder documentBuilder = documentBuilderFactory.newDocumentBuilder();

			// y a partir de "documentBuilder" creamos otro de la clase "Document"
			Document document = documentBuilder.newDocument();

			// Creamos el elemento raíz llamado "Personas" y lo incluimos dentro
			Element rootElement = document.createElement("Personas");
			document.appendChild(rootElement);

			// Ahora intentamos leer datos desde el archivo de entrada mediante un "BufferedReader"
			// El FileReader apuntará hacia el fichero de entrada, es decir, el fichero de texto
			try (BufferedReader reader = new BufferedReader(new FileReader(inputPath))) {
				String line;
				// La variable "line" representa cada línea que se lee por el búffer
				// Se van a leer líneas hasta que no se puedan leer más (line==null)
				while ((line = reader.readLine()) != null) {
					// Supongamos que, como en el ejemplo de arriba, cada línea en el archivo tiene
					// el formato "Nombre Edad"
					// Se crea un array de strings, separando los elementos de la línea por el
					// espacio y posteriormente metiendo esa información en variables
					String[] parts = line.split(" ");
					String nombre = parts[0];
					String edad = parts[1];

					// Se crea un elemento "Persona"
					Element personaElement = document.createElement("Persona");

					// Se crean elementos "Nombre" y "Edad" y se marca la jerarquía entre estos
					// elementos y el elemento "Persona"
					// "Nombre" y "Edad" se configuran como elementos hijo de "Persona"
					Element nombreElement = document.createElement("Nombre");
					nombreElement.appendChild(document.createTextNode(nombre));
					personaElement.appendChild(nombreElement);

					Element edadElement = document.createElement("Edad");
					edadElement.appendChild(document.createTextNode(edad));
					personaElement.appendChild(edadElement);

					// Se agrega el elemento "Persona" al elemento raíz
					rootElement.appendChild(personaElement);
				}
			}

			// A continuación se transforma el documento en un archivo XML con formato
			// Para ello hay que crear objetos de tipo "TransformerFactory" y "Transformer"
			TransformerFactory transformerFactory = TransformerFactory.newInstance();
			Transformer transformer = transformerFactory.newTransformer();

			// Se añade el siguiente formato: "indent" -> Respetar la indentación
			transformer.setOutputProperty("indent", "yes");
			// Y mantener una indentación de 2 espacios
			transformer.setOutputProperty("{http://xml.apache.org/xslt}indent-amount", "2");

			// Creamos un objeto de la clase "DOMSource" que representa el documento XML que
			// se va a transformar.
			DOMSource source = new DOMSource(document);

			// Se usa un "FileWriter" para escribir en el nuevo fichero (el xml), el cual
			// indicamos que es "outputPath"
			try (FileWriter fileWriter = new FileWriter(outputPath)) {
				// Se utiliza la clase "StreamResult" para especificar la ubicación del 
				// archivo de salida
				StreamResult result = new StreamResult(fileWriter);
				// Realizamos la transformación
				transformer.transform(source, result);
			}
			// Mensaje de confirmación
			System.out.println("Conversión a XML completada exitosamente.");
			// En el caso de no poder crearse el RandomAccessFile, se lanza una excepción
		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	// MÉTODOS Y CLASES AUXILIARES
	// Método para leer cadenas con búffers
	private static String leerCadenaConBuffer(RandomAccessFile raf, int longitud) throws IOException {
		// Se crea un array de caracteres para almacenar la cadena
		char[] buffer = new char[longitud];
		// Después se itera sobre cada caracter en el array y se lee desde el archivo
		for (int i = 0; i < longitud; i++) {
			buffer[i] = raf.readChar();
		}
		// Por último se devuelve la cadena construida a partir del array de caracteres
		return new String(buffer);
	}

	// Método para escribir cadenas con búffers
	private static void escribirCadenaConBuffer(RandomAccessFile raf, String cadena, int longitud) throws IOException {
		// Se crea un array de caracteres con la longitud definida como parámetro
		char[] buffer = new char[longitud];
		// Se itera sobre los caracteres de la cadena
		// Luego se rellena el array con los caracteres de la cadena
		for (int i = 0; i < longitud; i++) {
			// Si el índice es menor que la longitud definida anteriormente, se llena con
			// los caracteres
			if (i < cadena.length()) {
				buffer[i] = cadena.charAt(i);
			} else {
				// Si la cadena es más corta que la longitud deseada, se llena con espacios en blanco
				buffer[i] = ' ';
			}
		}
		// Por último escribimos la cadena en el fichero aleatorio
		raf.writeChars(new String(buffer));
	}

	// Clase Persona sencilla que implementa Serializable
	// Se usa para escribir objetos"Persona" en los subprogramas 5 y 6
	public static class Persona implements Serializable {
		private String nombre;
		private int edad;

		public Persona(String nombre, int edad) {
			this.nombre = nombre;
			this.edad = edad;
		}

		public String toString() {
			return "Persona{nombre='" + nombre + "', edad=" + edad + '}';
		}
	}

	// Clase MiObjectOutputStream para evitar la escritura de la cabecera
	// MiObjectOutputStream es una clase que extiende ObjectOutputStream para evitar
	// la excepción "StreamCorruptedException"
	public static class MiObjectOutputStream extends ObjectOutputStream {
		public MiObjectOutputStream(OutputStream out) throws IOException {
			super(out);
		}
	}
}