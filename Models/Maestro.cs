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
<<<<<<< HEAD
        public string Rol { get; set; }
        public bool Activo { get; set; }
=======
        public int IdRol { get; set; }
>>>>>>> 43dc92d35bc61847e47e97ffd6f0ea0cd830e489

        public ICollection<Maestrosmateria> Maestrosmateria { get; set; }
    }
}
