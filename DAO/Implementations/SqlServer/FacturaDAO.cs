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
    public class FacturaDAO : SqlTransactRepository, IFacturaDAO
    {
        public FacturaDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        public void Add(Factura obj)
        {
            throw new NotImplementedException();
        }

        public List<Factura> GetAll()
        {
            throw new NotImplementedException();
        }

        public Factura GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Factura obj)
        {
            throw new NotImplementedException();
        }
    }
}
