
public class LineaPedido { // articulosPedido
	private int num_pedido, codigo, cantidad;

	public LineaPedido() {

	}

	public LineaPedido(int num_pedido, int codigo, int cantidad) {
		this.num_pedido = num_pedido;
		this.codigo = codigo;
		this.cantidad = cantidad;
	}

	public int getNum_pedido() {
		return num_pedido;
	}

	public void setNum_pedido(int num_pedido) {
		this.num_pedido = num_pedido;
	}

	public int getCodigo() {
		return codigo;
	}

	public void setCodigo(int codigo) {
		this.codigo = codigo;
	}

	public int getCantidad() {
		return cantidad;
	}

	public void setCantidad(int cantidad) {
		this.cantidad = cantidad;
	}
}
