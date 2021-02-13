using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Repositories;
using Tutorias.Models;

namespace Tutorias.Repositories
{
    public class AlumnoRepository : Repository<Alumno>
    {
        public void InsertAlumno(AlumnoViewModel alumno)
        {
            string error = Validar(alumno);

            if (error != "")
                throw new ArgumentException(error);

            Alumno alum = new Alumno()
            {
                NumeroControl = alumno.NumeroControl,
                Nombre = alumno.Nombres,
                ApPaterno = alumno.ApPaterno,
                ApMaterno = alumno.ApMaterno,
                Email = alumno.Email,
                Contraseña = alumno.Contraseña,
                IdSemestre = alumno.IdSemestre,
                IdCarrera = alumno.IdCarrera
                //IdRol = alumno.IdRol
            };
            Insert(alum);
        }

        string Validar (AlumnoViewModel alumno)
        {
            if (string.IsNullOrEmpty(alumno.NumeroControl))
                return "Proporcione su numero de control";

            if (string.IsNullOrEmpty(alumno.Nombre))
                return "Proporcione su nombre";
            if (string.IsNullOrEmpty(alumno.ApPaterno))
                return "Proporcione su apellido paterno";
            if (string.IsNullOrEmpty(alumno.ApMaterno))
                return "Proporcione su apellido materno";
            if (string.IsNullOrEmpty(alumno.Email))
                return "Proporcione su email";
            if (string.IsNullOrEmpty(alumno.Contraseña))
                return "Proporcione su contraseña";
            if (alumno.IdSemestre==0)
                return "Proporcione su semestre";
            if (alumno.IdCarrera==0)
                return "Proporcione su carrera";

            return "";

        }
    }
}
