using BloginSystem.Data;
using BloginSystem.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BloginSystem.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly BlogingContext _blogingContext;
        private DbSet<TEntity> entities;
        public Repository(BlogingContext blogingContext)
        {
            _blogingContext = blogingContext;
            entities = _blogingContext.Set<TEntity>();
        }
        public List<TEntity> GetAll()
        {
            return entities.ToList();
        }
        public TEntity GetById(int id)
        {
            var a = entities.Where(x => x.Id == id).FirstOrDefault();
            return a;
        }
        public void Insert(TEntity entity) 
        { 
           entities.Add(entity);
           _blogingContext.SaveChanges();
        }
        public void Delete(TEntity entity)
        {
            entities.Remove(entity);
            _blogingContext.SaveChanges();
        }
        public void Update(TEntity entity)
        {
            entities.Update(entity);
            _blogingContext.SaveChanges();
        }


    }

}
