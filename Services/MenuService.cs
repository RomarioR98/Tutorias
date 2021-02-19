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



        public IEnumerable<Materia> GetMateriasbySemestre(int semestre)
        {
            tutoriasContext context = new tutoriasContext();
            return context.Materia.Where(x => x.IdSemestreNavigation.NoSem == semestre)
                .Select(x => new Materia
                {
                    Clave = x.Clave,
                    Materia1 = x.Materia1

                });


        }
        public IEnumerable<Alumnosmateria> GetAlumnosMateriaById(string Id)
        {
            tutoriasContext context = new tutoriasContext();
            return context.Alumnosmateria.Where(x => x.IdAlumno == Id).Select(
                x => new Alumnosmateria
                {
                    Id = x.Id,
                    IdMateria = x.IdMateria

                });
        }
    }
}
