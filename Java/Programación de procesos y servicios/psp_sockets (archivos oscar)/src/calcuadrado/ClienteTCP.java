package calcuadrado;

//ClienteTCP.java
import java.io.*;
import java.net.*;

public class ClienteTCP {

	public static void main(String[] args) {

		// Se lee el primer argumento (la ip)
		InetAddress direcc = null;
		try {
			direcc = InetAddress.getByName(args[0]);
		} catch (UnknownHostException uhe) {
			System.err.println("Host no encontrado : " + uhe);
			System.exit(-1);
		}

		// Puerto que hemos usado para el servidor
		int puerto = 1234;

		// DataInputStream y DataOutputStream
		DataInputStream dis = null;
		DataOutputStream dos = null;

		// Se leen el segundo y tercer argumento
		int numeroMinimo = Integer.parseInt(args[1]);
		int numeroMaximo = Integer.parseInt(args[2]);

		try {
			// Crea un nuevo socket y lo conecta a una dirección y un puerto específicos
			Socket socketDelCliente = new Socket(direcc, puerto);

			// Se extraen los streams de entrada y salida del socket del cliente
			dis = new DataInputStream(socketDelCliente.getInputStream());
			dos = new DataOutputStream(socketDelCliente.getOutputStream());

			// Se escriben los parámetros
			dos.writeInt(numeroMinimo);
			dos.writeInt(numeroMaximo);
			
			// En este punto, el servidor se pone a leer los parámetros y devuelve un resultado que el cliente puede leer por su "dis"

			// Se lee el resultado
			int resultado = dis.readInt();

			System.out.println("Params: " + numeroMinimo + ", " + numeroMaximo + " --> Resultado: " + resultado);
			dis.close();
			dos.close();
			socketDelCliente.close();

		} catch (IOException e) {
			e.printStackTrace();
		}

	}

}
