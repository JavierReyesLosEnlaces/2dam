public class Bebida : Producto
{
    private bool conAlcohol;

    public Bebida(bool conAlcohol)
    {
        this.conAlcohol = conAlcohol;

        precioBase = 3.0f;
        if (conAlcohol) precioExtras += 0.5f;

        precio = precioBase + precioExtras;
    }

    public bool ConAlcohol
    {
        get { return conAlcohol; }
        set { conAlcohol = value; }
    }
}
