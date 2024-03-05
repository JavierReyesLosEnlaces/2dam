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
            Application.Exit();
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
            // Obtener los valores de los TextBoxes
            string modelo = textBox_modelo.Text;
            string color = textBox_color.Text;
            string peso = textBox_peso.Text;

            // Consulta SQL para la inserción
            string query = "INSERT INTO coches (modelo, color, peso) VALUES (@Modelo, @Color, @Peso)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
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
                        // Mostrar mensaje de éxito
                        MessageBox.Show("Registro de coche insertado correctamente en la base de datos.");
                    }
                    catch (Exception ex)
                    {
                        // Mostrar mensaje de error si ocurre algún problema
                        MessageBox.Show("Error al insertar el registro de coche: " + ex.Message);
                    }
                }
            }

            String id_servicio = Form_Cliente.getIdServicio();
        }
    }
}
