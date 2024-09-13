using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    internal sealed class PagoMapper : IObjectMapper<Pago>
    {


            #region singleton
            private readonly static PagoMapper _instance = new PagoMapper();

            public static PagoMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private PagoMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public Pago Fill(object[] values)
        {
            Pago pago = new Pago();
            pago.idPago = (int)values[0];
            pago.factura = new Factura() { idFactura = (int)values[1] };
            pago.metodoPago = new MetodoPago() { idMetodoPago = (int)values[2] };
            pago.monto = (Double)values[3];
            return pago;
        }
    }
}
