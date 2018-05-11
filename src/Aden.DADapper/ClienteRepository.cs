using Aden.Dapper;
using Aden.Models;
using Aden.Repository;

namespace Aden.DADapper
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(string connectionString) : base(connectionString)
        {
        }
    }
}
