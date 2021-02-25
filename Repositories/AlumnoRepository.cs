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




        public void InsertAlumno(AlumnoViewModel alumno)
        {
            string error = Validar(alumno);

            if (error != "")
                throw new ArgumentException(error);

            //Verifica si el alumno tiene una cuenta activa
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Nombre == alumno.Nombre && x.ApPaterno == alumno.ApPaterno
         && x.ApMaterno == alumno.ApMaterno && x.Email == alumno.Email && x.Activo == true))
                throw new ArgumentException("El alumno ya ha sido registrado");
            //Verifica si el numero de control se esta utilizando por un usuario activo
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Activo==true ))
                throw new ArgumentException("El numero de control ya ha sido registrado");
            //Verifica si el email se esta utilizando por un usuario activo
            if (GetAll().Any(x => x.Email == alumno.Email && x.Activo==true))
                throw new ArgumentException("El email ya ha sido registrado");

            //Si el alumno ya ha se a registrado y se dio de baja lo activa y actualiza datos
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Nombre == alumno.Nombre && x.ApPaterno == alumno.ApPaterno
                    && x.ApMaterno == alumno.ApMaterno && x.Email == alumno.Email && x.Activo == false))
            {
                var alumnoBD = GetById(alumno.NumeroControl);

                alumnoBD.Activo = true;
                alumnoBD.Contraseña = alumno.Contraseña;
                alumnoBD.IdSemestre = alumno.IdSemestre;
                alumnoBD.IdCarrera = alumno.IdCarrera;
                Update(alumnoBD);

            }
            //Si es nuevo lo agrega
            else
            {

                Alumno alum = new Alumno()
                {
                    NumeroControl = alumno.NumeroControl.ToUpper(),
                    Nombre = alumno.Nombre,
                    ApPaterno = alumno.ApPaterno,
                    ApMaterno = alumno.ApMaterno,
                    Email = alumno.Email,
                    Contraseña =alumno.Contraseña, //Encrypt.GetMD5(alumno.Contraseña),
                    IdSemestre = alumno.IdSemestre,
                    IdCarrera = alumno.IdCarrera,
                    Rol = "Alumno",
                    Activo = true

                };
                Insert(alum);
            }
        }

        public void UpdateAlumno(AlumnoViewModel alumno)
        {
            if (GetById(alumno.NumeroControl).NumeroControl == alumno.NumeroControl.ToUpper())
                return;

            string error = Validar(alumno);

            if (error != "")
                throw new ApplicationException(error);

            if (GetAll().Any(x => x.Email == alumno.Email && x.Activo == true))
                throw new ArgumentException("El email ya ha sido registrado");

            var alumnoBD = GetById(alumno.NumeroControl);

            alumnoBD.Nombre = alumno.Nombre;
            alumnoBD.ApPaterno = alumno.ApPaterno;
            alumnoBD.ApMaterno = alumno.ApMaterno;
            alumnoBD.Email = alumno.Email;
            alumnoBD.Contraseña = alumno.Contraseña; /*Encrypt.GetMD5(alumno.Contraseña);*/
            alumnoBD.IdSemestre = alumno.IdSemestre;
            alumnoBD.IdCarrera = alumno.IdCarrera;

            Update(alumnoBD);


        }

        //Baja logica
        //public void DeleteAlumno(int Id)
        //{
        //    var alumD = GetById(Id);

        //    if (alumD != null)
        //    {
        //        alumD.Activo = false;
        //        Update(alumD);
        //    }

        //}

        string Validar(AlumnoViewModel alumno)
        { 
            if (string.IsNullOrEmpty(alumno.NumeroControl))
                return "Proporcione su numero de control";
            if ((alumno.NumeroControl).Length != 8)
                return "Verifique su numero de control";
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
            if (alumno.IdSemestre == 0)
                return "Proporcione su semestre";
            if (alumno.IdCarrera == 0)
                return "Proporcione su carrera";

            return "";

        }
}
}
