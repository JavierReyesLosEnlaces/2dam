using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez.Forms_Identificación
{

    public partial class Form_Cliente : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
        public Form_Cliente()
        {
            InitializeComponent();
            InitUI();
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

        private void timer1_tick(object sender, EventArgs e)
        {
            labelHora.Text = DateTime.Now.ToString("dd/MM/yyyy") + " - " + DateTime.Now.ToString("HH:mm:ss");
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

                string query = @"SELECT s.descripcion AS 'Nombre del Servicio', t.direccion AS 'Dirección del Taller', s.precio AS 'Importe Bruto'
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
                            string direccionTaller = reader["Dirección del Taller"].ToString();
                            string importeBruto = reader["Importe Bruto"].ToString();

                            // Asignar los valores obtenidos a las etiquetas correspondientes
                            label7.Text = nombreServicio;
                            label8.Text = direccionTaller;
                            label9.Text = importeBruto;
                            label10.Text = "21%";
                            label11.Text = ((int.Parse(importeBruto)) * 1.21f).ToString();
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
    }
}
