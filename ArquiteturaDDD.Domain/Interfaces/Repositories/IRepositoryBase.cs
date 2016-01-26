

using System.Collections.Generic;

namespace ArquiteturaDDD.Domain.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void add(TEntity obj);
        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        void Dispose();

    }
}
