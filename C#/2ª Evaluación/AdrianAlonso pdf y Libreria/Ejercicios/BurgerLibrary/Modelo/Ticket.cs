using System.Collections.Generic;

namespace BurgerLibrary.Modelo
{
    public class Ticket
    {
        /// <summary>
        /// LineaPedido es una linea del ticket a formar
        /// </summary>
        public struct LineaPedido
        {
            public string nombre;
            public float precio;
        }


        private static int orden = 0;               //Propiedad estática que determina la cantidad de ordenes expedidas
        private int numOrden;                       //Numero de orden del tickect en cuestion
        private List<LineaPedido> lineas;            //Lista con todos los productos pedidos
        private float totalOrden;                   //Precio total del ticket
 
        /// <summary>
        /// Constructor del ticket,
        /// vacio ya que todo lo importamos a posteriori
        /// </summary>
        public Ticket()
        {
            orden++;                                    //Sumamos uno al valor estático al crear un ticket nuevo
            numOrden = orden;                           //Definimos el numero de orden en relación al valor definido
            totalOrden = 0.0f;                          //Inicializamos a 0 totalOrden
            lineas = new List<LineaPedido>();
        }

        /// <summary>
        /// Devuelve el numero de Orden del ticket actual
        /// </summary>
        /// <returns>Numero de orden del ticket actual</returns>
        public int getNumOrden()
        {
            return numOrden;
        }

        /// <summary>
        /// Añadimos a nuestro totalOrden el valor del producto añadido a
        /// nuestra lista lineas
        /// </summary>
        /// <param name="precio">Valor a añadir al ticket</param>
        private void addPrecio(float precio)
        {
            totalOrden += precio;
        }
        
        /// <summary>
        /// Sustrae un valor precio a nuestra propiedad totalOrden
        /// dicho valor viene dado por el producto que eliminamos de nuestra lista lineas
        /// </summary>
        /// <param name="precio">Valor a sustraer de nuestro totalOrden</param>
        private void delPrecio(float precio)
        {
            totalOrden -= precio;
        }

        /// <summary>
        /// Devuelve la lista que conforma el pedido
        /// </summary>
        /// <returns>Lista de LineasPedido</returns>
        public List<LineaPedido> getLineas() 
        { 
            return lineas; 
        }

        /// <summary>
        /// Añadimos a nuestra lista lineas un producto de nombre "nombre" y de precio "precio"
        /// ademas modifica el precio de totalOrden
        /// </summary>
        /// <param name="nombre">Nombre del producto a añadir</param>
        /// <param name="precio">Valor del producto a añadir</param>
        public void addLinea(string nombre, float precio)
        {
            lineas.Add(new LineaPedido { nombre = nombre, precio = precio });
            addPrecio(precio);
        }

        /// <summary>
        /// Elimina un producto de nuestra lista lineas
        /// a traves de su posicion en la lista, además modifica el valor de totalOrden
        /// </summary>
        /// <param name="index">Valor que referencia la posicion de la linea a eliminar</param>
        public void delLinea(int index)
        {
            delPrecio(lineas[index].precio);    
            lineas.RemoveAt(index);
        }

        /// <summary>
        /// Devuelve un string que muestra el objeto ticket formateado
        /// </summary>
        /// <returns>String que muestra el objeto ticket</returns>
        public string imprimeTicket()
        {
            string cabecera = "******************************\n**********  Ticket  **********\n******************************\n";
            string cadena = "";
            string texto = "";
            texto += cabecera;
            string cadenaOrden = this.getNumOrden().ToString();
            cadena += "Numero de Orden:";
            while (cadena.Length < 25)
            {
                cadena += " ";
            }
            texto += cadena;
            while (cadenaOrden.Length < 5)
            {
                cadenaOrden = "0" + cadenaOrden;
            }
            cadena = "";
            texto += cadenaOrden + "\n";
            texto += "------------------------------\n";
            foreach (LineaPedido linea in lineas)
            {
                cadena += imprimeLinea(linea);
            }
            texto += cadena;
            texto += "\n";
            texto += "******************************\n";
            cadena = "* Total:";
            while (cadena.Length < (27 - totalOrden.ToString("0.00").Length))
            {
                cadena += "_";
            }
            cadena += this.totalOrden.ToString("0.00")+"€ *\n";
            texto += cadena;
            texto += "******************************\n";
            return texto;
        }

        /// <summary>
        /// Devuelve una linea del pedido formateada
        /// </summary>
        /// <param name="linea">Struct con nombre y precio para montar el string a devolver</param>
        /// <returns>String de una LineaPedido formateada</returns>
        private string imprimeLinea(LineaPedido linea)
        {
            string cadena = "";
            cadena += linea.nombre;
            while (cadena.Length < 25)
            {
                cadena += "_";
            }
            cadena += linea.precio.ToString("0.00");
            cadena += "€\n";
            return cadena;
        }
        
        /// <summary>
        /// Devuelve un string con las LineaPedido que componen la lista lineas del objeto Ticket enumeradas
        /// </summary>
        /// <returns>string formateado de la lista lineas</returns>
        public string listTicket()
        {
            string texto = "";
            for (int i = 0;i<lineas.Count;i++)
            {
                string cadena = i + ". " + lineas[i].nombre;
                while (cadena.Length < 25)
                {
                    cadena += "_";
                }
                cadena += lineas[i].precio.ToString("0.00") + "€\n";
                texto += cadena;
            }
            return texto;
        }
    }
}
