using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    public class UsuarioFamiliaMapper : IObjectMapper<UsuarioFamilia>
    {


            #region singleton
            private readonly static UsuarioFamiliaMapper _instance = new UsuarioFamiliaMapper();

            public static UsuarioFamiliaMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private UsuarioFamiliaMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
        


        public UsuarioFamilia Fill(object[] values)
        {
            return new UsuarioFamilia
            {
                idUsuario = (Guid)values[0],
                idFamilia = (Guid)values[1]
            };
        }
    }
}
