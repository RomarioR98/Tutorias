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

            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl))
                throw new ArgumentException("El numero de control ya ha sido registrado");
            if (GetAll().Any(x => x.Email == alumno.Email))
                throw new ArgumentException("El email ya ha sido registrado");

            Alumno alum = new Alumno()
            {
                NumeroControl = alumno.NumeroControl.ToLower(),
                Nombres = alumno.Nombres,
                ApPaterno = alumno.ApPaterno,
                ApMaterno = alumno.ApMaterno,
                Email = alumno.Email,
                Contraseña = Encrypt.GetMD5(alumno.Contraseña),
                IdSemestre = alumno.IdSemestre,
                IdCarrera = alumno.IdCarrera,
                IdRol = 1
            };
            Insert(alum);
        }

        public void UpdateAlumno(AlumnoViewModel alumno)
        {
            if (GetById(alumno.NumeroControl).NumeroControl == alumno.NumeroControl.ToLower())
                return;

            string error = Validar(alumno);

            if (error != "")
                throw new ApplicationException(error);

            if (GetAll().Any(x=>x.Email==alumno.Email))
                throw new ArgumentException("El email ya ha sido registrado");

            var alumnoBD = GetById(alumno.NumeroControl);

            alumnoBD.Nombres = alumno.Nombres;
            alumnoBD.ApPaterno = alumno.ApPaterno;
            alumnoBD.ApMaterno = alumno.ApMaterno;
            alumnoBD.Email = alumno.Email;
            alumnoBD.Contraseña = Encrypt.GetMD5(alumno.Contraseña);
            alumnoBD.IdSemestre = alumno.IdSemestre;
            alumnoBD.IdCarrera = alumno.IdCarrera;

            Update(alumnoBD);


        }


        string Validar(AlumnoViewModel alumno)
        {
            if (string.IsNullOrEmpty(alumno.NumeroControl))
                return "Proporcione su numero de control";
            if (string.IsNullOrEmpty(alumno.Nombres))
                return "Proporcione su nombre";
            if (string.IsNullOrEmpty(alumno.ApPaterno))
                return "Proporcione su apellido paterno";
            if (string.IsNullOrEmpty(alumno.ApMaterno))
                return "Proporcione su apellido materno";
            if (string.IsNullOrEmpty(alumno.Email))
                return "Proporcione su email";
            if (string.IsNullOrEmpty(alumno.Contraseña))
                return "Proporcione su contraseña";
            if (alumno.IdSemestre == 0)
                return "Proporcione su semestre";
            if (alumno.IdCarrera == 0)
                return "Proporcione su carrera";

            return "";

        }
    }
}
