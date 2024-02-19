package objetos;

public class Cliente {
	private String num_cliente, nombre, direccion, telefono;

	public Cliente() {

	}

	public Cliente(String num_cliente, String nombre, String direccion, String telefono) {
		this.num_cliente = num_cliente;
		this.nombre = nombre;
		this.direccion = direccion;
		this.telefono = telefono;
	}

	public String getNum_cliente() {
		return num_cliente;
	}

	public void setNum_cliente(String num_cliente) {
		this.num_cliente = num_cliente;
	}

	public String getNombre() {
		return nombre;
	}

	public void setNombre(String nombre) {
		this.nombre = nombre;
	}

	public String getDireccion() {
		return direccion;
	}

	public void setDireccion(String direccion) {
		this.direccion = direccion;
	}

	public String getTelefono() {
		return telefono;
	}

	public void setTelefono(String telefono) {
		this.telefono = telefono;
	}

	public String toString() {
		return "Cliente [num_cliente=" + num_cliente + ", nombre=" + nombre + ", direccion=" + direccion + ", telefono="
				+ telefono + "]";
	}
}
