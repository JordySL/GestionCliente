using Aden.Models;
using Aden.UnitOfWork;
using System.Collections.Generic;

namespace Aden.Business
{
    public interface IClienteBusiness
    {
        IEnumerable<Cliente> GetClientes();
        int InsertCliente(Cliente cliente);
        int UpdateCliente(Cliente cliente);
        Cliente GetCliente(int id);
        int DeleteCliente(Cliente cliente);
    }
    public class ClienteBusiness : IClienteBusiness
    {
        private readonly IUnitOfWork _unitofWork;
        public ClienteBusiness(IUnitOfWork unitOfwork)
        {
            _unitofWork = unitOfwork;
        }
        public int DeleteCliente(Cliente cliente)
        {
            return _unitofWork.clientes.Delete(cliente);
        }
        public Cliente GetCliente(int id)
        {
            return _unitofWork.clientes.GetById(id);
        }
        public IEnumerable<Cliente> GetClientes()
        {
            return _unitofWork.clientes.GetList();
        }
        public int InsertCliente(Cliente cliente)
        {
            return _unitofWork.clientes.Insert(cliente);
        }
        public int UpdateCliente(Cliente cliente)
        {
            return _unitofWork.clientes.Update(cliente);
        }
    }
}
