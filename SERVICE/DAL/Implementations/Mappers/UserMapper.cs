using SERVICE.DAL.Contracts;
using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Implementations.Mappers
{
    internal class UserMapper : IObjectMapper<Usuario>
    {


       
         #region singleton
            private readonly static UserMapper _instance = new UserMapper();

            public static UserMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private UserMapper()
            {
                //Implent here the initialization of your singleton
            }
            #endregion
        


        public Usuario Fill(object[] values)
        {
            return new Usuario
            {
                IdUsuario = (Guid)values[0],
                UserName = (string)values[1],
                Password = (string)values[2],



            };
        }
    }
}
