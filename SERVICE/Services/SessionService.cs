using SERVICE.Domain;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public static class SessionService
    {
        private static Usuario usuarioActual;

        public static void SetUsuario(Usuario usuario)
        {
            usuarioActual = usuario;
            BitacoraService.RegistrarEvento(new Bitacora(GetUsuario().UserName, $"Inicio sesion en el sistema"));
        }

        public static Usuario GetUsuario()
        {
            return usuarioActual;
        }

        public static void Clear()
        {
            usuarioActual = null;
        }

        public static bool IsLogged()
        {
            return usuarioActual != null;
        }

    }
}
                                                                                                                            