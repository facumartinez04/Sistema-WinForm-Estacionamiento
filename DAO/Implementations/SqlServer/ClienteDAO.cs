using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DAO.Implementations.SqlServer.Mappers;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer
{
    public sealed class ClienteDAO : SqlTransactRepository, IClienteDAO
    {


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Cliente] (idCliente,nombre,dni,fecha_nacimiento) VALUES (@idCliente,@nombre,@dni,@fechaNacimiento)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Cliente] SET () WHERE  = @";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Cliente] WHERE idCliente = @idCliente";
        }

        private string SelectOneStatement
        {
            get => "SELECT *  FROM [dbo].[Cliente] WHERE idCliente = @idCliente";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Cliente]";
        }
        #endregion



        public ClienteDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }

        public void Add(Cliente obj)
        {


            int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@idCliente", obj.idCliente),
                                     new SqlParameter("@nombre", obj.nombre),
                                     new SqlParameter("@dni", obj.dni),
                                     new SqlParameter("@fechaNacimiento", obj.fechaNacimiento)
                });
            if (esCargado == 0)
            {
                throw new Exception("No se pudo insertar el cliente");
            }
        }

        public List<Cliente> GetAll()
        {
            List<Cliente> clientes = new List<Cliente>();

            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text,
                new SqlParameter[] { }))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Cliente customer = ClienteMapper.Current.Fill(data);
                    clientes.Add(customer);
                }
            }

            return clientes;
        }

        public Cliente GetById(Guid id)
        {
            Cliente cliente = default;

            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
              new SqlParameter[] { new SqlParameter("@idCliente", id) }))
            {
                //Mientras tenga algo en mi tabla de Customers
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    cliente = ClienteMapper.Current.Fill(data);
                }
            }

            return cliente;
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Cliente obj)
        {
            throw new NotImplementedException();
        }
    }
}
