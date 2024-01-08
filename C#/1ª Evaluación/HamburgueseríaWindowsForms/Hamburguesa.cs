using System;

public class Hamburguesa
{
    private bool panCenteno;
    private bool carneVacuno;
    private readonly float precioBase = 4.0f; //readonly = final
    private float precioExtras = 0;
    private float precioFinal;


    public Hamburguesa(bool panCenteno, bool carneVacuno)
    {
        this.panCenteno = panCenteno;
        this.carneVacuno = carneVacuno;

        if (panCenteno) precioExtras += 0.5f;
        if (carneVacuno) precioExtras += 1.0f;

        precioFinal = precioBase + precioExtras;
    }

    //GETTERS Y SETTERS 
    public bool PanCenteno
    {
        get { return panCenteno; }
        set { panCenteno = value; }
    }

    public bool CarneVacuno
    {
        get { return carneVacuno; }
        set { carneVacuno = value; }
    }

    public float PrecioFinal
    {
        get { return precioFinal; }
        set { precioFinal = value; }
    }
}

