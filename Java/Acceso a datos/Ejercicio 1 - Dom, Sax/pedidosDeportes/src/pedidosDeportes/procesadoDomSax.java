package pedidosDeportes;

import java.io.File;
import java.text.ParseException;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;

public class procesadoDomSax {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		int opcion;
		File f = new File("pedidos_deportes.xml");
		do {			
			System.out.println("Escoge la forma de procesar el XML:");
			System.out.println("0. Salir");
			System.out.println("1. DOM");
			System.out.println("2. SAX");
			opcion = teclado.nextInt();
			switch(opcion) {
				case 0:
					System.out.println("Programa terminado");
					break;
				case 1: 
					procesadoDom(f);
					break;
				case 2: 
					procesadoSax(f);
					break;
				default:
					System.out.println("Valor incorrecto");
					break;			
			}
		}while(opcion!=0);

	}

	private static void procesadoSax(File f) {	
		try {
			DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbf.newDocumentBuilder();
			Document d = db.parse(f);
			// En este punto tengo el objeto Document apuntando al fichero
			
			d.createElement("pedidos_deporte");		
		}catch(Exception e) {
			e.printStackTrace();
		}
	}

	private static void procesadoDom(File f) {
	}

}
