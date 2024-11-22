using SERVICE.Domain.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE.DAL.Contracts
{
    internal interface IUsuarioPatenteDAO : IGenericDAO<UsuarioPatente>
    {
        List<UsuarioPatente> usuarioPatentes(Guid idUsuario);
    }
}
