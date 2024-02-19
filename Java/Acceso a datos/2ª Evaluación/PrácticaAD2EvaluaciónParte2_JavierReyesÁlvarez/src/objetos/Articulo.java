package objetos;

public class Articulo {
	private String codigo, descripcion, familiaProducto, fecha_alta;

	public Articulo() {

	}

	public Articulo(String codigo, String descripcion, String familiaProducto, String fecha_alta) {
		this.codigo = codigo;
		this.descripcion = descripcion;
		this.familiaProducto = familiaProducto;
		this.fecha_alta = fecha_alta;
	}

	public String getCodigo() {
		return codigo;
	}

	public void setCodigo(String codigo) {
		this.codigo = codigo;
	}

	public String getDescripcion() {
		return descripcion;
	}

	public void setDescripcion(String descripcion) {
		this.descripcion = descripcion;
	}

	public String getFamiliaProducto() {
		return familiaProducto;
	}

	public void setFamiliaProducto(String familiaProducto) {
		this.familiaProducto = familiaProducto;
	}

	public String getFecha_alta() {
		return fecha_alta;
	}

	public void setFecha_alta(String fecha_alta) {
		this.fecha_alta = fecha_alta;
	}

	public String toString() {
		return "Articulo [codigo=" + codigo + ", descripcion=" + descripcion + ", familiaProducto=" + familiaProducto
				+ ", fecha_alta=" + fecha_alta + "]";
	}

}
