namespace BurgerLibrary.Modelo.Productos
{

    public abstract class Producto
    {
        //Propiedades
        
        private string nombre;  
        private float precio;   
        private int calorias;   

        /// <summary>
        /// Constructor del Producto
        /// </summary>
        /// <param name="nombre">Nombre del objeto</param>
        /// <param name="precio">Precio del objeto</param>
        /// <param name="calorias">Calorias del objeto</param>
        public Producto(string nombre, float precio, int calorias)

        {
            this.precio = precio;
            this.nombre = nombre;
            this.calorias = calorias;
        }

        //Comportamientos
        /// <summary>
        /// Getter y Setter del nombre del objeto
        /// </summary>
        public string Nombre { get => nombre; set => nombre = value; }
        /// <summary>
        /// Getter y Setter del precio del objeto
        /// </summary>
        public float Precio { get => precio; set => precio = value; }
        /// <summary>
        /// Getter y Setter de las calorias del objeto
        /// </summary>
        public int Calorias { get => calorias; set => calorias = value; }
    }
}
