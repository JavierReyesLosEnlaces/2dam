namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public class PedidoFinal
    {
        // Campos privados
        private decimal importeBruto;
        private decimal importeNeto;
        private string fecha;
        private string idCoche;
        private string idServicio;
        private int tipoImpositivo;

        // Constructor
        public PedidoFinal()
        {
            // Por defecto, se establece el tipo impositivo en 21%
            tipoImpositivo = 21;
        }

        // Propiedades públicas

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
            get { return idCoche; }
            set { idCoche = value; }
        }

        public string IdServicio
        {
            get { return idServicio; }
            set { idServicio = value; }
        }
    }
}
