using System;
using System.Collections.Generic;

namespace Tutorias.Models
{
    public partial class Roles
    {
        public Roles()
        {
            Usuarios = new HashSet<Usuarios>();
        }

        public int Id { get; set; }
        public string Rol { get; set; }

        public ICollection<Usuarios> Usuarios { get; set; }
    }
}
