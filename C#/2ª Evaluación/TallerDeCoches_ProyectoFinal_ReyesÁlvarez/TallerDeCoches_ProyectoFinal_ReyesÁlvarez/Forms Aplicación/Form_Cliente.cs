using Microsoft.Data.SqlClient;
using System.Configuration;
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Aplicación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación
{
    public partial class Form_Cliente : Form
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public static String idservicio;
        public static int idCliente;
        public static PedidoFinal pedidoFinal = new PedidoFinal();

        public Form_Cliente()
        {
            InitializeComponent();

            Form_Login fl = new Form_Login();
            label1.Text = "¿Qué servicio estás buscando?";
            InitUI();
        }
        /*
        public static String getIdServicio()
        {
            return idservicio;
        }
        */

        private void InitUI()
        {
            tlp_lavadoDetallado.Visible = false;
            tlp_mantenimiento.Visible = false;
            tlp_reparacion.Visible = false;
            tlp_serviciosEspeciales.Visible = false;
            tlpTarjeta.Visible = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tlp_reparacion.Visible = false;
            tlp_serviciosEspeciales.Visible = false;
            tlp_mantenimiento.Visible = false;
            tlp_lavadoDetallado.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tlp_lavadoDetallado.Visible = false;
            tlp_reparacion.Visible = false;
            tlp_serviciosEspeciales.Visible = false;
            tlp_mantenimiento.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tlp_lavadoDetallado.Visible = false;
            tlp_mantenimiento.Visible = false;
            tlp_serviciosEspeciales.Visible = false;
            tlp_reparacion.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tlp_lavadoDetallado.Visible = false;
            tlp_mantenimiento.Visible = false;
            tlp_reparacion.Visible = false;
            tlp_serviciosEspeciales.Visible = true;
        }

        private void servicioItem_Click(object sender, EventArgs e)
        {
            {
                tlpTarjeta.Visible = true;

                // Obtener el texto del botón pulsado
                string textoBoton = ((Button)sender).Text;
                string query = @"SELECT s.id_servicio AS 'Id del servicio', s.descripcion AS 'Nombre del Servicio', t.direccion AS 'Dirección del Taller', s.precio AS 'Importe Bruto', s.familia AS 'Familia de servicio'
                         FROM servicios s
                         LEFT JOIN talleres t ON s.id_taller = t.id_taller
                         LEFT JOIN pedidos p ON s.id_servicio = p.id_servicio
                         WHERE s.descripcion = '" + textoBoton + "'";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            // Obtener los valores de las columnas de la consulta
                            string nombreServicio = reader["Nombre del Servicio"].ToString();
                            string familia = reader["Familia de servicio"].ToString();
                            string direccionTaller = reader["Dirección del Taller"].ToString();
                            string importeBruto = reader["Importe Bruto"].ToString();
                            idservicio = reader["Id del servicio"].ToString();

                            // Seteas el idServicio del pedidoFinal
                            pedidoFinal.IdServicio = idservicio;
                            pedidoFinal.ImporteBruto = decimal.Parse(importeBruto);
                            pedidoFinal.ImporteNeto = (pedidoFinal.ImporteBruto * 1.21m);
                            pedidoFinal.Fecha = DateTime.Now.ToString("yyyy-MM-dd");

                            // Asignar los valores obtenidos a las etiquetas correspondientes
                            labelSE_Servicio.Text = nombreServicio;
                            labelSE_Taller.Text = direccionTaller;
                            labelSE_ImporteBruto.Text = importeBruto;
                            labelSE_TipoImpositivo.Text = "21%";

                            switch (familia)
                            {
                                case "Lavado y Detallado":
                                    pboxFamilia.BackgroundImage = Image.FromFile("img\\lavado.jpg");
                                    break;
                                case "Mantenimiento":
                                    pboxFamilia.BackgroundImage = Image.FromFile("img\\mantenimiento.jpg");
                                    break;
                                case "Reparación":
                                    pboxFamilia.BackgroundImage = Image.FromFile("img\\reparacion.jpg");
                                    break;
                                case "Servicios Especiales":
                                    pboxFamilia.BackgroundImage = Image.FromFile("img\\serviciosespeciales.jpg");
                                    break;
                                default:
                                    // Manejar un caso por defecto si no se encuentra ninguna familia específica
                                    break;
                            }
                        }
                        else
                        {
                            // Si no se encontraron resultados, mostrar un mensaje de error
                            MessageBox.Show("No se encontraron datos para el servicio: " + textoBoton);
                        }
                    }
                }
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            
            Form_Cliente_DatosCoche fcdc = new Form_Cliente_DatosCoche();
            fcdc.Show();
            Hide();
        }

        public void CargarDatosCliente(string nombre_usuario)
        {
            string query = "SELECT c.id_cliente FROM clientes c INNER JOIN usuarios u ON c.id_usuario = u.id_usuario WHERE u.nombre_usuario = @nombreUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombre_usuario);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            idCliente = reader.GetInt32(reader.GetOrdinal("id_cliente"));
                        }
                    }
                }
            }
            MessageBox.Show(idCliente.ToString());
        }
    }
}
