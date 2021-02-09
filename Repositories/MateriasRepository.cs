using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tutorias.Areas.Maestro;
using Tutorias.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Tutorias.Repositories
{
    public class MateriasRepository : Repository<Materia>
    {
        public IEnumerable<Materia> GetMaterias()
        {
            return Context.Materia.Select(x => new Materia
            {
                Clave = x.Clave,
                Materia1 = x.Materia1,
            }).OrderBy(x => x.Materia1);
        }
        public IEnumerable<Materia> GetMateriasByMaestro(string id)
        {
            return Context.Materia.Where(x => x.Maestrosmateria.Select(y => y.IdMaestroNavigation.NumeroControl).ToString() == id).Select(x => new Materia
            {
                Clave = x.Clave,
                Materia1 = x.Materia1,
            }).ToList().OrderBy(x => x.Materia1);
        }
    }
}
