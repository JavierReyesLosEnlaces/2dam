import java.sql.Statement;
import java.math.BigInteger;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.Scanner;

import org.neodatis.odb.ODB;
import org.neodatis.odb.ODBFactory;
import org.neodatis.odb.ObjectValues;
import org.neodatis.odb.Objects;
import org.neodatis.odb.Values;
import org.neodatis.odb.core.query.IValuesQuery;
import org.neodatis.odb.core.query.criteria.Where;
import org.neodatis.odb.impl.core.query.values.ValuesCriteriaQuery;

import objetos.Articulo;
import objetos.Cliente;
import objetos.LineaPedido;
import objetos.Pedido;

public class Main {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		int opcion;
		ArrayList<LineaPedido> listaLineasPedido = new ArrayList<>();
		ArrayList<Pedido> listaPedidos = new ArrayList<>();
		ArrayList<Articulo> listaArticulos = new ArrayList<>();
		ArrayList<Cliente> listaClientes = new ArrayList<>();

		// BASES DE DATOS
		String bdPath = "jdbc:sqlite:BDs\\bdDePedidos.db";
		String odbPath = "BDs\\bdDePedidos.odb";
		Connection conn = conexionBD(bdPath);

		// MENÚ
		do {
			System.out.println("0. Salir");
			System.out.println("1. Pasar los datos de SQLite a Neodatis y mostrarlos");
			System.out.println("2. Numero de pedidos recibidos y procesados correctamente");
			System.out.println("3. Numero de lineas de pedido recibidas");
			System.out.println("4. Listado de articulos diferentes recibidos (incluir en cuantos pedidos cada articulo)");
			System.out.println("5. Listado de clientes que han enviado pedidos. (incluir el numero de pedidos)");
			System.out.println("6. Listado de articulos con las cantidades sumadas de todos los pedidos");
			System.out.println("7. Listado de unidades pedidas por pedido (independientemente del codigo)");
			System.out.println("8. Media de articulos por pedido recibidos");
			System.out.println("9. *Mostrar datos*");

			opcion = teclado.nextInt();
			switch (opcion) {
			case 0:
				System.out.println("Has abandonado el programa. ");
				break;
			case 1:
				crearObjetosPedido(conn, listaPedidos);
				crearObjetosLineaPedido(conn, listaLineasPedido);
				crearObjetosArticulo(conn, listaArticulos);
				crearObjetosCliente(conn, listaClientes);

				insertarObjetos(listaLineasPedido, listaPedidos, listaArticulos, listaClientes, odbPath);
				break;
			case 2:
				opcion2(odbPath);
				break;
			case 3:
				opcion3(odbPath);
				break;
			case 4:
				opcion4(odbPath);
				break;
			case 5:
				opcion5(odbPath);
				break;
			case 6:
				opcion6(odbPath);
				break;
			case 7:
				opcion7(odbPath);
				break;
			case 8:
				opcion8(odbPath);
				break;
			case 9:
				mostrarObjetos(listaLineasPedido, listaPedidos, listaArticulos, listaClientes);
				break;
			default:
				System.out.println("Opcion invalida\n");
				break;
			}

		} while (opcion != 0);

		teclado.close();
	}

	/*
	 * private static void opcion8(String path) { //
	 * System.out.println("8. Media de artículos por pedido recibidos"); ODB odb =
	 * ODBFactory.open(path); IValuesQuery valuesQuery = new
	 * ValuesCriteriaQuery(LineaPedido.class).avg("cantidad"); Values values =
	 * odb.getValues(valuesQuery);
	 * 
	 * double media = 0.00;
	 * 
	 * while (values.hasNext()) { ObjectValues objectValues = values.next(); media =
	 * (Double) objectValues.getByAlias("cantidad"); }
	 * System.out.println("Media de articulos por pedido recibidos: "+media);
	 * System.out.print("\n"); odb.close(); }
	 */

