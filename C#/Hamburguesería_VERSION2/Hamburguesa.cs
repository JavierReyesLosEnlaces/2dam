public class Hamburguesa : Producto
{
    private string tipoHamburguesa; //v = vacuno    p = pollo //METER VEGANANANAAAAAAA
    private bool conTomate;
    private bool conQueso;
    private bool conHuevo;
    private bool conCebolla;
    private bool conBacon;


    public Hamburguesa(string tipoHamburguesa, bool conTomate, bool conQueso, bool conCebolla, bool conBacon)
    {
        this.tipoHamburguesa = tipoHamburguesa;

        this.conTomate = conTomate;
        this.conQueso = conQueso;
        this.conCebolla = conCebolla;
        this.conBacon = conBacon;

        if (tipoHamburguesa == "vacuno")
        {
            precioBase = 4.0f;
        }
        else if (tipoHamburguesa == "pollo")
        {
            precioBase = 3.0f;
        }
        else if(tipoHamburguesa == "vegana")

        if (conTomate) precioExtras += 0.25f;
        if (conQueso) precioExtras += 0.5f;
        if (conHuevo) precioExtras += 0.75f;
        if (conCebolla) precioExtras += 0.35f;
        if (conBacon) precioExtras += 1.0f;


        precio = precioBase + precioExtras;
    }

    public bool ConQueso
    {
        get { return conQueso; }
        set { conQueso = value; }
    }
}
