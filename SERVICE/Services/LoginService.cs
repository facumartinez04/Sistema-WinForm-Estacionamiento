using SERVICE.DAL.Implementations;
using SERVICE.Domain.Composite;
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

            if(user.Username == "" || user.Password == "")
            {
                throw new Exception("El usuario o la contraseña no pueden ser nulos");
            }


            bool checheando = UsuarioRepository.Current.Add(user);


            if(checheando == false)
            {
                throw new Exception("El usuario ya existe");
            }
            else
            {
                throw new Exception("El usuario fue registrado con exito");
            }



        }

        public static void Validate(Usuario user)
        {


            if (user.Username == "" || user.Password == "")
            {
                throw new Exception("El usuario o la contraseña no pueden ser nulos");
            }


            Usuario userCheck = UsuarioRepository.Current.GetAll().FirstOrDefault(x => x.Username == user.Username);

            if (userCheck == null)
            {
                throw new Exception("El usuario no existe");
            }
            else
            {
                if (!CryptographyService.ComparePassword(user.Password,userCheck.Password))
                {
                    throw new Exception("La contraseña es incorrecta");
                }

            }



        }



    }
}
