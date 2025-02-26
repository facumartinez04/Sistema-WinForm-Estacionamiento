using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    internal sealed class VehiculoMapper : IObjectMapper<Vehiculo>
    {


	
		#region singleton
			private readonly static VehiculoMapper _instance = new VehiculoMapper();

			public static VehiculoMapper Current
			{
				get
				{
					return _instance;
				}
			}

			private VehiculoMapper()
			{
				//Implent here the initialization of your singleton
			}
        #endregion

        /// <summary>
        /// //Con fill vamos a concretar la adapción de cada backend en un objeto de nuestra app.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public Vehiculo Fill(object[] values)
        {
			Vehiculo vehiculo = new Vehiculo();
            vehiculo.idVehiculo = (Guid)values[0];
            vehiculo.patente = values[1].ToString();
            vehiculo.marca = values[2].ToString();
            vehiculo.modelo = values[3].ToString();
            return vehiculo;
        }
    }
}
