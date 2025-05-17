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
    public partial class frmForo : Form
    {
        private static string nombreServidor = "JAIME\\SQLEXPRESS";
        private static string nombreBaseDatos = "BDSisEstudiantil";

        private string connectionString =
            $"Data Source={nombreServidor}; Initial Catalog={nombreBaseDatos}; Integrated Security=True";

        public frmForo()
        {
            InitializeComponent();
            lblCorreo.Text = ReconocimientoDeUsuario.CorreoElectronico;
            CenterToScreen();

            // Con esto se definen las columnas necesarias en el DataGridView dgvPregunta
            dgvPregunta.Columns.Add("PreguntaId", "ID de Pregunta");
            dgvPregunta.Columns.Add("UsuarioNombre", "Usuario");
            dgvPregunta.Columns.Add("Contenido", "Contenido");
            dgvPregunta.Columns.Add("FechaPublicacion", "Fecha de Publicación");

            // Lo mismo para el DataGridView dgvForo
            dgvForo.Columns.Add("FechaPublicacion", "Fecha de Publicación");
            dgvForo.Columns.Add("UsuarioNombre", "Usuario");
            dgvForo.Columns.Add("Contenido", "Contenido");

            // Con esto se asocia el evento SelectionChanged del DataGridView dgvPregunta
            dgvPregunta.SelectionChanged += dgvPregunta_SelectionChanged;
        }

        private void dgvPregunta_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvPregunta.SelectedRows.Count > 0)
            {
                int preguntaId = Convert.ToInt32(dgvPregunta.SelectedRows[0].Cells["PreguntaId"].Value);
                CargarComentariosDePreguntaDesdeBD(preguntaId, connectionString);
            }
        }


        private void linklblRegresar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBuscarConsulta ventanaBuscarConsulta = new frmBuscarConsulta();
            ventanaBuscarConsulta.Show();
            this.Hide();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            // Se obtiene el comentario del TextBox
            string comentario = txtComentario.Text;

            // Se obtiene el nombre de usuario del label lblCorreo
            string usuarioNombre = lblCorreo.Text;

            // Verificar si se ha seleccionado una pregunta en dgvPregunta
            if (dgvPregunta.SelectedRows.Count > 0)
            {
                // Aquí se obtiene el PreguntaId de la pregunta seleccionada
                int preguntaId = Convert.ToInt32(dgvPregunta.SelectedRows[0].Cells["PreguntaId"].Value);

                // Aquí se inserta el comentario en la base de datos
                if (InsertarComentarioEnBD(preguntaId, usuarioNombre, comentario, connectionString))
                {
                    // De esta manera se refresca el DataGridView dgvForo
                    CargarComentariosDePreguntaDesdeBD(preguntaId, connectionString);

                    // Aquí se limpia el TextBox después de enviar el comentario para que quede listo para realizar un nuevo comentario.
                    txtComentario.Text = "";
                    txtComentario.Focus();
                }
                else
                {
                    MessageBox.Show("Error al enviar el comentario.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una pregunta antes de enviar un comentario.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarComentariosDePreguntaDesdeBD(int preguntaId, string connectionString)
        {
            string query =
                "SELECT FechaPublicacion, UsuarioNombre, Contenido FROM ComentariosPreguntas WHERE PreguntaId = @PreguntaId";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PreguntaId", preguntaId);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    dgvForo.Rows.Clear(); // Limpiar las filas existentes en el DataGridView

                    while (reader.Read())
                    {
                        DateTime fechaPublicacion = Convert.ToDateTime(reader["FechaPublicacion"]);
                        string usuarioNombre = reader["UsuarioNombre"].ToString();
                        string contenido = reader["Contenido"].ToString();

                        dgvForo.Rows.Add(fechaPublicacion, usuarioNombre, contenido);
                    }
                }
            }
        }

        // Esto es un método para insertar un comentario en la base de datos
        public bool InsertarComentarioEnBD(int preguntaId, string usuarioNombre, string contenido,
            string connectionString)
        {
            // Se realiza la consulta SQL para insertar el comentario en la tabla ComentariosPreguntas
            string query =
                "INSERT INTO ComentariosPreguntas (PreguntaId, UsuarioNombre, Contenido, FechaPublicacion) VALUES (@PreguntaId, @UsuarioNombre, @Contenido, @FechaPublicacion)";

            // Se abre una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Se crea un comando SQL con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    //Parámetros
                    command.Parameters.AddWithValue("@PreguntaId", preguntaId);
                    command.Parameters.AddWithValue("@UsuarioNombre", usuarioNombre);
                    command.Parameters.AddWithValue("@Contenido", contenido);
                    command.Parameters.AddWithValue("@FechaPublicacion", DateTime.Now);

                    //Se abre otra conexión a la base de datos
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    //Con esto se espera retornar un verdadero si se insertó el comentario correctamente (esto solo en caso de que afectó por lo menos una fila)
                    return rowsAffected > 0;
                }
            }
        }

        // Esto es un m étodo para cargar la pregunta seleccionada desde la base de datos y mostrarla en el DataGridView dgvPregunta
        public void CargarPreguntaSeleccionadaDesdeBD(int preguntaId, string connectionString)
        {
            // Se hace la consulta SQL para obtener los datos de la pregunta seleccionada
            string query =
                "SELECT UsuarioNombre, Contenido, FechaPublicacion FROM Preguntas WHERE PreguntaId = @PreguntaId";

            // Se abre una conexión a la base de datos
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Se crea un comando SQL con la consulta y la conexión
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Se agrega el parámetro @PreguntaId a la consulta
                    command.Parameters.AddWithValue("@PreguntaId", preguntaId);
                    // Se abre la conexión
                    connection.Open();
                    // Se ejecuta la consulta y se obtiene un lector de datos
                    SqlDataReader reader = command.ExecuteReader();

                    // Se verifica si se encontraron datos
                    if (reader.Read())
                    {
                        // Aquí se obtinen los datos de la pregunta del lector de datos
                        string usuarioNombre = reader["UsuarioNombre"].ToString();
                        string contenido = reader["Contenido"].ToString();
                        DateTime fechaPublicacion = Convert.ToDateTime(reader["FechaPublicacion"]);

                        // Esto es para limpiar las filas existentes en el DataGridView
                        dgvPregunta.Rows.Clear();

                        // Acá se agrega la fila con los datos obtenidos de la base de datos
                        dgvPregunta.Rows.Add(preguntaId, usuarioNombre, contenido, fechaPublicacion);
                    }
                    else
                    {
                        // Se muestra un mensaje de error si no se encontró la pregunta
                        MessageBox.Show("No se encontró la pregunta en la base de datos.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

