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

namespace SERVICE.DAL.Implementations
{
    public class UsuarioPatenteRepository : IGenericDAO<UsuarioPatente>
    {


        #region singleton
        private readonly static UsuarioPatenteRepository _instance = new UsuarioPatenteRepository();

        public static UsuarioPatenteRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioPatenteRepository()
        {
            //Implent here the initialization of your singleton
        }
        #endregion



        public bool Add(UsuarioPatente obj)
        {
            try
            {
                if (obj.idPatente == Guid.Empty || obj.idPatente == Guid.Empty)
                    throw new Exception("El ID de patente o de usuario no pueden ser nulos");

                int result = SqlHelper.ExecuteNonQuery(
                    "Usuario_PatenteInsert",
                    CommandType.StoredProcedure,
                    new SqlParameter[]
                    {
                    new SqlParameter("@IdUsuario", obj.idUsuario),
                    new SqlParameter("@IdPatente", obj.idPatente)
                    }
                );

                return result > 0;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<UsuarioPatente> GetAll()
        {
            List<UsuarioPatente> patentes = new List<UsuarioPatente>();

            using (var reader = SqlHelper.ExecuteReader(
                "Usuario_PatenteSelectAll",
                CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    patentes.Add(UsuarioPatenteMapper.Current.Fill(data));
                }
            }

            return patentes;
        }

        public UsuarioPatente GetById(Guid id)
        {
            UsuarioPatente usuarioPatente = null;

            using (var reader = SqlHelper.ExecuteReader(
                "Usuario_PatenteSelectByIdUsuario",
                CommandType.StoredProcedure,
                new SqlParameter[]
                {
                new SqlParameter("@IdUsuario", id)
                }))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    usuarioPatente = UsuarioPatenteMapper.Current.Fill(data);
                }
            }

            return usuarioPatente;
        }

        public bool Remove(Guid id)
        {
            try
            {
                int result = SqlHelper.ExecuteNonQuery(
                    "Usuario_PatenteDelete",
                    CommandType.StoredProcedure,
                    new SqlParameter[]
                    {
                    new SqlParameter("@IdUsuario", id)
                    }
                );

                // Asumiendo que un resultado > 0 indica éxito
                return result > 0;
            }
            catch (Exception)
            {
                // Considera registrar la excepción para depuración
                return false;
            }
        }

        public bool Update(UsuarioPatente obj)
        {
            try
            {
                int result = SqlHelper.ExecuteNonQuery(
                    "Usuario_PatenteUpdate",
                    CommandType.StoredProcedure,
                    new SqlParameter[]
                    {
                    new SqlParameter("@IdUsuario", obj.idUsuario),
                    new SqlParameter("@IdPatente", obj.idPatente)
                    }
                );

                // Asumiendo que un resultado > 0 indica éxito
                return result > 0;
            }
            catch (Exception)
            {
                // Considera registrar la excepción para depuración
                return false;
            }
        }
    }
}
