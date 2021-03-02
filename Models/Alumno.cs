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
        public string Nombre { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string Email { get; set; }
        public string Contraseña { get; set; }
        public int IdSemestre { get; set; }
        public int IdCarrera { get; set; }
<<<<<<< HEAD
        public string Rol { get; set; }
        public bool Activo { get; set; }
=======
        public int IdRol { get; set; }
>>>>>>> 43dc92d35bc61847e47e97ffd6f0ea0cd830e489

        public Carrera IdCarreraNavigation { get; set; }
        public Semestre IdSemestreNavigation { get; set; }
        public ICollection<Alumnosmateria> Alumnosmateria { get; set; }
    }
}
