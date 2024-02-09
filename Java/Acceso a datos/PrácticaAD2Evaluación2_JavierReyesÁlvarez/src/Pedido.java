import java.util.List;

public class Pedido {
	private String numeroCliente, numeroPedido, fecha;
	private List<Articulo>articulos;
	
	public Pedido(String numeroCliente, String numeroPedido, String fecha, List<Articulo>articulos) {
		this.numeroCliente = numeroCliente;
		this.numeroPedido = numeroPedido;
		this.articulos = articulos;
		this.fecha = fecha;
	}

	public String getNumeroCliente() {
		return numeroCliente;
	}

	public void setNumeroCliente(String numeroCliente) {
		this.numeroCliente = numeroCliente;
	}

	public String getNumeroPedido() {
		return numeroPedido;
	}

	public void setNumeroPedido(String numeroPedido) {
		this.numeroPedido = numeroPedido;
	}

	public String getFecha() {
		return fecha;
	}

	public void setFecha(String fecha) {
		this.fecha = fecha;
	}

	public List<Articulo> getArticulos() {
		return articulos;
	}

	public void setArticulos(List<Articulo> articulos) {
		this.articulos = articulos;
	}

	@Override
	public String toString() {
		return "Pedido [numeroCliente=" + numeroCliente + ", numeroPedido=" + numeroPedido + ", fecha=" + fecha
				+ ", articulos=" + articulos + "]";
	}
	
	
}
