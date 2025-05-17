using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO
{
    public class Usuario : Persona
    {
        
        public string Contrasenna { get; set; }
     
        public bool Activo { get; set; }
        public bool RolEstudiante { get; set; }
        
        
        public bool RolAgenteBienesRaices { get; set; }

        public byte FotoPerfil { get; set; }
        public string PIN { get; set; }
        public Usuario()
        {


        }
        public Usuario(int id, string identificacion, string nombre, string primerApellido, string segundoApellido, int edad, string correoElectronico, string numeroTelefonico, string direccion, DateTime fechaNacimiento, string paisNacimiento, bool rolEstudiante, bool activo, bool rolAgenteBienesRaices, bool generoMasculino, bool generoFemenino, bool generoOtro, string contrasenna, byte fotoPerfil, string pin)
        {
            Id = id;
            Identificacion = identificacion;
            Nombre = nombre;
            PrimerApellido = primerApellido;
            SegundoApellido = segundoApellido;
            Edad = edad;
            CorreoElectronico = correoElectronico;
            NumeroTelefonico = numeroTelefonico;
            Direccion = direccion;
            FechaNacimiento = fechaNacimiento;
            PaisNacimiento = paisNacimiento;
            RolEstudiante = rolEstudiante;
            Activo = activo;
            RolAgenteBienesRaices = rolAgenteBienesRaices;
            GeneroMasculino = generoMasculino;
            GeneroFemenino = generoFemenino;
            GeneroOtro = generoOtro;
            Contrasenna = contrasenna;
            FotoPerfil = fotoPerfil;
            PIN = pin;


        }
    }
}
