using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer
{
    public sealed class MetodoPagoDAO : SqlTransactRepository, IMetodoPagoDAO
    {
        public MetodoPagoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }


        


        public void Add(MetodoPago obj)
        {
            throw new NotImplementedException();
        }

        public List<MetodoPago> GetAll()
        {
            throw new NotImplementedException();
        }

        public MetodoPago GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(MetodoPago obj)
        {
            throw new NotImplementedException();
        }
    }
}
