using System.Collections.Generic;

namespace BurgerLibrary.Modelo.Productos
{
    public class Complemento : Producto
    {
        //Clase pensada para complementos, no postres.
        //Difiero el caso por la posibilidad de añadir y quitar ingredientes

        //Propiedades
        private List<string> ingredientes;  //Listado de ingredientes del complemento
        private int unidades;               //Cantidad de unidades en la racion. (Ejemplo: 6 croquetas)

        /// <summary>
        /// El constructor base de Producto más la lista de ingredientes del complemento 
        /// y la cantidad de unidades que lo componen
        /// </summary>
        /// <param name="ingredientes">Lista de ingredientes que componen el objeto</param>
        /// <param name="unidades">Cantidad total que componen el objeto</param>
        public Complemento( string nombre, float precio, int calorias,List<string>ingredientes, int unidades) : base(nombre, precio, calorias)
        {   
            this.ingredientes = ingredientes;
            this.unidades = unidades;
        }
        
        /// <summary>
        /// Devuelve un string que es la descripcion de nuestro objeto
        /// </summary>
        /// <returns>String que es la descripcion del objeto</returns>
        public override string ToString()
        {
            string texto = "";
            texto += "Complemento \"";
            texto += Nombre;
            texto += "\":\n";
            texto += "\tCompuesto por:\n";
            foreach (string nombre in this.ingredientes)
            {
                texto += "\t\t" + nombre + "\n";
            }
            texto += "La racion es de " + Unidades + " uds, ";
            texto += "al módico precio de " + Precio + " euros.\n";
            texto += "Valor nutricional: " + Calorias + " kcal.\n";
            return texto;
        }

        /// <summary>
        /// Devuelve la lista de ingredientes del complemento
        /// </summary>
        /// <returns>Lista de strings ingredientes</returns>
        public List<string> getIngredientes() 
        { 
            return ingredientes; 
        }

        /// <summary>
        /// Elimina un ingrendiente de la lista Ingredientes
        /// </summary>
        /// <param name="index">Posición del ingrediente a eliminar dentro de la lista</param>
        public void delIngrediente (int index)
        {
            ingredientes.RemoveAt(index);
        }
        
        /// <summary>
        /// Getter y Setter de la propiedad unidades
        /// </summary>
        public int Unidades { get => unidades; set => unidades = value; }

    }
}
