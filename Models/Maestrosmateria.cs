using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Maestrosmateria
    {
        public int Id { get; set; }
        public string IdMateria { get; set; }
        public string IdMaestro { get; set; }

        public Maestro IdMaestroNavigation { get; set; }
        public Materia IdMateriaNavigation { get; set; }
    }
}
