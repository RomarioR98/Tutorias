using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Usuarios
    {
        public int Id { get; set; }
        public string NumeroControl { get; set; }
        public string Contraseña { get; set; }
        public int Rol { get; set; }

        public Maestro NumeroControl1 { get; set; }
        public Alumno NumeroControlNavigation { get; set; }
        public Roles RolNavigation { get; set; }
    }
}
