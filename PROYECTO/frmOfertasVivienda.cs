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

namespace PROYECTO
{
    public partial class frmOfertasVivienda : Form
    {
        public frmOfertasVivienda()
        {
            InitializeComponent(); // Inicia el form
            CenterToScreen(); // Centra la ventana
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
            frmMenuBienesRaices ventana = new frmMenuBienesRaices();
            ventana.Show();
        }

        private void btnVerOfertas_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos
            string connectionString = "SERVER=JAIME\\SQLEXPRESS;Integrated Security=true;database=BDSisEstudiantil";

            // Consulta SQL para seleccionar los datos del Agente de Bienes Raíces por correo electrónico
            string query = "SELECT * FROM AgenteBienesRaices";

            // Se crea una conexión a la base de datos
            using SqlConnection connection = new SqlConnection(connectionString);

            // Se crea un comando SQL con la consulta y la conexión
            using SqlCommand command = new SqlCommand(query, connection);


            try
            {

                connection.Open();

                // Esto es para crear un adaptador de datos para ejecutar la consulta y llenar un DataTable
                using SqlDataAdapter adapter = new SqlDataAdapter(command);

                // Aquí se crea un DataTable para almacenar los resultados de la consulta
                DataTable dataTable = new DataTable();

                // Con esto se llena el DataTable con los resultados de la consulta
                adapter.Fill(dataTable);

                // Aquí se asigna el DataTable como origen de datos del DataGridView 
                dgvOfertasVivienda.DataSource = dataTable;
            }
            catch (SqlException ex)
            {

                MessageBox.Show("No se puede realizar la consulta." + ex.Message);
            }
        }

        private void btnSalir800_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Cierra la aplicacion
        }

        private void btnVerFotos_Click(object sender, EventArgs e)
        {
            // Con esto se verifica si se ha seleccionado una fila
            if (dgvOfertasVivienda.SelectedRows.Count > 0)
            {
                // Aquí se obtiene el identificador único de la fila seleccionada
                int idFila = (int)dgvOfertasVivienda.SelectedRows[0].Cells["IdAgenteBienesRaices"].Value;

                // Se realiza una consulta a la base de datos para obtener las imágenes relacionadas con el identificador único
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
                                // Se verifica si las imágenes no son nulas antes de convertirlas
                                List<byte[]> imagenes = new List<byte[]>();
                                for (int i = 1; i <= 4; i++)
                                {
                                    if (!reader.IsDBNull(reader.GetOrdinal("Imagen" + i)))
                                    {
                                        byte[] imagen = (byte[])reader["Imagen" + i];
                                        imagenes.Add(imagen);
                                    }
                                }

                                // Se muestran las imágenes en el formulario frmVerFotos
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
    }
}
    
  

        
    

