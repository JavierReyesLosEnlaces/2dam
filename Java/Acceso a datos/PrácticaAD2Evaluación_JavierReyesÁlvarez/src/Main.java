import java.sql.Statement;
import java.io.File;
import java.io.IOException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Iterator;
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
		String bd = "jdbc:sqlite:bds\\sample3.db";
		Connection conn = ConexionBD(bd);

		int opcion;
		do {
			System.out.println("0. Desconectarse");
			System.out.println("1. Crear las tablas");
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
				insertarDatosExtras(conn);
				break;
			default:
				System.out.println("Opcion invalida\n");
				break;
			}
		} while (opcion != 0);

		teclado.close();
	}

	private static void insertarDatosExtras(Connection conn) {
		Statement stmt;
		String[] insClientes = {
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C1', 'Juan Pérez', 'Calle 123', '1234567890')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C2', 'María García', 'Avenida 456', '9876543210')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C3', 'Pedro López', 'Carrera 789', '5678901234')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C4', 'Ana Martínez', 'Plaza 012', '3210987654')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C5', 'Luis Rodríguez', 'Paseo 345', '7890123456')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C6', 'Laura González', 'Camino 678', '2345678901')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C7', 'Diego Hernández', 'Travesía 901', '8901234567')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C8', 'Sofía Díaz', 'Ronda 234', '4567890123')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C9', 'Carlos Sánchez', 'Pasaje 567', '9012345678')",
		    "INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('C10', 'Elena Ruiz', 'Autopista 890', '6789012345')"
		};

		String[] insArticulos = {
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A1', 'Producto 1', 'Familia 1', '2024-01-01')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A2', 'Producto 2', 'Familia 2', '2024-01-02')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A3', 'Producto 3', 'Familia 3', '2024-01-03')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A4', 'Producto 4', 'Familia 4', '2024-01-04')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A5', 'Producto 5', 'Familia 5', '2024-01-05')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A6', 'Producto 6', 'Familia 1', '2024-01-06')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A7', 'Producto 7', 'Familia 2', '2024-01-07')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A8', 'Producto 8', 'Familia 3', '2024-01-08')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A9', 'Producto 9', 'Familia 4', '2024-01-09')",
		    "INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('A10', 'Producto 10', 'Familia 5', '2024-01-10')"
		};
		
		String[] insStock = {
			    "INSERT INTO stock(codigo, stock) VALUES ('123456', 30)",
			    "INSERT INTO stock(codigo, stock) VALUES ('234567', 40)",
			    "INSERT INTO stock(codigo, stock) VALUES ('345678', 50)",
			    "INSERT INTO stock(codigo, stock) VALUES ('456789', 60)",
			    "INSERT INTO stock(codigo, stock) VALUES ('567890', 70)",
			    "INSERT INTO stock(codigo, stock) VALUES ('678901', 80)",
			    "INSERT INTO stock(codigo, stock) VALUES ('789012', 90)",
			    "INSERT INTO stock(codigo, stock) VALUES ('890123', 100)",
			    "INSERT INTO stock(codigo, stock) VALUES ('123457', 110)",
			    "INSERT INTO stock(codigo, stock) VALUES ('234568', 120)",
			};

		try {
		    stmt = conn.createStatement();
		    for (String insCliente : insClientes) {
		        stmt.executeUpdate(insCliente);
		        System.out.println("[+] 'clientes'");
		    }
		    for (String insArticulo : insArticulos) {
		        stmt.executeUpdate(insArticulo);
		        System.out.println("[+] 'articulos'");
		    }
		    for (String ins : insStock) {
		        stmt.executeUpdate(ins);
		        System.out.println("[+] 'stock'");
		    }
		} catch (SQLException e) {
		    e.printStackTrace();
		}
		System.out.println("");
	}

	private static void LecturaVolcadoXML(File f, Connection conn) {
		String numero_cliente = null;
		String num_pedido = null;
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
					num_pedido = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
					fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();

					ResultSet rs = existeNumPedido(conn, num_pedido);				

					// SI NO EXISTE EL DATO, SE INSERTA EN AMBAS TABLAS
					if (!rs.next()) {
						
						// INSERCIÓN EN pedidos
						String insPedidos = "INSERT INTO pedidos VALUES('" + num_pedido + "', '" + numero_cliente + "', '" + fecha + "')";
						stm = conn.createStatement();
						stm.executeUpdate(insPedidos);
						System.out.println("[+]'pedidos'");
											
						NodeList articulos = pedido.getElementsByTagName("articulo");
						for (int j = 0; j < articulos.getLength(); j++) {					// EN CADA PEDIDO, CADA 
							Node nodoArticulo = articulos.item(j);
							if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
								Element articulo = (Element) nodoArticulo;

								codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
								cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();
								
								// INSERCIÓN EN articulosPedido	
								String insArticulosPedido = "INSERT INTO articulosPedido VALUES('" + num_pedido + "', '" + codigo + "', '" + cantidad + "');";
								try {
									stm = conn.createStatement();
									stm.executeUpdate(insArticulosPedido);
									System.out.println("[+]'articulosPedido'");

								} catch (SQLException e) {
									e.printStackTrace();
								}
							}
						}
					// SI EXISTE EL DATO, HAY QUE PROPONER ACTUALIZAR LOS DATOS VIEJOS POR LOS NUEVOS EN AMBAS TABLAS
					} else {
						OpcionSobreescribir(conn, num_pedido, f);							
					}

				}
			}

		} catch (Exception e) {
			e.printStackTrace();
		}
	}

	// SE COMPRUEBA SI EXISTE LA num_pedido
	private static ResultSet existeNumPedido(Connection conn, String num_pedido) throws SQLException {
		Statement stm = conn.createStatement();
		String comprobacion = "SELECT num_pedido FROM pedidos WHERE (num_pedido = '" + num_pedido + "');";
		ResultSet rs = stm.executeQuery(comprobacion);
		return rs;
	}
	

	// SE COMPRUEBA SI EXISTE num_cliente
	private static ResultSet existeCliente(Connection conn, String num_cliente) throws SQLException {
		Statement stm = conn.createStatement();
		String comprobacion = "SELECT num_pedido FROM clientes WHERE (num_cliente = '" + num_cliente + "');";
		ResultSet rs = stm.executeQuery(comprobacion);
		return rs;
	}
	
	
	
	
	// MÉTODO DE SI EXISTE EL PRODUCTO
	
	
	
	// SE COMPRUEBA SI EL STOCK ES POSITIVO
	private static ResultSet existesStock(Connection conn, String num_pedido) throws SQLException {
		Statement stm = conn.createStatement();
		
		// DEBE COMPROBAR QUE EXISTE 
		
		String comprobacion = "SELECT stock FROM ar WHERE (num_cliente = '" + num_pedido + "');";
		ResultSet rs = stm.executeQuery(comprobacion);
		return rs;
		
		
		
		
		
		
		
		
		
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
	
	private static void OpcionSobreescribir(Connection conn, String num_pedido, File f) throws ParserConfigurationException, SAXException, IOException {
		Scanner teclado = new Scanner(System.in);
		DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
		DocumentBuilder db = dbf.newDocumentBuilder();
		Document d = db.parse(f);
		d.getDocumentElement().normalize();
		Statement stm;
		
		int opcion;
		do {
			System.out.println("Existe un registro con num_pedido: '"+num_pedido+"'\n¿Desea sobreescribirlo?");		
			System.out.println("0. SI");
			System.out.println("1. NO");
			opcion = teclado.nextInt();
			switch(opcion) {
			case 0: 
				System.out.println("No se ha sobreescrito. ");
				break;
			case 1: 		
			    NodeList pedidos = d.getElementsByTagName("pedido");
			    for (int i = 0; i < pedidos.getLength(); i++) {
			        Node nodoPedido = pedidos.item(i);

			        if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
			            Element pedido = (Element) nodoPedido;

			            String num_pedido_actual = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();

			            if (num_pedido_actual.equals(num_pedido)) {
			                String numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
			                String fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();

			                // Actualizar datos en la tabla pedidos
			                String upPedidos = "UPDATE pedidos SET num_cliente = '"+numero_cliente+ "', fecha ='" + fecha + "' WHERE num_pedido = '" + num_pedido + "';";						
			                try {
			                    stm = conn.createStatement();
			                    stm.executeUpdate(upPedidos);
			                    System.out.println("Dato insertado en la tabla 'pedidos' correctamente");
			                } catch (SQLException e) {
			                    e.printStackTrace();
			                }

			                // Eliminar todas las entradas relacionadas con el num_pedido actual en articulosPedido
			                String delTuplaArticulosPedido = "DELETE FROM articulosPedido WHERE num_pedido = '"+num_pedido_actual+"';";
			                try {
			                    stm = conn.createStatement();
			                    stm.executeUpdate(delTuplaArticulosPedido);
			                } catch (SQLException e) {
			                    e.printStackTrace();
			                }

			                // Insertar los articulos del pedido actual en articulosPedido
			                NodeList articulos = pedido.getElementsByTagName("articulo");
			                for (int j = 0; j < articulos.getLength(); j++) {
			                    Node nodoArticulo = articulos.item(j);
			                    if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
			                        Element articulo = (Element) nodoArticulo;

			                        String codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
			                        String cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();

			                        String upArticulosPedido = "INSERT INTO articulosPedido VALUES('"+num_pedido_actual+"', '"+codigo+"', '"+cantidad+"');";
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
        System.out.println("");
		return conn;
	}
	
	private static void DesconexionBD(Connection conn) {
		try {
			conn.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println("Te has desconectado.");
	}

	private static void CrearTablas(String bd, Connection conn) {
		String ct_pedidos = "CREATE TABLE IF NOT EXISTS pedidos(num_pedido TEXT PRIMARY KEY UNIQUE, num_cliente TEXT, fecha TEXT, FOREIGN KEY(num_cliente) REFERENCES clientes(num_cliente));";
		String ct_articulosPedido = "CREATE TABLE IF NOT EXISTS articulosPedido(num_pedido TEXT, codigo TEXT, cantidad INTEGER, FOREIGN KEY(num_pedido) REFERENCES pedidos(num_pedido));";
		String ct_clientes = "CREATE TABLE IF NOT EXISTS clientes(num_cliente TEXT PRIMARY KEY UNIQUE, nombre TEXT, direccion TEXT, telefono TEXT);";
		String ct_articulos =  "CREATE TABLE IF NOT EXISTS articulos(codigo TEXT PRIMARY KEY UNIQUE, descripcion TEXT, familiaProducto TEXT, fecha_alta TEXT);";
		String ct_stock = "CREATE TABLE IF NOT EXISTS stock(codigo TEXT, stock INTEGER);";
		Statement stm;

		try {
			stm = conn.createStatement();
			stm.executeUpdate(ct_pedidos);
			System.out.println("[+] Tabla 'pedidos'");
			stm.executeUpdate(ct_articulosPedido);
			System.out.println("[+] Tabla 'articulosPedido'");
			stm.executeUpdate(ct_clientes);
			System.out.println("[+] Tabla 'clientes'");
			stm.executeUpdate(ct_articulos);
			System.out.println("[+] Tabla 'articulos'");
			stm.executeUpdate(ct_stock);
			System.out.println("[+] Tabla 'stock'");
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
			System.out.println("[-] Tabla 'pedidos'");
			System.out.println("[-] Tabla 'articulosPedido'");
			System.out.println("[-] Tabla 'clientes'");
			System.out.println("[-] Tabla 'articulos'");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println(" ");
	}

}
