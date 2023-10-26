public class Bebida : Producto
{
    private bool conAlcohol;

    public Bebida(bool conAlcohol)
    {
        this.conAlcohol = conAlcohol;

        if (conAlcohol) precio = 3.5f;
        else precio = 3.0f;
    }

    public bool ConAlcohol
    {
        get { return conAlcohol; }
        set { conAlcohol = value; }
    }
}
