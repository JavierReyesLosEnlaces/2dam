using System.Collections.Generic;

namespace BurgerLibrary.Modelo.Productos
{
    public class Comida : Producto
    {   
        //La clase comida esta pensada para hamburguesas.
        
        //Propiedades
        private List<string> ingredientes;  
        private string tipo;                
        private int peso;                   

        /// <summary>
        /// Constructor base mas, la lista de ingredientes que componen el producto
        /// tipo de hamburguesa (vegana, vegetariana, carnivora...) y
        /// el peso del filete o producto principal que compone la hamburguesa
        /// </summary>
        /// <param name="ingredientes">Lista de ingredientes básicos que componen el objeto</param>
        /// <param name="tipo">Tipo de comida (Carnívora, vegetariana o vegana)</param>
        /// <param name="peso">Peso del ingrediente principal de la hamburguesa</param>
        public Comida(string nombre, float precio,int calorias,List<string> ingredientes, string tipo, int peso) : base(nombre, precio, calorias)
        {   
            this.ingredientes=ingredientes;
            this.tipo = tipo;
            this.peso = peso;
        }

        /// <summary>
        /// Devuelve un string que es la descripcion del objeto
        /// </summary>
        /// <returns>String que compone la descripcion del objeto</returns>
        public override string ToString()
        {
            string texto = "";
            texto += "La ";
            texto += Nombre;
            texto += " es una hamburguesa ";
            texto += tipo;
            texto += " y esta compuesta por:\n";
            foreach (string nombre in this.ingredientes)
            {
                if (nombre.Contains("Carne"))
                {
                    texto += "\t" + nombre + " con un peso de " + Peso + " gramos.\n";
                }
                else
                {
                    texto += "\t" + nombre + "\n";
                }
            }
            texto += "Al módico precio de " + Precio+ " euros\n";
            texto += "Tiene un valor nutricional de " + Calorias + " kcal\n";
            return texto;
        }
        
        /// <summary>
        /// Devuelve el listado de ingredientes del objeto
        /// </summary>
        /// <returns>Listado de strings que representan los ingredientes</returns>
        public List<string> getIngredientes()
        {
            return ingredientes;
        }   
        
        /// <summary>
        /// Elimina un ingrediente, a raíz de su index/posicion en la lista
        /// </summary>
        /// <param name="index">Posicion del ingrediente a eliminar dentro de la lista</param>
        public void delIngrediente(int index)
        {
            ingredientes.RemoveAt(index);   
        }

        /// <summary>
        /// Getter y Setter del tipo de comida
        /// </summary>
        public string Tipo { get => tipo; set => tipo = value; }

        /// <summary>
        /// Getter y Setter del peso
        /// </summary>
        public int Peso { get => peso; set => peso = value; }



    }
}
