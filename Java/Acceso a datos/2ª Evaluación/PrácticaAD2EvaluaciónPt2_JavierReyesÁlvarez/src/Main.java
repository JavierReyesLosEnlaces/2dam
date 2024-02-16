import java.util.ArrayList;
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

public class Main {

	public static void main(String[] args) {
		Scanner teclado = new Scanner(System.in);
		String path = "C:\\Users\\Alumno\\Desktop\\workspaces\\workspaceAccesoADatos\\PrácticaAD2EvaluaciónPt2_JavierReyesÁlvarez\\BDs\\bdDePedidos.db";
		
		// PASO 1: COGER LOS DATOS DE SQLITE Y CONVERTIRLAS EN OBJETOS
		ArrayList<LineaPedido> listaLineasPedido = new ArrayList<>();
		// El resultado del select lo meto dentro del resultset y lo recorro while rs.hasNext
		crearObjetosPedido(path);
		crearObjetosLineaPedido(path);

	}

	private static void crearObjetosLineaPedido(String path) {
		//String count
		String query = "SELECT * FROM articulosPedido";
		
	}

	private static void crearObjetosPedido(String path) {
		// TODO Auto-generated method stub
		
	}

}
