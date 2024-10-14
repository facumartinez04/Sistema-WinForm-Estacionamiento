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
    public sealed class FamiliaRepository : IGenericDAO<Familia>
    {

       
         #region singleton
            private readonly static FamiliaRepository _instance = new FamiliaRepository();

            public static FamiliaRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private FamiliaRepository()
            {
                //Implent here the initialization of your singleton
            }

        #endregion



        public bool Add(Familia obj)
        {
            obj.idFamilia = Guid.NewGuid();

            int data =  SqlHelper.ExecuteNonQuery("FamiliaInsert", CommandType.StoredProcedure,
            new SqlParameter[] { new SqlParameter("@IdFamilia", obj.idFamilia),
                                   new SqlParameter("@Nombre", obj.Nombre) });


            if (data < 0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public bool Update(Familia obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Familia GetById(Guid id)
        {
            Familia familia = default;

            using (var reader = SqlHelper.ExecuteReader("FamiliaSelect", CommandType.StoredProcedure,
              new SqlParameter[] { new SqlParameter("@IdFamilia", id) }))
            {
                //Mientras tenga algo en mi tabla de Customers
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    familia = FamiliaMapper.Current.Fill(data);
                }
            }

            return familia;
        }

        public List<Familia> GetAll()
        {
            List<Familia> familias = new List<Familia>();

            using (var reader = SqlHelper.ExecuteReader("FamiliaSelectAll", CommandType.StoredProcedure))
            {
                while (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    familias.Add(FamiliaMapper.Current.Fill(data));
                }
            }

            return familias;




        }

    }
}
