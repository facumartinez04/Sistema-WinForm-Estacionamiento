using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    internal sealed class TipoTarifaMapper : IObjectMapper<TipoTarifa>
    {


      
        #region singleton
            private readonly static TipoTarifaMapper _instance = new TipoTarifaMapper();

            public static TipoTarifaMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private TipoTarifaMapper()
            {
                //Implent here the initialization of your singleton
            }
        #endregion

        /// <summary>
        /// //Con fill vamos a concretar la adapción de cada backend en un objeto de nuestra app.
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public TipoTarifa Fill(object[] values)
        {
            return new TipoTarifa
            {
                idTipoTarifa = (int)values[0],
                monto_por_hora = Convert.ToDouble(values[1].ToString()),
                descripcion = values[2].ToString()
            };
        }
    }
}
