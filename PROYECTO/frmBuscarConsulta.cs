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
    public partial class frmBuscarConsulta : Form
    {
        // Conexión a la base de datos
        private static string nombreServidor = "JAIME\\SQLEXPRESS";
        private static string nombreBaseDatos = "BDSisEstudiantil";

        private string connectionString =
            $"Data Source={nombreServidor}; Initial Catalog={nombreBaseDatos}; Integrated Security=True";

        public frmBuscarConsulta()
        {
            InitializeComponent();
            CenterToScreen();
            lblCorreo.Text = ReconocimientoDeUsuario.CorreoElectronico;
            // Se suscribe el evento SelectedIndexChanged del ComboBox cbbCategoria
            cbbCategoria.SelectedIndexChanged += cbbCategoria_SelectedIndexChanged;

            // Se carga las categorías al ComboBox
            CargarCategorias();

        }

        // Método para cargar las categorías al ComboBox
        private void CargarCategorias()
        {
            try
            {
                // Esto establece la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Aquí se hace la consulta SQL para obtener las categorías
                    string query = "SELECT Nombre FROM Categorias";

                    // Crea el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Abre la conexión a la BD
                        connection.Open();

                        // Ejecuta el comando y se lee el resultado
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            // Se agrega cada categoría al ComboBox
                            cbbCategoria.Items.Add(reader["Nombre"].ToString());
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar las categorías: {ex.Message}", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cbbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Esto es par obtener la categoría que selecciona el usuario
            string categoriaSeleccionada = cbbCategoria.SelectedItem?.ToString();

            // Valida si se ha seleccionado una categoría
            if (!string.IsNullOrEmpty(categoriaSeleccionada))
            {
                try
                {
                    // Se establece la conexión a la base de datos
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        // Se realiza la consulta SQL para obtener los datos de la categoría seleccionada
                        string query = "SELECT PreguntaId, UsuarioNombre, Contenido, FechaPublicacion FROM Preguntas WHERE CategoriaId = @CategoriaId";

                        // Habilita el comando SQL
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Con esto se obtiene el Id de la categoría seleccionada
                            int categoriaId = ObtenerCategoriaId(categoriaSeleccionada);

                            // Aqui se agrega el parámetro para la consulta
                            command.Parameters.AddWithValue("@CategoriaId", categoriaId);

                            // Abre la conexión a la BD
                            connection.Open();

                            // Se ejecuta el comando y obtienen los datos en un DataTable para mostrar en el DataGridView
                            SqlDataAdapter adapter = new SqlDataAdapter(command);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            // Se asignan los datos al DataGridView dgvBuscar
                            dgvBuscar.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        // Esto es un método para obtener el Id de la categoría seleccionada
        private int ObtenerCategoriaId(string categoria)
        {
            int categoriaId = 0;
            try
            {
                // Establecer la conexión a la base de datos
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Construir la consulta SQL para obtener el Id de la categoría
                    string query = "SELECT CategoriaId FROM Categorias WHERE Nombre = @Nombre";

                    // Crear el comando SQL
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Agregar el parámetro para la consulta
                        command.Parameters.AddWithValue("@Nombre", categoria);

                        // Abrir la conexión
                        connection.Open();

                        // Ejecutar el comando y leer el resultado
                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            categoriaId = Convert.ToInt32(reader["CategoriaId"]);
                        }
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener el Id de la categoría: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return categoriaId;
        }




        private void btnSalirBC_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIrAForo_Click(object sender, EventArgs e)
        {
            if (dgvBuscar.SelectedRows.Count > 0)
            {
                // Obtener el Id de la pregunta seleccionada en dgvBuscar
                int preguntaId = Convert.ToInt32(dgvBuscar.SelectedRows[0].Cells["PreguntaId"].Value);

                // Crear una instancia de frmForo
                frmForo foro = new frmForo();

                // Llamar al método para cargar la pregunta seleccionada desde la base de datos
                foro.CargarPreguntaSeleccionadaDesdeBD(preguntaId, connectionString);

                // Mostrar el formulario frmForo
                foro.Show();
                this.Hide();    
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una pregunta antes de ir al foro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegresar90_Click(object sender, EventArgs e)
        {
            frmMenuForo ventanaMenuForo = new frmMenuForo();
            ventanaMenuForo.Show();
            this.Hide();
        }
    }
}
