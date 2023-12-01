import java.io.*;

public class UD1_Actividad1_7 {

	public static void main(String[] args) {
		Departamento dep;
		File fichero;
		FileOutputStream fileout;
		ObjectOutputStream objectOS;

		String nombres[] = { "INFORMATICA", "MARKETING", "CONTABILIDAD",
				"VENTAS", "COMPRAS", "PERSONAL", "RECURSOS", 
				"ADMINISTRACIÓN",	"ECONOMÍA" };
		int num[] = { 10, 15, 20, 25, 30, 35, 40, 45, 50 };
		String loc[] = { "MADRID", "SEVILLA", "LEON", "TOLEDO", "GUADALAJARA",
				"CUENCA", "OVIEDO", "BILBAO", "VALENCIA" };


		try {
			fichero = new File("departamentos.dat");			
			fileout = new FileOutputStream(fichero);

			objectOS = new ObjectOutputStream(fileout);

			for (int i = 0; i < num.length; i++) { // recorro los arrays
				dep = new Departamento(nombres[i], num[i], loc[i]);
				objectOS.writeObject(dep); // escribo el departamento
			}
			objectOS.close(); // cerrar stream de salida
			Listado();

		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}catch (IOException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
	}//main

	public static void Listado() throws IOException {
		Departamento dep;
		// declara el fichero
		File fichero = new File("departamentos.dat");

		FileInputStream filein = new FileInputStream(fichero);
		// conecta el flujo de bytes al flujo de datos
		ObjectInputStream objctIS = new ObjectInputStream(filein);
		System.out.println("LISTADO DE DEPARTAMENTOS:");
		System.out.println("=======================================================");

		try {
			while (true) { // lectura del fichero
				dep = (Departamento) objctIS.readObject(); 
				System.out.println("Departamento: "+dep.getDep()+
						", Nombre: " + dep.getNombre()
						+ ", Localidad: " + dep.getLoc());
			}						
		} catch (Exception e) {	
			//Se produce EOFException al finalizar la lectura
			if(!e.toString().equals("java.io.EOFException"))
				System.err.println("Error al leer fichero: "+e.toString());
		}		
		System.out.println("=======================================================");

		objctIS.close(); // cerrar stream de entrada
	
	}//FIN Listado()

}//class
