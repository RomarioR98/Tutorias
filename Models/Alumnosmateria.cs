using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Alumnosmateria
    {
        public int Id { get; set; }
        public string IdMateria { get; set; }
        public string IdAlumno { get; set; }

        public Alumno IdAlumnoNavigation { get; set; }
        public Materia IdMateriaNavigation { get; set; }
    }
}
