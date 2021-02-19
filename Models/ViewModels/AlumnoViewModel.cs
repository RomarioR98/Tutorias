using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tutorias.Models
{
    public class AlumnoViewModel
    {

        public string NumeroControl { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int IdSemestre { get; set; }
        public int IdCarrera { get; set; }
        public int IdRol { get; set; }
        public bool Activo { get; set; }
    }
}
