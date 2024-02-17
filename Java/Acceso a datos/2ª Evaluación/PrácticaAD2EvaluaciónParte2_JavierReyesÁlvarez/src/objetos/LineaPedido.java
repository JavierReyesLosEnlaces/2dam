package objetos;

public class LineaPedido { // articulosPedido
	private String num_pedido, codigo; 
	private int cantidad;

	public LineaPedido() {

	}

	public LineaPedido(String num_pedido, String codigo, int cantidad) {
		this.num_pedido = num_pedido;
		this.codigo = codigo;
		this.cantidad = cantidad;
	}

	public String getNum_pedido() {
		return num_pedido;
	}

	public void setNum_pedido(String num_pedido) {
		this.num_pedido = num_pedido;
	}

	public String getCodigo() {
		return codigo;
	}

	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}

	public int getCantidad() {
		return cantidad;
	}

	public void setCantidad(int cantidad) {
		this.cantidad = cantidad;
	}
}
