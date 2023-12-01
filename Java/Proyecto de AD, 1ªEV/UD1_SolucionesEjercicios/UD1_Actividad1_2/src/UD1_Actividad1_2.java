import java.io.*;
import java.util.Scanner;

public class UD1_Actividad1_2 {
    public static void main(String[] args) {
        Scanner teclado = new Scanner(System.in);
        String ruta;
        int opcion;

        do {
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
            
            System.out.println(" ");
            opcion = teclado.nextInt();
            
            switch (opcion) {
                case 0:
                    System.out.println("Fin del programa. ");
                    break;
                    
                    
                    
                    
                case 1:
                    System.out.println("Introduce la ruta del directorio: ");
                    VerDir(teclado.next());
                    break;
                case 2:
                    System.out.println("Introduce la ruta del directorio: ");
                    VerInf(teclado.next());
                    break;
                    
                    
                    
                    
                case 3:
                    System.out.println("Introduce la ruta del fichero de texto: ");
                    LeerFichTextoBuff(teclado.next());
                    break;
                case 4:
                    System.out.println("Introduce la ruta del fichero de texto para escribir: ");
                    EscribirFichTextoBuff(teclado.next());
                    break;
                
                
                
                case 5:
                    System.out.println("Introduce la ruta del fichero de texto para escribir: ");
                    LeerFichObject(teclado.next());
                    break;                                      
                case 6:
                    System.out.println("Introduce la ruta del fichero para escribir objetos Persona: ");
                    EscribirFichObject(teclado.next());
                    break;
                
                
                
                
                
                
                case 7:
                    System.out.println("Introduce la ruta del fichero aleatorio para escribir datos: ");
                    LeerFichAleatorio(teclado.next());;
                case 8:
                    System.out.println("Introduce la ruta del fichero aleatorio para leer datos: ");
                    EscribirFichAleatorio(teclado.next());
                    break;
                    
                    

                case 9:
                    System.out.println("Introduce la ruta del fichero aleatorio para leer un registro: ");
                    String rutaFichero = teclado.next();
                    System.out.println("Introduce el número del registro a leer: ");
                    int numeroRegistro = teclado.nextInt();
                    LeerFichAleatorioUnReg(rutaFichero, numeroRegistro); 
                    break;
                case 10:
                    System.out.println("Introduce la ruta del fichero aleatorio para insertar un registro: ");
                    EscribirFichAleatorioUnReg(teclado.next());
                    break;
                    
                    
                    
                    
                    
                    
                    
                    
                    
                default:
                    System.out.println("Opción inválida");
                    break;
            }
        } while (opcion != 0);
    }
    
    private static void VerDir(String ruta) {
        File directorio = new File(ruta);

        if (directorio.exists() && directorio.isDirectory()) {
            // Obtener la lista de ficheros (archivos o directorios) en el directorio
            String[] listaFicheros = directorio.list();

            if (listaFicheros != null && listaFicheros.length > 0) {
                System.out.println("Ficheros en el directorio:");
                for (String nombreFichero : listaFicheros) {
                    // Construir la ruta completa del fichero
                    String rutaCompleta = directorio.getAbsolutePath() + File.separator + nombreFichero;

                    // Verificar si es un archivo o directorio
                    File fichero = new File(rutaCompleta);
                    String tipo = fichero.isFile() ? "Archivo" : "Directorio";

                    System.out.printf("%s (%s)%n", nombreFichero, tipo);
                }
            } else {
                System.out.println("El directorio está vacío.");
            }
        } else {
            System.out.println("La ruta no es un directorio válido.");
        }
    }
    
