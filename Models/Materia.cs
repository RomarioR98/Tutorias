using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Materia
    {
        public Materia()
        {
            Alumnosmateria = new HashSet<Alumnosmateria>();
            Maestrosmateria = new HashSet<Maestrosmateria>();
        }

        public string Clave { get; set; }
        public string Materia1 { get; set; }
        public int IdSemestre { get; set; }
        public bool Activo { get; set; }

        public Semestre IdSemestreNavigation { get; set; }
        public ICollection<Alumnosmateria> Alumnosmateria { get; set; }
        public ICollection<Maestrosmateria> Maestrosmateria { get; set; }
    }
}
