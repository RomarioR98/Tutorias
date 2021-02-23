using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tutorias.Models
{
    public class AlumnosMateriaViewModel
    {
        public int Id { get; set; }
        public string IdMateria { get; set; }
        public string IdAlumno { get; set; }

        public Materia IdMateriaNavigation { get; set; }
    }
}
