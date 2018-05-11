using Aden.Repository;
using Aden.UnitOfWork;

namespace Aden.DADapper
{
    public class AdenUnitOfWork : IUnitOfWork
    {
        public AdenUnitOfWork(string connectionString)
        {
            clientes = new ClienteRepository(connectionString);
        }
        public IClienteRepository clientes { get; private set; }
    }
}
