using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tutorias.Repositories;
using Tutorias.Models;

namespace Tutorias.Repositories
{
    public class MaestroRepository : Repository<Maestro>
    {
        public MaestroViewModel GetMaestroById(string numctrl)
        {
            return Context.Maestro.Where(x => x.NumeroControl == numctrl)
                .Select(x => new MaestroViewModel
                {
                    NumeroControl = x.NumeroControl,
                    Nombre = x.Nombre,
                    ApPaterno = x.ApPaterno,
                    ApMaterno = x.ApMaterno,
                    Email = x.Email,
                    Contraseña = x.Contraseña,
                }).FirstOrDefault();

        }
        public IEnumerable<Maestrosmateria> GetMaestrosMateriaById(string numctrl)
        {
            return Context.Maestrosmateria.Where(x => x.IdMaestro == numctrl).Select(x => new Maestrosmateria
                {
                    Id = x.Id,
                    IdMateria = x.IdMateria
                });
        }

        public void InsertMaestro(MaestroViewModel maestroVM)
        {
            string error = Validar(maestroVM);

            if (error != "")
                throw new ArgumentException(error);

            //Verifica si el alumno tiene una cuenta activa
            if (GetAll().Any(x => x.NumeroControl.ToUpper() == maestroVM.NumeroControl.ToUpper() && x.Nombre == maestroVM.Nombre && x.ApPaterno == maestroVM.ApPaterno
         && x.ApMaterno == maestroVM.ApMaterno && x.Email == maestroVM.Email && x.Activo == true))
                throw new ArgumentException("El maestro ya ha sido registrado");
            //Verifica si el numero de control se esta utilizando por un usuario activo
            if (GetAll().Any(x => x.NumeroControl.ToUpper() == maestroVM.NumeroControl.ToUpper() && x.Activo == true))
                throw new ArgumentException("El numero de control ya ha sido registrado");
            //Verifica si el email se esta utilizando por un usuario activo
            if (GetAll().Any(x => x.Email == maestroVM.Email && x.Activo == true))
                throw new ArgumentException("El email ya ha sido registrado");

            //Si el alumno ya ha se a registrado y se dio de baja lo activa y actualiza datos
            if (GetAll().Any(x => x.NumeroControl.ToUpper() == maestroVM.NumeroControl.ToUpper() && x.Nombre == maestroVM.Nombre && x.ApPaterno == maestroVM.ApPaterno
                    && x.ApMaterno == maestroVM.ApMaterno && x.Email == maestroVM.Email && x.Activo == false))
            {
                var maestro = GetById(maestroVM.NumeroControl);

                maestro.Activo = true;
                maestro.Contraseña = maestroVM.Contraseña;
                Update(maestro);

            }
            //Si es nuevo lo agrega
            else
            {

                Maestro maes = new Maestro()
                {
                    NumeroControl = maestroVM.NumeroControl.ToUpper(),
                    Nombre = maestroVM.Nombre,
                    ApPaterno = maestroVM.ApPaterno,
                    ApMaterno = maestroVM.ApMaterno,
                    Email = maestroVM.Email,
                    Contraseña = maestroVM.Contraseña, //Encrypt.GetMD5(maestroVM.Contraseña),
                    Rol = maestroVM.Rol,
                    Activo = true

                };
                Insert(maes);
            }
        }

        public void UpdateMaestro(MaestroViewModel maestroVM)
        {
            if (GetById(maestroVM.NumeroControl).NumeroControl.ToUpper() == maestroVM.NumeroControl.ToUpper())
                return;

            string error = Validar(maestroVM);

            if (error != "")
                throw new ApplicationException(error);

            if (GetAll().Any(x => x.Email == maestroVM.Email && x.Activo == true))
                throw new ArgumentException("El email ya ha sido registrado");

            var maestro = GetById(maestroVM.NumeroControl);

            maestro.Nombre = maestroVM.Nombre;
            maestro.ApPaterno = maestroVM.ApPaterno;
            maestro.ApMaterno = maestroVM.ApMaterno;
            maestro.Email = maestroVM.Email;
            maestro.Contraseña = maestroVM.Contraseña; /*Encrypt.GetMD5(maestroVM.Contraseña);*/

            Update(maestro);


        }

