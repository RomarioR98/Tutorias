using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Tutorias.Models
{
    public class MaestroViewModel
    {
        public string NumeroControl { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }
    }
}
