using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    public sealed class MetodoPagoMapper : IObjectMapper<MetodoPago>
    {

      
            #region singleton
            private readonly static MetodoPagoMapper _instance = new MetodoPagoMapper();

            public static MetodoPagoMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private MetodoPagoMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
        


        public MetodoPago Fill(object[] values)
        {
            MetodoPago metodoPago = new MetodoPago();
            metodoPago.idMetodoPago = (int)values[0];
            metodoPago.descripcion = (string)values[1];
            return metodoPago;
        }
    }
}
