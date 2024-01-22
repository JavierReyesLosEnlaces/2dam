import java.net.*;
import java.io.*;


public class ReciboEnvio {
	
	
	

	public static void main(String[] args) {
		try {
			System.out.println("Creando socket datagrama");
			InetSocketAddress addrs =new InetSocketAddress("localhost",5555);
			DatagramSocket datagramSocket = new DatagramSocket(addrs);
			System.out.println("Recibiendo mensaje");
			byte[] mensaje =new byte[25];
			DatagramPacket datagrama1 =new DatagramPacket (mensaje,25);
			datagramSocket.receive(datagrama1);
			System.out.println("Mensaje recibido..."+ new String(mensaje));
			System.out.println("Enviando mensaje");
			InetAddress addr = InetAddress.getByName("localhost");
			DatagramPacket datagrama2 = new DatagramPacket(mensaje, mensaje.length, addr, 5556);
			datagramSocket.send(datagrama2);
			datagramSocket.close();
			System.out.println("Terminé");
		}catch(Exception e){
			System.out.println(e.getMessage());
		}

	}

}
