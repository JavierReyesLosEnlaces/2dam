package javier_sockets;

import java.io.*;
import java.net.*;
import java.util.Scanner;

public class ClienteTCP {

	public static void main(String[] args) {

		Scanner scanner = new Scanner(System.in);
		String direccionIP = "localhost";
		boolean salir = false;

		do {
			System.out.println("0. Salir");
			System.out.println("1. Generar un numero aleatorio");
			System.out.println("2. Invertir un nombre");
			System.out.println("3. Obtener un pais aleatorio");
			System.out.print("Seleccione una opcion: ");
			int opcion = scanner.nextInt();

			if (opcion == 0) {
				salir = true; // Si el cliente quiere salir del programa, salta al final del bucle
				continue;
			}

			// DataInputStream y DataOutputStream
			DataInputStream dis = null;
			DataOutputStream dos = null;

			try {
				Socket socketDelCliente = new Socket(direccionIP, 1234);
				dis = new DataInputStream(socketDelCliente.getInputStream());
				dos = new DataOutputStream(socketDelCliente.getOutputStream());

				// Menu de opciones del cliente
				dos.writeInt(opcion);
				switch (opcion) {
				case 1:
					System.out.print("Introduce el numero minimo: ");
					int numeroMinimo = scanner.nextInt();
					System.out.print("Introduce el numero maximo: ");
					int numeroMaximo = scanner.nextInt();
					dos.writeInt(numeroMinimo);
					dos.writeInt(numeroMaximo);
					break;
				case 2:
					System.out.print("Introduce el nombre a invertir: ");
					scanner.nextLine(); // Limpiar el buffer del scanner
					String nombre = scanner.nextLine();
					dos.writeUTF(nombre);
					break;
				case 3:
					// No se requieren parámetros adicionales para esta opción
					break;
				default:
					System.err.println("Opcion no valida");
					break;
				}

				// Se lee el resultado (siempre UTF)
				String resultado = dis.readUTF();

				System.out.println("RESULTADO: " + resultado + "\n");
				dis.close();
				dos.close();
				socketDelCliente.close();

			} catch (IOException e) {
				System.out.println("No ha sido posible procesar la operacion.\n");
			}
		} while (!salir);

		// Se cierra el scanner al finalizar
		scanner.close();
		System.out.println("Cliente cerrado");
	}
}
