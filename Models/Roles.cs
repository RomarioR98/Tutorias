using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Alumno = new HashSet<Alumno>();
            Maestro = new HashSet<Maestro>();
        }

        public int Id { get; set; }
        public string Rol { get; set; }

        public ICollection<Alumno> Alumno { get; set; }
        public ICollection<Maestro> Maestro { get; set; }
    }
}
