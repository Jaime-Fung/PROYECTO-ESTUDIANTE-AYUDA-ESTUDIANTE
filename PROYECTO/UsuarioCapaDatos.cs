using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO
{
    public class UsuarioCapaDatos
    {
        private static string nombreServidor = "JAIME\\SQLEXPRESS";
        private static string nombreBaseDatos = "BDSisEstudiantil";
        private static string usuarioBaseDatos = "";
        private static string contrasennaBaseDatos = "";
        private string connectionString = $"Data Source={nombreServidor};Initial Catalog={nombreBaseDatos};Integrated Security=True;";



        public int ConsultarIdNuevoUsuario()
        {
            PersonaCapaDatos cdPersona = new PersonaCapaDatos();
            return cdPersona.ConsultarIdNuevaPersona();
        }
        


        public void RegistrarseUsuario(Usuario usuario)
        {
            PersonaCapaDatos cdPersona = new PersonaCapaDatos();
            cdPersona.RegistrarsePersona(usuario);

            SqlConnection connection = new SqlConnection(connectionString);



            string query = "INSERT INTO Usuario (IdUsuario, RolEstudiante,CorreoElectronico, Contrasenna, PIN) VALUES (@IdUsuario ,@RolEstudiante, @CorreoElectronico, @Contrasenna, @PIN)";


            using (SqlCommand command = new SqlCommand(query, connection))
            {



                command.Parameters.AddWithValue("@IdUsuario", usuario.Id);
                command.Parameters.AddWithValue("@RolEstudiante", usuario.RolEstudiante);
                
               
                command.Parameters.AddWithValue("@RolAgenteBienesRaices", usuario.RolAgenteBienesRaices);
                command.Parameters.AddWithValue("@CorreoElectronico", usuario.CorreoElectronico);
                command.Parameters.AddWithValue("@Contrasenna", usuario.Contrasenna);
                command.Parameters.AddWithValue("@PIN" , usuario.PIN);
                



                connection.Open();
                command.ExecuteNonQuery();







            }


        }
    }
}
