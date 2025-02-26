using SERVICE.DAL.Implementations;
using SERVICE.Domain.Composite;
using SERVICE.Domain.ServicesExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public static class LoginService
    {



        public static void Register(Usuario user)
        {
            try
            {

                if (user.UserName == "" || user.Password == "")
                {
                    throw new Exception("El usuario o la contraseña no pueden ser nulos");
                }

                Usuario userCheck = UsuarioRepository.Current.GetAll().FirstOrDefault(x => x.UserName == user.UserName);


                bool checheando = UsuarioRepository.Current.Add(user);
                var userFamilia = new UsuarioFamilia();
                userFamilia.idUsuario = user.IdUsuario;
                userFamilia.idFamilia = new Guid("9A818C81-BA52-490C-A4C3-97F30A5DB69C");
                UsuarioFamiliaRepository.Current.Add(userFamilia);

                if (checheando == false)
                {
                    throw new Exception("El usuario ya existe");
                }

            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }





        }

        public static Usuario Validate(Usuario user)
        {


            if (user.UserName == "" || user.Password == "")
            {
                throw new Exception("El usuario o la contraseña no pueden ser nulos");
            }


            Usuario userCheck = UsuarioRepository.Current.GetAll().FirstOrDefault(x => x.UserName == user.UserName);




            if (userCheck == null)
            {
                throw new Exception("El usuario no existe");
            }
            else if (!CryptographyService.ComparePassword(user.Password, userCheck.Password))
            {
                throw new Exception("La contraseña es incorrecta");
            }
            else
            {
                user.IdUsuario = userCheck.IdUsuario;
                user.UserName = userCheck.UserName;
                user.Password = userCheck.Password;

                var usuarioFamilas = UsuarioFamiliaRepository.Current.GetAll().Where(x => x.idUsuario == user.IdUsuario).ToList();
                var usuarioPatentes = UsuarioPatenteRepository.Current.GetAll().Where(x => x.idUsuario == user.IdUsuario).ToList();

                var familiasList = new List<Familia>();
                var patentesList = new List<Patente>();

                foreach (var item in usuarioFamilas)
                {
                    var familia = FamiliaRepository.Current.GetAll().FirstOrDefault(x => x.Id == item.idFamilia);
                    familiasList.Add(familia);
                }

                foreach (var item in usuarioPatentes)
                {
                    var patente = PatenteRepository.Current.GetAll().FirstOrDefault(x => x.idPatente == item.idPatente);
                    patentesList.Add(patente);
                }

                user.Accesos = new List<Acceso>();

                foreach (var familia in familiasList)
                {
                    user.Accesos.Add(familia);
                }

                foreach (var patente in patentesList)
                {
                    user.Accesos.Add(patente);
                }

                user.GetAllPatentes();
                user.GetFamilias();

                return user;




            }

        }


    }

}

