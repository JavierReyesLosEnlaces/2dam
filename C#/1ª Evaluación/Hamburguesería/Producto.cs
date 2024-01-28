public class Producto
{
    public float precio;
    public float precioBase;
    public float precioExtras = 0.0f;

    public Producto(){}
    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }
}
