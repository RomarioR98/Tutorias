using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Maestro
    {
        public Maestro()
        {
            Maestrosmateria = new HashSet<Maestrosmateria>();
            Usuarios = new HashSet<Usuarios>();
        }

        public string NumeroControl { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }

        public ICollection<Maestrosmateria> Maestrosmateria { get; set; }
        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
