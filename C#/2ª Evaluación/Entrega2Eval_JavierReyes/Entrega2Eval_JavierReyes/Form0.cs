using BurgerLibrary.Modelo.Productos;
using System.Text.Json;

namespace Entrega2Eval_JavierReyes
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
            InitUI();
        }

        // SE INICIALIZAN PROPIEDADES GENERALES DEL FORM0
        private void InitUI()
        {
            // TAMAÑO DEL FORM FIJO
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

            // QUITAR BOTONES DE MAXIMIZAR Y MINIMIZAR
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            VerificarEstadoBtnUltimoPedido();
        }

        // SE OBTIENEN LOS PRODUCTOS DEL PEDIDO CON MAYOR ID 
        private List<Producto> ObtenerProductosDelPedidoConMayorId()
        {
            List<Producto> productos = new List<Producto>();
            int maxIdPedido = -1;

            // LEE EL ARCHIVO JSON "historicoDeFacturas.json" LÍNEA POR LÍNEA
            string jsonFilePath = "facturas.json";
            if (File.Exists(jsonFilePath))
            {
                // ABRE EL ARCHIVO PARA LEER LÍNEA POR LÍNEA
                using (StreamReader file = new StreamReader(jsonFilePath))
                {
                    string line;
                    while ((line = file.ReadLine()) != null)
                    {
                        // DESERIALIZA CADA LÍNEA EN UN OBJETO Factura
                        Factura factura = JsonSerializer.Deserialize<Factura>(line);

                        // COMPARA EL IdPedido CON EL MÁXIMO ENCONTRADO HASTA AHORA
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

        // SE VERIFICA EL ESTADO DEL BOTÓN DE "ÚLTIMO PEDIDO"
        private void VerificarEstadoBtnUltimoPedido()
        {
            // VERIFICAR SI EL ARCHIVO JSON ESTÁ VACÍO
            string jsonFilePath = "facturas.json";
            bool archivoVacio = !File.Exists(jsonFilePath) || new FileInfo(jsonFilePath).Length == 0;

            // HABILITAR O DESHABILITAR EL BOTÓN SEGÚN EL ESTADO DEL ARCHIVO
            btnUltimoPedido.Visible = !archivoVacio;

            // SI EL ARCHIVO NO ESTÁ VACÍO, CAMBIA EL TAMAÑO DEL FORMULARIO
            if (!archivoVacio)
            {
                this.Width = 657;
                this.Height = 800;
            }
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            // ABRIR Form1
            Form1 f1 = new Form1();
            f1.Show();

            // CERRAR Form0
            this.Hide();
        }

        // SE MUESTRA EL ÚLTIMO PEDIDO REALIZADO EN FORM1
        private void btnPedidoAyer_Click(object sender, EventArgs e)
        {
            // SE OBTIENE LOS PRODUCTOS DEL PEDIDO CON EL MAYOR ID
            List<Producto> productos = ObtenerProductosDelPedidoConMayorId();

            // LUEGO SE PUEDE PASAR LA LISTA DE PRODUCTOS AL SIGUIENTE FORMULARIO
            Form1 form1 = new Form1();
            form1.fase = 6;
            form1.MostrarPantallaFactura(productos);
            form1.Show();
        }

        private void btnEmpezar_MouseEnter(object sender, EventArgs e) { btnEmpezar.BackColor = System.Drawing.Color.FromArgb(45, 123, 60); }

        private void btnEmpezar_MouseLeave(object sender, EventArgs e) { btnEmpezar.BackColor = System.Drawing.Color.Black; }

        private void btnUltimoPedido_MouseEnter(object sender, EventArgs e) { btnUltimoPedido.BackColor = System.Drawing.Color.FromArgb(45, 123, 60); }

        private void btnUltimoPedido_MouseLeave(object sender, EventArgs e) { btnUltimoPedido.BackColor = System.Drawing.Color.Black; }

        // SI SE CIERRA "Form1" SE APAGA LA APLICACIÓN 
        private void Form0_FormClosed(object sender, FormClosedEventArgs e) { Application.Exit(); }
    }
}