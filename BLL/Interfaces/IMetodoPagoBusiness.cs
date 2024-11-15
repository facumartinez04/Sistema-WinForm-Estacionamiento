using DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    internal interface IMetodoPagoBusiness : IGenericBusiness<MetodoPago>
    {

        void Eliminar(int id);

        MetodoPago ObtenerPorId(int id);

    }
}
