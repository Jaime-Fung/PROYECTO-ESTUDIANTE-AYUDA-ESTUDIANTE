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
    public partial class frmAgenteBienesRaices : Form
    {




        public frmAgenteBienesRaices()
        {
            InitializeComponent();
            CenterToScreen();
            lblCorreo.Text = ReconocimientoDeUsuario.CorreoElectronico;
        }

        private void btnAgregarOferta_Click(object sender, EventArgs e)
        {
            frmAgregarOferta ventana = new frmAgregarOferta();
            ventana.Show();
            this.Close();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmVentanaPrincipal ventana = new frmVentanaPrincipal();
            ventana.Show();
            this.Close();
        }

        private void btnActualizarListado_Click(object sender, EventArgs e)
        {
            // Esta es la cadena de conexión a la base de datos
            string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";

            // Acá se realiza la consulta SQL para seleccionar los datos del Agente de Bienes Raíces por correo electrónico
            string query = "SELECT IdAgenteBienesRaices,TipoAlquiler, Area, TipoMoneda, PrecioMensual, Provincia, Canton, DescripcionInmueble, ServiciosIncluidos, DireccionInmueble, Correo, Telefono, Imagen1, Imagen2, Imagen3, Imagen4 FROM AgenteBienesRaices WHERE Correo = @Correo";

            // Con esto se crea una conexión a la base de datos
            using SqlConnection connection = new SqlConnection(connectionString);

            // Aquí se crea un comando SQL con la consulta y la conexión
            using SqlCommand command = new SqlCommand(query, connection);

            // Parámetro @Correo
            command.Parameters.AddWithValue("@Correo", lblCorreo.Text);

            try
            {
                // Se abre la conexión
                connection.Open();

                // Se crear un adaptador de datos para ejecutar la consulta y llenar un DataTable
                using SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Se crea un DataTable para almacenar los resultados de la consulta
                DataTable dataTable = new DataTable();

                // Con esto se llena el DataTable con los resultados de la consulta
                adapter.Fill(dataTable);

                // Aquí se asigna el DataTable como origen de datos del DataGridView
                dgvAgenteBR.DataSource = dataTable;

                // Se "recorre la lista" sobre cada fila del DataGridView para cargar las imágenes
                foreach (DataGridViewRow row in dgvAgenteBR.Rows)
                {
                    for (int i = 1; i <= 4; i++)
                    {
                        // Con esto se obtiene el valor de la columna de cada imagen
                        byte[] imagenBytes = row.Cells["Imagen" + i].Value as byte[];

                        // Aquí se verifica si la columna de imagen tiene datos
                        if (imagenBytes != null && imagenBytes.Length > 0)
                        {
                            // Con esto se convierten los bytes de la imagen a un objeto Image
                            using (var ms = new System.IO.MemoryStream(imagenBytes))
                            {
                                Image imagen = Image.FromStream(ms);

                                // Asignar la imagen a la celda correspondiente del DataGridView
                                row.Cells["Imagen" + i].Value = imagen;
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {

                MessageBox.Show("No se puede realizar la consulta." + ex.Message);
            }
        }

        private void btnEliminarOferta_Click(object sender, EventArgs e)
        {
            if (dgvAgenteBR.SelectedRows.Count > 0)
            {
                var valorClave = dgvAgenteBR.SelectedRows[0].Cells["IdAgenteBienesRaices"].Value;

                string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";
                string query = "DELETE FROM AgenteBienesRaices WHERE IdAgenteBienesRaices = @IdAgenteBienesRaices";

                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta oferta?", "Confirmación de eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Verificar la respuesta del usuario
                if (result == DialogResult.Yes)
                {

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IdAgenteBienesRaices", valorClave);

                            try
                            {
                                connection.Open();
                                int filasAfectadas = command.ExecuteNonQuery();
                                if (filasAfectadas > 0)
                                {
                                    btnActualizarListado_Click(null, EventArgs.Empty);
                                }
                                else
                                {
                                    MessageBox.Show("No se encontró ninguna oferta para eliminar.");
                                }
                            }
                            catch (SqlException ex)
                            {
                                MessageBox.Show("Error de SQL: " + ex.Message);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una oferta para eliminar.");
            }
        }


        private void btnVerFotos_Click(object sender, EventArgs e)
        {
            // Esto es para verificar si se ha seleccionado una fila
            if (dgvAgenteBR.SelectedRows.Count > 0)
            {
                // Aquí se bbtiene el identificador único de la fila seleccionada
                int idFila = (int)dgvAgenteBR.SelectedRows[0].Cells["IdAgenteBienesRaices"].Value;

                // Con esto se realiza una consulta a la base de datos para obtener las imágenes relacionadas con el identificador único
                string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";
                string query = "SELECT Imagen1, Imagen2, Imagen3, Imagen4 FROM AgenteBienesRaices WHERE IdAgenteBienesRaices = @IdAgenteBienesRaices";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IdAgenteBienesRaices", idFila);

                        try
                        {
                            connection.Open();
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                // Aquí se verifica si las imágenes no son nulas antes de convertirlas
                                List<byte[]> imagenes = new List<byte[]>();
                                for (int i = 1; i <= 4; i++)
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("Imagen" + i)))
                                    {
                                        byte[] imagen = (byte[])reader["Imagen" + i];
                                        imagenes.Add(imagen);
                                    }
                                }

                                // Con esto se muestran las imágenes en un formulario específico
                                if (imagenes.Count > 0)
                                {
                                    frmVerFotos mostrarImagenesForm = new frmVerFotos(imagenes[0], imagenes.ElementAtOrDefault(1), imagenes.ElementAtOrDefault(2), imagenes.ElementAtOrDefault(3));
                                    mostrarImagenesForm.ShowDialog();
                                }
                                else
                                {
                                    MessageBox.Show("No se encontraron imágenes para esta oferta.");
                                }
                            }
                            else
                            {
                                MessageBox.Show("No se encontraron imágenes para esta oferta.");
                            }
                        }
                        catch (SqlException ex)
                        {
                            MessageBox.Show("Error de SQL: " + ex.Message);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para consultar las imágenes.");
            }
        }

        private void btnSalirABR_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



