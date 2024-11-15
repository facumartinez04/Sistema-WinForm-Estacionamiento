using Dao.Implementations.SqlServer.Helpers;
using DAO.Contracts;
using DAO.Implementations.SqlServer.Mappers;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer
{
    public class IngresoDAO : SqlTransactRepository, IIngresoDAO
    {
        public IngresoDAO(SqlConnection context, SqlTransaction _transaction) : base(context, _transaction)
        {
        }


        #region Statements
        private string InsertStatement
        {
            get => "INSERT INTO [dbo].[Ingreso] (idIngreso,idVehiculo,idCliente,FechaHorario_Ingreso,idTipoTarifa,estado) VALUES (@idIngreso,@idVehiculo,@idCliente,@fechaHorario_Ingreso,@idTipoTarifa,@estado)";
        }


        private string IngresosActualesStatement
        {
            get => "SELECT * FROM [dbo].[Ingreso] WHERE FechaHorario_Salida IS NULL";
        }

        private string IngresoPorPatenteStatement
        {

            get => "SELECT * FROM [DBEstacionamiento].[dbo].[Ingreso] i INNER JOIN [DBEstacionamiento].[dbo].[Vehiculo] v ON i.idVehiculo = v.idVehiculo INNER JOIN [DBEstacionamiento].[dbo].[TipoTarifa] t ON i.idTipoTarifa = t.idTipoTarifa WHERE v.patente = @patente AND FechaHorario_Salida IS NOT NULL";
        }




        private string RegistroSalida
        {
            get => "UPDATE [dbo].[Ingreso] SET FechaHorario_Salida = @FechaHorario_Salida WHERE idIngreso = @idIngreso";
        }

        private string UpdateStatement
        {
            get => "UPDATE [dbo].[Ingreso] SET (idIngreso,idCliente,FechaHorario_Ingreso,FechaHorario_Salida,estado) WHERE idIngreso = @idIngreso";
        }

        private string DeleteStatement
        {
            get => "DELETE FROM [dbo].[Ingreso] WHERE idIngreso = @idIngreso";
        }

        private string SelectOneStatement
        {
            get => "SELECT * FROM [dbo].[Ingreso] WHERE idIngreso = @idIngreso";
        }

        private string SeleccionarPorFechas
        {
            get => "SELECT * FROM [dbo].[Ingreso] WHERE  FechaHorario_Salida IS NOT NULL AND FechaHorario_Ingreso BETWEEN @fechaInicio AND @fechaFin";
        }

        private string BuscarLaPatente
        {
            get => "SELECT * FROM [dbo].[Ingreso] i INNER JOIN [dbo].[Vehiculo] v ON i.idVehiculo = v.idVehiculo WHERE v.patente = @patente AND i.FechaHorario_Salida IS NULL;";
        }


        private string SelectAllStatement
        {
            get => "SELECT * FROM [dbo].[Ingreso]";
        }
        #endregion

        public void Add(Ingreso obj)
        {

        }

        public List<Ingreso> GetAll()
        {
            List<Ingreso> ingresos = new List<Ingreso>();
            using (var reader = ExecuteReader(SelectAllStatement, CommandType.Text))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Ingreso ingreso = IngresoMapper.Current.Fill(data);
                    ingresos.Add(ingreso);
                }
            }
            return ingresos;
        }

        public Ingreso GetById(Guid id)
        {

            Ingreso ingreso = null;
            using (var reader = ExecuteReader(SelectOneStatement, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@idIngreso", id) }))
            {
                while (reader.Read())
                {


                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    ingreso = IngresoMapper.Current.Fill(data);

                    

                }
                return ingreso;
            }
        }

     
        public void RegistrarEntrada(Ingreso obj)
        {
            int esCargado = ExecuteNonQuery(InsertStatement, CommandType.Text,
                               new SqlParameter[] { new SqlParameter("@idIngreso", obj.idIngreso),
                               new SqlParameter("@idVehiculo", obj.vehiculo.idVehiculo),
                               new SqlParameter("@idCliente", obj.cliente.idCliente),
                               new SqlParameter("@idTipoTarifa", obj.objTipoTarifa.idTipoTarifa),
                               new SqlParameter("@estado",obj.estado),
                               new SqlParameter("@fechaHorario_Ingreso", obj.fechaIngreso)});

            if (esCargado == 0)
            {
                throw new Exception("No se pudo insertar el registro");
            }
        }

        public void RegistrarSalida(Ingreso obj)
        {
            int esCargado = ExecuteNonQuery(RegistroSalida, CommandType.Text,
                               new SqlParameter[] { new SqlParameter("@idIngreso", obj.idIngreso),
                               new SqlParameter("@FechaHorario_Salida", obj.fechaEgreso)});

            if (esCargado == 0)
            {
                throw new Exception("No se pudo insertar el registro");
            }
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Ingreso obj)
        {
            throw new NotImplementedException();



        }

        public List<Ingreso> IngresosActuales()
        {

            List<Ingreso> ingresos = new List<Ingreso>();
            using (var reader = ExecuteReader(IngresosActualesStatement, CommandType.Text))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Ingreso ingreso = IngresoMapper.Current.Fill(data);
                    ingresos.Add(ingreso);
                }
            }
            return ingresos;
        }

        public List<Ingreso> BuscarPorPatente(string patente)
        {

            List<Ingreso> ingresos = new List<Ingreso>();
            using (var reader = ExecuteReader(IngresoPorPatenteStatement, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@patente", patente) }))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Ingreso ingreso = IngresoMapper.Current.Fill(data);
                    ingresos.Add(ingreso);
                }
            }
            return ingresos;

        }

        public List<Ingreso> ListarPorFechas(DateTime desde, DateTime hasta)
        {

            List<Ingreso> ingresos = new List<Ingreso>();
            using (var reader = ExecuteReader(SeleccionarPorFechas, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@fechaInicio", desde.ToString("yyyy-MM-dd 00:00:00")), new SqlParameter("@fechaFin", hasta.ToString("yyyy-MM-dd 23:59:59")) }))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    Ingreso ingreso = IngresoMapper.Current.Fill(data);
                    ingresos.Add(ingreso);
                }
            }
            return ingresos;
        }

        public Ingreso BuscarUnaPatente(string patente)
        {

            Ingreso ingreso = null;

            using (var reader = ExecuteReader(BuscarLaPatente, CommandType.Text,
                new SqlParameter[] { new SqlParameter("@patente", patente) }))
            {
                while (reader.Read())
                {

                    object[] data = new object[reader.FieldCount];
                    reader.GetValues(data);

                    ingreso = IngresoMapper.Current.Fill(data);
                }
            }
            return ingreso;
        }
    }
}
