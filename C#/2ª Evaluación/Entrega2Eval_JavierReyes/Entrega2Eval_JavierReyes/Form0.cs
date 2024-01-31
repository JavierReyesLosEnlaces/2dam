using BurgerLibrary.Modelo.Productos;
using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Entrega2Eval_JavierReyes
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            InitUI();
        }

        private void btnPedidoAyer_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.fase = 5;
            form1.Show();

            Factura f = ObtenerUltimoPedido();
            form1.MostrarPantallaFactura();
            
        }

        private Factura ObtenerUltimoPedido()
        {
            string rutaArchivo = "facturas.json";

            // Verificar si el archivo existe
            if (!File.Exists(rutaArchivo))
            {
                Console.WriteLine("El archivo facturas.json no existe.");
                return null;
            }

            try
            {
                // Leer todo el contenido del archivo JSON
                string json = File.ReadAllText(rutaArchivo);

                // Deserializar el JSON en una lista de objetos Pedido
                List<Factura> pedidos = JsonSerializer.Deserialize<List<Factura>>(json);

                // Obtener el último pedido ordenando la lista por IdPedido de forma descendente y tomando el primer elemento
                Factura ultimoPedido = pedidos.OrderByDescending(p => p.IdPedido).FirstOrDefault();

                return ultimoPedido;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al leer el archivo facturas.json: {ex.Message}");
                return null;
            }
        }
























        private void InitUI()
        {
            // Tamaño del Form fijo
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Quitar botones de maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            // Abrir Form1
            Form1 f1 = new Form1();
            f1.Show();

            // Cerrar Form0
            this.Hide();
        }

        private void btnEmpezar_MouseEnter(object sender, EventArgs e)
        {
            btnEmpezar.BackColor = Color.FromArgb(45, 123, 60);
        }

        private void btnEmpezar_MouseLeave(object sender, EventArgs e)
        {
            btnEmpezar.BackColor = Color.Black;
        }

        private void Form0_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra el Form0 se cierra la aplicación
            Application.Exit();
        }


    }
}
