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

	static Scanner teclado = new Scanner(System.in);

	public static void main(String[] args) {

		File f = new File("xml\\Pedidos_Tiendas.xml");
		String bd = "jdbc:sqlite:bdDePedidos.db";
		boolean tablasCreadas = false;
		
		// EL PROGRAMA CONECTA AUTOMÁTICAMENTE CON LA BASE DE DATOS CUANDO SE EJECUTA
		Connection conn = conexionBD(bd);

		int opcion;
		do {
			System.out.println("0. Desconectarse");
			System.out.println("1. Crear las tablas");
			
			// LAS SIGUIENTES OPCIONES SOLO ESTÁN DISPONIBLES CUANDO SE HAN CREADO LAS TABLAS
			if (tablasCreadas) {
				System.out.println("2. Insertar datos en 'clientes', 'articulos' y 'stock'");
				System.out.println("3. Borrar las tablas");
				System.out.println("4. Borrar datos de las tablas");
				System.out.println("5. Leer XML y volcar los datos");
			}
			
			opcion = teclado.nextInt();			
			switch (opcion) {
			case 0:
				// EL PROGRAMA TE DESCONECTA CUANDO SE SALE DEL PROGRAMA
				desconexionBD(conn);
				break;
			case 1:
				crearTablas(bd, conn);
				tablasCreadas = true;
				break;
			case 2:
				if (tablasCreadas) {
					volcadoDatosExtras(conn);
				} else {
					System.out.println("Por favor, primero cree las tablas.");
				}
				break;
			case 3:
				if (tablasCreadas) {
					borrarTablas(f, conn);
					tablasCreadas = false;
				} else {
					System.out.println("Por favor, primero cree las tablas.");
				}
				break;
			case 4:
				if (tablasCreadas) {
					borrarDatos(f, conn);
				} else {
					System.out.println("Por favor, primero cree las tablas.");
				}
				break;
			case 5:
				if (tablasCreadas) {
					volcadoDatosXml(f, conn);
				} else {
					System.out.println("Por favor, primero cree las tablas.");
				}
				break;
			default:
				System.out.println("Opcion invalida\n");
				break;
			}
		} while (opcion != 0);

		teclado.close();
	}

	// EL MÉTODO "borrarDatos" BORRA LOS DATOS DE LAS TABLAS SIN BORRAR LAS TABLAS
	private static void borrarDatos(File f, Connection conn) {
		Statement stm;
		String borrarDatos = "DELETE FROM articulos; DELETE FROM articulosPedido; DELETE FROM clientes; DELETE FROM pedidos; DELETE FROM stock;";
		try {
			stm = conn.createStatement();
			stm.executeUpdate(borrarDatos);
			System.out.println("Datos borrados de 'articulos', 'articulosPedido', 'clientes', 'pedidos' y 'stock'");
		} catch (SQLException e) {
			System.out.println("No existen las tablas de 'articulos', 'articulosPedido', 'clientes', 'pedidos' y 'stock'");
		}
		System.out.println(" ");
	}

	// EL MÉTODO "opcionSobreescribir" DA LA OPCIÓN DE SOBREESCRIBIR LOS DATOS DE UN PEDIDO CUANDO INTENTAS INSERTAR UN PEDIDO CON UN "num_pedido" YA EXISTENTE 
	private static void opcionSobreescribir(Connection conn, String num_pedido, File f) throws ParserConfigurationException, SAXException, IOException {
		DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
		DocumentBuilder db = dbf.newDocumentBuilder();
		Document d = db.parse(f);
		d.getDocumentElement().normalize();
		Statement stm;
		Integer opcion;
		
		// SE PREGUNTA AL USUARIO SI SE DESEA SOBREESCRIBIR LA INFORMACIÓN DEL PEDIDO
		do {
			System.out.println("Existe un registro con num_pedido: '" + num_pedido + "'\n¿Desea sobreescribirlo?");
			System.out.println("0. NO");
			System.out.println("1. SI");
			
			opcion = teclado.nextInt();
			switch (opcion) {
			case 0:
				System.out.println("No se ha sobreescrito. ");
				break;
			case 1:
				NodeList pedidos = d.getElementsByTagName("pedido");
				for (int i = 0; i < pedidos.getLength(); i++) {
					Node nodoPedido = pedidos.item(i);
					if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
						Element pedido = (Element) nodoPedido;
						
						// SE CONSIGUE EL NÚMERO DE PEDIDO QUE INTERESA SOBREESCRIBIR Y EL RESTO DE INFORMACIÓN QUE LE CORRESPONDE
						String num_pedido_actual = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
						if (num_pedido_actual.equals(num_pedido)) {
							String numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
							String fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();

							// SE ACTUALIZAN TODOS LOS DATOS DE "pedidos" CON ESE "num_pedido"
							String upPedidos = "UPDATE pedidos SET num_cliente = '" + numero_cliente + "', fecha ='"
									+ fecha + "' WHERE num_pedido = '" + num_pedido + "';";
							try {
								stm = conn.createStatement();
								stm.executeUpdate(upPedidos);
								System.out.println("Dato insertado en la tabla 'pedidos' correctamente");
							} catch (SQLException e) {
								e.printStackTrace();
							}

							// SE ELIMINAN TODAS LAS ENTRADAS RELACIONADAS CON EL "num_pedido actual" EN articulosPedido
							String delTuplaArticulosPedido = "DELETE FROM articulosPedido WHERE num_pedido = '"
									+ num_pedido_actual + "';";
							try {
								stm = conn.createStatement();
								stm.executeUpdate(delTuplaArticulosPedido);
							} catch (SQLException e) {
								e.printStackTrace();
							}

							// SE INSERTAN LOS ARTÍCULOS DEL PEDIDO ACTUAL EN "articulosPedido"
							NodeList articulos = pedido.getElementsByTagName("articulo");
							for (int j = 0; j < articulos.getLength(); j++) {
								Node nodoArticulo = articulos.item(j);
								if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
									Element articulo = (Element) nodoArticulo;

									String codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
									String cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();
									String upArticulosPedido = "INSERT INTO articulosPedido VALUES('"
											+ num_pedido_actual + "', '" + codigo + "', '" + cantidad + "');";
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
				System.out.println("Opcion invalida");
				break;
			}
		} while (opcion != 0 && opcion != 1);
	}

	// EL MÉTODO "conexionBD" CONECTA A LA BASE DE DATOS
	private static Connection conexionBD(String bd) {
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

	// EL MÉTODO "desconexionBD" DESCONECTA DE LA BASE DE DATOS
	private static void desconexionBD(Connection conn) {
		try {
			conn.close();
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println("Te has desconectado.");
	}

	// EL MÉTODO "volcadoDatosXml" LEE EL "Pedidos_Tiendas.xml" Y VUELCA LOS DATOS EN LA BASE DE DATOS
	private static void volcadoDatosXml(File f, Connection conn) {
		try {
			DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
			DocumentBuilder db = dbf.newDocumentBuilder();
			Document d = db.parse(f);
			d.getDocumentElement().normalize();

			NodeList pedidos = d.getElementsByTagName("pedido");
			for (int i = 0; i < pedidos.getLength(); i++) {
				Node nodoPedido = pedidos.item(i);

				if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
					Element pedido = (Element) nodoPedido;

					// SE CONSIGUEN LOS ELEMENTOS
					String numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
					
					// SE COMPRUEBA SI EL CLIENTE EXISTE ANTES DE INSERTAR EL PEDIDO
					// SI EXISTE, SE PROCEDE A INSERTAR DATOS
					if (existeCliente(conn, numero_cliente)) {
						String num_pedido = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
						String fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();
						
						// SE COMPRUEBA SI EXISTE EL PEDIDO
						// SI NO EXISTE EL DATO, SE PROCEDE A INSERTAR DATOS
						if (!existeNumPedido(conn, num_pedido)) {
							
							insertarPedido(conn, numero_cliente, num_pedido, fecha);

							NodeList articulos = pedido.getElementsByTagName("articulo");
							for (int j = 0; j < articulos.getLength(); j++) {
								Node nodoArticulo = articulos.item(j);
								if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
									Element articulo = (Element) nodoArticulo;
									
									String codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
									Integer cantidad = Integer.parseInt(
											articulo.getElementsByTagName("cantidad").item(0).getTextContent());
									
									// SE COMPRUEBA SI EXISTA EL PRODUCTO
									// SI EXISTE, SE COMPRUEBA QUE EXISTE SUFICIENTE STOCK PARA ATENDER AL PEDIDO
									// SI EXISTE SUFICIENTE STOCK, SE INSERTAN LOS DATOS SOBRE ARTÍCULOS DEL PEDIDO Y SE ACTUALIZA EL STOCK DEL PRODUCTO
									if (existeProducto(conn, codigo)) {
										if (existeSuficienteStock(conn, codigo, cantidad)) {
											insertarArticulosPedido(conn, num_pedido, codigo, cantidad);
											actualizarStockArticulo(conn, codigo, cantidad);
										} else {
											// SI NO EXISTE SUFICIENTE STOCK, NO SE PERMITE INSERTAR DATOS
											System.out.println("No existe suficiente stock");
										}
									} else {
										// SI NO EXISTE EL PRODUCTO, NO SE PERMITE INSERTAR DATOS
										System.out.println("No existe el producto");
									}
								}
							}
						} else {
							// SI YA EXISTE EL PEDIDO, SE DA LA OPCIÓN DE SOBREESCRIBIR 
							opcionSobreescribir(conn, num_pedido, f);
						}
					} else {
						// SI EL CLIENTE NO EXISTE, NO SE PERMITE NSERTAR DATOS
						System.out.println("El cliente " + numero_cliente + " no existe en la base de datos.");
					}
				}
			}
		} catch (Exception e) {
			e.printStackTrace();
		}
		System.out.println("");
	}

	// EL MÉTODO "actualizarStockArticulo" PERMITE ACTUALIZAR EL STOCK DEL ARTÍCULO QUE SE ESTÁ INSERTANDO
	private static void actualizarStockArticulo(Connection conn, String codigo, int cantidad) {
		try {
			// SE OBTIENE EL STOCK ACTUAL DEL PRODUCTO A INSERTAR
			String consultaStock = "SELECT stock FROM stock WHERE codigo = '" + codigo + "';";
			try (Statement stm = conn.createStatement(); ResultSet rs = stm.executeQuery(consultaStock)) {
				if (rs.next()) {
					int stockActual = rs.getInt("stock");
					int nuevoStock = stockActual - cantidad;

					// SE ACTUALIZA EL STOCK DEL PRODUCTO
					String actualizarStock = "UPDATE stock SET stock = " + nuevoStock + " WHERE codigo = '" + codigo + "';";
					stm.executeUpdate(actualizarStock);
				} else {
					System.out.println("No se encontró ningún articulo con el código " + codigo);
				}
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	// EL MÉTODO "volcadoDatosExtras" INSERTA DATOS DE PARTIDA EN LAS TABLAS DE "clientes", "articulos" Y "stock"
	private static void volcadoDatosExtras(Connection conn) {
		Statement stmt;
		// LAS SENTENCIAS SE HAN CONTENIDO EN ARRAYS DE STRINGS Y POSTERIORMENTE SE HA ITERADO SOBRE ELLOS PARA LLEVAR A CABO LAS INSERCIONES
		String[] insClientes = {
				"INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('1234567890', 'Juan Pérez', 'Calle 123', '1234567890');",
				"INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('9876543210', 'María García', 'Avenida 456', '9876543210');",
				"INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('1234567891', 'Pedro López', 'Carrera 789', '5678901234');",
				"INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('1234567892', 'Ana Martínez', 'Plaza 012', '3210987654');",
				"INSERT INTO clientes(num_cliente, nombre, direccion, telefono) VALUES ('1234567893', 'Luis Rodríguez', 'Paseo 345', '7890123456');" };

		String[] insArticulos = {
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('123456', 'Producto 1', 'Familia 1', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('234567', 'Producto 2', 'Familia 2', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('345678', 'Producto 3', 'Familia 3', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('456789', 'Producto 4', 'Familia 4', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('567890', 'Producto 5', 'Familia 5', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('678901', 'Producto 6', 'Familia 1', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('789012', 'Producto 7', 'Familia 2', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('890123', 'Producto 8', 'Familia 3', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('123457', 'Producto 9', 'Familia 4', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('234568', 'Producto 10', 'Familia 5', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('901234', 'Producto 11', 'Familia 1', '2024-02-03');",
				"INSERT INTO articulos(codigo, descripcion, familiaProducto, fecha_alta) VALUES ('012345', 'Producto 12', 'Familia 2', '2024-02-03');" };

		String[] insStock = { "INSERT INTO stock(codigo, stock) VALUES ('123456', 30);",
				"INSERT INTO stock(codigo, stock) VALUES ('234567', 40);",
				"INSERT INTO stock(codigo, stock) VALUES ('345678', 50);",
				"INSERT INTO stock(codigo, stock) VALUES ('456789', 60);",
				"INSERT INTO stock(codigo, stock) VALUES ('567890', 70);",
				"INSERT INTO stock(codigo, stock) VALUES ('678901', 80);",
				"INSERT INTO stock(codigo, stock) VALUES ('789012', 90);",
				"INSERT INTO stock(codigo, stock) VALUES ('890123', 100);",
				"INSERT INTO stock(codigo, stock) VALUES ('123457', 110);",
				"INSERT INTO stock(codigo, stock) VALUES ('234568', 120);",
				"INSERT INTO stock(codigo, stock) VALUES ('901234', 130);",
				"INSERT INTO stock(codigo, stock) VALUES ('012345', 140);", };

		// ESTOS DATOS SON DE PRUEBA, NO QUEREMOS QUE SE INSERTEN MÁS DE UNA VEZ
		// AL CONTENER CLAVES "UNIQUE", NO SE INSERTAN DATOS EN LAS TABLAS MÁS DE UNA VEZ PARA EVITAR DUPLICIDAD DE DATOS

		try {
			stmt = conn.createStatement();
			for (String insCliente : insClientes) {
				stmt.executeUpdate(insCliente);
				System.out.println("[+] Campo 'clientes'");
			}
			for (String insArticulo : insArticulos) {
				stmt.executeUpdate(insArticulo);
				System.out.println("[+] Campo 'articulos'");
			}
			for (String ins : insStock) {
				stmt.executeUpdate(ins);
				System.out.println("[+] Campo 'stock'");
			}
		} catch (SQLException e) {
			System.out.println("Ya existen los registros. ");
		}
		System.out.println("");
	}

	// EL MÉTODO "insertarArticulosPedido" INSERTA DATOS EN LA TABLA "articulosPedido"
	private static void insertarArticulosPedido(Connection conn, String num_pedido, String codigo, Integer cantidad) {
		Statement stm;
		String insArticulosPedido = "INSERT INTO articulosPedido VALUES('" + num_pedido + "', '" + codigo + "', '" + cantidad + "');";
		
		try {
			stm = conn.createStatement();
			stm.executeUpdate(insArticulosPedido);
			System.out.println("[+] Campo 'articulosPedido'");

		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	// EL MÉTODO "insertarPedido" INSERTA DATOS EN LA TABLA "pedidos"
	private static void insertarPedido(Connection conn, String numero_cliente, String num_pedido, String fecha) {
		Statement stm;
		String insPedidos = "INSERT INTO pedidos VALUES('" + num_pedido + "', '" + numero_cliente + "', '" + fecha + "');";
		
		try {
			stm = conn.createStatement();
			stm.executeUpdate(insPedidos);
			System.out.println("[+] Campo 'pedidos'");
		}catch (SQLException e) {
			e.printStackTrace();
		}		
	}

	// EL MÉTODO "existeNumPedido" COMPRUEBA SI EXISTE "" CON UN "" CONCRETO
	private static boolean existeNumPedido(Connection conn, String num_pedido) throws SQLException {
		Statement stm = conn.createStatement();
		String comprobacion = "SELECT num_pedido FROM pedidos WHERE num_pedido = '" + num_pedido + "';";
		
		try (ResultSet rs = stm.executeQuery(comprobacion)) {
			return rs.next(); // Si hay algún resultado, significa que el número de pedido existe
		}
	}

	// EL MÉTODO "existeCliente" COMPRUEBA SI EXISTE UN CLIENTE CON UN "num_cliente" CONCRETO
	private static boolean existeCliente(Connection conn, String num_cliente) throws SQLException {
		Statement stm = conn.createStatement();
		String comprobacion = "SELECT num_cliente FROM clientes WHERE num_cliente = '" + num_cliente + "';";
		
		try (ResultSet rs = stm.executeQuery(comprobacion)) {
			return rs.next();
		}
	}

	// EL MÉTODO "existeProducto" COMPRUEBA SI EXISTE UN PRODUCTO CON UN "codigo" CONCRETO
	private static boolean existeProducto(Connection conn, String codigo) throws SQLException {
		Statement stm = conn.createStatement();
		String comprobacion = "SELECT codigo FROM articulos WHERE codigo = '" + codigo + "';";
		
		try (ResultSet rs = stm.executeQuery(comprobacion)) {
			return rs.next();
		}
	}

	// EL MÉTODO "existeSuficienteStock" COMPRUEBA SI EXISTE SUFICIENTE STOCK EN UN PRODUCTO CON UN "codigo" CONCRETO
	private static boolean existeSuficienteStock(Connection conn, String codigo, Integer cantidad) throws SQLException {
		Statement stm = conn.createStatement();
		String consultaStock = "SELECT stock FROM stock WHERE codigo = '" + codigo + "';";
		ResultSet rs = stm.executeQuery(consultaStock);
		int stock = 0;
		
		if (rs.next()) {
			stock = rs.getInt("stock");
		}
		if (stock > cantidad) {
			return true;
		} else
			return false;
	}

	// EL MÉTODO "crearTablas" CREA LAS TABLAS "pedidos", "articulosPedido", "clientes", "articulos" Y "stock"
	private static void crearTablas(String bd, Connection conn) {
		Statement stm;
		String ct_pedidos = "CREATE TABLE IF NOT EXISTS pedidos(num_pedido TEXT UNIQUE, num_cliente TEXT, fecha TEXT);";
		String ct_articulosPedido = "CREATE TABLE IF NOT EXISTS articulosPedido(num_pedido TEXT, codigo TEXT, cantidad INTEGER);";
		String ct_clientes = "CREATE TABLE IF NOT EXISTS clientes(num_cliente TEXT UNIQUE, nombre TEXT, direccion TEXT, telefono TEXT);";
		String ct_articulos = "CREATE TABLE IF NOT EXISTS articulos(codigo TEXT UNIQUE, descripcion TEXT, familiaProducto TEXT, fecha_alta TEXT);";
		String ct_stock = "CREATE TABLE IF NOT EXISTS stock(codigo TEXT UNIQUE, stock INTEGER);";

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

	// EL MÉTODO "borrarTablas" BORRA LAS TABLAS "pedidos", "articulosPedido", "clientes", "articulos" Y "stock"
	private static void borrarTablas(File f, Connection conn) {
		Statement stm;
		String borrarTablas = "DROP TABLE IF EXISTS pedidos; DROP TABLE IF EXISTS articulosPedido; DROP TABLE IF EXISTS clientes; DROP TABLE IF EXISTS articulos; DROP TABLE IF EXISTS stock\"";
		
		try {
			stm = conn.createStatement();
			stm.execute(borrarTablas);
			System.out.println("[-] Tabla 'pedidos'");
			System.out.println("[-] Tabla 'articulosPedido'");
			System.out.println("[-] Tabla 'clientes'");
			System.out.println("[-] Tabla 'articulos'");
			System.out.println("[-] Tabla 'stock'");
		} catch (SQLException e) {
			e.printStackTrace();
		}
		System.out.println(" ");
	}
}
