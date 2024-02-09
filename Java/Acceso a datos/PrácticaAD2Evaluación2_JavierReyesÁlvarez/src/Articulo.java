
public class Articulo {
	private String codigo;
	private Integer cantidad;
	
	public Articulo(String codigo, Integer cantidad) {
		this.codigo = codigo;
		this.cantidad = cantidad;
	}

	public String getCodigo() {
		return codigo;
	}

	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}

	public Integer getCantidad() {
		return cantidad;
	}

	public void setCantidad(Integer cantidad) {
		this.cantidad = cantidad;
	}

	public String toString() {
		return "Articulo [codigo=" + codigo + ", cantidad=" + cantidad + "]";
	}
	
}
