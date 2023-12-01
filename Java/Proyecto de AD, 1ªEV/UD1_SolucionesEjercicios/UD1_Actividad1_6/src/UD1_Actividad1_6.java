

import java.io.*;
import org.xml.sax.Attributes;
import org.xml.sax.SAXException;
import org.xml.sax.helpers.DefaultHandler;
import javax.xml.parsers.SAXParserFactory;
import javax.xml.parsers.ParserConfigurationException;
import javax.xml.parsers.SAXParser;

public class UD1_Actividad1_6 {		
	
	public static void main(String[] args) throws FileNotFoundException, IOException, SAXException, ParserConfigurationException {		
		 	 
		/* Crea el objeto SAXParser como procesador (parser) del fichero */
		SAXParserFactory factory = SAXParserFactory.newInstance();
		SAXParser procesadorXML = factory.newSAXParser();
			
		/* Crea el gestor de contenido */
		GestionContenido gestor= new GestionContenido();
		
		/* https://docs.oracle.com/en/java/javase/11/docs/api/java.base/java/io/File.html
		/* Indica la fuente (fichero XML) a procesar y le dice al procesador que lo procese
		 * con el gestor de contenido personalizado */
		File fileXML = new File("Empleados.xml");	    
		procesadorXML.parse(fileXML, gestor);  	 
	}
	
} //fin UD1_Actividad1_6

class GestionContenido extends DefaultHandler {	 
	    public GestionContenido() {
	        super();
	    }
	    
	    public void startDocument() {
	        System.out.println("Comienzo del Documento XML");
	    }
	    
	    public void endDocument() {
	        System.out.println("Final del Documento XML");
	    }	 
	    
	    public void startElement(String uri, String nombre, String nombreC, Attributes atts) {
	        System.out.println("\tPrincipio Elemento: " + nombre);	 	        
	    } 
	
	    public void endElement(String uri, String nombre, String nombreC) {
	        System.out.println("\tFin Elemento: " + nombre);
	    }
		
		public void characters(char[] ch, int start, int length) throws SAXException {
		   String car=new String(ch, start, length);
		   car = car.replaceAll("[\t\n]","");//quitar saltos de línea		   
		   System.out.println ("\tCaracteres: " + car);		
	    }
		
}//fin GestionContenido

