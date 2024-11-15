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
		


		public Factura Fill(object[] values)
        {
            Factura factura = new Factura();
            factura.idFactura = (int)values[0];
            factura.ingreso.idIngreso = (Guid)values[1];
            factura.metodoPago.idMetodoPago = (int)values[2];
            factura.monto_total = (Double)values[3];
            return factura;
        }
    }
}
