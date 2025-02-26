using System;

namespace Dao.Contracts.UnitOfWork
{

    /// <summary>
    /// //UnitOfWorkAdapter Interface
    /// </summary>
    public interface IUnitOfWorkAdapter : IDisposable
    {
        IUnitOfWorkRepository Repositories { get; }
        void SaveChanges();
    }
}
