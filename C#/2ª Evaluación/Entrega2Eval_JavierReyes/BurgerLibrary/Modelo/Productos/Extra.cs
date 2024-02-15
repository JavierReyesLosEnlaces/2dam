namespace BurgerLibrary.Modelo.Productos
{
    public class Extra : Producto
    {
        //Propiedades

        //Unidades añadidas por cada extra (Ejemplo: Bacon, 1 unidad, añade una tira de bacon)
        private int unidades;

        /// <summary>
        /// Constructor base más las unidades
        /// </summary>
        /// <param name="unidades">Cantidad que conforman el conjunto del objeto.</param>
        public Extra(string nombre, float precio, int calorias, int unidades) : base(nombre, precio, calorias)
        {
            this.unidades = unidades;
        }
        
        /// <summary>
        /// Devuelve un string que es la descripcion del objeto
        /// </summary>
        /// <returns>String que es la descripcion del objeto</returns>
        public override string ToString()
        {
            string texto = "";
            texto += this.Nombre + "\t\t" + this.Precio + " euros\t\t"+this.Unidades+" uds.";
            return texto;
        }

        /// <summary>
        /// Getter y Setter de las unidades
        /// </summary>
        public int Unidades { get => unidades; set => unidades = value; }
    }
}
