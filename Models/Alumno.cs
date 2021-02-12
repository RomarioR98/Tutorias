using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Alumno
    {
        public Alumno()
        {
            Alumnosmateria = new HashSet<Alumnosmateria>();
        }

        public string NumeroControl { get; set; }
        public string Nombres { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int IdSemestre { get; set; }
        public int IdCarrera { get; set; }
        public int IdRol { get; set; }

        public Carrera IdCarreraNavigation { get; set; }
        public Roles IdRolNavigation { get; set; }
        public Semestre IdSemestreNavigation { get; set; }
        public ICollection<Alumnosmateria> Alumnosmateria { get; set; }
    }
}
