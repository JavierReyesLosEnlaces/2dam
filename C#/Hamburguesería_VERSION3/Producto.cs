public class Producto
{

    private string nombreProducto;
    public float precio;
    public float precioBase;
    public float precioExtras = 0.0f;

    public Producto(string nombreProducto)
    {
        this.nombreProducto = nombreProducto;
    }
    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public string NombreProducto
    {
        get { return nombreProducto; }
        set { nombreProducto = value; }
    }
}
