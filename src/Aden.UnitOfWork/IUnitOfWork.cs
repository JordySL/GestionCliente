using Aden.Repository;

namespace Aden.UnitOfWork
{
    public interface IUnitOfWork
    {
        IClienteRepository clientes { get; }
    }
}