// APARTADOS DEL EJERCICIO

	private static void opcion2(String path) {
		ODB odb = ODBFactory.open(path);
		IValuesQuery valueQuery = new ValuesCriteriaQuery(Pedido.class).count("num_pedido");
		Values values = odb.getValues(valueQuery);
		ObjectValues objectValues = values.nextValues();
		BigInteger count = (BigInteger) objectValues.getByAlias("num_pedido");
		System.out.println("Numero de pedidos recibidos y procesados correctamente: " + count.intValue() + "\n");
		odb.close();
	}

	private static void opcion3(String path) {
		ODB odb = ODBFactory.open(path);
		IValuesQuery valueQuery = new ValuesCriteriaQuery(LineaPedido.class).count("num_pedido");
		Values values = odb.getValues(valueQuery);
		ObjectValues objectValues = values.nextValues();
		BigInteger count = (BigInteger) objectValues.getByAlias("num_pedido");
		System.out.println("Numero de lineas de pedido recibidas: " + count.intValue() + "\n");
		odb.close();
	}

	private static void opcion4(String path) {
		ODB odb = ODBFactory.open(path);
		Objects<Articulo> objects = odb.getObjects(Articulo.class);
		int contador = 1;

		while (objects.hasNext()) {
			Articulo articuloActual = objects.next();
			String codigo = articuloActual.getCodigo();
			int numPedidosPorArticulo = comprobarNumPedidosPorArticulo(codigo, odb);
			System.out.println("Articulo " + contador + " -> Codigo de producto: " + codigo + ", Se encuentra en "
					+ numPedidosPorArticulo + " pedido(s)");
			contador += 1;
		}
		System.out.print("\n");
		odb.close();
	}

	private static void opcion5(String path) {
		ODB odb = ODBFactory.open(path);
		IValuesQuery valueQuery = new ValuesCriteriaQuery(Pedido.class).field("num_cliente");
		Values values = odb.getValues(valueQuery);
		int contador = 1;

		while (values.hasNext()) {
			ObjectValues objectValues = (ObjectValues) values.next();
			String num_cliente = objectValues.getByAlias("num_cliente").toString();
			ArrayList<String> numPedidosAsociados = comprobarNumPedidosPorCliente(num_cliente, odb);
			System.out.println("Cliente " + contador + " -> num_cliente: " + num_cliente
					+ ", Se ha enviado productos al cliente en el pedido con num_pedido: "
					+ numPedidosAsociados.toString());
			contador++;
		}
		System.out.print("\n");
		odb.close();
	}

	private static void opcion6(String path) {
		ODB odb = ODBFactory.open(path);
		IValuesQuery valuesQuery = new ValuesCriteriaQuery(Articulo.class).field("codigo");
		Values values = odb.getValues(valuesQuery);

		while (values.hasNext()) {
			ObjectValues objectValues = (ObjectValues) values.next();
			String codigo = objectValues.getByAlias("codigo").toString();
			int cantidadTotalArticulo = comprobarCantidadTotalArticulo(codigo, odb);
			System.out.println("Articulo con codigo de producto: " + codigo + "\n\t--> Cantidad total: "
					+ cantidadTotalArticulo + "\n");
		}
		odb.close();
	}

	private static void opcion7(String path) {
		ODB odb = ODBFactory.open(path);
		IValuesQuery valuesQuery = new ValuesCriteriaQuery(LineaPedido.class).field("num_pedido").groupBy("num_pedido");
		Values values = odb.getValues(valuesQuery);

		while (values.hasNext()) {
			ObjectValues objectValues = values.next();
			String num_pedido = objectValues.getByAlias("num_pedido").toString();
			int unidadesPorPedido = comprobarUnidadesPorPedido(num_pedido, odb);
			System.out
					.println("Numero de pedido: " + num_pedido + ", Unidades pedidas por pedido: " + unidadesPorPedido);
		}
		System.out.print("\n");
		odb.close();
	}

	private static void opcion8(String path) {
		ODB odb = ODBFactory.open(path);
		double media;

		// SE CUENTAN LOS CÓDIGOS DE PRODUCTO POR NÚMERO DE PEDIDO
		IValuesQuery valuesQuery1 = new ValuesCriteriaQuery(LineaPedido.class).count("codigo").groupBy("num_pedido");
		double contadorCodigos = 0;
		Values values1 = odb.getValues(valuesQuery1);

		while (values1.hasNext()) {
			ObjectValues objectValues1 = values1.next();
			int numCodigosEnPedido = Integer.parseInt(objectValues1.getByAlias("codigo").toString());
			contadorCodigos += numCodigosEnPedido;
		}
		// System.out.println("Suma numero productos en cada pedido: " +
		// contadorCodigos);

		// SE CUENTAN EL NÚMERO DE PEDIDOS
		IValuesQuery valuesQuery2 = new ValuesCriteriaQuery(Pedido.class).count("num_pedido");
		Values values2 = odb.getValues(valuesQuery2);
		int contadorPedidos = 0;

		while (values2.hasNext()) {
			ObjectValues objectValues2 = values2.next();
			contadorPedidos = Integer.parseInt(objectValues2.getByAlias("num_pedido").toString());
		}
		// System.out.println("Num total pedidos: " + contadorPedidos);

		media = contadorCodigos / contadorPedidos;
		System.out.println("Media de articulos por pedido recibidos: " + media);
		System.out.print("\n");
		odb.close();

	}

