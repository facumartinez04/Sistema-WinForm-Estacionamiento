﻿using Dao.Implementations.SqlServer.Helpers;
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
    public  sealed class PatenteRepository : IGenericDAO<Patente>
    {

      
        #region singleton
            private readonly static PatenteRepository _instance = new PatenteRepository();

            public static PatenteRepository Current
            {
                get
                {
                    return _instance;
                }
            }

            private PatenteRepository()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
        


        public bool Add(Patente obj)
        {
            try
            {
                if(obj.idPatente == Guid.Empty)
                {
                    obj.idPatente = Guid.NewGuid();
                }

                Patente patenteCheck = GetById(obj.idPatente);

                if (patenteCheck != null) return false;

               int escorrecto =  SqlHelper.ExecuteNonQuery("PatenteInsert", CommandType.StoredProcedure,
                    new SqlParameter[] { new SqlParameter("@IdPatente", obj.idPatente),
                                    new SqlParameter("@Nombre", obj.Name),
                                   new SqlParameter("@DataKey", obj.DataKey),
                                   new SqlParameter("@TipoAcceso", obj.TipoAcceso) });

                if (escorrecto > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }



            } catch (Exception ex)
            {
                return false;
            }



        }

        public List<Patente> GetAll()
        {
            throw new NotImplementedException();
        }

        public Patente GetById(Guid id)
        {
            Patente patente = default;

            using (var reader = SqlHelper.ExecuteReader("PatenteSelect", CommandType.StoredProcedure,
              new SqlParameter[] { new SqlParameter("@IdPatente", id) }))
            {
                //Mientras tenga algo en mi tabla de Customers
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    patente = PatenteMapper.Current.Fill(data);
                }
            }

            return patente;
        }

        public bool Update(Patente obj)
        {
            throw new NotImplementedException();
        }

        public bool Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}