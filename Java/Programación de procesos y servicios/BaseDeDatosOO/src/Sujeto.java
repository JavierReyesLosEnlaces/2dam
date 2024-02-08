import org.neodatis.odb.*;

public class Sujeto {

	private String nombre, ciudad;
	int edad;
	
	public Sujeto(String nombre, int edad, String ciudad) {
		this.nombre = nombre; 
		this.edad = edad;
		this.ciudad = ciudad;
	}

	public int getEdad() {
		return edad;
	}

	public String getName() {
		return nombre;
	}
	public String getCiudad() {
		return ciudad;
	}

	public void setCiudad(String string) {
		this.ciudad = string;
		
	}
	
}
