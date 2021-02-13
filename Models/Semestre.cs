using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Semestre
    {
        public Semestre()
        {
            Alumno = new HashSet<Alumno>();
            Materia = new HashSet<Materia>();
        }

        public int Id { get; set; }
        public int NoSem { get; set; }

        public ICollection<Alumno> Alumno { get; set; }
        public ICollection<Materia> Materia { get; set; }
    }
}
