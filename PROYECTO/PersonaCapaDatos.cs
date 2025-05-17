using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PROYECTO
{
    public class PersonaCapaDatos
    {


        private static string nombreServidor = "JAIME\\SQLEXPRESS";
        private static string nombreBaseDatos = "BDSisEstudiantil";
        private static string usuarioBaseDatos = "";
        private static string contrasennaBaseDatos = "";
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};Integrated Security=True;";

        public int ConsultarIdNuevaPersona()
        {
            int maxId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT MAX(Id) FROM Persona";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        maxId = Convert.ToInt32(result);
                        maxId++;
                    }
                }
            }
            return maxId;
        }
        public bool ConsultarIdExistente(int Id)
        {
            bool existe = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT COUNT(*) FROM Usuario WHERE IdUsuario = @IdUsuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", Id);
                    connection.Open();

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    existe = count > 0;
                }
            }

            return existe;
        }
        public void RegistrarsePersona(Usuario usuario)
        {

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Persona ( Id, Identificacion, Nombre, PrimerApellido, SegundoApellido, NumeroTelefonico, Direccion, FechaNacimiento, PaisNacimiento, GeneroMasculino, GeneroFemenino, GeneroOtro ) VALUES (@Id, @Identificacion, @Nombre, @PrimerApellido, @SegundoApellido, @Numerotelefonico, @Direccion, @FechaNacimiento,  @PaisNacimiento, @GeneroMasculino, @GeneroFemenino, @GeneroOtro)";


            using (SqlCommand command = new SqlCommand(query, connection))
            {






                command.Parameters.AddWithValue("@Id", usuario.Id);
                command.Parameters.AddWithValue("@Identificacion", usuario.Identificacion);
                command.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                command.Parameters.AddWithValue("@PrimerApellido", usuario.PrimerApellido);
                command.Parameters.AddWithValue("@SegundoApellido", usuario.SegundoApellido);
                command.Parameters.AddWithValue("@NumeroTelefonico", usuario.NumeroTelefonico);
                command.Parameters.AddWithValue("@Direccion", usuario.Direccion);
                command.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                command.Parameters.AddWithValue("@PaisNacimiento", usuario.PaisNacimiento);
                command.Parameters.AddWithValue("@GeneroMasculino", usuario.GeneroMasculino);
                command.Parameters.AddWithValue("@GeneroFemenino", usuario.GeneroFemenino);
                command.Parameters.AddWithValue("@GeneroOtro", usuario.GeneroOtro);




                connection.Open();

                int columnasModificadas = command.ExecuteNonQuery();


                // Verificar si se registraron los datos
                if (columnasModificadas > 0)
                {
                    MessageBox.Show("Los datos se registraron correctamente.");
                    return;
                }
                else
                {
                    MessageBox.Show("No se pudieron registrar los datos.");
                }

            }







        }
    }
}