// COMPROBACIONES DE DATOS EN UN CAMPO CONCRETO

	private static int comprobarCantidadTotalArticulo(String codigo, ODB odb) {
		IValuesQuery valuesQuery = new ValuesCriteriaQuery(LineaPedido.class, Where.equal("codigo", codigo))
				.field("cantidad");
		Values values = odb.getValues(valuesQuery);
		int cantidadTotal = 0;

		while (values.hasNext()) {
			ObjectValues objectValues = (ObjectValues) values.next();
			int cantidad = Integer.parseInt(objectValues.getByAlias("cantidad").toString());
			cantidadTotal += cantidad;
		}
		return cantidadTotal;
	}

	private static int comprobarUnidadesPorPedido(String num_pedido, ODB odb) {
		IValuesQuery valuesQuery = new ValuesCriteriaQuery(LineaPedido.class, Where.equal("num_pedido", num_pedido))
				.field("cantidad");
		Values values = odb.getValues(valuesQuery);
		Integer unidades = 0;

		while (values.hasNext()) {
			ObjectValues objectValues = (ObjectValues) values.next();
			Integer cantidad = Integer.parseInt(objectValues.getByAlias("cantidad").toString());
			unidades += cantidad;
		}
		return unidades;
	}

	private static int comprobarNumPedidosPorArticulo(String codigo, ODB odb) {
		IValuesQuery valuesQuery = new ValuesCriteriaQuery(LineaPedido.class, Where.equal("codigo", codigo))
				.count("codigo").groupBy("num_pedido");
		Values values = odb.getValues(valuesQuery);
		int contador = 0;

		while (values.hasNext()) {
			values.next();
			contador++;
		}
		return contador;
	}

	private static ArrayList<String> comprobarNumPedidosPorCliente(String num_cliente, ODB odb) {
		ArrayList<String> numPedidosAsociados = new ArrayList<>();
		IValuesQuery valuesQuery = new ValuesCriteriaQuery(Pedido.class, Where.equal("num_cliente", num_cliente))
				.field("num_pedido");
		Values values = odb.getValues(valuesQuery);

		while (values.hasNext()) {
			ObjectValues objectValues = (ObjectValues) values.next();
			String num_pedido = objectValues.getByAlias("num_pedido").toString();
			numPedidosAsociados.add(num_pedido);
		}
		return numPedidosAsociados;
	}

