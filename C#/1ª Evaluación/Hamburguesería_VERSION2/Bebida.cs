public class Bebida : Producto
{
    private bool conAlcohol;
    private bool conBurbujas;
    private string sabor;

    public Bebida(string nombreProducto, bool conAlcohol, bool conBurbujas, string sabor) : base(nombreProducto)
    {
        this.conAlcohol = conAlcohol;
        this.conBurbujas = conBurbujas;
        this.sabor = sabor;

        precioBase = 3.0f;
        if (conAlcohol) precioExtras += 0.5f;
        if (!conBurbujas) precioExtras += 0.25f;

        precio = precioBase + precioExtras;
    }
    public string ListarIngredientes()
    {
        if (conAlcohol)
        {
            return "Bebida con alcohol";
        }
        else
        {
            return "Bebida sin alcohol";
        }
    }
    public bool ConAlcohol
    {
        get { return conAlcohol; }
        set { conAlcohol = value; }
    }

    public bool ConBurbujas
    {
        get { return conBurbujas; }
        set { conBurbujas = value; }
    }

    public string Sabor
    {
        get { return sabor; }
        set { sabor = value; }
    }
}
