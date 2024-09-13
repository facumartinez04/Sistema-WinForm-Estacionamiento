using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts.UnitOfWork;
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
    public class VehiculoDAO : SqlTransactRepository,IVehiculoDAO
    {
        public VehiculoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Vehiculo] (idVehiculo,patente,marca,modelo) VALUES (@idVehiculo,@patente,@marca,@modelo)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Vehiculo] SET (idVehiculo,patente,marca,modelo) WHERE idVehiculo = @idVehiculo";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Vehiculo] WHERE idVehiculo = @idVehiculo";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Vehiculo] WHERE idVehiculo = @idVehiculo";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Vehiculo]";
        }
        #endregion


        public void Add(Vehiculo obj)
        {
            int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
           new SqlParameter[] { new SqlParameter("@idVehiculo", obj.idVehiculo),
                                     new SqlParameter("@patente", obj.patente),
                                     new SqlParameter("@marca", obj.marca),
                                     new SqlParameter("@modelo", obj.modelo)
           });
            if (esCargado == 0)
            {
                throw new Exception("No se pudo insertar el vehiculo");
            }


        }

        public List<Vehiculo> GetAll()
        {
            List<Vehiculo> vehiculos = new List<Vehiculo>();

            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text,
                new SqlParameter[] { }))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Vehiculo vehiculo = VehiculoMapper.Current.Fill(data);
                    vehiculos.Add(vehiculo);
                }
            }

            return vehiculos;
        }

        public Vehiculo GetById(Guid id)
        {
            Vehiculo vehiculo = null;

            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                               new SqlParameter[] { new SqlParameter("@idVehiculo", id) }))
            {
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    vehiculo = VehiculoMapper.Current.Fill(data);
                }
            }

            return vehiculo;
        }

        public void Remove(Guid id)
        {
            int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                               new SqlParameter[] { new SqlParameter("@idVehiculo", id) });
            if (esCargado == 0)
            {
                throw new Exception("No se pudo eliminar el vehiculo");
            }
        }

        public void Update(Vehiculo obj)
        {
            int esCargado = ExecuteNonQuery(UpdateStatement, CommandType.Text,
                                              new SqlParameter[] { new SqlParameter("@idVehiculo", obj.idVehiculo),
                                              new SqlParameter("@patente", obj.patente),
                                              new SqlParameter("@marca", obj.marca),
                                              new SqlParameter("@modelo", obj.modelo)
                                              });
            if (esCargado == 0)
            {
                throw new Exception("No se pudo actualizar el vehiculo");
            }
        }
    }
}
