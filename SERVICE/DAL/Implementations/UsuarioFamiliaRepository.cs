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
    public class UsuarioFamiliaRepository : IUsuarioFamiliaDAO
    {

       
            #region singleton
            private readonly static UsuarioFamiliaRepository _instance = new UsuarioFamiliaRepository();

            public static UsuarioFamiliaRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private UsuarioFamiliaRepository()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
      


        public bool Add(UsuarioFamilia obj)
        {

            try
            {

                

                if (obj.idFamilia == Guid.Empty || obj.idUsuario == Guid.Empty) throw new Exception("El id de familia o de usuario no pueden ser nulos");



                int data = SqlHelper.ExecuteNonQuery("Usuario_FamiliaInsert", CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdUsuario", obj.idUsuario),
                                   new SqlParameter("@IdFamilia", obj.idFamilia ) });    



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
                return false;
            }



        }

        public List<UsuarioFamilia> GetAll()
        {

            List<UsuarioFamilia> familias = new List<UsuarioFamilia>();

            using (var reader = SqlHelper.ExecuteReader("Usuario_FamiliaSelectAll", CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    familias.Add(UsuarioFamiliaMapper.Current.Fill(data));
                }
            }

            return familias;


        }

        public UsuarioFamilia GetById(Guid id)
        {

            UsuarioFamilia user = null;

            using (var reader = SqlHelper.ExecuteReader("Usuario_FamiliaSelectByIdUsuario", CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    user = (UsuarioFamiliaMapper.Current.Fill(data));
                }
            }

            return user;


        }

        public bool Remove(Guid id)
        {

            try
            {
                int data = SqlHelper.ExecuteNonQuery("Usuario_FamiliaDelete", CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdUsuario", id) });

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
                return false;
            }
        }

        public bool Update(UsuarioFamilia obj)
        {

            try
            {
                int data = SqlHelper.ExecuteNonQuery("Usuario_FamiliaUpdate", CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdUsuario", obj.idUsuario),
                                   new SqlParameter("@IdFamilia", obj.idFamilia) });

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
                return false;
            }

        }

        public List<UsuarioFamilia> GetFamiliasByUsuario(Guid idUsuario)
        {
            List<UsuarioFamilia> familias = new List<UsuarioFamilia>();

            using (var reader = SqlHelper.ExecuteReader("Usuario_FamiliaSelectByIdUsuario", CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    familias.Add(UsuarioFamiliaMapper.Current.Fill(data));
                }
            }

            return familias;

        }
    }
}
