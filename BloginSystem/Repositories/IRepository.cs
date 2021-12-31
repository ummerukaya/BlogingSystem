using BloginSystem.Entities;
using System.Collections.Generic;

namespace BloginSystem.Repositories
{
    public interface IRepository<TEntity> where TEntity : BaseEntity
    {

        void Delete(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        
    }
}