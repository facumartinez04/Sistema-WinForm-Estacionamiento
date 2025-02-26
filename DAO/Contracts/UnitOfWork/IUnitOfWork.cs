namespace Dao.Contracts.UnitOfWork
{
    /// <summary>
    /// //UnitOfWork interface
    /// </summary>
    public interface IUnitOfWork
    {
        IUnitOfWorkAdapter Create();
    }
}
