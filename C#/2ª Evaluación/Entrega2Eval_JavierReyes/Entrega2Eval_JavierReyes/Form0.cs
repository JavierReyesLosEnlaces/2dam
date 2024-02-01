using BurgerLibrary.Modelo.Productos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace Entrega2Eval_JavierReyes
{
    public partial class form0 : Form
    {
        public form0()
        {
            InitializeComponent();
            InitUI();
        }

        private void btnPedidoAyer_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ObtenerProductosDelPedidoConMayorId();
            // Luego puedes pasar esta lista de productos al siguiente formulario
            Form1 form1 = new Form1();
            form1.fase = 6;
            form1.MostrarPantallaFactura(productos);
            form1.Show();
        }

        private List<Producto> ObtenerProductosDelPedidoConMayorId()
        {
            List<Producto> productos = new List<Producto>();
            int maxIdPedido = -1;

            // Lee el archivo JSON "facturas.json" línea por línea
            string jsonFilePath = "facturas.json";
            if (File.Exists(jsonFilePath))
            {
                // Abre el archivo para leer línea por línea
                using (StreamReader file = new StreamReader(jsonFilePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        // Deserializa cada línea en un objeto Factura
                        Factura factura = JsonSerializer.Deserialize<Factura>(line);

                        // Compara el IdPedido con el máximo encontrado hasta ahora
                        if (factura != null && factura.IdPedido > maxIdPedido)
                        {
                            maxIdPedido = factura.IdPedido;
                            productos = factura.Comanda;
                        }
                    }
                }
            }

            return productos;
        }


        private void InitUI()
        {
            // Tamaño del Form fijo
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // Quitar botones de maximizar y minimizar
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            VerificarEstadoBtnUltimoPedido();
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
            btnEmpezar.BackColor = System.Drawing.Color.FromArgb(45, 123, 60);
        }

        private void btnEmpezar_MouseLeave(object sender, EventArgs e)
        {
            btnEmpezar.BackColor = System.Drawing.Color.Black;
        }


        private void btnUltimoPedido_MouseEnter(object sender, EventArgs e)
        {
            btnUltimoPedido.BackColor = System.Drawing.Color.FromArgb(45, 123, 60);
        }

        private void btnUltimoPedido_MouseLeave(object sender, EventArgs e)
        {
            btnUltimoPedido.BackColor = System.Drawing.Color.Black;
        }



        private void Form0_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Si se cierra el Form0 se cierra la aplicación
            Application.Exit();
        }

        private void VerificarEstadoBtnUltimoPedido()
        {
            // Verificar si el archivo JSON está vacío
            string jsonFilePath = "facturas.json";
            bool archivoVacio = !File.Exists(jsonFilePath) || new FileInfo(jsonFilePath).Length == 0;

            // Habilitar o deshabilitar el botón según el estado del archivo
            btnUltimoPedido.Visible = !archivoVacio;

            // Si el archivo no está vacío, cambia el tamaño del formulario
            if (!archivoVacio)
            {
                this.Width = 657;
                this.Height = 800;
            }
        }
    }
}
