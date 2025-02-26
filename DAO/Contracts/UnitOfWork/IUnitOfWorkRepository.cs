
using DAO.Contracts;
using DAO.Contracts.UnitOfWork;

namespace Dao.Contracts.UnitOfWork
{
    /// <summary>
    /// //Interface que define los repositorios que se van a utilizar en la unidad de trabajo
    /// </summary>
    public interface IUnitOfWorkRepository
    {

        IIngresoDAO IngresoRepository { get; }

        IVehiculoDAO VehiculoRepository { get; }

        ITipoTarifaDAO TipoTarifaRepository { get; }

        IMetodoPagoDAO MetodoPagoRepository { get; }

        IFacturaDAO FacturaRepository { get; }

    }
}
