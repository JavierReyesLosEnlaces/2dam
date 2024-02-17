package objetos;

public class Pedido {
	private String num_pedido, num_cliente, fecha;
	
	public Pedido() {
		
	}
	
	public Pedido(String num_pedido, String num_cliente, String fecha) {
		this.num_pedido = num_pedido;
		this.num_cliente = num_cliente;
		this.fecha = fecha;
	}

	public String getNum_pedido() {
		return num_pedido;
	}

	public void setNum_pedido(String num_pedido) {
		this.num_pedido = num_pedido;
	}

	public String getNum_cliente() {
		return num_cliente;
	}

	public void setNum_cliente(String num_cliente) {
		this.num_cliente = num_cliente;
	}

	public String getFecha() {
		return fecha;
	}

	public void setFecha(String fecha) {
		this.fecha = fecha;
	}
}
