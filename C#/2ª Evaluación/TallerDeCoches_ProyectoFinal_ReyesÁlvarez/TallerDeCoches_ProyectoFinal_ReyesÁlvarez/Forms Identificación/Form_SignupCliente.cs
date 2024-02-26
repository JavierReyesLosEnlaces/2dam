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
                MessageBox.Show("Username or password no válido, muy corto");

            }
            else
            {
                // Creacion del directorio que contendrá el fichero con las claves cifradas
                string dir = textbox_nombreUsuario.Text;
                if (!Directory.Exists("data\\clientes\\" + dir))
                {
                    // NOMBRE DE USUARIO Y CONTRASEÑA

                    Directory.CreateDirectory("data\\clientes\\" + dir);
                    string encusr = AesCryp.Encrypt(textbox_nombreUsuario.Text);
                    string encpss = AesCryp.Encrypt(textbox_contraseña.Text);
                    var streamwriter = new StreamWriter("data\\clientes\\" + dir + "\\data.ls");
                    streamwriter.WriteLine(encusr);
                    streamwriter.WriteLine(encpss);
                    streamwriter.Close();

                    // INSERTAR DATOS DEL FORMULARIO DE CLIENTE

                    string connectionString = "Data Source=JAVIER;Initial Catalog=BDPaquito;Encrypt=False;Integrated Security=true";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = @"INSERT INTO usuarios (nombre, primer_apellido, segundo_apellido, dni, telefono, correo_electronico, id_rol) VALUES (@Nombre, @PrimerApellido, @SegundoApellido, @DNI, @Telefono, @CorreoElectronico, @Rol)";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@Nombre", textbox_nombre.Text);
                            command.Parameters.AddWithValue("@PrimerApellido", textbox_primerApellido.Text);
                            command.Parameters.AddWithValue("@SegundoApellido", textbox_segundoApellido.Text);
                            command.Parameters.AddWithValue("@DNI", textbox_dni.Text);
                            command.Parameters.AddWithValue("@Telefono", textbox_numeroTelefono.Text);
                            command.Parameters.AddWithValue("@CorreoElectronico", textbox_correoElectronico.Text);
                            command.Parameters.AddWithValue("@Rol", 2);

                            command.ExecuteNonQuery();
                            MessageBox.Show("Los datos del cliente se ha registrado correctamente");

                            Form_Login fl = new Form_Login();
                            fl.Show();
                            this.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El usuario ya existe. ");
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

        private void textbox_nombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
