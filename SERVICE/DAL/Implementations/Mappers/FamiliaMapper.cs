using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    public  sealed class FamiliaMapper : IObjectMapper<Familia>
    {


     
            #region singleton
            private readonly static FamiliaMapper _instance = new FamiliaMapper();

            public static FamiliaMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private FamiliaMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public Familia Fill(object[] values)
        {
            Familia familia = new Familia();
            familia.Id = Guid.Parse(values[0].ToString());
            familia.Nombre = values[1].ToString();
            return familia;
        }
    }
}
