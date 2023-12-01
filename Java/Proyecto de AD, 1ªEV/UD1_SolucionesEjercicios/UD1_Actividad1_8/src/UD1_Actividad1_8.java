import org.w3c.dom.*;
import javax.xml.parsers.*;
import javax.xml.transform.*;
import javax.xml.transform.dom.*;
import javax.xml.transform.stream.*;
import java.io.*;

public class UD1_Actividad1_8 {

	public static void main(String[] args) {
		Departamento depart;
		File fichero;
		FileInputStream filein;
		ObjectInputStream objectIS=null;

		DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
		Document document=null;
		try {
			fichero = new File("departamentos.dat");
			filein = new FileInputStream(fichero);
			objectIS = new ObjectInputStream(filein);

			DocumentBuilder builder = factory.newDocumentBuilder();
			DOMImplementation implementation = builder.getDOMImplementation();
			document = implementation.createDocument(null,	"departamentos", null);
			document.setXmlVersion("1.0"); // asignamos la version de nuestro XML

			try {
				while (true) { // lectura del fichero
					depart = (Departamento) objectIS.readObject();
					Element nodo = document.createElement("departamento");
					document.getDocumentElement().appendChild(nodo);
					CrearElemento("numero", Integer.toString(depart.getDep()), nodo, document);
					CrearElemento("nombre", depart.getNombre(), nodo, document);
					CrearElemento("localidad", depart.getLoc(), nodo, document);
				}
			} catch (EOFException e) {
				try {
					objectIS.close();
				} catch (IOException e1) {
					System.out.println("Error al cerrarel archivo de objetos");
				}

			}
			
			Source source = new DOMSource(document);
			Result result = new StreamResult(new java.io.File("departamentos.xml"));
			Transformer transformer=null;
			transformer = TransformerFactory.newInstance().newTransformer();
			transformer.transform(source, result);
			
		}  catch (Exception e) {
			System.out.println("Error: " +	e);
		}

	}//main

	public static void CrearElemento(String dato, String valor, Element raiz,	Document document) {
		Element elem = document.createElement(dato); // creamos hijo
		Text text = document.createTextNode(valor); // damos valor
		raiz.appendChild(elem); // pegamos el elemento hijo a la raiz
		elem.appendChild(text); // pegamos el valor
	}

}
