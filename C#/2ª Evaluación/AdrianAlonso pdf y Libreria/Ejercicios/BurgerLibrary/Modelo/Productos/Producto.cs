namespace BurgerLibrary.Modelo.Productos
{
    public class Producto
    {
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public int Calorias { get; set; }

        // Constructor sin parámetros
        public Producto()
        {
        }

        // Constructor con parámetros
        public Producto(string nombre, float precio, int calorias)
        {
            Nombre = nombre;
            Precio = precio;
            Calorias = calorias;
        }
    }
}
