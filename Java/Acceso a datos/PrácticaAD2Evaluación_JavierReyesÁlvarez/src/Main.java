import java.sql.Statement;
import java.io.File;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;

public class Main {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);

		File f = new File("xml\\Pedidos_Tiendas.xml");
		String bd = "jdbc:sqlite:sample2.db";
		Connection conn = ConexionBD(bd);

		int opcion;
		do {
			System.out.println("0. Salir");
			System.out.println("1. Crear las tablas ");
			System.out.println("2. Borrar las tablas");
			System.out.println("3. Borrar datos de las tablas");
			System.out.println("4. Leer XML y volcar los datos");

			opcion = teclado.nextInt();
			switch (opcion) {
			case 0:
				DesconexionBD(conn);
				break;
			case 1:
				CrearTablas(bd, conn);
				break;
			case 2:
				BorrarTablas(f, conn);
				break;
			case 3:
				BorrarDatos(f, conn);
				break;
			case 4:
				LecturaVolcadoXML(f, conn);
				break;
			default:
				System.out.println("Opcion invalida\n");
				break;
			}
		} while (opcion != 0);

		teclado.close();
	}

	private static void BorrarTablas(File f, Connection conn) {
		Statement stm;
		// Se borran las tablas
		String borrarDatos = "DROP TABLE IF EXISTS pedidos; DROP TABLE IF EXISTS articulosPedido;";
		try {
			stm = conn.createStatement();
			stm.executeUpdate(borrarDatos);
			System.out.println("Tablas 'pedidos' y 'articulosPedido' borradas");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println(" ");
	}

	private static void BorrarDatos(File f, Connection conn) {
		Statement stm;
		// Se borran los datos, no las tablas
		String borrarDatos = "DELETE FROM pedidos; DELETE FROM articulosPedido;";
		try {
			stm = conn.createStatement();
			stm.executeUpdate(borrarDatos);
			System.out.println("Datos borrados de 'pedidos' y 'articulosPedido'");
		} catch (SQLException e) {
			System.out.println("No existen las tablas de 'pedidos' y 'articulosPedido'");
		}
		System.out.println(" ");
	}

	private static void LecturaVolcadoXML(File f, Connection conn) {
		try {
			DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbf.newDocumentBuilder();
			Document d = db.parse(f);
			d.getDocumentElement().normalize();

			Statement stm;
			
			NodeList pedidos = d.getElementsByTagName("pedido");
			for (int i = 0; i < pedidos.getLength(); i++) {
				Node nodoPedido = pedidos.item(i);

				if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
					Element pedido = (Element) nodoPedido;

					String numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
					String numero_pedido = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
					String fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();

					// Inserción
					String insPedidos = "INSERT INTO pedidos VALUES('" + numero_pedido + "', '" + numero_cliente + "', '" + fecha + "')";	
					
					// Comprobación de PKs
					String comprobacion = "SELECT num_pedido FROM pedidos WHERE (num_pedido = '"+numero_pedido+"');";					
					stm = conn.createStatement();
					ResultSet rs = stm.executeQuery(comprobacion);
								
					try {
						if (!rs.next()) {						
							stm = conn.createStatement();
							stm.executeUpdate(insPedidos);
							System.out.println("Dato insertado en la tabla 'pedidos' correctamente");
						}else {
							System.out.println("No puede insertarse, ya existe dicha PK. ");
						}						
					} catch (SQLException e) {
						e.printStackTrace();
					}
									
					NodeList articulos = pedido.getElementsByTagName("articulo");
					for (int j = 0; j < articulos.getLength(); j++) {
						Node nodoArticulo = articulos.item(j);
						if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
							Element articulo = (Element) nodoArticulo;

							String codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
							String cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();

							// Inserción
							String insArticulosPedido = "INSERT INTO articulosPedido VALUES('" + numero_pedido + "', '" + codigo
									+ "', '" + cantidad + "');";
							try {
								stm = conn.createStatement();
								stm.executeUpdate(insArticulosPedido);
								System.out.println("Dato insertado en la tabla 'articulosPedido' correctamente");
							} catch (SQLException e) {
								e.printStackTrace();
							}

						}
					}
					
				}
			}
			System.out.println("");

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	private static void DesconexionBD(Connection conn) {
		try {
			conn.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println("Te has desconectado a la base de datos.");
	}

	private static Connection ConexionBD(String bd) {
		Connection conn = null;
		try {
			Class.forName("org.sqlite.JDBC");
			conn = DriverManager.getConnection(bd);
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
		System.out.println("Te has conectado a la base de datos.");
		return conn;
	}

	private static void CrearTablas(String bd, Connection conn) {
		String ct_pedidos = "CREATE TABLE IF NOT EXISTS pedidos(num_pedido TEXT PRIMARY KEY UNIQUE, num_cliente TEXT, fecha TEXT);";
		String ct_articulosPedido = "CREATE TABLE IF NOT EXISTS articulosPedido(num_pedido INTEGER, codigo TEXT, cantidad INTEGER, FOREIGN KEY(num_pedido) REFERENCES pedidos(num_pedido));";
		Statement stm;

		try {
			stm = conn.createStatement();
			stm.executeUpdate(ct_pedidos);
			System.out.println("Se ha creado la tabla de pedidos.");
			stm.executeUpdate(ct_articulosPedido);
			System.out.println("Se ha creado la tabla de articulosPedido.");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println(" ");
	}

}
