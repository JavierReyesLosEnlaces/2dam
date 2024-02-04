using BurgerLibrary.Modelo.Productos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2Eval_JavierReyes
{
    public class Factura
    {
        public int IdPedido { get; set; }
        public List<Producto> Comanda { get; set; }
        public string Observaciones { get; set; }
        public float Total { get; set; }
    }
}

