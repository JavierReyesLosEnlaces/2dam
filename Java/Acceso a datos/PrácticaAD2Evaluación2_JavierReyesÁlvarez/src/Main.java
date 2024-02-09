import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

import org.neodatis.odb.ODB;
import org.neodatis.odb.ODBFactory;

public class Main {

	public static void main(String[] args) {
		String pathBd = "C:\\Users\\Alumno\\Desktop\\repositorios\\2dam\\Java\\Acceso a datos\\PrácticaAD2Evaluación2_JavierReyesÁlvarez\\bd\\bdDePedidos";	
		crearPedidos(pathBd, crearArticulos(pathBd));
		
	}

	private static void crearPedidos(String path, ArrayList<Articulo> listaDeArticulos) {
		
		ODB odb = ODBFactory.open(path);
		
		ArrayList<Articulo> listaDeArticulos1 = new ArrayList<>();		
		ArrayList<Articulo> listaDeArticulos2 = new ArrayList<>();;
		ArrayList<Articulo> listaDeArticulos3 = new ArrayList<>();;
		ArrayList<Articulo> listaDeArticulos4 = new ArrayList<>();;
		ArrayList<Articulo> listaDeArticulos5 = new ArrayList<>();;
		
		listaDeArticulos1.add(listaDeArticulos.get(0));
		listaDeArticulos1.add(listaDeArticulos.get(1));
		

		listaDeArticulos2.add(listaDeArticulos.get(0));
		listaDeArticulos2.add(listaDeArticulos.get(0));
		
		Pedido p1 = new Pedido("1234567890", "12345", "2024-01-22", listaDeArticulos1);
		Pedido p2 = new Pedido("9876543210", "12346", "2024-01-23", listaDeArticulos2);
		Pedido p3 = new Pedido("1234567891", "12347", "2024-01-24", listaDeArticulos3);
		Pedido p4 = new Pedido("1234567892", "12348", "2024-01-25", listaDeArticulos4);
		Pedido p5 = new Pedido("1234567893", "12349", "2024-01-26", listaDeArticulos5);
		
		odb.close();
		
		System.out.println("Se han creado los objetos. ");
	}

	private static ArrayList<Articulo> crearArticulos(String path) {

		ArrayList<Articulo> listaDeArticulos = new ArrayList<Articulo>();
		ODB odb = ODBFactory.open(path);
		
		listaDeArticulos.add(new Articulo("123456",10));
		listaDeArticulos.add(new Articulo("234567",20));
		listaDeArticulos.add(new Articulo("345678",30));
		listaDeArticulos.add(new Articulo("456789",40));
		listaDeArticulos.add(new Articulo("567890",50));
		listaDeArticulos.add(new Articulo("678901",60));
		listaDeArticulos.add(new Articulo("789012",70));
		listaDeArticulos.add(new Articulo("890123",80));
		listaDeArticulos.add(new Articulo("123457",10));
		listaDeArticulos.add(new Articulo("234568",20));
		listaDeArticulos.add(new Articulo("901234",90));
		listaDeArticulos.add(new Articulo("012345",100));
		
		for(int i=0;i<listaDeArticulos.size();i++) {
			odb.store(listaDeArticulos.get(i));
		}
		
		return listaDeArticulos;
	}

}
