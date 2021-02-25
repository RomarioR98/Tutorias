using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Maestro
    {
        public Maestro()
        {
            Maestrosmateria = new HashSet<Maestrosmateria>();
        }

        public string NumeroControl { get; set; }
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public string Rol { get; set; }
        public bool Activo { get; set; }

        public ICollection<Maestrosmateria> Maestrosmateria { get; set; }
    }
}
