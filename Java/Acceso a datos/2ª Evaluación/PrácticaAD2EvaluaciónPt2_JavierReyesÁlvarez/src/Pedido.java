
public class Pedido {
	private int num_pedido, num_cliente;
	private String fecha;
	
	public Pedido() {
		
	}
	
	public Pedido(int num_pedido, int num_cliente, String fecha) {
		this.num_pedido = num_pedido;
		this.num_cliente = num_cliente;
		this.fecha = fecha;
	}

	public int getNum_pedido() {
		return num_pedido;
	}

	public void setNum_pedido(int num_pedido) {
		this.num_pedido = num_pedido;
	}

	public int getNum_cliente() {
		return num_cliente;
	}

	public void setNum_cliente(int num_cliente) {
		this.num_cliente = num_cliente;
	}

	public String getFecha() {
		return fecha;
	}

	public void setFecha(String fecha) {
		this.fecha = fecha;
	}	
}
