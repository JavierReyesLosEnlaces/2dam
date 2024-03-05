using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Aplicación;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación
{

    public partial class Form_Cliente : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public static String idServicio;
        public Form_Cliente()
        {
            InitializeComponent();
            InitUI();
        }

        public static String getIdServicio()
        {
            return idServicio;
        }

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
                            idServicio = reader["Id del servicio"].ToString();

                            // Asignar los valores obtenidos a las etiquetas correspondientes
                            label7.Text = nombreServicio;
                            label8.Text = direccionTaller;
                            label9.Text = importeBruto;
                            label10.Text = "21%";

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
    }
}
