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
    public class FacturaDAO : SqlTransactRepository, IFacturaDAO
    {
        public FacturaDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Factura] (idFactura,idIngreso,idMetodoPago,monto_total) VALUES (@idFactura,@idIngreso,@idMetodoPago,@monto_total)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Factura] SET (idFactura,idIngreso,idMetodoPago,monto_total) WHERE idFactura = @idFactura";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Factura] WHERE idFactura = @idFactura";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Factura] WHERE idFactura = @idFactura";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Factura]";
        }
        #endregion


        public void Add(Factura obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                    new SqlParameter("@idFactura", obj.idFactura),
                    new SqlParameter("@idIngreso", obj.ingreso.idIngreso),
                    new SqlParameter("@idMetodoPago", obj.metodoPago.idMetodoPago),
                    new SqlParameter("@monto_total", obj.monto_total)
                    );

                if (esCargado == 0)
                {
                    throw new Exception("No se ha podido cargar la factura");
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }



        }

        public List<Factura> GetAll()
        {

            List<Factura> facturas = new List<Factura>();
            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Factura factura = FacturaMapper.Current.Fill(data);
                    facturas.Add(factura);
                }
            }
            return facturas;
        }

        public Factura GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Factura obtenerPorID(int ID)
        {

            Factura factura = null;

            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                               new SqlParameter("@idFactura", ID)))

            {
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    factura = FacturaMapper.Current.Fill(data);
                }

                return factura;

            }
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Factura obj)
        {
            using (var reader = ExecuteReader(UpdateStatement, CommandType.Text,
                new SqlParameter("@idFactura", obj.idFactura),
                new SqlParameter("@idIngreso", obj.ingreso.idIngreso),
                new SqlParameter("@idMetodoPago", obj.metodoPago.idMetodoPago),
                new SqlParameter("@monto_total", obj.monto_total)
                ))
            {
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Factura factura = FacturaMapper.Current.Fill(data);
                }
            }
        }
    }
}
