using Dao.Contracts;
using Dao.Contracts.UnitOfWork;
using Dao.Implementations.SqlServer;
using DAO.Contracts;
using DAO.Contracts.UnitOfWork;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao.Factory
{
    public static class FactoryDao
    {
        /// <summary>
        /// Constructor de tipo estático: Se ejecuta una vez en todo un programa...
        /// </summary>
        /// 
        private static int backendType;
        private static string ingresoDAO;
        private static string facturaData;
        private static string metodoPagoData;
        private static string tipoTarifaData;
        private static string pagoData;
        private static string vehiculoData;
        private static string empleadoDATA;
        private static string rolData;
        
        static FactoryDao()
        {
            backendType = int.Parse(ConfigurationManager.AppSettings["BackendType"]);
            ingresoDAO = ConfigurationManager.AppSettings["IngresoConcreteDAO"];
            vehiculoData = ConfigurationManager.AppSettings["VehiculoConcreteDAO"];
            facturaData = ConfigurationManager.AppSettings["FacturaConcreteDAO"];
            metodoPagoData = ConfigurationManager.AppSettings["MetodoPagoConcreteDAO"];
            tipoTarifaData = ConfigurationManager.AppSettings["TipoTarifaConcreteDAO"];
            pagoData = ConfigurationManager.AppSettings["PagoConcreteDAO"];
            empleadoDATA = ConfigurationManager.AppSettings["EmpleadoConcreteDAO"];
            rolData = ConfigurationManager.AppSettings["RolConcreteDAO"];


            UnitOfWork = new Implementations.SqlServer.UnitOfWork.UnitOfWorkSqlServer();
        }

        /// <summary>
        /// Dao sin Tx
        /// </summary>
    
        public static IIngresoDAO IngresoDAO
        {
            get
            {
                Type ingresoType = Type.GetType(ingresoDAO);

                return Activator.CreateInstance(ingresoType) as IIngresoDAO;
            }
        }


        public static IVehiculoDAO vehiculoDAO
        {
            get
            {
                Type vehiculoType = Type.GetType(vehiculoData);

                return Activator.CreateInstance(vehiculoType) as IVehiculoDAO;
            }
        }

        public static IFacturaDAO facturaDAO
        {
            get
            {
                Type facturaType = Type.GetType(facturaData);

                return Activator.CreateInstance(facturaType) as IFacturaDAO;
            }
        }


        public static IMetodoPagoDAO metodoPagoDAO
        {
            get
            {
                Type metodoPagoType = Type.GetType(metodoPagoData);

                return Activator.CreateInstance(metodoPagoType) as IMetodoPagoDAO;
            }
        }

        public static ITipoTarifaDAO tipoTarifaDAO
        {
            get
            {
                Type tipoTarifaType = Type.GetType(tipoTarifaData);

                return Activator.CreateInstance(tipoTarifaType) as ITipoTarifaDAO;
            }
        }

        public static IPagoDAO pagoDAO
        {
            get
            {
                Type pagoType = Type.GetType(pagoData);

                return Activator.CreateInstance(pagoType) as IPagoDAO;
            }
        }


        public static IEmpleadoDAO empleadoDAO
        {
            get
            {
                Type empleadoType = Type.GetType(empleadoDATA);

                return Activator.CreateInstance(empleadoType) as IEmpleadoDAO;
            }
        }


   



        public static IUnitOfWork UnitOfWork { get; private set; }
    }

    internal enum BackendType
    {
        Memory,
        SqlServer,
        Sqlite,
        Oracle
    }
}
