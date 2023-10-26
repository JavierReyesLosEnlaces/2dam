public class Hamburguesa : Producto
{
    private bool conPanCenteno;
    private bool conQueso;
    private readonly float precioBase = 4.0f; //readonly = final
    private float precioExtras = 0;


    public Hamburguesa(bool conPanCenteno, bool conQueso)
    {
        this.conPanCenteno = conPanCenteno;
        this.conQueso = conQueso;

        if (conPanCenteno) precioExtras += 0.5f;
        if (conQueso) precioExtras += 1.0f;

        precio = precioBase + precioExtras;
    }

    //GETTERS Y SETTERS 
    public bool PanCenteno
    {
        get { return conPanCenteno; }
        set { conPanCenteno = value; }
    }

    public bool ConQueso
    {
        get { return conQueso; }
        set { conQueso = value; }
    }

    public float Precio
    {
        get { return precio; }
        set { precio = value; }
    }
}
