using SERVICE.DAL.Implementations;
using SERVICE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public static class BitacoraService
    {
        public static void RegistrarEvento(Bitacora bitacora)
        {
            try
            {

                if (bitacora.accion == null)
                {
                    bitacora.accion = "No se ha especificado una acción";
                }

                bitacora.fecha = DateTime.Now;
                bitacora.idBitacora = Guid.NewGuid();


                bool data = BitacoraRespository.Current.Add(bitacora);


            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Bitacora> ObtenerBitacora()
        {
            try
            {
                return BitacoraRespository.Current.GetAll();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Bitacora> ObtenerBitacoraPorUsuario(string usuario)
        {
            try
            {
                if(usuario == null) throw new Exception("El usuario no puede ser nulo");
                return BitacoraRespository.Current.obtenerPorUsuario(usuario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Bitacora> ObtenerBitacoraPorFecha(DateTime fecha)
        {
            try
            {
                return BitacoraRespository.Current.obtenerPorFecha(fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Bitacora> ObtenerBitacoraPorUsuarioFecha(string usuario, DateTime fecha)
        {
            try
            {
                return BitacoraRespository.Current.obtenerPorUsuarioFecha(usuario, fecha);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
