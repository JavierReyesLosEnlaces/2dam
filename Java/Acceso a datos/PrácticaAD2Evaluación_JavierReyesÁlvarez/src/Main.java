import java.sql.Statement;
import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Scanner;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;

import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.Node;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

public class Main {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);

		File f = new File("xml\\Pedidos_Tiendas.xml");
		String bd = "jdbc:sqlite:sample7.db";
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

	private static void LecturaVolcadoXML(File f, Connection conn) {
		String numero_cliente = null;
		String numero_pedido = null;
		String fecha = null;
		String codigo = null;
		String cantidad = null;
		
		try {
			DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbf.newDocumentBuilder();
			Document d = db.parse(f);
			d.getDocumentElement().normalize();

			Statement stm;

			NodeList pedidos = d.getElementsByTagName("pedido");
			for (int i = 0; i < pedidos.getLength(); i++) {			// POR CADA PEDIDO
				Node nodoPedido = pedidos.item(i);

				if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
					Element pedido = (Element) nodoPedido;

					// SE CONSIGUEN LOS ELEMENTOS
					numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
					numero_pedido = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
					fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();

					// SE COMPRUEBA SI EXISTE LA PK 
					String comprobacion = "SELECT num_pedido FROM pedidos WHERE (num_pedido = '" + numero_pedido + "');";
					stm = conn.createStatement();
					ResultSet rs = stm.executeQuery(comprobacion);				

					// SI NO EXISTE EL DATO, SE INSERTA EN AMBAS TABLAS
					if (!rs.next()) {
						
						// INSERCIÓN EN pedidos
						String insPedidos = "INSERT INTO pedidos VALUES('" + numero_pedido + "', '" + numero_cliente + "', '" + fecha + "')";
						stm = conn.createStatement();
						stm.executeUpdate(insPedidos);
						System.out.println("Dato insertado en la tabla 'pedidos' correctamente");
											
						NodeList articulos = pedido.getElementsByTagName("articulo");
						for (int j = 0; j < articulos.getLength(); j++) {					// EN CADA PEDIDO, CADA 
							Node nodoArticulo = articulos.item(j);
							if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
								Element articulo = (Element) nodoArticulo;

								codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
								cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();
								
								// INSERCIÓN EN articulosPedido	
								String insArticulosPedido = "INSERT INTO articulosPedido VALUES('" + numero_pedido + "', '" + codigo + "', '" + cantidad + "');";
								try {
									stm = conn.createStatement();
									stm.executeUpdate(insArticulosPedido);
									System.out.println("Dato insertado en la tabla 'articulosPedido' correctamente");

								} catch (SQLException e) {
									e.printStackTrace();
								}
							}
						}
					// SI EXISTE EL DATO, HAY QUE PROPONER ACTUALIZAR LOS DATOS VIEJOS POR LOS NUEVOS EN AMBAS TABLAS
					} else {
						OpcionSobreescribir(conn, numero_pedido, f);							
					}

				}
			}
			System.out.println("");

		} catch (Exception e) {
			e.printStackTrace();
		}
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
	
	private static void OpcionSobreescribir(Connection conn, String numero_pedido, File f) throws ParserConfigurationException, SAXException, IOException {
		Scanner teclado = new Scanner(System.in);
		DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
		DocumentBuilder db = dbf.newDocumentBuilder();
		Document d = db.parse(f);
		d.getDocumentElement().normalize();
		Statement stm;
		
		int opcion;
		do {
			System.out.println("Parece que ya existe un registro con  numero_pedido '"+numero_pedido+"' en 'pedidos' y, por lo tanto, en 'articulosPedido'");		
			System.out.println("0. No sobreescribirlo en 'pedidos' y 'articulosPedido'");
			System.out.println("1. Sobreescribirlo en 'pedidos' y 'articulosPedido");
			opcion = teclado.nextInt();
			switch(opcion) {
			case 0: 
				System.out.println("No se sobreescribe, se mantiene el antiguo registro. ");
				break;
			case 1: 
				NodeList pedidos = d.getElementsByTagName("pedido");
				for (int i = 0; i < pedidos.getLength(); i++) {			// POR CADA PEDIDO
					Node nodoPedido = pedidos.item(i);

					if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
						Element pedido = (Element) nodoPedido;

						// SE CONSIGUEN LOS ELEMENTOS
						String numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
						numero_pedido = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
						String fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();

						// ACTUALIZACION EN pedidos							
						String upPedidos = "UPDATE pedidos SET num_pedido = '"+numero_pedido+"', num_cliente = '"+numero_cliente+ "', fecha ='" + fecha + "' WHERE num_pedido = '" + numero_pedido + "';";						
						try {
							stm = conn.createStatement();
							stm.executeUpdate(upPedidos);
						} catch (SQLException e) {
							e.printStackTrace();
						}
						System.out.println("Dato insertado en la tabla 'pedidos' correctamente");
											
						NodeList articulos = pedido.getElementsByTagName("articulo");
						for (int j = 0; j < articulos.getLength(); j++) {					// EN CADA PEDIDO, CADA 
							Node nodoArticulo = articulos.item(j);
							if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
								Element articulo = (Element) nodoArticulo;

								String codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
								String cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();
								
								// ACTUALIZACION EN articulosPedido	
								String upArticulosPedido = "UPDATE articulosPedido SET num_pedido = '"+numero_pedido+"', codigo = '"+codigo+"', cantidad = '"+cantidad+ "' WHERE num_pedido = '" + numero_pedido + "';";			
								try {
									stm = conn.createStatement();
									stm.executeUpdate(upArticulosPedido);
								} catch (SQLException e) {
									e.printStackTrace();
								}
							}
						}
					}
				}
				break;
			default: 
				System.out.println("Opción erronea, vuelve a intentarlo");
				break;
			}			
		}while(opcion!=0 && opcion!=1);
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
	
	private static void DesconexionBD(Connection conn) {
		try {
			conn.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println("Te has desconectado a la base de datos.");
	}

	private static void CrearTablas(String bd, Connection conn) {
		String ct_pedidos = "CREATE TABLE IF NOT EXISTS pedidos(num_pedido TEXT PRIMARY KEY UNIQUE, num_cliente TEXT, fecha TEXT, FOREIGN KEY(num_cliente) REFERENCES clientes(num_cliente));";
		String ct_articulosPedido = "CREATE TABLE IF NOT EXISTS articulosPedido(num_pedido TEXT, codigo TEXT, cantidad INTEGER, FOREIGN KEY(num_pedido) REFERENCES pedidos(num_pedido));";
		String ct_clientes = "CREATE TABLE IF NOT EXISTS clientes(num_cliente TEXT PRIMARY KEY UNIQUE, nombre TEXT, direccion TEXT, telefono TEXT);";
		String ct_articulos =  "CREATE TABLE IF NOT EXISTS articulos(descripcion TEXT, nombrePadre TEXT, nombreMadre TEXT, fecha_alta TEXT);";
		Statement stm;

		try {
			stm = conn.createStatement();
			stm.executeUpdate(ct_pedidos);
			System.out.println("Se ha creado la tabla 'pedidos'");
			stm.executeUpdate(ct_articulosPedido);
			System.out.println("Se ha creado la tabla 'articulosPedido'");
			stm.executeUpdate(ct_clientes);
			System.out.println("Se ha creado la tabla 'clientes'");
			stm.executeUpdate(ct_articulos);
			System.out.println("Se ha creado la tabla 'articulos'");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println(" ");
	}
	
	private static void BorrarTablas(File f, Connection conn) {
		Statement stm;
		// Se borran las tablas
		String borrarDatos = "DROP TABLE IF EXISTS pedidos; DROP TABLE IF EXISTS articulosPedido; DROP TABLE IF EXISTS clientes; DROP TABLE IF EXISTS articulos";
		try {
			stm = conn.createStatement();
			stm.executeUpdate(borrarDatos);
			System.out.println("Se ha borrado la tabla 'pedidos'");
			System.out.println("Se ha borrado la tabla 'articulosPedido'");
			System.out.println("Se ha borrado la tabla 'clientes'");
			System.out.println("Se ha borrado la tabla 'articulos'");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println(" ");
	}

}
