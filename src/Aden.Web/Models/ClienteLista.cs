using Aden.Models;
using System.Collections.Generic;

namespace Aden.Web.Models
{
    public class ClienteLista
    {
        public ClienteLista(IEnumerable<Cliente> clientes)
        {
            Clientes = clientes;
        }
        public IEnumerable<Cliente> Clientes { get; set; }
    }
}
