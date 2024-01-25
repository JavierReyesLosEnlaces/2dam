import java.beans.Statement;
import java.net.ConnectException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;
import java.util.Scanner;

public class Main {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in); 
		String bd = "jdbc:sqlite:bd\\sample.db";
		conexionBD(bd);
		int opcion; 
		do {
			System.out.println("0. Salir");
			System.out.println("1. Conectarse a la base de datos");
			System.out.println("1. Crear las tablas ");
			System.out.println(" ");
			
			opcion = teclado.nextInt();
			switch (opcion) {
			case 0:
				System.out.println("Has salido. ");
				break;
			case 1:
				CrearTablas(bd);
				break;
			case 2:
				break;
			default:
				System.out.println("Opcion invalida");
				break;
			}
		} while (opcion != 0); 
		
		teclado.close();
	}

	
	private static void conexionBD(String bd) {
		try {
			Class.forName("org.sqlite.JDBC");
		} catch (Exception e) {
			// TODO: handle exception
		}
		Connection conn = DriverManager.getConnection(bd);
		System.out.println("Te has conectado a la base de datos "+);
		
	}


	private static void CrearTablas(String bd) {
		// Queries
		String ct_pedidos = "CREATE TABLE [IF NOT EXISTS] pedidos(num-cliente TEXT, num-pedido TEXT, fecha TEXT);";
		String ct_articulosPedido = "CREATE TABLE [IF NOT EXISTS] articulosPedido(num-pedido INTEGER, codigo TEXT, cantidad INTEGER;";
		
		
		
		
		
	}
}
