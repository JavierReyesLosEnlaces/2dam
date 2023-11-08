using System.Collections.Generic;

namespace MyBurguerLib_Ex2
{
    public class Hamburguesa : Producto
    {
        private char tipoFilete;
        private bool conTomate;
        private bool conQueso;
        private bool conHuevo;
        private bool conCebolla;
        private bool conBacon;

        public Hamburguesa(string nombreProducto, char tipoFilete, bool conTomate, bool conQueso, bool conHuevo, bool conCebolla, bool conBacon) : base(nombreProducto)
        {
            this.tipoFilete = tipoFilete;
            this.conTomate = conTomate;
            this.conHuevo = conHuevo;
            this.conQueso = conQueso;
            this.conCebolla = conCebolla;
            this.conBacon = conBacon;

            // Tipos de filete: c = cerdo, p = pollo, v = vegana.

            if (tipoFilete == 'c') precioBase = 4.0f;
            else if (tipoFilete == 'p') precioBase = 3.0f;
            else if (tipoFilete == 'v') precioBase = 4.5f;

            if (conTomate) precioExtras += 0.25f;
            if (conQueso) precioExtras += 0.5f;
            if (conHuevo) precioExtras += 0.75f;
            if (conCebolla) precioExtras += 0.35f;
            if (conBacon) precioExtras += 1.0f;

            precio = precioBase + precioExtras;
        }
        public string ListarIngredientes()
        {
            List<string> ingredientes = new List<string>();

            if (tipoFilete == 'c') ingredientes.Add("Filete de cerdo");
            else if (tipoFilete == 'p') ingredientes.Add("Filete de pollo");
            else if (tipoFilete == 'v') ingredientes.Add("Filete vegano");

            if (conTomate) ingredientes.Add("tomate");
            if (conQueso) ingredientes.Add("queso");
            if (conHuevo) ingredientes.Add("huevo");
            if (conCebolla) ingredientes.Add("cebolla");
            if (conBacon) ingredientes.Add("bacon");

            string listaIngredientes = string.Join(", ", ingredientes);
            return "Ingredientes: " + listaIngredientes;
        }
        public char TipoFilete
        {
            get { return tipoFilete; }
            set { tipoFilete = value; }
        }

        public bool ConTomate
        {
            get { return conTomate; }
            set { conTomate = value; }
        }

        public bool ConQueso
        {
            get { return conQueso; }
            set { conQueso = value; }
        }

        public bool ConHuevo
        {
            get { return conHuevo; }
            set { conHuevo = value; }
        }

        public bool ConCebolla
        {
            get { return conCebolla; }
            set { conCebolla = value; }
        }

        public bool ConBacon
        {
            get { return conBacon; }
            set { conBacon = value; }
        }
    }
}