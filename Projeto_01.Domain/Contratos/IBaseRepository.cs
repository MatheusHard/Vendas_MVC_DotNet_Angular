using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_01.Domain.Contratos
{
    public interface IBaseRepository<TEntity>: IDisposable where TEntity : class
    {
        void Add(TEntity entity);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
        void Remove(TEntity entity);

    }
}
