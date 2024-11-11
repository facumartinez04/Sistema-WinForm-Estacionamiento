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
    public class TipoTarifaDAO : SqlTransactRepository, ITipoTarifaDAO
    {
        public TipoTarifaDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[TipoTarifa] (monto_por_hora,descripcion) VALUES (@monto_por_hora,@descripcion)";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[TipoTarifa] SET monto_por_hora = @monto_por_hora ,descripcion = @descripcion WHERE idTipoTarifa = @idTipoTarifa";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[TipoTarifa] WHERE idTipoTarifa = @idTipoTarifa";
        }

        private string SelectOneStatement
        {
            get => "SELECT idTipoTarifa, monto_por_hora,descripcion FROM [dbo].[TipoTarifa] WHERE idTipoTarifa = @idTipoTarifa";
        }

        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[TipoTarifa]";
        }
        #endregion


        public void Add(TipoTarifa obj)
        {
            try
            {
                int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                    new SqlParameter("@monto_por_hora", obj.monto_por_hora),
                    new SqlParameter("@descripcion", obj.descripcion)
                    );

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo insertar el registro");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<TipoTarifa> GetAll()
        {
            List<TipoTarifa> tarifas = new List<TipoTarifa>();
            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    TipoTarifa tarifa = TipoTarifaMapper.Current.Fill(data);
                    tarifas.Add(tarifa);
                }
            }
            return tarifas;

        }

        public TipoTarifa GetById(Guid id)
        {
            return null;
        }

        public TipoTarifa ListById(int id)
        {
            TipoTarifa tarifa = null;
            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                               new SqlParameter("@idTipoTarifa", id)))
            {
                if (reader.Read())
                {
                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    tarifa = TipoTarifaMapper.Current.Fill(data);
                }
            }
            return tarifa;
        }

        public void Remove(Guid id)
        {
            try
            {
                int esCargado = ExecuteNonQuery(DeleteStatement, CommandType.Text,
                                       new SqlParameter("@idTipoTarifa", id));

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo eliminar el registro");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Update(TipoTarifa obj)
        {

            try
            {
                int esCargado = ExecuteNonQuery(UpdateStatement, CommandType.Text,
                    new SqlParameter("@monto_por_hora", obj.monto_por_hora),
                    new SqlParameter("@descripcion", obj.descripcion),
                    new SqlParameter("@idTipoTarifa", obj.idTipoTarifa)
                    );

                if (esCargado == 0)
                {
                    throw new Exception("No se pudo actualizar el registro");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