    private static void VerInf(String ruta) {

        File fichero = new File(ruta);

        if (fichero.exists()) {
            System.out.println("Atributos del fichero:");
            System.out.println("Nombre: " + fichero.getName());
            System.out.println("Ruta: " + fichero.getPath());
            System.out.println("Ruta Absoluta: " + fichero.getAbsolutePath());
            System.out.println("Es un archivo?: " + fichero.isFile());
            System.out.println("Es un directorio?: " + fichero.isDirectory());
            System.out.println("Puede leerse?: " + fichero.canRead());
            System.out.println("Puede escribirse?: " + fichero.canWrite());
            System.out.println("Tamaño en bytes: " + fichero.length() + " bytes");
            System.out.println("Última modificación: " + fichero.lastModified());
        } else {
            System.out.println("El fichero no existe.");
        }
    }
    
    
    
    
    
    private static void LeerFichTextoBuff(String ruta) {
        try (BufferedReader br = new BufferedReader(new FileReader(new File(ruta)))) {
            String linea;
            while ((linea = br.readLine()) != null) {
                System.out.println(linea);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    private static void EscribirFichTextoBuff(String ruta) {
        try (BufferedWriter bw = new BufferedWriter(new FileWriter(new File(ruta)))) {
            Scanner teclado = new Scanner(System.in);
            System.out.println("Introduce el texto a escribir en el fichero (escribe 'FIN' para terminar):");
            String linea;
            while (!(linea = teclado.nextLine()).equalsIgnoreCase("FIN")) {
                bw.write(linea);
                bw.newLine();
            }
            System.out.println("Texto escrito en el fichero.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }

    
    
    
    private static void LeerFichObject(String ruta) {

        try (ObjectInputStream ois = new ObjectInputStream(new FileInputStream(new File(ruta)))) {
            while (true) {
                try {
                    // Intenta leer un objeto del archivo y hacer el cast a la clase Persona
                    Persona persona = (Persona) ois.readObject();
                    System.out.println("Objeto Persona leído: " + persona.toString());
                } catch (EOFException e) {
                    // Se lanza EOFException al llegar al final del archivo
                    System.out.println("Fin de archivo alcanzado.");
                    break;
                }
            }
        } catch (IOException | ClassNotFoundException e) {
            e.printStackTrace();
        }
    }  
    private static void EscribirFichObject(String ruta) {
        try (ObjectOutputStream oos = new MiObjectOutputStream(new FileOutputStream(new File(ruta), true))) {
            Scanner teclado = new Scanner(System.in);
            System.out.println("Introduce los datos de la Persona:");
            System.out.print("Nombre: ");
            String nombre = teclado.nextLine();
            System.out.print("Edad: ");
            int edad = teclado.nextInt();
            Persona persona = new Persona(nombre, edad);
            oos.writeObject(persona);
            System.out.println("Objeto Persona escrito en el fichero.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    
    
    
    private static void LeerFichAleatorio(String ruta) {
        try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "r")) {
            int tamañoRegistro = 36; // Tamaño de cada registro en bytes

            // Obtener el tamaño total del fichero
            long tamañoFichero = raf.length();

            // Leer registros desde el fichero aleatorio
            while (raf.getFilePointer() < tamañoFichero) {
                int identificador = raf.readInt();
                String apellido = leerCadenaConBuffer(raf, 10);
                int numeroDepartamento = raf.readInt();
                double salario = raf.readDouble();

                // Mostrar los datos leídos
                System.out.printf("Identificador: %d, Apellido: %s, Número de Departamento: %d, Salario: %.2f%n",
                        identificador, apellido.trim(), numeroDepartamento, salario);
            }
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    
    private static void EscribirFichAleatorio(String ruta) {
        try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "rw")) {
            // Datos de ejemplo para escribir en el fichero aleatorio
            int[] identificadores = { 1, 2, 3, 4, 5 };
            String[] apellidos = { "Smith", "Johnson", "Williams", "Jones", "Brown" };
            int[] numerosDepartamento = { 101, 102, 103, 104, 105 };
            double[] salarios = { 50000.0, 60000.0, 70000.0, 80000.0, 90000.0 };

            // Tamaño de cada registro en bytes
            int tamañoRegistro = 36;

            // Escribir registros en el fichero aleatorio
            for (int i = 0; i < identificadores.length; i++) {
                // Mover el puntero al inicio del registro
                raf.seek(i * tamañoRegistro);

                // Escribir datos en el fichero aleatorio
                raf.writeInt(identificadores[i]);
                escribirCadenaConBuffer(raf, apellidos[i], 10);
                raf.writeInt(numerosDepartamento[i]);
                raf.writeDouble(salarios[i]);
            }

            System.out.println("Registros escritos en el fichero aleatorio.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    
    
    

    private static void LeerFichAleatorioUnReg(String ruta, int numeroRegistro) {
        try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "rw")) {
            int tamañoRegistro = 36; // Tamaño de cada registro en bytes

            // Calcular la posición del registro a leer
            long posicion = (numeroRegistro - 1) * tamañoRegistro;

            // Posicionarse en la posición calculada
            raf.seek(posicion);

            // Leer datos del registro
            int identificador = raf.readInt();
            String apellido = leerCadenaConBuffer(raf, 10);
            int numeroDepartamento = raf.readInt();
            double salario = raf.readDouble();

            // Mostrar los datos leídos
            System.out.printf("Registro %d: Identificador: %d, Apellido: %s, Número de Departamento: %d, Salario: %.2f%n",
                    numeroRegistro, identificador, apellido.trim(), numeroDepartamento, salario);
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
    
    private static void EscribirFichAleatorioUnReg(String ruta) {
        try (RandomAccessFile raf = new RandomAccessFile(new File(ruta), "rw")) {
            // Datos de ejemplo para escribir en el fichero aleatorio
            int identificador = 6;
            String apellido = "Taylor";
            int numeroDepartamento = 106;
            double salario = 100000.0;

            int tamañoRegistro = 36; // Tamaño de cada registro en bytes

            // Calcular la posición para insertar el nuevo registro
            long posicion = (identificador - 1) * tamañoRegistro;

            // Posicionarse en la posición calculada
            raf.seek(posicion);

            // Escribir datos en el fichero aleatorio
            raf.writeInt(identificador);
            escribirCadenaConBuffer(raf, apellido, 10);
            raf.writeInt(numeroDepartamento);
            raf.writeDouble(salario);

            System.out.println("Registro insertado en el fichero aleatorio.");
        } catch (IOException e) {
            e.printStackTrace();
        }
    }
 

    

    
    
    
    
    
    
    
    
    

    // EXTRASSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSSS
    
    private static String leerCadenaConBuffer(RandomAccessFile raf, int longitud) throws IOException {
        char[] buffer = new char[longitud];
        for (int i = 0; i < longitud; i++) {
            buffer[i] = raf.readChar();
        }
        return new String(buffer);
    }

    private static void escribirCadenaConBuffer(RandomAccessFile raf, String cadena, int longitud) throws IOException {
        // Crear un array de caracteres con la longitud deseada
        char[] buffer = new char[longitud];

        // Rellenar el array con caracteres de la cadena
        for (int i = 0; i < longitud; i++) {
            if (i < cadena.length()) {
                buffer[i] = cadena.charAt(i);
            } else {
                // Si la cadena es más corta que la longitud deseada, llenar con espacios en blanco
                buffer[i] = ' ';
            }
        }
        // Escribir la cadena en el fichero aleatorio
        raf.writeChars(new String(buffer));
    }
    
 // Clase Persona que implementa Serializable
    public static class Persona implements Serializable {
        private static final long serialVersionUID = 1L;
        private String nombre;
        private int edad;

        public Persona(String nombre, int edad) {
            this.nombre = nombre;
            this.edad = edad;
        }

        @Override
        public String toString() {
            return "Persona{nombre='" + nombre + "', edad=" + edad + '}';
        }
    }

    // Clase MiObjectOutputStream para evitar la escritura de la cabecera
    public static class MiObjectOutputStream extends ObjectOutputStream {
        public MiObjectOutputStream(OutputStream out) throws IOException {
            super(out);
        }

        @Override
        protected void writeStreamHeader() throws IOException {
            // No escribir cabecera
        }
    }


}
