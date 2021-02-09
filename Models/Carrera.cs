using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Carrera
    {
        public Carrera()
        {
            Alumno = new HashSet<Alumno>();
        }

        public int Id { get; set; }
        public string Carrera1 { get; set; }

        public ICollection<Alumno> Alumno { get; set; }
    }
}
