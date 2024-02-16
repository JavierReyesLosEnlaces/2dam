package comunicacion;
//ServidorTCP.java
import java.io.*;
import java.net.*; 

public class ServidorTCP {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		// Primero indicamos la dirección IP local 
		try {
			System.out.println("LocalHost = " +InetAddress.getLocalHost().toString()); //cuál es mi dirección local
		} catch (U	nknownHostException uhe)
		{
			System.err.println("No puedo saber la dirección IP local : " + uhe); 
		}
		
		// Abrimos un "Socket de Servidor" TCP en el puerto 1234.
		ServerSocket ss = null; 
		
		try {
			ss = new ServerSocket(1234); // haces que el socket se ponga a escuchar en el puerto 1234  
		} catch (IOException ioe)
		{
			System.err.println("Error al abrir el socket de servidor : " + ioe);
			System.exit(-1);  
		}
		
		int entrada;
		long salida;
		// Bucle infinito 
		while(true) // está imitando al servidor esperando de forma indefinida
		 { 
			try
			 { 
				// Esperamos a que alguien se conecte a nuestroSocket
				 Socket sckt = ss.accept();
				 // Extraemos los Streams de entrada y de salida
				 DataInputStream dis = new DataInputStream(sckt.getInputStream());
				 DataOutputStream dos = new DataOutputStream(sckt.getOutputStream());
				 // Podemos extraer información del socket
				 // Nº de puerto remoto
				 int puerto = sckt.getPort();
				 // Dirección de Internet remota
				 InetAddress direcc = sckt.getInetAddress();
				 // Leemos datos de la peticion
				 entrada = dis.readInt();
				 // Calculamos resultado
				 salida = (long)entrada*(long)entrada;
				 // Escribimos el resultado
				 dos.writeLong(salida);
				 // Cerramos los streams
				 dis.close();
				 dos.close();
				 sckt.close();
				 ss.close();
				 // Registramos en salida estandard
				 System.out.println( "Cliente = " + direcc + ":" + puerto
				 + "\tEntrada = " + entrada + "\tSalida = " +
				 salida ); 
			 }  catch(Exception e) {
				 System.err.println("Se ha producido la excepción : " +e);
			 }
		 }

	}

}
