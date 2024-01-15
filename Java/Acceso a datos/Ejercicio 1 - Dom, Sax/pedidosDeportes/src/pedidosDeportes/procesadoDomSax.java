	package pedidosDeportes;

import java.io.File;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.DOMImplementation;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;

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

	}

	private static void procesadoDom(File f) {
		try {
			DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbf.newDocumentBuilder();
			Document d = db.parse(f);
			// En este punto tengo el objeto Document apuntando al fichero					
			
			// Elemento raiz <pedidos_deporte>
			Element raiz = d.getDocumentElement();	
			System.out.println(raiz.toString());
			
			// Elementos nodo 1
			NodeList nodo1 = d.getElementsByTagName("pedido");
			
			// Elementos nodo 2
			NodeList nodo2a = nodo1.getElementsByTagName("nombre");
			NodeList nodo2b = nodo1.getElementsByTagName("numero_pedido");
			NodeList nodo2c = nodo1.getElementsByTagName("articulos");
			
		}catch(Exception e) {
			e.printStackTrace();
		}
	}

}