        public void BajaLogicaMaestro(string numctrl)
        {
            var maestro = Context.Maestro.FirstOrDefault(x => x.NumeroControl == numctrl);
            maestro.Activo = false;
            Update(maestro);
        }

        public void RecuperacionMaestro(string numctrl)
        {
            var maestro = Context.Maestro.FirstOrDefault(x => x.NumeroControl == numctrl);
            maestro.Activo = true;
            Update(maestro);
        }

        string Validar(MaestroViewModel maestro)
        {
            if (string.IsNullOrEmpty(maestro.NumeroControl))
                return "Proporcione su numero de control";
            if ((maestro.NumeroControl).Length != 4)
                return "Verifique su numero de control";
            if (string.IsNullOrEmpty(maestro.Nombre))
                return "Proporcione su nombre";
            if (string.IsNullOrEmpty(maestro.ApPaterno))
                return "Proporcione su apellido paterno";
            if (string.IsNullOrEmpty(maestro.ApMaterno))
                return "Proporcione su apellido materno";
            if (string.IsNullOrEmpty(maestro.Email))
                return "Proporcione su email";
            if (string.IsNullOrEmpty(maestro.Contraseña))
                return "Proporcione su contraseña";

            return "";

        }

        //Codigo de prueba MaestroRepository
        //public MaestroViewModel GetMaestroById(string numctrl)
        //{
        //    return Context.Maestro.Where(x => x.NumeroControl == numctrl)
        //        .Select(x => new MaestroViewModel
        //        {
        //            NumeroControl = x.NumeroControl,
        //            Nombre = x.Nombre,
        //            ApPaterno = x.ApPaterno,
        //            ApMaterno = x.ApMaterno,
        //            Email = x.Email,
        //            Contraseña = x.Contraseña,
        //        }).FirstOrDefault();
        //}

        //public void InsertM(MaestroViewModel maestroVM)
        //{
        //    Maestro maestro = new Maestro()
        //    {
        //        NumeroControl = maestroVM.NumeroControl,
        //        Nombre = maestroVM.Nombre,
        //        ApPaterno = maestroVM.ApPaterno,
        //        ApMaterno = maestroVM.ApMaterno,
        //        Email = maestroVM.Email,
        //        Contraseña = maestroVM.Contraseña,
        //        Rol = maestroVM.Rol,
        //        Activo = true
        //    };
        //    Insert(maestro);
        //    maestroVM.NumeroControl = maestro.NumeroControl;
        //}

        //public void Update(MaestroViewModel maestroVM)
        //{
        //    var maestro = Context.Maestro.FirstOrDefault(x => x.NumeroControl == maestroVM.NumeroControl);
        //    if (maestro != null)
        //    {
        //        maestro.NumeroControl = maestroVM.NumeroControl;
        //        maestro.Nombre = maestroVM.Nombre;
        //        maestro.ApPaterno = maestroVM.ApPaterno;
        //        maestro.ApMaterno = maestroVM.ApMaterno;
        //        maestro.Email = maestroVM.Email;
        //        maestro.Contraseña = maestroVM.Contraseña;
        //        Update(maestro);
        //    }
        //}

        //public void BajaLogica(string numctrl)
        //{
        //    var maestro = Context.Maestro.FirstOrDefault(x => x.NumeroControl == numctrl);
        //    maestro.Activo = false;
        //    Update(maestro);
        //}

        //public void Recuperacion(string numctrl)
        //{
        //    var maestro = Context.Maestro.FirstOrDefault(x => x.NumeroControl == numctrl);
        //    maestro.Activo = true;
        //    Update(maestro);
        //}
    }
}
