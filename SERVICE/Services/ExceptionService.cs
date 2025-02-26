using SERVICE.DAL;
using SERVICE.Domain;
using SERVICE.Domain.ServicesExceptions;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.Services
{
    public sealed class ExceptionService
    {

	
		#region singleton
			private readonly static ExceptionService _instance = new ExceptionService();

			public static ExceptionService Current
			{
				get
				{
					return _instance;
				}
			}

			private ExceptionService()
			{
				//Implent here the initialization of your singleton
			}
        #endregion

        public void HandleException(DALException ex)
        {
            LoggerDao.WriteLog(new Log("Ocurrio un error en la base de datos.", TraceLevel.Error), ex);
            throw new Exception("Ocurrio un error en la base de datos.", ex.InnerException);
        }

        public void HandleException(BLLException ex)
        {
            if (ex.InnerException is DALException dalEx)
            {
                LoggerService.WriteLog(
                    new Log("Error crítico en la capa de datos.", TraceLevel.Error),
                    dalEx
                );

                throw new Exception(
                    $"Ocurrio un error en la base de datos: {dalEx.Message}",
                    dalEx.InnerException
                );
            }

            if (ex.IsBusinessException)
            {
                LoggerService.WriteLog(
                    new Log("Error crítico en la capa de negocio.", TraceLevel.Error),
                    ex
                );

                throw new Exception(
                    $"Ocurrió un error en la capa de negocio: {ex.Message}",
                    ex.InnerException
                );
            }


        }

    }
}
