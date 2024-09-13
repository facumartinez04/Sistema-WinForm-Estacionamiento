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
    public class PagoDAO : SqlTransactRepository, IPagoDAO
    {
        public PagoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {

        }


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Pago] (idFactura,idMetodoPago,monto_total) VALUES (@idFactura@idMetodoPago,@montoTotal)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Pago] SET (idMetodoPago,monto_total) WHERE idPago = @idPago";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Pago] WHERE idPago = @idPago";
        }

        private string SelectOneStatement
        {
            get => "SELECT idFactura, idMetodoPago,monto_total FROM [dbo].[Pago] WHERE idPago = @idPago";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Pago]";
        }
        #endregion


        public void Add(Pago obj)
        {
            int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,   
                              new SqlParameter[] { new SqlParameter("@idMetodoPago", obj.metodoPago.idMetodoPago),
                              new SqlParameter("@idVehiculo", obj.factura.idFactura),
                               new SqlParameter("@montoTotal", obj.monto)});

            if (esCargado == 0)
            {
                throw new Exception("No se pudo insertar el registro");
            }

        }

        public List<Pago> GetAll()
        {
            List<Pago> pagos = new List<Pago>();
            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Pago pago = PagoMapper.Current.Fill(data);
                    pagos.Add(pago);
                }
            }
            return pagos;
        }

        public Pago GetById(Guid id)
        {

            Pago pago = null;
            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                               new SqlParameter[] { new SqlParameter("@idPago", id) }))
            {
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    pago = PagoMapper.Current.Fill(data);
                }
            }
            return pago;


        }

        public void Remove(Guid id)
        {

            int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                                              new SqlParameter[] { new SqlParameter("@idPago", id) });

            if (esCargado == 0)
            {
                throw new Exception("No se pudo eliminar el registro");
            }
        }

        public void Update(Pago obj)
        {
            int esCargado = ExecuteNonQuery(UpdateStatement, CommandType.Text,
                                              new SqlParameter[] { new SqlParameter("@idPago", obj.idPago),
                                              new SqlParameter("@idMetodoPago", obj.metodoPago.idMetodoPago),
                                              new SqlParameter("@montoTotal", obj.monto) });

            if (esCargado == 0)
            {
                throw new Exception("No se pudo actualizar el registro");
            }
        }
    }
}
