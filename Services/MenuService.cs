using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Repositories;
using Tutorias.Models;

namespace Tutorias.Services
{
    public class MenuService
    {
        public IEnumerable<Semestre> GetSemestres()
        {
            tutoriasContext context = new tutoriasContext();
            return context.Semestre.Select(x => new Semestre { NoSem = x.NoSem, Id = x.Id }).OrderBy(x => x.NoSem);
        }

        public IEnumerable<Carrera> GetCarreras()
        {
            tutoriasContext context = new tutoriasContext();
            return context.Carrera.Select(x => new Carrera { Id = x.Id, Carrera1 = x.Carrera1 }).OrderBy(x => x.Carrera1);
        }
    }
}
