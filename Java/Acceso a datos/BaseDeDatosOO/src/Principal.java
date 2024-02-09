
import java.math.BigInteger;
import java.util.Scanner;

import org.neodatis.odb.ODB;
import org.neodatis.odb.ODBFactory;
import org.neodatis.odb.ObjectValues;
import org.neodatis.odb.Objects;
import org.neodatis.odb.Values;
import org.neodatis.odb.core.query.IValuesQuery;
import org.neodatis.odb.core.query.criteria.ICriterion;
import org.neodatis.odb.core.query.criteria.Where;
import org.neodatis.odb.impl.core.query.criteria.CriteriaQuery;
import org.neodatis.odb.impl.core.query.values.ValuesCriteriaQuery;

public class Principal {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		String path = "C:/Users/Alumno/Desktop/repositorios/2dam/Java/Acceso a datos/BaseDeDatosOO/bds/baseDeDatos2.odb";
		int opcion;
		
		do {
			System.out.println("8. Agrupados");
			System.out.println("7. Agregados con selección");
			System.out.println("6. Agregados");
			System.out.println("5. Modificar sujetos");
			System.out.println("4. Borrar sujetos");
			System.out.println("3. Seleccionar sujetos con edad 23");
			System.out.println("2. Listar sujetos");
			System.out.println("1. Crear sujetos");
			System.out.println("0. Salir");
			opcion = teclado.nextInt();
			switch(opcion) {
			case 8: 
				agrupados(path);
				break;
			case 7: 
				agregadosConSeleccion(path);
				break;
			case 6: 
				agregados(path);
				break;
			case 5: 
				modificarSujetos(path);
				break;
			case 4: 
				borrarSujetos(path);
				break;
			case 3: 
				 seleccionarSujetos(path);
				 break;
			case 2: 
				listarSujetos(path);
				break;
			case 1: 
				crearSujetos(path);
				break; 
			case 0: 
				System.out.println("Has salido. ");
				break;
			}
		}while(opcion!=0);
		teclado.close();
	}

	private static void agrupados(String path) {
		ODB odb8 = ODBFactory.open("D:/Carlos/Base_datos_OO/tutorial.odb");
		IValuesQuery valuesQuery8 = new ValuesCriteriaQuery(Sujeto.class, Where.gt("edad",
		1)).avg("edad").field("ciudad").groupBy("ciudad");
		Values values8 = odb8.getValues(valuesQuery8);
		while (values8.hasNext()) {
		ObjectValues objectValues8 = (ObjectValues) values8.next();
		System.out.println(objectValues8.getByAlias("ciudad") + " ---> " +
		objectValues8.getByAlias("edad"));
		}
		odb8.close();
		
	}

	private static void agregadosConSeleccion(String path) {
		ODB odb7 = ODBFactory.open("D:/Carlos/Base_datos_OO/tutorial.odb");
		IValuesQuery valuesQuery7 = new ValuesCriteriaQuery(Sujeto.class,
		Where.gt("edad", 21)).count("nombre").field("ciudad").groupBy("ciudad");
		Values values7 = odb7.getValues(valuesQuery7);
		while (values7.hasNext()) {
		ObjectValues objectValues7 = (ObjectValues) values7.next();
		System.out.println(objectValues7.getByAlias("ciudad") + " ---> " +
		objectValues7.getByAlias("nombre"));
		}
		odb7.close();
		
	}

	private static void agregados(String path) {
		ODB odb6 = ODBFactory.open(path);
		IValuesQuery valuesQuery6 = new
		ValuesCriteriaQuery(Sujeto.class).count("nombre");
		Values values6 = odb6.getValues(valuesQuery6);
		ObjectValues objectValues6 = values6.nextValues();
		BigInteger count6 = (BigInteger) objectValues6.getByAlias("nombre");
		System.out.println("NÃºmero de Jugadores: " + count6.intValue());
		odb6.close();		
	}

	private static void modificarSujetos(String path) {
		// Modificar objetos
		ODB odb5 = ODBFactory.open(path);
		ICriterion criterio5 = Where.gt("edad",2);
		CriteriaQuery query5 = new CriteriaQuery(Sujeto.class, criterio5);
		Objects<Sujeto> objects5 = odb5.getObjects(query5);
		while(objects5.hasNext())
		{
		Sujeto sujeto_actual5= objects5.next();
		System.out.println("\t: " + sujeto_actual5.getName() + " " +
		sujeto_actual5.getEdad() + " <--Ciudad Cambiada");
		sujeto_actual5.setCiudad("XXXX");
		odb5.store(sujeto_actual5);
		odb5.commit();
		}
		odb5.close();
		
	}

	private static void borrarSujetos(String path) {
		ODB odb4 = ODBFactory.open(path);
		ICriterion criterio4 = Where.gt("edad",1);
		CriteriaQuery query4 = new CriteriaQuery(Sujeto.class, criterio4);
		Objects<Sujeto> objects4 = odb4.getObjects(query4);
		while(objects4.hasNext())
		{
		Sujeto sujeto_actual4= objects4.next();
		System.out.println("\t: " + sujeto_actual4.getName() + " " +
		sujeto_actual4.getEdad() + " <--Eliminado");
		odb4.delete(sujeto_actual4);
		}
		odb4.close();
	}

	private static void seleccionarSujetos(String path) {

		ODB odb3 = ODBFactory.open(path);
		ICriterion criterio = Where.equal("edad",23);
		CriteriaQuery query = new CriteriaQuery(Sujeto.class, criterio);
		Objects<Sujeto> objects3 = odb3.getObjects(query);
		while(objects3.hasNext())
		{
		Sujeto sujeto_actual3= objects3.next();
		System.out.println("\t: " + sujeto_actual3.getName() + " " +
		sujeto_actual3.getEdad());
		}
		odb3.close();
		
	}

	private static void listarSujetos(String path) {
		
		ODB odb2 = ODBFactory.open(path);
		Objects<Sujeto> objects = odb2.getObjects(Sujeto.class);
		
		System.out.println("Lista de sujetos: ");
		while(objects.hasNext())
		{
		Sujeto sujeto_actual2= objects.next();
		System.out.println("\t: " + sujeto_actual2.getName() + " " +
		sujeto_actual2.getEdad() + " " + sujeto_actual2.getCiudad());
		}
		odb2.close();
		
	}

	private static void crearSujetos(String path) {
		Sujeto s1 = new Sujeto("Maria", 23, "Madrid");
		Sujeto s2 = new Sujeto("Javier", 29, "Zaragoza");
		Sujeto s3 = new Sujeto("Lucia", 28, "Zaragoza");
		Sujeto s4 = new Sujeto("Marcos", 20, "Zaragoza");

		ODB odb = ODBFactory.open(path);
		odb.store(s1);
		odb.store(s2);
		odb.store(s3);
		odb.store(s4);
		odb.close();
		
		System.out.println("Se han creado los objetos. ");
		
	}

}