// CREACIÓN DE OBJETOS 

	private static void crearObjetosLineaPedido(Connection conn, ArrayList<LineaPedido> listaLineasPedido) {
		String query = "SELECT * FROM articulosPedido;";
		Statement stm;
		ResultSet rs;

		try {
			stm = conn.createStatement();
			rs = stm.executeQuery(query);
			while (rs.next()) {
				String num_pedido = rs.getString(1);
				String codigo = rs.getString(2);
				int cantidad = rs.getInt(3);
				listaLineasPedido.add(new LineaPedido(num_pedido, codigo, cantidad));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	private static void crearObjetosPedido(Connection conn, ArrayList<Pedido> listaPedidos) {
		String query = "SELECT * FROM pedidos;";
		Statement stm;
		ResultSet rs;

		try {
			stm = conn.createStatement();
			rs = stm.executeQuery(query);
			while (rs.next()) {
				String num_pedido = rs.getString(1);
				String num_cliente = rs.getString(2);
				String fecha = rs.getString(3);
				listaPedidos.add(new Pedido(num_pedido, num_cliente, fecha));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	private static void crearObjetosCliente(Connection conn, ArrayList<Cliente> listaClientes) {
		String query = "SELECT * FROM clientes;";
		Statement stm;
		ResultSet rs;

		try {
			stm = conn.createStatement();
			rs = stm.executeQuery(query);
			while (rs.next()) {
				String num_cliente = rs.getString(1);
				String nombre = rs.getString(2);
				String direccion = rs.getString(3);
				String telefono = rs.getString(4);

				listaClientes.add(new Cliente(num_cliente, nombre, direccion, telefono));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

	private static void crearObjetosArticulo(Connection conn, ArrayList<Articulo> listaArticulos) {
		String query = "SELECT * FROM articulos;";
		Statement stm;
		ResultSet rs;

		try {
			stm = conn.createStatement();
			rs = stm.executeQuery(query);
			while (rs.next()) {
				String codigo = rs.getString(1);
				String descripcion = rs.getString(2);
				String familiaProducto = rs.getString(3);
				String fecha_alta = rs.getString(4);

				listaArticulos.add(new Articulo(codigo, descripcion, familiaProducto, fecha_alta));
			}
		} catch (SQLException e) {
			e.printStackTrace();
		}
	}

// INSERCIÓN DE OBJETOS

	private static void insertarObjetos(ArrayList<LineaPedido> listaLineasPedido, ArrayList<Pedido> listaPedidos,
			ArrayList<Articulo> listaArticulos, ArrayList<Cliente> listaClientes, String bd) {
		ODB odb = ODBFactory.open(bd);

		for (LineaPedido lineaPedido : listaLineasPedido) {
			odb.store(lineaPedido);
		}
		System.out.println("[+] Lineas de pedido pasadas a la OBD.");

		for (Pedido pedido : listaPedidos) {
			odb.store(pedido);
		}
		System.out.println("[+] Pedidos pasados a la OBD.");

		for (Articulo articulo : listaArticulos) {
			odb.store(articulo);
		}
		System.out.println("[+] Articulos pasados a la OBD.");

		for (Cliente cliente : listaClientes) {
			odb.store(cliente);
		}
		System.out.println("[+] Clientes pasados a la OBD.\n");

		odb.close();
	}

// MOSTRAR OBJETOS

	private static void mostrarObjetos(ArrayList<LineaPedido> listaLineasPedido, ArrayList<Pedido> listaPedidos,
			ArrayList<Articulo> listaArticulos, ArrayList<Cliente> listaClientes) {

		for (int i = 0; i < listaLineasPedido.size(); i++) {
			System.out.println(listaLineasPedido.get(i).toString());
		}

		for (int i = 0; i < listaPedidos.size(); i++) {
			System.out.println(listaPedidos.get(i).toString());
		}

		for (int i = 0; i < listaArticulos.size(); i++) {
			System.out.println(listaArticulos.get(i).toString());
		}

		for (int i = 0; i < listaClientes.size(); i++) {
			System.out.println(listaClientes.get(i).toString());
		}
	}

// CONEXIÓN A LA BASE DE DATOS SQLITE

	private static Connection conexionBD(String path) {
		Connection conn = null;
		try {
			Class.forName("org.sqlite.JDBC");
			conn = DriverManager.getConnection(path);
		} catch (SQLException e) {
			e.printStackTrace();
		} catch (ClassNotFoundException e) {
			e.printStackTrace();
		}
		System.out.println("Te has conectado a la base de datos.");
		System.out.println("");
		return conn;
	}
}