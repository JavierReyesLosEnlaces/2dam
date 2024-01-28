public class Patatas : Producto
{
    private bool conSal;
    private string tipoPatata;
    private string tipoDeCorte;
    private string dressing;

    public Patatas(string nombreProducto, bool conSal, string tipoPatata, string tipoDeCorte, string dressing) : base(nombreProducto)
    {
        this.conSal = conSal;
        this.tipoPatata = tipoPatata;
        this.tipoDeCorte = tipoDeCorte;
        this.dressing = dressing;

        precioBase = 3.0f;
        if (tipoPatata == "batata") precioExtras += 0.3f;
        if (tipoDeCorte == "deluxe") precioExtras += 0.5f;

        precio = precioBase + precioExtras;
    }

    public bool ConSal
    {
        get { return conSal; }
        set { conSal = value; }
    }

    public string TipoPatata
    {
        get { return tipoPatata; }
        set { tipoPatata = value; }
    }

    public string TipoDeCorte
    {
        get { return tipoDeCorte; }
        set { tipoDeCorte = value; }
    }

    public string Dressing
    {
        get { return dressing; }
        set { dressing = value; }
    }

    public string ListarIngredientes()
    {
        List<string> ingredientes = new List<string>();

        if (conSal)
        {
            ingredientes.Add("Con sal");
        }
        else
        {
            ingredientes.Add("Sin sal");
        }

        if (tipoPatata == "batata")
        {
            ingredientes.Add("batata");
        }
        else
        {
            ingredientes.Add("patata");
        }
        ingredientes.Add("corte " + tipoDeCorte);

        string listaIngredientes = string.Join(", ", ingredientes);
        return listaIngredientes + " y " + dressing + " como dressing";
    }
}
