using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    public sealed class RolMapper 
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
       


    
    }
}
