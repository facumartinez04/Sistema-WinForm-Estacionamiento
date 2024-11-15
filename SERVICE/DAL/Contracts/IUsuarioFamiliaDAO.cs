using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Contracts
{
    internal interface IUsuarioFamiliaDAO : IGenericDAO<UsuarioFamilia>
    {
        List<UsuarioFamilia> GetFamiliasByUsuario(Guid idUsuario);
    }
}
