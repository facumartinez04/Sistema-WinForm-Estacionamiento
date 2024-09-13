using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    internal sealed class IngresoMapper : IObjectMapper<Ingreso>
    {

		#region singleton
			private readonly static IngresoMapper _instance = new IngresoMapper();

			public static IngresoMapper Current
			{
				get
				{
					return _instance;
				}
			}

			private IngresoMapper()
			{
			}

		#endregion

		public Ingreso Fill(object[] values)
		{
			Ingreso ingreso = new Ingreso();
			ingreso.idIngreso = (Guid)values[0];
            ingreso.vehiculo = new Vehiculo() { idVehiculo = (Guid)values[1] };
            ingreso.cliente = new Cliente() { idCliente = (Guid)values[2] };
			ingreso.fechaIngreso = DateTime.Parse(values[3].ToString());

			if (values[4] != DBNull.Value) {
				ingreso.fechaEgreso = DateTime.Parse(values[4].ToString());
			} else
			{
				ingreso.fechaEgreso = DateTime.Parse("01/01/0001");

			}

            return ingreso;
        }

    }
}
