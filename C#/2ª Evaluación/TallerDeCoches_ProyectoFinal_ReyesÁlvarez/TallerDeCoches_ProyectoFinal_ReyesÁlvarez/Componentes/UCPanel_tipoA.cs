using System;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Data.SqlClient; // Utiliza Microsoft.Data.SqlClient para acceder a bases de datos SQL Server

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class UCPanel_tipoA : UserControl
    {
        public UCPanel_tipoA()
        {
            InitializeComponent();
            InitUI();
        }

        // Método para inicializar la interfaz de usuario
        private void InitUI()
        {
            tlpDatos.Enabled = true;
            btn_crearRegistro.BackColor = Color.FromArgb(121, 141, 236);
            btn_crearRegistro.Enabled = true;
            btn_modificarRegistro.Enabled = false;
            btn_modificarRegistro.BackColor = Color.LightGray;
            btn_borrarRegistro.Enabled = false;
            btn_borrarRegistro.BackColor = Color.LightGray;
        }

        // Método para llenar los TextBoxes con la información de la fila seleccionada
        private void LlenarTextboxes(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                int visibleTextBoxCount = 0;

                // Iterar sobre todas las celdas en la fila seleccionada, comenzando desde el segundo campo (índice 1)
                for (int i = 1; i < selectedRow.Cells.Count; i++)
                {
                    string textBoxName = "campoTextbox" + (visibleTextBoxCount + 1);
                    TextBox textBox = tlpDatos.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                    // Verificar si se encontró el TextBox y si está visible
                    if (textBox != null && textBox.Visible)
                    {
                        textBox.Text = GetValueFromCell(selectedRow.Cells[i]);
                        visibleTextBoxCount++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        // Método para obtener el valor de una celda del DataGridView
        private string GetValueFromCell(DataGridViewCell cell)
        {
            // Verificar si la celda tiene un valor
            return cell.Value != null ? cell.Value.ToString() : "";
        }

        // Método para actualizar el DataGridView con los registros de la base de datos
        private void ActualizarDataGridView()
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                string nombreTabla = label_nombreTabla.Text.ToLower();

                // Construir la consulta SQL para seleccionar todos los registros de la tabla
                string query = $"SELECT * FROM {nombreTabla}";

                // Crear un DataTable para almacenar los datos de la consulta
                DataTable dataTable = new DataTable();

                // Ejecutar la consulta SQL y llenar el DataTable con los resultados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(dataTable);
                    }
                }

                // Asignar el DataTable como la fuente de datos del DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el DataGridView: " + ex.Message);
            }
        }

        // Evento de clic en una celda del DataGridView
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en los encabezados)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                LlenarTextboxes(selectedRow);

                // Desbloquear el panel que contiene los TextBox
                tlpDatos.Enabled = true;
                btn_modificarRegistro.Enabled = true;
                btn_borrarRegistro.Enabled = true;

                // Cambiar el color de fondo de los botones solo si se seleccionó una fila completa
                if (dataGridView1.SelectedRows.Count > 0 && selectedRow.Selected)
                {
                    btn_modificarRegistro.BackColor = Color.FromArgb(255, 192, 128);
                    btn_borrarRegistro.BackColor = Color.FromArgb(255, 128, 128);
                }
                else
                {
                    // Cambiar el color de fondo de los botones a gris y deshabilitarlos si no se seleccionó una fila completa
                    btn_modificarRegistro.BackColor = Color.LightGray;
                    btn_modificarRegistro.Enabled = false;
                    btn_borrarRegistro.BackColor = Color.LightGray;
                    btn_borrarRegistro.Enabled = false;
                }
            }
        }

        // Evento de cambio de selección en el DataGridView
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                LlenarTextboxes(selectedRow);
                tlpDatos.Enabled = true;
                btn_modificarRegistro.Enabled = true;
                btn_borrarRegistro.Enabled = true;
                btn_modificarRegistro.BackColor = Color.FromArgb(255, 192, 128);
                btn_crearRegistro.BackColor = Color.FromArgb(121, 141, 236);
                btn_borrarRegistro.BackColor = Color.FromArgb(255, 128, 128);
            }
            else
            {
                btn_modificarRegistro.Enabled = false;
                btn_borrarRegistro.Enabled = false;
                btn_modificarRegistro.BackColor = Color.LightGray;
                btn_borrarRegistro.BackColor = Color.LightGray;
            }
        }

        // Evento de clic en el botón "Modificar"
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener la cadena de conexión desde el archivo de configuración
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                string nombreTabla = label_nombreTabla.Text.ToLower();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string primaryKeyColumnName = dataGridView1.Columns[0].Name; // Nombre de la columna de la clave primaria en el DataGridView
                    int primaryKeyValue = Convert.ToInt32(selectedRow.Cells[primaryKeyColumnName].Value); // Obtener el valor de la clave primaria

                    // Construir y ejecutar la consulta SQL para actualizar el registro
                    string query = $"UPDATE {nombreTabla} SET ";

                    // Construir los campos a actualizar
                    for (int i = 1; i < selectedRow.Cells.Count; i++) // Empezamos desde 1 para evitar el ID
                    {
                        string columnName = dataGridView1.Columns[i].Name; // Nombre de la columna en la base de datos
                        string textBoxName = "campoTextbox" + (i);
                        TextBox textBox = tlpDatos.Controls.Find(textBoxName, true).FirstOrDefault() as TextBox;

                        if (textBox != null)
                        {
                            query += $"{columnName} = '{textBox.Text}', "; // Agregar el campo a la consulta de actualización
                        }
                    }

                    // Eliminar la coma final y agregar la condición WHERE
                    query = query.Remove(query.Length - 2) + $" WHERE {primaryKeyColumnName} = {primaryKeyValue}";
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas actualizar este registro?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Ejecutar la consulta SQL para actualizar el registro
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Registro actualizado correctamente.");
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Actualización cancelada.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para actualizar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
        }

        // Evento de clic en el botón "Borrar"
        private void btn_borrar_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                string nombreTabla = label_nombreTabla.Text.ToLower();

                if (dataGridView1.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    string primaryKeyColumnName = dataGridView1.Columns[0].Name; // Nombre de la columna de la clave primaria en el DataGridView
                    int primaryKeyValue = Convert.ToInt32(selectedRow.Cells[primaryKeyColumnName].Value); // Obtener el valor de la clave primaria

                    // Mostrar cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas eliminar este registro?", "Confirmar Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Construir y ejecutar la consulta SQL para eliminar el registro
                        string query = $"DELETE FROM {nombreTabla} WHERE {primaryKeyColumnName} = {primaryKeyValue}";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Registro eliminado correctamente.");
                        ActualizarDataGridView(); // Actualizar el DataGridView después de eliminar el registro
                    }
                    else
                    {
                        MessageBox.Show("Eliminación cancelada.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione una fila para eliminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al borrar el registro: " + ex.Message);
            }
        }

        // Evento de clic en el botón "Crear Registro"
        private void btn_crearRegistro_Click(object sender, EventArgs e)
        {
            if (!tlpDatos.Enabled)
            {
                return;
            }
            else
            {
                try
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                    string nombreTabla = label_nombreTabla.Text.ToLower();

                    // Verificar si hay algún TextBox dentro del TableLayoutPanel
                    bool hayTextBoxes = tlpDatos.Controls.OfType<TextBox>().Any(textBox => textBox.Visible);

                    // Construir la consulta SQL para la inserción
                    string query = $"INSERT INTO {nombreTabla} (";

                    // Obtener los nombres de las columnas
                    for (int i = 1; i < dataGridView1.Columns.Count; i++)
                    {
                        query += $"{dataGridView1.Columns[i].Name}, ";
                    }
                    // Eliminar la coma final y agregar el cierre de paréntesis
                    query = query.Remove(query.Length - 2) + ") VALUES (";

                    // Obtener los valores de los TextBoxes visibles en el panel tlpDatos
                    foreach (Control control in tlpDatos.Controls)
                    {
                        if (control is TextBox && control.Visible)
                        {
                            query += $"'{((TextBox)control).Text}', ";
                        }
                    }
                    // Eliminar la coma final y agregar el cierre de paréntesis
                    query = query.Remove(query.Length - 2) + ")";

                    // Mostrar cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas crear este registro?", "Confirmar Creación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        // Ejecutar la consulta SQL para insertar un nuevo registro
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Registro creado correctamente.");

                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Creación cancelada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el registro: " + ex.Message);
                }
            }
        }

        // Evento de clic en el botón "Reiniciar campos"
        private void button1_Click(object sender, EventArgs e)
        {
            // Reiniciar todos los TextBoxes a cadena vacía
            foreach (Control control in tlpDatos.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
            }
        }

        // Evento de clic en el botón "Ayuda"
        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar un mensaje de bienvenida y una breve descripción de la aplicación
            MessageBox.Show("¡Bienvenido a la Base de Datos!\n\nEn esta aplicación, puedes crear, modificar y borrar registros.\n\nPara modificar o borrar un registro, simplemente selecciona la fila correspondiente.\n\nRecuerda que puedes utilizar la opción 'Reiniciar campos' para poner los campos en blanco y comenzar de nuevo.", "Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
