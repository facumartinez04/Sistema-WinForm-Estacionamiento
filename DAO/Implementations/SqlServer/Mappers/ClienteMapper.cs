using Dao.Contracts;
using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.Implementations.SqlServer.Mappers
{
    internal class ClienteMapper : IObjectMapper<Cliente>
    {


     #region singleton
            private readonly static ClienteMapper _instance = new ClienteMapper();

            public static ClienteMapper Current
            {
                get
                {
                    return _instance;
                }
            }

            private ClienteMapper()
            {
                //Implent here the initialization of your singleton
            }
        #endregion




        public Cliente Fill(object[] values)
        {

                Cliente cliente = new Cliente();
                cliente.idCliente = (Guid)values[0];
                cliente.nombre = (string)values[1];
                cliente.dni = (int)values[2];
                cliente.fechaNacimiento = (DateTime)values[3];
                return cliente;
        }

		
    }
}
