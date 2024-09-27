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
    public sealed class FamiliaPatenteRepository : IGenericDAO<FamiliaPatente>
    {

 
        #region singleton
            private readonly static FamiliaPatenteRepository _instance = new FamiliaPatenteRepository();

            public static FamiliaPatenteRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private FamiliaPatenteRepository()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
     


        public bool Add(FamiliaPatente obj)
        {
            try
            {

                if(obj.idFamilia == Guid.Empty || obj.idPatente == Guid.Empty) throw new Exception("El id de la familia o la patente no pueden ser nulos");
               



                int data = SqlHelper.ExecuteNonQuery("Familia_PatenteInsert", CommandType.StoredProcedure,
                new SqlParameter[] { new SqlParameter("@IdFamilia", obj.idFamilia),
                                   new SqlParameter("@IdPatente", obj.idPatente) });

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

        public List<FamiliaPatente> GetAll()
        {
            List<FamiliaPatente> familias = new List<FamiliaPatente>();

            using (var reader = SqlHelper.ExecuteReader("Familia_PatenteSelectAll", CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    familias.Add(FamiliaPatenteMapper.Current.Fill(data));
                }
            }

            return familias;


        }

        public FamiliaPatente GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool Update(FamiliaPatente obj)
        {
            throw new NotImplementedException();
        }
    }
}
