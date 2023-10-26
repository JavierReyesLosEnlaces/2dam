public class Hamburguesa : Producto
{
    private bool conPanCenteno;
    private bool conQueso;
    private readonly float precioBase = 4.0f;
    private float precioExtras = 0.0f;

    public Hamburguesa(bool conPanCenteno, bool conQueso)
    {
        this.conPanCenteno = conPanCenteno;
        this.conQueso = conQueso;

        if (conPanCenteno) precioExtras += 0.5f;
        if (conQueso) precioExtras += 1.0f;

        precio = precioBase + precioExtras;

    }

    public bool ConPanCenteno
    {
        get { return conPanCenteno; }
        set { conPanCenteno = value; }
    }

    public bool ConQueso
    {
        get { return conQueso; }
        set { conQueso = value; }
    }
}
