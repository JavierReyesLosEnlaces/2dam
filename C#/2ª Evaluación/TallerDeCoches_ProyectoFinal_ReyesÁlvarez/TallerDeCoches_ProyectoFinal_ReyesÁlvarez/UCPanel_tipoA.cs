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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TextBox = System.Windows.Forms.TextBox;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{


    public partial class UCPanel_tipoA : UserControl
    {
        public UCPanel_tipoA()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            tlpDatos.Enabled = false;
            btn_aceptar.BackColor = Color.LightGray;
        }

        private void btn_modificarRegistro_Click(object sender, EventArgs e)
        {
            // Llamar a la función para actualizar los TextBox
            // SetTextBoxValuesFromSelectedRow();
            btn_aceptar.BackColor = tlpDatos.Enabled ? Color.LightGray : Color.FromArgb(117, 230, 164);

            // Habilitar o deshabilitar el panel según su estado actual
            tlpDatos.Enabled = !tlpDatos.Enabled;


        }





        private string GetValueFromCell(DataGridViewCell cell)
        {
            // Verificar si la celda tiene un valor
            if (cell.Value != null)
            {
                return cell.Value.ToString();
            }
            else
            {
                return ""; // Si la celda está vacía, devuelve una cadena vacía
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            // Llamar a la función para actualizar los TextBox
            // SetTextBoxValuesFromSelectedRow();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en los encabezados)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                SetTextBoxValuesFromSelectedRow(selectedRow);
            }
        }

        private void SetTextBoxValuesFromSelectedRow(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                int visibleTextBoxCount = 0;

                // Iterar sobre todas las celdas en la fila seleccionada, comenzando desde el segundo campo (índice 1)
                for (int i = 1; i < selectedRow.Cells.Count && visibleTextBoxCount < 10; i++)
                {
                    // Construir el nombre del TextBox
                    string textBoxName = "campoTextbox" + (visibleTextBoxCount + 1);

                    // Buscar el TextBox en el panel por nombre
                    TextBox textBox = tlpDatos.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                    // Verificar si se encontró el TextBox y si está visible
                    if (textBox != null && textBox.Visible)
                    {
                        textBox.Text = GetValueFromCell(selectedRow.Cells[i]);
                        visibleTextBoxCount++;
                    }
                    else
                    {
                        break; // Si no se encuentra el TextBox o no está visible, salir del bucle
                    }
                }
            }
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (!tlpDatos.Enabled)
            {
                MessageBox.Show("El panel está bloqueado. Desbloquéelo para realizar cambios.");
                return;
            }

            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                string nombreTabla = label_nombreTabla.Text.ToLower();

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Comenzamos en 1 para omitir el primer campo (ID)
                for (int i = 1; i < selectedRow.Cells.Count; i++)
                {
                    // Construir el nombre del TextBox
                    string textBoxName = "campoTextbox" + i;

                    // Buscar el TextBox en el panel por nombre
                    TextBox textBox = tlpDatos.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                    if (textBox != null)
                    {
                        string columnName = dataGridView1.Columns[i].Name; // Nombre de la columna en la base de datos
                        string newValue = textBox.Text;

                        // Realizar la actualización en la base de datos
                        ActualizarRegistro(connectionString, nombreTabla, columnName, newValue, selectedRow.Cells[0].Value.ToString());
                    }
                }

                MessageBox.Show("Registro actualizado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
        }

        private void ActualizarRegistro(string connectionString, string nombreTabla, string columnName, string newValue, string id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = $"UPDATE {nombreTabla} SET {columnName} = @newValue WHERE ID = @id";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@newValue", newValue);
                    command.Parameters.AddWithValue("@id", id);

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected == 0)
                    {
                        throw new Exception("No se pudo actualizar la fila.");
                    }
                }
            }
        }
    }
    }
