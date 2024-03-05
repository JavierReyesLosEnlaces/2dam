using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TallerDeCoches_ProyectoFinal_ReyesÁlvarez
{
    public partial class Form_SignupCliente : Form
    {
        public Form_SignupCliente()
        {
            InitializeComponent();
            InitUI();
        }

        private void InitUI()
        {
            textbox_contraseña.UseSystemPasswordChar = true;
        }

        private void btn_irLogin_Click(object sender, EventArgs e)
        {
            Form_Login fl = new Form_Login();
            fl.Show();
            this.Hide();
        }

        private void btn_crearCuenta_Click(object sender, EventArgs e)
        {
            if (textbox_nombreUsuario.Text.Length < 3 || textbox_contraseña.Text.Length < 5)
            {
                MessageBox.Show("Nombre de usuario o contraseña no válidos, muy cortos");
            }
            else
            {
                string nombre = textbox_nombre.Text;
                string primerApellido = textbox_primerApellido.Text;
                string segundoApellido = textbox_segundoApellido.Text;
                string dni = textbox_dni.Text;
                string telefono = textbox_numeroTelefono.Text;
                string correoElectronico = textbox_correoElectronico.Text;
                string nombreUsuario = textbox_nombreUsuario.Text;
                string contraseñaUsuario = textbox_contraseña.Text;

                // Creación del directorio que contendrá el fichero con las claves cifradas
                string dir = nombreUsuario;
                string path = "data\\clientes\\" + dir;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    string encusr = AesCryp.Encrypt(nombreUsuario);
                    string encpss = AesCryp.Encrypt(contraseñaUsuario);
                    var streamwriter = new StreamWriter(Path.Combine(path, "data.ls"));
                    streamwriter.WriteLine(encusr);
                    streamwriter.WriteLine(encpss);
                    streamwriter.Close();

                    // Inserción de datos del formulario de cliente en la base de datos
                    string connectionString = "Data Source=JAVIER;Initial Catalog=BDPaquito;Encrypt=False;Integrated Security=true";
                    string queryInsertUsuario = @"INSERT INTO usuarios (nombre, primer_apellido, segundo_apellido, dni, telefono, correo_electronico, nombre_usuario, contraseña_usuario, id_rol) 
                                 VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @DNI, @Telefono, @CorreoElectronico, @NombreUsuario, @ContraseñaUsuario, @Rol)";

                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            using (SqlCommand commandUsuario = new SqlCommand(queryInsertUsuario, connection))
                            {
                                commandUsuario.Parameters.AddWithValue("@Nombre", nombre);
                                commandUsuario.Parameters.AddWithValue("@PrimerApellido", primerApellido);
                                commandUsuario.Parameters.AddWithValue("@SegundoApellido", segundoApellido);
                                commandUsuario.Parameters.AddWithValue("@DNI", dni);
                                commandUsuario.Parameters.AddWithValue("@Telefono", telefono);
                                commandUsuario.Parameters.AddWithValue("@CorreoElectronico", correoElectronico);
                                commandUsuario.Parameters.AddWithValue("@NombreUsuario", encusr);
                                commandUsuario.Parameters.AddWithValue("@ContraseñaUsuario", encpss);
                                commandUsuario.Parameters.AddWithValue("@Rol", 2); // ID del rol 2 = rol de cliente

                                // Ejecutar la inserción del usuario
                                commandUsuario.ExecuteNonQuery();
                            }

                            // Obtener el ID de usuario insertado
                            string queryGetUserId = "SELECT MAX(id_usuario) FROM usuarios";
                            int userId;
                            using (SqlCommand getUserIdCommand = new SqlCommand(queryGetUserId, connection))
                            {
                                userId = Convert.ToInt32(getUserIdCommand.ExecuteScalar());
                            }

                            // Insertar datos del cliente
                            string queryInsertCliente = @"INSERT INTO clientes (cantidad_adeudada, fecha_registro, codigo_postal, id_usuario) 
                                                 VALUES (0, @FechaRegistro, @CodigoPostal, @IdUsuario)";
                            using (SqlCommand commandCliente = new SqlCommand(queryInsertCliente, connection))
                            {
                                // Formatear la fecha actual en formato YYYY-MM-DD
                                string fechaRegistro = DateTime.Now.ToString("yyyy-MM-dd");

                                commandCliente.Parameters.AddWithValue("@FechaRegistro", fechaRegistro);
                                commandCliente.Parameters.AddWithValue("@CodigoPostal", textbox_codigoPostal.Text);
                                commandCliente.Parameters.AddWithValue("@IdUsuario", userId);

                                // Ejecutar la inserción del cliente
                                commandCliente.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show("Los datos del cliente se han registrado correctamente");
                        Form_Login fl = new Form_Login();
                        fl.Show();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al insertar los datos en la base de datos: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya existe.");
                }
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textbox_contraseña.UseSystemPasswordChar = !textbox_contraseña.UseSystemPasswordChar;
        }
    }
}
