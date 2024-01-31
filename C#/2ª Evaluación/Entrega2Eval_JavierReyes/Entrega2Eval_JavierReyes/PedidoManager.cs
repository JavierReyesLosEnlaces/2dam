using BurgerLibrary.Modelo.Productos;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;
using System.Windows.Forms;

namespace Entrega2Eval_JavierReyes
{
    public class PedidoManager
    {
        private int ultimoIdPedido;

        public PedidoManager()
        {
            // Al iniciar el programa, intenta cargar el último ID de pedido desde un archivo
            // Si no hay ningún archivo o el contenido no se puede analizar como un entero, comenzamos desde 1
            try
            {
                string idString = File.ReadAllText("ultimo_id_pedido.txt");
                ultimoIdPedido = int.Parse(idString);
            }
            catch (FileNotFoundException)
            {
                ultimoIdPedido = 1; // Si el archivo no existe, comenzamos desde 1
            }
            catch (FormatException)
            {
                ultimoIdPedido = 1; // Si el contenido del archivo no es un número válido, comenzamos desde 1
            }
        }

        public int GenerarNuevoIdPedido()
        {
            // Incrementa el ID del pedido y lo devuelve
            return ++ultimoIdPedido;
        }

        public void GuardarUltimoIdPedido()
        {
            // Guarda el último ID de pedido en un archivo
            File.WriteAllText("ultimo_id_pedido.txt", ultimoIdPedido.ToString());
        }
    }
}
