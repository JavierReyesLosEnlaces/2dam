package pedidosDeportes;

import java.io.File;
import java.io.FileInputStream;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.SAXParser;
import javax.xml.parsers.SAXParserFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.Attributes;
import org.xml.sax.InputSource;
import org.xml.sax.SAXException;
import org.xml.sax.XMLReader;
import org.xml.sax.helpers.DefaultHandler;

public class leerXMLconDOMSax {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		int opcion;
		File f = new File("pedidos_deportes.xml");
		do {
			System.out.println("Escoge la forma de leer el XML:");
			System.out.println("0. Salir");
			System.out.println("1. DOM");
			System.out.println("2. SAX");
			opcion = teclado.nextInt();
			switch (opcion) {
			case 0:
				System.out.println("Programa terminado");
				break;
			case 1:
				leerXMLconDOM(f);
				break;
			case 2:
				leerXMLconSAX(f);
				break;
			default:
				System.out.println("Valor incorrecto");
				break;
			}
		} while (opcion != 0);

	}

    private static void leerXMLconSAX(File f) {
        try {
            // spf, sp, procesadorXML
            SAXParserFactory spf = SAXParserFactory.newInstance();
            SAXParser sp = spf.newSAXParser();
            XMLReader procesadorXML = sp.getXMLReader();

            // Crear y configurar el manejador de eventos (debe implementar esos 3 métodos)
            DefaultHandler manejador = new DefaultHandler() {
                @Override
                public void startElement(String uri, String localName, String qName, Attributes attributes) throws SAXException {
                    // Lógica para manejar el inicio de un elemento
                    System.out.println("+ " + qName);
                }

                @Override
                public void endElement(String uri, String localName, String qName) throws SAXException {
                    // Lógica para manejar el final de un elemento
                    System.out.println("- " + qName);
                }

                @Override
                public void characters(char[] ch, int start, int length) throws SAXException {
                    // Lógica para manejar datos dentro de un elemento
                    String datos = new String(ch, start, length);
                    datos.replaceAll("[\t\n]", "");
                    //System.out.println("Datos: " + datos);
                }
            };

            // Configurar el procesadorXML con el manejador de eventos
            procesadorXML.setContentHandler(manejador);

            // Leer el archivo XML
            procesadorXML.parse(new InputSource(new FileInputStream(f)));

        } catch (Exception e) {
            e.printStackTrace();
        }
		System.out.println("");
    }

	private static void leerXMLconDOM(File f) {
		try {
			// dbf, db, d y normalize
			DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbf.newDocumentBuilder();
			Document d = db.parse(f);
			d.getDocumentElement().normalize();

			Node raiz = d.getDocumentElement();
			NodeList pedidos = d.getElementsByTagName("pedido");

			/*
			 * Tienes un NodeList, lo recorres y sacas un nodo Después tienes que comprobar
			 * que ese nodo es, en efecto un elemento, después creas el elemento y de él
			 * sacas la información
			 */

			for (int i = 0; i < pedidos.getLength(); i++) {
				Node nodoPedido = pedidos.item(i);
				System.out.println("-> PEDIDO " + (i + 1));

				if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) { // si nodoPedido es un nodo
					Element pedido = (Element) nodoPedido;
					System.out.println("Nombre: " + pedido.getElementsByTagName("nombre").item(0).getTextContent());
					System.out.println(
							"N. de pedido: " + pedido.getElementsByTagName("numero_pedido").item(0).getTextContent());

					NodeList articulos = pedido.getElementsByTagName("articulo");
					for (int j = 0; j < articulos.getLength(); j++) {
						Node nodoArticulo = articulos.item(j);
						if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
							Element articulo = (Element) nodoArticulo;
							System.out.println("Descripcion del articulo: " + articulo.getAttribute("descripcion"));
							System.out.println("Cantidad: " + articulo.getAttribute("cantidad"));
						}
					}
					System.out.println("");
				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

}
