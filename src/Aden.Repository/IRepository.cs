using System.Collections.Generic;

namespace Aden.Repository
{
    public interface IRepository<Datos> where Datos : class
    {
        int Insert(Datos entity);
        int Delete(Datos entity);
        int Update(Datos entity);
        IEnumerable<Datos> GetList();
        Datos GetById(int id);
    }
}
}
