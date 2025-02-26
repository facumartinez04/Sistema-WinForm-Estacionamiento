using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    public sealed class FacturaMapper : IObjectMapper<Factura>
    {

		
			#region singleton
			private readonly static FacturaMapper _instance = new FacturaMapper();

			public static FacturaMapper Current
			{
				get
				{
					return _instance;
				}
			}

			private FacturaMapper()
			{
				//Implent here the initialization of your singleton
			}
        #endregion


        /// <summary>
        /// //Con fill vamos a concretar la adapción de cada backend en un objeto de nuestra app.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public Factura Fill(object[] values)
        {
            Factura factura = new Factura();
            factura.idFactura = (int)values[0];
            factura.ingreso = new Ingreso();
			factura.ingreso.idIngreso = (Guid)values[1];
            factura.metodoPago = new MetodoPago();
            factura.metodoPago.idMetodoPago = (int)values[2];

            factura.monto_total = (Decimal)values[3];

			factura.fechaRegistro = (DateTime)values[4];

            factura.verificador = (string)values[5];
            return factura;
        }
    }
}
