using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    public sealed class RolMapper : IObjectMapper<Rol>
    {


           #region singleton
            private readonly static RolMapper _instance = new RolMapper();

            public static RolMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private RolMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
       


        public Rol Fill(object[] values)
        {
            Rol rol = new Rol();
            rol.idRol = (int)values[0];
            rol.descripcion = (string)values[1];

            return rol;
        }
    }
}
