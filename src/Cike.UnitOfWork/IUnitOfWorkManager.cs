namespace Cike.UnitOfWork
{
    public interface IUnitOfWorkManager
    {
        public IUnitOfWork CurrentUnitOfWork { get; }

        public IUnitOfWork Create(UnitOfWorkOptions unitOfWorkOptions = null);
    }
}