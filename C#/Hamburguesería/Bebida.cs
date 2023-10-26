public class Bebida : Producto
{
    private bool conAlcohol;
    private readonly float precioBase = 3.0f;
    private float precioExtras = 0.0f;

    public Bebida(bool conAlcohol)
    {
        this.conAlcohol = conAlcohol;

        if (conAlcohol) precioExtras += 0.5f;

        precio = precioBase + precioExtras;
    }

    public bool ConAlcohol
    {
        get { return conAlcohol; }
        set { conAlcohol = value; }
    }
}
