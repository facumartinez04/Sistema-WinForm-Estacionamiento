using Dao.Implementations.SqlServer.Helpers;
using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SERVICE.DAL.Implementations.Mappers;
using SERVICE.Domain.ServicesExceptions;
using SERVICE.Services;

namespace SERVICE.DAL.Implementations
{
    public sealed  class UsuarioRepository : IGenericDAO<Usuario>
    {

       
          #region singleton
            private readonly static UsuarioRepository _instance = new UsuarioRepository();

            public static UsuarioRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private UsuarioRepository()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public bool Add(Usuario obj)
        {
            try
            {


                obj.IdUsuario = Guid.NewGuid();


                int data = SqlHelper.ExecuteNonQuery("UsuarioInsert", CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdUsuario", obj.IdUsuario),
                                   new SqlParameter("@UserName", obj.UserName),
                                   new SqlParameter("@Password", obj.HashPassword) });



                

                if (data < 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }


        }

        public List<Usuario> GetAll()
        {
            try
            {
                List<Usuario> usuarios = new List<Usuario>();

                using (var reader = SqlHelper.ExecuteReader("UsuarioSelectAll", CommandType.StoredProcedure))
                {
                    while (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        usuarios.Add(UserMapper.Current.Fill(data));
                    }
                }
                return usuarios;
            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }

            
        }

        public Usuario GetById(Guid id)
        {
            
            try {

                Usuario usuario = default;

                using (var reader = SqlHelper.ExecuteReader("UsuarioSelect", CommandType.StoredProcedure,
                                 new SqlParameter[] { new SqlParameter("@IdUsuario", id) }))
                {
                    //Mientras tenga algo en mi tabla de Customers
                    if (reader.Read())
                    {
                        object[] data = new object[reader.FieldCount];
                        reader.GetValues(data);

                        usuario = UserMapper.Current.Fill(data);
                    }
                }

                return usuario;

            }
            catch (Exception ex)
            {
                ExceptionService.Current.HandleException(new DALException(ex));
                throw;
            }
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Usuario obj)
        {


            try
            {

                if(obj.UserName == SessionService.GetUsuario().UserName)
                {
                    throw new Exception("No se puede modificar el usuario actual");
                }

                int data = SqlHelper.ExecuteNonQuery("UsuarioUpdate", CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdUsuario", obj.IdUsuario),
                                   new SqlParameter("@UserName", obj.UserName),
                                   new SqlParameter("@Password", obj.Password) });


                UsuarioPatenteRepository.Current.Remove(obj.IdUsuario);

                foreach (var item in obj.GetFamilias())
                {
                    UsuarioFamiliaRepository.Current.Add(new UsuarioFamilia() { idUsuario = obj.IdUsuario, idFamilia = item.IdFamilia });

                }

                if (data < 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }

            }

            catch (Exception ex)
            {

                throw new Exception("No se puede modificar el usuario actual");


            }

        }


    }
}
