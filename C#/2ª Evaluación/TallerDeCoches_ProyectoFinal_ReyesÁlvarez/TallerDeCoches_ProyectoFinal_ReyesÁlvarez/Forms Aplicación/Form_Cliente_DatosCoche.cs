using Microsoft.Data.SqlClient;
using System.Configuration;
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Aplicación
{
    public partial class Form_Cliente_DatosCoche : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;

        public Form_Cliente_DatosCoche()
        {
            InitializeComponent();
            InitUI(); 
        }

        private void InitUI()
        {
            btn_continuar.Enabled = false;
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Form_Cliente fc = new Form_Cliente();
            fc.Show();
            Hide();
        }

        private void CheckCampos()
        {
            bool camposCompletos = !string.IsNullOrWhiteSpace(textBox_modelo.Text) &&
                                   !string.IsNullOrWhiteSpace(textBox_color.Text) &&
                                   !string.IsNullOrWhiteSpace(textBox_peso.Text) &&
                                   checkbox_condiciones.Checked;
            btn_continuar.Enabled = camposCompletos;
        }

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            CheckCampos();
        }

        private void checkbox_condiciones_CheckedChanged(object sender, EventArgs e)
        {
            CheckCampos();
        }

        private void btn_continuar_Click(object sender, EventArgs e)
        {
            // INSERTAR COCHES
            string modelo = textBox_modelo.Text;
            string color = textBox_color.Text;
            string peso = textBox_peso.Text;

            string queryCoche = "INSERT INTO coches (modelo, color, peso) VALUES (@Modelo, @Color, @Peso)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryCoche, connection))
                {
                    // Agregar parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@Modelo", modelo);
                    command.Parameters.AddWithValue("@Color", color);
                    command.Parameters.AddWithValue("@Peso", peso);
                    try
                    {
                        // Abrir conexión
                        connection.Open();
                        // Ejecutar la consulta
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error si ocurre algún problema
                        MessageBox.Show("Error al insertar el registro de coche: " + ex.Message);
                    }
                }
            }

            // CONSEGUIR EL ID DEL ULTIMO COCHE
            string queryUltimoIdCoche = "SELECT MAX(id_coche) FROM coches";
            int ultimoIdCoche;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryUltimoIdCoche, connection))
                {
                    try
                    {
                        connection.Open();
                        // Obtener el último id_coche
                        ultimoIdCoche = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el último id_coche: " + ex.Message);
                        return; // Salir del método si hay un error
                    }
                }
            }

            // INSERTAR PEDIDOS
            string queryPedido = "INSERT INTO pedidos (importe_bruto, tipo_impositivo, importe_neto, fecha, id_coche, id_servicio)" +
                " VALUES (@ImporteBruto, @TipoImpositivo, @ImporteNeto, @Fecha, @IdCoche, @IdServicio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryPedido, connection))
                {
                    // Agregar parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@ImporteBruto", Form_Cliente.pedidoFinal.ImporteBruto);
                    command.Parameters.AddWithValue("@TipoImpositivo", Form_Cliente.pedidoFinal.ImporteNeto);
                    command.Parameters.AddWithValue("@ImporteNeto", Form_Cliente.pedidoFinal.ImporteNeto);
                    command.Parameters.AddWithValue("@Fecha", Form_Cliente.pedidoFinal.Fecha);
                    command.Parameters.AddWithValue("@IdCoche", ultimoIdCoche); // Usar el último id_coche obtenido
                    command.Parameters.AddWithValue("@IdServicio", Form_Cliente.pedidoFinal.IdServicio);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar el registro de pedido: " + ex.Message);
                    }
                }
            }


            // CONSEGUIR EL ID_PEDIDO ÚLTIMO
            string queryUltimoId = "SELECT MAX(id_pedido) FROM pedidos";
            int idPedidoInsertado;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryUltimoId, connection))
                {
                    try
                    {
                        connection.Open();
                        // Obtener el último id_coche
                        idPedidoInsertado = (int)command.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al obtener el último id_coche: " + ex.Message);
                        return; // Salir del método si hay un error
                    }
                }
            }



            // INSERTAR PEDIDOS REVISIÓN
            string queryPedidoRevision = "INSERT INTO pedidosRevision (id_pedido) VALUES (@IdPedido)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(queryPedidoRevision, connection))
                {
                    // Agregar parámetros para evitar la inyección SQL
                    command.Parameters.AddWithValue("@IdPedido", idPedidoInsertado);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("¡Gracias, tu pedido se ha procesado correctamente!");
                        volverAlLogin();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar el registro de pedido de revisión: " + ex.Message);
                    }
                }
            }
            
        }

        private void volverAlLogin()
        {
            Form_Login fl = new Form_Login();
            fl.Show();
            this.Hide();
        }
    }
}
