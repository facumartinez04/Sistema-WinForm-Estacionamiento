using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    public class FamiliaPatenteMapper : IObjectMapper<FamiliaPatente>
    {
        #region singleton
        private readonly static FamiliaPatenteMapper _instance = new FamiliaPatenteMapper();

        public static FamiliaPatenteMapper Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaPatenteMapper()
        {
            //Implent here the initialization of your singleton
        }
        #endregion

        public FamiliaPatente Fill(object[] values)
        {
            FamiliaPatente familiaPatente = new FamiliaPatente();
            familiaPatente.idFamilia = Guid.Parse(values[0].ToString());
            familiaPatente.idPatente = Guid.Parse(values[1].ToString());
            return familiaPatente;
        }
    }
}
