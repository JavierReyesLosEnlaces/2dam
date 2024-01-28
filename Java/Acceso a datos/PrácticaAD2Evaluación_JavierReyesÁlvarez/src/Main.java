import java.sql.Statement;
import java.io.File;
import java.net.ConnectException;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.Iterator;
import java.util.Scanner;

import javax.naming.spi.DirStateFactory.Result;
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
		String bd = "jdbc:sqlite:bd\\sample.db";		
		Connection conn = ConexionBD(bd);
		
		int opcion; 
		do {
			System.out.println("0. Salir");
			System.out.println("1. Crear las tablas ");
			System.out.println("2. Leer XML y volcar los datos");
			
			opcion = teclado.nextInt();
			switch (opcion) {
			case 0:
				DesconexionBD(conn);	
				break;
			case 1:
				CrearTablas(bd, conn);
				break;
			case 2:
				LecturaXML(f);
			default:
				System.out.println("Opcion invalida");
				break;
			}
		} while (opcion != 0); 
			
		teclado.close();
	}

	private static void	LecturaXML(File f) {
	    try {
	        DocumentBuilderFactory dbf = DocumentBuilderFactory.newInstance();
	        DocumentBuilder db = dbf.newDocumentBuilder();
	        Document d = db.parse(f);
	        d.getDocumentElement().normalize();

	        NodeList pedidos = d.getElementsByTagName("pedido");

	        for (int i = 0; i < pedidos.getLength(); i++) {
	            Node nodoPedido = pedidos.item(i);
	            System.out.println("-> PEDIDO " + (i + 1));

	            if (nodoPedido.getNodeType() == Node.ELEMENT_NODE) {
	                Element pedido = (Element) nodoPedido;
	                
	                String numero_cliente = pedido.getElementsByTagName("numero-cliente").item(0).getTextContent();
	                String numero_pedido = pedido.getElementsByTagName("numero-pedido").item(0).getTextContent();
	                String fecha = pedido.getElementsByTagName("fecha").item(0).getTextContent();
	                
	                System.out.println("numero cliente: "+numero_cliente);
	                System.out.println("numero pedido: "+numero_pedido);
	                System.out.println("fecha"+fecha);
	                
	                
	                //Inserción
	                String insPedidos = "INSERT INTO pedidos"
	                		+ "VALUES("+numero_pedido+" TEXT,"+numero_cliente+" TEXT,"+fecha+" TEXT"
	                
	                NodeList articulos = pedido.getElementsByTagName("articulo");
	                for (int j = 0; j < articulos.getLength(); j++) {
	                    Node nodoArticulo = articulos.item(j);
	                    if (nodoArticulo.getNodeType() == Node.ELEMENT_NODE) {
	                        Element articulo = (Element) nodoArticulo;
	                        
	                        String codigo = articulo.getElementsByTagName("codigo").item(0).getTextContent();
	                        String cantidad = articulo.getElementsByTagName("cantidad").item(0).getTextContent();
	                        
	                        System.out.println("  Código: " + codigo);
	                        System.out.println("  Cantidad: " + cantidad);
	                    }
	                }
	            }
	            System.out.println(""); // Print an empty line after each order
	        }

	    } catch (Exception e) {
	        e.printStackTrace();
	    }
	    
	}


	private static void DesconexionBD(Connection conn) {
		try {
			conn.close();
		}catch (Exception e) {
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
		String ct_pedidos = "CREATE TABLE [IF NOT EXISTS] pedidos(num-cliente TEXT, num-pedido TEXT, fecha TEXT);";
		String ct_articulosPedido = "CREATE TABLE [IF NOT EXISTS] articulosPedido(num-pedido INTEGER, codigo TEXT, cantidad INTEGER;";
		Statement stm;
		try{
			stm = conn.createStatement();		
			ResultSet rsPedidos = stm.executeQuery(ct_pedidos);
			System.out.println("Se ha creado la tabla de pedidos. ");
			ResultSet rsArtPedidos = stm.executeQuery(ct_articulosPedido);
			System.out.println("Se ha creado la tabla de articulosPedido");
			
		}catch (Exception e) {
			e.printStackTrace();
		}
	}	
}
