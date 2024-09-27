using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    public sealed class PatenteMapper : IObjectMapper<Patente>
    {


      
            #region singleton
            private readonly static PatenteMapper _instance = new PatenteMapper();

            public static PatenteMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private PatenteMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public Patente Fill(object[] values)
        {
            Patente patente = new Patente();
            patente.Id = Guid.Parse(values[0].ToString());
            patente.DataKey = values[1].ToString();

            return patente;
        }
    }
}
