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
            RevisarUltimoPedido();
        }

        private void RevisarUltimoPedido()
        {
            // Ruta al archivo JSON de facturas
            string rutaArchivo = "facturas.json";

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    // Leer el contenido del archivo JSON
                    string contenidoJson = File.ReadAllText(rutaArchivo);

                    // Convertir el contenido a un objeto JSON
                    Factura[] facturas = JsonSerializer.Deserialize<Factura[]>(contenidoJson);

                    // Verificar si hay alguna factura
                    if (facturas.Length > 0)
                    {
                        // Obtener la última factura
                        Factura ultimaFactura = facturas[^1]; // Utiliza el índice ^1 para obtener el último elemento en el array

                        // Mostrar la última factura como opción "Quiero repetir el pedido"
                        MostrarOpcionRepetirFactura(ultimaFactura);
                    }
                    else
                    {
                        Console.WriteLine("No hay facturas disponibles.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al leer el archivo JSON: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("El archivo de facturas no existe.");
            }
        }

        static void MostrarOpcionRepetirFactura(Factura factura)
        {
            // Aquí puedes mostrar los detalles de la factura como una opción para repetir
            // Por ejemplo, podrías imprimir el ID de la factura y algunos detalles relevantes
            Console.WriteLine("Quiero repetir la siguiente factura:");

            int idFactura = factura.IdPedido;
            float total = factura.Total;
            Console.WriteLine($"ID Factura: {idFactura}, Total: {total}");

            // Puedes mostrar más detalles según sea necesario, como los elementos de la comanda o las observaciones
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

        private void btnPedidoAyer_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            // Ruta al archivo JSON de facturas
            string rutaArchivo = "facturas.json";

            // Verificar si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                try
                {
                    // Leer todas las líneas del archivo
                    string[] lineasJson = File.ReadAllLines(rutaArchivo);

                    // Verificar si hay alguna línea en el archivo
                    if (lineasJson.Length > 0)
                    {
                        // Obtener la última línea que contiene un objeto JSON válido
                        string ultimaLineaJson = lineasJson.Last();

                        // Deserializar la última línea JSON en un objeto Factura
                        Factura ultimaFactura = JsonSerializer.Deserialize<Factura>(ultimaLineaJson);

                        // Pasar los valores de la última factura al método GenerarFactura
                        f1.GenerarFactura(ultimaFactura.Comanda, ultimaFactura.Observaciones);
                    }
                    else
                    {
                        MessageBox.Show("El archivo de facturas está vacío.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al leer el archivo JSON: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("El archivo de facturas no existe.");
            }

        }
    }
}
