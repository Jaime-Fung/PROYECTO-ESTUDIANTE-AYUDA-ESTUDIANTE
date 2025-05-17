using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PROYECTO
{
    public class Persona
    {

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string Genero { get; set; }
        public int Edad { get; set; }
        public string Identificacion { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefonico { get; set; }
        public string Direccion { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string PaisNacimiento { get; set; }

        public bool GeneroMasculino { get; set; }
        public bool GeneroFemenino { get; set; }
        public bool GeneroOtro { get; set; }

    }
}
