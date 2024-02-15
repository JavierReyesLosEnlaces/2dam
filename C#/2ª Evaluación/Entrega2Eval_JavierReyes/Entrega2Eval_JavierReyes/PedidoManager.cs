namespace Entrega2Eval_JavierReyes
{
    public class PedidoManager
    {
        private int ultimoIdPedido;
        public PedidoManager()
        {
            // AL INICIARSE, SE INTENTA CARGAR EL ÚLTIMO ID DE PEDIDO DESDE UN ARCHIVO
            // SI NO HAY NINGÚN ARCHIVO O EL CONTENIDO NO SE PUEDE ANALIZAR COMO UN ENTERO, SE COMIENZA DESDE NÚMERO 1
            try
            {
                string idString = File.ReadAllText("ultimo_id_pedido.txt");
                ultimoIdPedido = int.Parse(idString);
            }
            catch (FileNotFoundException)
            {
                ultimoIdPedido = 1; // SI EL ARCHIVO NO EXISTE, SE COMIENZA DESDE 1
            }
            catch (FormatException)
            {
                ultimoIdPedido = 1; // SI EL CONTENIDO DEL ARCHIVO NO ES UN NÚMERO VÁLIDO, SE COMIENZA DESDE 1
            }
        }
        public int GenerarNuevoIdPedido()
        {
            // SE INCREMENTA EL ID DEL PEDIDO Y LO DEVUELVE
            return ++ultimoIdPedido;
        }
        public void GuardarUltimoIdPedido()
        {
            // SE GUARDA EL ÚLTIMO ID DE PEDIDO EN UN ARCHIVO
            File.WriteAllText("ultimo_id_pedido.txt", ultimoIdPedido.ToString());
        }
    }
}
