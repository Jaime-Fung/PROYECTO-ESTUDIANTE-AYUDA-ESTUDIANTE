using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.Cache;

namespace PROYECTO
{
    public partial class frmFormularConsulta : Form
    {
        // Parametros para establecer la conexión a la base de datos
        private static string nombreServidor = "JAIME\\SQLEXPRESS";
        private static string nombreBaseDatos = "BDSisEstudiantil";
        private string connectionString = $"Data Source={nombreServidor}; Initial Catalog={nombreBaseDatos}; Integrated Security=True";

        public frmFormularConsulta()
        {
            InitializeComponent();
            CenterToScreen();

            // Con esto se cargan las categorías desde la base de datos
            CargarCategorias();
            lblCorreo.Text = ReconocimientoDeUsuario.CorreoElectronico;
        }

        private void CargarCategorias()
        {
            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Se realiza la consulta SQL para obtener las categorías
                    string query = "SELECT Nombre FROM Categorias";

                    // Se ejecuta la "sentencia" de comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Se abre la conexión
                        connection.Open();

                        // Se ejecuta el comando y se leen los resultados
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Esto es una lista para almacenar las categorías
                            List<string> categorias = new List<string>();

                            // Aquí se leen las categorías y se agregan a la lista
                            while (reader.Read())
                            {
                                categorias.Add(reader["Nombre"].ToString());
                            }

                            // Con esto se agregan las categorías al ComboBox
                            cbbCategoria.Items.AddRange(categorias.ToArray());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cbbCategoria.SelectedIndex = -1;
            txtConsulta.Clear();
            txtConsulta.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            // Verificar si se ha seleccionado una categoría
            if (cbbCategoria.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una categoría.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verificar si se ha ingresado una consulta
            if (string.IsNullOrEmpty(txtConsulta.Text))
            {
                MessageBox.Show("Por favor, ingrese una consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Esto es para obtener el nombre de usuario del label lblCorreo
            string usuarioNombre = lblCorreo.Text;

            // Esto es para obtener el contenido de la consulta del TextBox txtConsulta
            string contenido = txtConsulta.Text;

            // Esto es para obtener la fecha y hora actual
            DateTime fechaPublicacion = DateTime.Now;

            // Esto es para obtener el identificador de la categoría seleccionada en el ComboBox cbbCategoria
            string categoriaSeleccionada = cbbCategoria.SelectedItem.ToString();
            int categoriaId = ObtenerCategoriaId(categoriaSeleccionada);

            try
            {
                // Aquí se establece la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Se genera la consulta SQL para insertar la nueva pregunta en la tabla Preguntas
                    string query = "INSERT INTO Preguntas (UsuarioNombre, CategoriaId, Contenido, FechaPublicacion) VALUES (@UsuarioNombre, @CategoriaId, @Contenido, @FechaPublicacion)";

                    // Comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetros para la consulta
                        command.Parameters.AddWithValue("@UsuarioNombre", usuarioNombre);
                        command.Parameters.AddWithValue("@CategoriaId", categoriaId);
                        command.Parameters.AddWithValue("@Contenido", contenido);
                        command.Parameters.AddWithValue("@FechaPublicacion", fechaPublicacion);

                        // Se vuelve a abrir la conexión
                        connection.Open();

                        // Se ejecuta el comando
                        int filasAfectadas = command.ExecuteNonQuery();

                        // Verificar si se insertaron filas correctamente
                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("La consulta se registró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            frmBuscarConsulta ventana = new frmBuscarConsulta();
                            ventana.Show();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar la consulta.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al consultar: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Esto es un método para obtener el identificador de la categoría seleccionada
        private int ObtenerCategoriaId(string categoriaSeleccionada)
        {
            // Aquí se define el identificador de la categoría
            int categoriaId = -1;

            try
            {
                // Se establece la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Se realiza la consulta SQL para obtener el Id de la categoría
                    string query = "SELECT CategoriaId FROM Categorias WHERE Nombre = @Nombre";

                    // Comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Parámetro único para la consulta
                        command.Parameters.AddWithValue("@Nombre", categoriaSeleccionada);

                        // Aquí se abre la conexión
                        connection.Open();

                        // Se ejecuta la consulta y se obtiene el resultado
                        object result = command.ExecuteScalar();

                        // Con esto se verifica si se obtuvo un resultado
                        if (result != null && result != DBNull.Value)
                        {
                            // Con esto se convierte el resultado a entero (CategoriaId)
                            categoriaId = Convert.ToInt32(result);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el Id de la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return categoriaId;
        }

        private void btnRegresar23_Click(object sender, EventArgs e)
        {
            frmMenuForo ventanaMenuForo = new frmMenuForo();
            ventanaMenuForo.Show();
            this.Hide();    

        }
    }
}

    

    
