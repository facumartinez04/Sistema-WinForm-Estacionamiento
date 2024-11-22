using SERVICE.DAL.Contracts;
using SERVICE.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    internal class BitacoraMapper : IObjectMapper<Bitacora>
    {


	
			#region singleton
			private readonly static BitacoraMapper _instance = new BitacoraMapper();

			public static BitacoraMapper Current
			{
				get
				{
					return _instance;
				}
			}

			private BitacoraMapper()
			{
				//Implent here the initialization of your singleton
			}
			#endregion
		

		public Bitacora Fill(object[] values)
        {

            Bitacora bitacora = new Bitacora();
            bitacora.idBitacora = (Guid)values[0];
            bitacora.usuario = (string)values[1];
            bitacora.fecha = (DateTime)values[2];
            bitacora.accion = (string)values[3];
            if (values[4] != DBNull.Value) bitacora.detalles = (string)values[4];
			else bitacora.detalles = "";
            return bitacora;

        }
    }
}
