using System;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public class PedidoFinal
    {
        private decimal importeBruto, importeNeto;
        private string fecha, id_coche, id_servicio;
        private int tipoImpositivo;

        // Constructor
        public PedidoFinal()
        {
            tipoImpositivo = 21;
        }

        // Propiedades
        public decimal ImporteBruto
        {
            get { return importeBruto; }
            set { importeBruto = value; }
        }

        public int TipoImpositivo
        {
            get { return tipoImpositivo; }
            set { tipoImpositivo = value; }
        }

        public decimal ImporteNeto
        {
            get { return importeNeto; }
            set { importeNeto = value; }
        }

        public string Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public string IdCoche
        {
            get { return id_coche; }
            set { id_coche = value; }
        }

        public string IdServicio
        {
            get { return id_servicio; }
            set { id_servicio = value; }
        }

    }
}
