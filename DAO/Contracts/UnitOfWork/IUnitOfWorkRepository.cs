
using DAO.Contracts;
using DAO.Contracts.UnitOfWork;

namespace Dao.Contracts.UnitOfWork
{
    public interface IUnitOfWorkRepository
    {
        IClienteDAO ClienteRepository { get; }

        IIngresoDAO IngresoRepository { get; }

        IVehiculoDAO VehiculoRepository { get; }

        ITipoTarifaDAO TipoTarifaRepository { get; }

        IMetodoPagoDAO MetodoPagoRepository { get; }

        IFacturaDAO FacturaRepository { get; }

        IPagoDAO PagoRepository { get; }
    }
}
