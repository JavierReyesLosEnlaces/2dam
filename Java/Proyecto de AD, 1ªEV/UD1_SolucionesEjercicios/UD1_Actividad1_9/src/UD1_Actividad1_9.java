
import java.io.*;
import com.thoughtworks.xstream.XStream;

public class UD1_Actividad1_9 {
  
  public static void main(String[] args) throws IOException, ClassNotFoundException {   	
    
	/* Declara el fichero que contiene los datos de los objetos Persona */
	File fichero = new File("departamentos.dat");
    FileInputStream filein = new FileInputStream(fichero);//flujo de entrada   
    //conecta el flujo de bytes al flujo de datos de tipo objeto
    ObjectInputStream dataIS = new ObjectInputStream(filein);      
    System.out.println ("Comienza el proceso de creación del fichero a XML ...");
				
    //Creamos un objeto Lista de Departamentos
    ListaDepartamentos listadpto = new ListaDepartamentos();	 
     
    try {
      while (true) { //lectura de los datos de tipo objeto del fichero
        //leer un departmento
	    Departamento dpto = (Departamento) dataIS.readObject();    
	    listadpto.add(dpto); //añadir persona a la lista  
      	}
      
    }catch (EOFException eo) {}
    dataIS.close();  //cerrar stream de entrada     
    
    /* Crea el archivo XML con la lista de personas, usando la clase XStream */
    try {
		XStream xstream = new XStream();   
		//cambiar de nombre a las etiquetas XML
		xstream.alias("Departamentos", ListaDepartamentos.class);	
		xstream.alias("Departamento", Departamento.class);
		
		xstream.aliasField("Nombre", Departamento.class, "nombre");
		xstream.aliasField("Numero", Departamento.class, "dep");
		xstream.aliasField("Localidad", Departamento.class, "loc");
		
		//quitar etiqueta lista (atributo de la claseListaPersonas)
		xstream.addImplicitCollection(ListaDepartamentos.class, "lista");
		//Insertar los objetos en el XML
	    xstream.toXML(listadpto, new FileOutputStream("DepartamentosConXStream.xml"));	
		System.out.println("Creado fichero XML....");
	
     }catch (Exception e) 
	   {e.printStackTrace();}	    
 
  } // fin main
} //fin 

