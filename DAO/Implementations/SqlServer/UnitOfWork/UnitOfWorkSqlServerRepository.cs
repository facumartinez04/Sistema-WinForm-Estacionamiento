
using Dao.Contracts;
using Dao.Contracts.UnitOfWork;
using DAO.Contracts;
using DAO.Contracts.UnitOfWork;
using System;
using System.Configuration;
using System.Data.SqlClient;

namespace Dao.Implementations.SqlServer.UnitOfWork
{
    public class UnitOfWorkSqlServerRepository : IUnitOfWorkRepository
    {

        public IIngresoDAO IngresoRepository { get; }

        public IVehiculoDAO VehiculoRepository { get; }

        public IMetodoPagoDAO MetodoPagoRepository { get; }

        public ITipoTarifaDAO TipoTarifaRepository { get; }

        public IFacturaDAO FacturaRepository { get; }


        public IEmpleadoDAO EmpleadoRepository { get; }


        private string ingresoDAO = ConfigurationManager.AppSettings["IngresoConcreteDAO"]; 
        
        private string vehiculoDAO = ConfigurationManager.AppSettings["VehiculoConcreteDAO"]; 

        private string metodoPagoDAO = ConfigurationManager.AppSettings["MetodoPagoConcreteDAO"];

        private string tipoTarifaDAO = ConfigurationManager.AppSettings["TipoTarifaConcreteDAO"];

        private string facturaDAO = ConfigurationManager.AppSettings["FacturaConcreteDAO"];

        private string empleadoDAO = ConfigurationManager.AppSettings["EmpleadoConcreteDAO"];

        private string rolDAO = ConfigurationManager.AppSettings["RolConcreteDAO"];




        public UnitOfWorkSqlServerRepository(SqlConnection context, SqlTransaction transaction)
        {
            


            Type ingresoType = Type.GetType(ingresoDAO);

            var ingresoInstance = Activator.CreateInstance(ingresoType, new object[]
            {
                context, transaction
            });

            IngresoRepository = ingresoInstance as IIngresoDAO;


            Type vehiculoType = Type.GetType(vehiculoDAO);

            var vehiculoInstance = Activator.CreateInstance(vehiculoType, new object[]
            {
                context, transaction
            });

            VehiculoRepository = vehiculoInstance as IVehiculoDAO;


            Type metodoPagoType = Type.GetType(metodoPagoDAO);

            var metodoPagoInstance = Activator.CreateInstance(metodoPagoType, new object[]
            {
                context, transaction
            });

            MetodoPagoRepository = metodoPagoInstance as IMetodoPagoDAO;


            Type tipoTarifaType = Type.GetType(tipoTarifaDAO);

            var tipoTarifaInstance = Activator.CreateInstance(tipoTarifaType, new object[]
            {
                context, transaction
            });
                
            TipoTarifaRepository = tipoTarifaInstance as ITipoTarifaDAO;

     

            Type facturaType = Type.GetType(facturaDAO);

            var facturaInstance = Activator.CreateInstance(facturaType, new object[]
            {
                context, transaction
            });

            FacturaRepository = facturaInstance as IFacturaDAO;




        }
    }
}

