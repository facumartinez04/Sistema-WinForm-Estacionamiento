using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    public class UsuarioPatenteMapper : IObjectMapper<UsuarioPatente>
    {



        #region singleton
        private readonly static UsuarioPatenteMapper _instance = new UsuarioPatenteMapper();

        public static UsuarioPatenteMapper Current
        {
            get
            {
                return _instance;
            }
        }

        private UsuarioPatenteMapper()
        {
            //Implent here the initialization of your singleton
        }
        #endregion


        public UsuarioPatente Fill(object[] values)
        {
            return new UsuarioPatente
            {
                idUsuario = (Guid)values[0],
                idPatente = (Guid)values[1]
            };
        }
    }
}
