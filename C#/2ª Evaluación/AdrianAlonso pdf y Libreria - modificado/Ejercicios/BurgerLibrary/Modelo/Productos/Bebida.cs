namespace BurgerLibrary.Modelo.Productos
{
    public class Bebida : Producto
    {   
        //Bebida esta pensado para cualquier refresco, o producto liquido
        private int cantidad;   //Cantidad de mililitros del producto

        /// <summary>
        /// Constructor base más la cantidad de bebida
        /// </summary>
        /// <param name="cantidad">Volumen de bebida (en mililitros)</param>
        public Bebida(string nombre, float precio, int calorias, int cantidad) : base(nombre, precio, calorias)
        {
            this.cantidad = cantidad;
        }

        /// <summary>
        /// Devuelve la descripción del objeto bebida en una variable string
        /// </summary>
        /// <returns>Devuelve un string que compone la descripcion del objeto</returns>
        public override string ToString()
        {
            string texto = "";
            texto += "Bebida \"";
            texto += this.Nombre;
            texto += "\":\n";
            texto += "\tEs una bebida de " + this.Cantidad + " ml ";
            texto += "al módico precio de " + this.Precio + " euros.\n";
            texto += "\tValor nutricional: " + this.Calorias + " kcal\n";
            return texto;
        }
        
        /// <summary>
        /// Getter y Setter de la cantidad
        /// </summary>
        public int Cantidad { get => cantidad; set => cantidad = value; }

    }
}
