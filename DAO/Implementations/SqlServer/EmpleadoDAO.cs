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
    public class EmpleadoDAO : SqlTransactRepository, IEmpleadoDAO
    {
        public EmpleadoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        public void Add(Empleado obj)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> GetAll()
        {
            throw new NotImplementedException();
        }

        public Empleado GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Empleado obj)
        {
            throw new NotImplementedException();
        }
    }
}
