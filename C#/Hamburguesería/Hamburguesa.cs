using System;

public class Hamburguesa
{
    private bool panCenteno;
    private bool carneVacuno;
    private float precioBase;
    private float precioFinal;

    public Hamburguesa()
    {
        panCenteno = false;
        carneVacuno = false;
        precioBase = 5.0f;
    }

    // Properties (getters and setters)
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

    public float PrecioBase
    {
        get { return precioBase; }
        set { precioBase = value; }
    }
}
