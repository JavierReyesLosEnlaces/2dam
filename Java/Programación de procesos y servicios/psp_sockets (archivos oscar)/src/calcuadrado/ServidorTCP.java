package calcuadrado;

import java.io.*;
import java.net.*;
import java.util.Random;

public class ServidorTCP {

	public static void main(String[] args) {
		
		// Primero indicamos la dirección IP local
		try {
			System.out.println("LocalHost = " + InetAddress.getLocalHost().toString());
		} catch (UnknownHostException uhe) {
			System.err.println("No puedo saber la dirección IP local : " + uhe);
		}

		// Abrimos un "Socket de Servidor" TCP en el puerto 1234.
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

				// Extraemos los Streams de entrada y de salida	
					// DataInputStream recibe mensajes del cliente
					// DataOutputStream devuelve mensajes al cliente
				DataInputStream dis = new DataInputStream(socketDelCliente.getInputStream());
				DataOutputStream dos = new DataOutputStream(socketDelCliente.getOutputStream());

				// Podemos extraer información del socket
				int puerto = socketDelCliente.getPort();
				InetAddress direcc = socketDelCliente.getInetAddress();

				// Leemos datos de la petición (queda a la espera)
				int numeroMinimo = dis.readInt();
				int numeroMaximo = dis.readInt();

				// Calculamos resultado: un número aleatorio entre el número máximo y mínimo

				int salida = (int) (Math.random() * (numeroMaximo - numeroMinimo + 1)) + numeroMinimo;

				// Escribimos el resultado
				dos.writeInt(salida);
				// Cerramos los streams
				dis.close();
				dos.close();
				// Cerramos el socket del cliente
				socketDelCliente.close();

				// Registramos en salida estándar
				System.out.println("Cliente = " + direcc + ":" + puerto + "\tEntrada = " + numeroMinimo + " y "
						+ numeroMaximo + "\tSalida = " + salida);
			} catch (Exception e) {
				System.err.println("Se ha producido la excepción : " + e);
			}
		}
	}
}
