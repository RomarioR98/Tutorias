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
        public void InsertMaestro(MaestroViewModel maestro)
        {

            string error = Validar(maestro);

            if (error != "")
                throw new ArgumentException(error);

            if (GetAll().Any(x => x.NumeroControl == maestro.NumeroControl))
                throw new ArgumentException("El numero de control ya ha sido registrado");
            if (GetAll().Any(x => x.Email == maestro.Email))
                throw new ArgumentException("El email ya ha sido registrado");

            Maestro ma = new Maestro()
            {
                NumeroControl = maestro.NumeroControl.ToLower(),
                Nombres = maestro.Nombres,
                ApPaterno = maestro.ApPaterno,
                ApMaterno = maestro.ApMaterno,
                Email = maestro.Email,
                Contraseña = Encrypt.GetMD5(maestro.Contraseña),
                IdRol = 2
            };
            Insert(ma);
        }

        public void UpdateMaestro(MaestroViewModel maestro)
        {
            if (GetById(maestro.NumeroControl).NumeroControl == maestro.NumeroControl.ToLower())
                return;

            string error = Validar(maestro);

            if (error != "")
                throw new ApplicationException(error);

            if (GetAll().Any(x => x.Email == maestro.Email))
                throw new ArgumentException("El email ya ha sido registrado");

            var maestroBD = GetById(maestro.NumeroControl);

            maestroBD.Nombres = maestro.Nombres;
            maestroBD.ApPaterno = maestro.ApPaterno;
            maestroBD.ApMaterno = maestro.ApMaterno;
            maestroBD.Email = maestro.Email;
            maestroBD.Contraseña = Encrypt.GetMD5(maestro.Contraseña);
            Update(maestroBD);


        }


        string Validar(MaestroViewModel maestro)
        {
            if (string.IsNullOrEmpty(maestro.NumeroControl))
                return "Proporcione su numero de control";
            if (string.IsNullOrEmpty(maestro.Nombres))
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
    }
}
