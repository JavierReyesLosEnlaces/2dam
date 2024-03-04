using Microsoft.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Text;
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
            tlpDatos.Enabled = true;
            btn_crearRegistro.BackColor = Color.FromArgb(121, 141, 236);
            btn_crearRegistro.Enabled = true;

            btn_modificarRegistro.Enabled = false;
            btn_modificarRegistro.BackColor = Color.LightGray;
            btn_borrarRegistro.Enabled = false;
            btn_borrarRegistro.BackColor = Color.LightGray;
        }


        // SELECCIÓN DE CELDA
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar si se hizo clic en una celda válida (no en los encabezados)
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                llenarTextboxes(selectedRow);
            }

            // Desbloquear el panel que contiene los TextBox
            tlpDatos.Enabled = true;
            btn_modificarRegistro.Enabled = true;
            btn_borrarRegistro.Enabled = true;

            // Cambiar el color de fondo de los botones según el estado del panel
            btn_modificarRegistro.BackColor = tlpDatos.Enabled ? Color.FromArgb(255, 192, 128) : Color.LightGray;
            btn_borrarRegistro.BackColor = tlpDatos.Enabled ? Color.FromArgb(255, 128, 128) : Color.LightGray;

        }

        // VIENES DE UNA CELDA SELECCIONA Y CAMBIAS A OTRA
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                llenarTextboxes(selectedRow);
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
                //btn_crearRegistro.BackColor = Color.LightGray;
                btn_borrarRegistro.BackColor = Color.LightGray;
            }
        }

        // LLENAR LOS TEXTBOXES CON LA INFORMACIÓN DE LA BASE DE DATOS
        private void llenarTextboxes(DataGridViewRow selectedRow)
        {
            if (selectedRow != null)
            {
                int visibleTextBoxCount = 0;

                // Iterar sobre todas las celdas en la fila seleccionada, comenzando desde el segundo campo (índice 1)
                for (int i = 1; i < selectedRow.Cells.Count; i++)
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

        // SE CONSIGUE EL VALOR DE LA CELDA QUE SE HA SELECCIONADO
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












        // LOS TRES BOTONES DE ABAJO
        private void btn_modificar_Click(object sender, EventArgs e)
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

                    // Mostrar cuadro de diálogo de confirmación
                    DialogResult result = MessageBox.Show("¿Estás seguro que deseas actualizar este registro?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                MessageBox.Show(query.ToString());
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
                MessageBox.Show("Error al actualizar el registro");
                //MessageBox.Show(ex.Message);
            }
        }





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
                        MessageBox.Show(query.ToString());

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
                MessageBox.Show("Error al borrar el registro");
                //MessageBox.Show(ex.Message);
            }
        }



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
                        // Ejecutar la consulta SQL
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand command = new SqlCommand(query, connection))
                            {
                                command.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Registro creado correctamente.");

                        // Actualizar el DataGridView
                        // Aquí deberías recargar los datos desde la base de datos y asignarlos al DataGridView
                        // Por ejemplo, puedes llamar a un método que actualice la fuente de datos del DataGridView.
                        ActualizarDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Creación cancelada.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al crear el registro");
                    //MessageBox.Show(ex.Message);
                }
            }
        }



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

    }
}
