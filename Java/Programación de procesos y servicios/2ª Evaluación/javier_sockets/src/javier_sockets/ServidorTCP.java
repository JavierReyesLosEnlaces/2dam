package javier_sockets;

import java.io.*;
import java.net.*;
import java.util.Random;

public class ServidorTCP {

	public static void main(String[] args) {

		// Primero indicamos la dirección IP local
		try {
			System.out.println("/SERVIDOR ACTIVO/");
			System.out.println("LocalHost = " + InetAddress.getLocalHost().toString());
		} catch (UnknownHostException uhe) {
			System.err.println("No puedo saber la dirección IP local : " + uhe);
		}

		// Abrimos un socket de servidor TCP en el puerto 1234.
		ServerSocket socketDelServidor = null;

		try {
			socketDelServidor = new ServerSocket(1234);
		} catch (IOException ioe) {
			System.err.println("Error al abrir el socket de servidor : " + ioe);
			System.exit(-1);
		}

		// Bucle infinito
		while (true) {
			try {
				// Esperamos a que alguien se conecte a nuestroSocket
				Socket socketDelCliente = socketDelServidor.accept();

				// Extraemos los flujos de entrada y de salida
				DataInputStream dis = new DataInputStream(socketDelCliente.getInputStream());
				DataOutputStream dos = new DataOutputStream(socketDelCliente.getOutputStream());

				// Leemos la opción enviada por el cliente
				int opcion = dis.readInt();

				// Manejamos la opción del cliente con un switchcase
				switch (opcion) {
				case 1:
					int numeroMinimo = dis.readInt();
					int numeroMaximo = dis.readInt();
					if (numeroMaximo > numeroMinimo) {
						int resultado1 = generarNumeroAleatorio(numeroMinimo, numeroMaximo);
						dos.writeUTF(resultado1 + ""); // Debe parsearse a String para que pueda ser leído
					} else {
						dos.writeUTF("Imposible\n(El numero minimo debe ser menor que el numero maximo) ");
					}
					break;
				case 2:
					String nombre = dis.readUTF();
					String resultado2 = invertirNombre(nombre);
					dos.writeUTF(resultado2);
					break;
				case 3:
					String resultado3 = obtenerPaisAleatorio();
					dos.writeUTF(resultado3);
					break;
				default:
					System.err.println("Opción no valida");
					socketDelCliente.close();
					continue; // Volvemos al inicio del bucle para esperar la próxima conexión
				}

				// Cerramos los streams y el socket del cliente
				dis.close();
				dos.close();
				socketDelCliente.close();

			} catch (Exception e) {
				e.printStackTrace();
			}
		}
	}

	// Método para generar un número aleatorio en un rango dado
	private static int generarNumeroAleatorio(int min, int max) {
		Random random = new Random();
		return random.nextInt(max - min + 1) + min;
	}

	// Método para invertir un nombre
	private static String invertirNombre(String nombre) {
		return new StringBuilder(nombre).reverse().toString();
	}

	// Método para obtener un país aleatorio
	private static String obtenerPaisAleatorio() {
		String[] paises = { "Canada", "Brasil", "Argentina", "Colombia", "Australia", "India" };
		Random random = new Random();
		return paises[random.nextInt(paises.length)];
	}
}
