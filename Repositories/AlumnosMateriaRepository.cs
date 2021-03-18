using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Models;

namespace Tutorias.Repositories
{
    public class AlumnosMateriaRepository : Repository<Alumnosmateria>
    {
        public void  InsertAlumnosMateria(AlumnosMateriaViewModel vm)
        {
      
            Alumnosmateria alumM = new Alumnosmateria()
            {
                IdAlumno = vm.IdAlumno,
                IdMateria = vm.IdMateria
            };
            Insert(alumM);

        }
    }
}
