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

            //Verifica si el alumno tiene una cuenta activa
<<<<<<< HEAD
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Nombre == alumno.Nombre && x.ApPaterno == alumno.ApPaterno
         && x.ApMaterno == alumno.ApMaterno && x.Email == alumno.Email && x.Activo == true))
=======
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Nombres == alumno.Nombres && x.ApPaterno == alumno.ApPaterno
         && x.ApMaterno == alumno.ApMaterno && x.Email == alumno.Email ))
>>>>>>> 43dc92d35bc61847e47e97ffd6f0ea0cd830e489
                throw new ArgumentException("El alumno ya ha sido registrado");
            //Verifica si el numero de control se esta utilizando por un usuario activo
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper()))
                throw new ArgumentException("El numero de control ya ha sido registrado");
            //Verifica si el email se esta utilizando por un usuario activo
            if (GetAll().Any(x => x.Email == alumno.Email ))
                throw new ArgumentException("El email ya ha sido registrado");

            //Si el alumno ya ha se a registrado y se dio de baja lo activa y actualiza datos
<<<<<<< HEAD
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Nombre == alumno.Nombre && x.ApPaterno == alumno.ApPaterno
                    && x.ApMaterno == alumno.ApMaterno && x.Email == alumno.Email && x.Activo == false))
            {
                var alumnoBD = GetById(alumno.NumeroControl);

                alumnoBD.Activo = true;
                alumnoBD.Contraseña = alumno.Contraseña;
=======
            if (GetAll().Any(x => x.NumeroControl == alumno.NumeroControl.ToUpper() && x.Nombres == alumno.Nombres && x.ApPaterno == alumno.ApPaterno
                    && x.ApMaterno == alumno.ApMaterno && x.Email == alumno.Email ))
            {
                var alumnoBD = GetById(alumno.NumeroControl);

                //alumnoBD.Activo = true;
                alumnoBD.Contraseña = Encrypt.GetMD5(alumno.Contraseña);
>>>>>>> 43dc92d35bc61847e47e97ffd6f0ea0cd830e489
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
<<<<<<< HEAD
                    Rol = alumno.Rol,
                    Activo = true
=======
                    IdRol = 1,
                    //Activo = true
>>>>>>> 43dc92d35bc61847e47e97ffd6f0ea0cd830e489

                };
                Insert(alum);
            }

        }

        public void UpdateAlumno(AlumnoViewModel alumno)
        {
            if (GetById(alumno.NumeroControl).NumeroControl == alumno.NumeroControl.ToLower())
                return;

            string error = Validar(alumno);

            if (error != "")
                throw new ApplicationException(error);


            if (GetAll().Any(x => x.Email == alumno.Email))

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

        public void BajaLogicaAlumno(string numctrl)
        {
            var alumno = Context.Alumno.FirstOrDefault(x => x.NumeroControl == numctrl);
            alumno.Activo = false;
            Update(alumno);
        }

        public void RecuperacionAlumno(string numctrl)
        {
            var alumno = Context.Alumno.FirstOrDefault(x => x.NumeroControl == numctrl);
            alumno.Activo = true;
            Update(alumno);
        }

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

        //Codigo de prueba AlumnoRepository
        //public AlumnoViewModel GetAlumnoById(string numctrl)
        //{
        //    return Context.Alumno.Where(x => x.NumeroControl == numctrl)
        //        .Select(x => new AlumnoViewModel
        //        {
        //            NumeroControl = x.NumeroControl,
        //            Nombre = x.Nombre,
        //            ApPaterno = x.ApPaterno,
        //            ApMaterno = x.ApMaterno,
        //            Email = x.Email,
        //            Contraseña = x.Contraseña,
        //            IdCarrera = x.IdCarrera,
        //            IdSemestre = x.IdSemestre
        //        }).FirstOrDefault();
        //}

        //public void InsertA(AlumnoViewModel alumnoVM)
        //{
        //    Alumno alum = new Alumno()
        //    {
        //        NumeroControl = alumnoVM.NumeroControl,
        //        Nombre = alumnoVM.Nombre,
        //        ApPaterno = alumnoVM.ApPaterno,
        //        ApMaterno = alumnoVM.ApMaterno,
        //        Email = alumnoVM.Email,
        //        Contraseña = alumnoVM.Contraseña,
        //        IdSemestre = alumnoVM.IdSemestre,
        //        IdCarrera = alumnoVM.IdCarrera,
        //        Rol = alumnoVM.Rol,
        //        Activo = true
        //    };
        //    Insert(alum);
        //    alumnoVM.NumeroControl = alum.NumeroControl;
        //}

        //public void Update(AlumnoViewModel alumnoVM)
        //{
        //    var alumno = Context.Alumno.FirstOrDefault(x => x.NumeroControl == alumnoVM.NumeroControl);
        //    if (alumno != null)
        //    {
        //        alumno.NumeroControl = alumnoVM.NumeroControl;
        //        alumno.Nombre = alumnoVM.Nombre;
        //        alumno.ApPaterno = alumnoVM.ApPaterno;
        //        alumno.ApMaterno = alumnoVM.ApMaterno;
        //        alumno.Email = alumnoVM.Email;
        //        alumno.Contraseña = alumnoVM.Contraseña;
        //        alumno.IdSemestre = alumnoVM.IdSemestre;
        //        alumno.IdCarrera = alumnoVM.IdCarrera;
        //        Update(alumno);
        //    }
        //}

        //public void BajaLogica(string numctrl)
        //{
        //    var alumno = Context.Alumno.FirstOrDefault(x => x.NumeroControl == numctrl);
        //    alumno.Activo = false;
        //    Update(alumno);
        //}

        //public void Recuperacion(string numctrl)
        //{
        //    var alumno = Context.Alumno.FirstOrDefault(x => x.NumeroControl == numctrl);
        //    alumno.Activo = true;
        //    Update(alumno);
        //}
    }
}
