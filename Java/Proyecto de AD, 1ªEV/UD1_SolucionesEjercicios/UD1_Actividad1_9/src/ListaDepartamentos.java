/* Define una lista de objetos de la clase Departamentos */

import java.util.ArrayList;
import java.util.List;

public class ListaDepartamentos {
	
    private List<Departamento> lista = new ArrayList<Departamento>();
    
    public ListaDepartamentos(){    	
    }

    public void add(Departamento dpto) {
            lista.add(dpto);
    }
   
    public List<Departamento> getListaDepartamentos() {
            return lista;
    }
}
