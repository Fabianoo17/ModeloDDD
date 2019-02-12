using Domain.Interfaces;
using Infrastructure.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
namespace Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected ModeloDDDContext Db = new ModeloDDDContext();

        public void Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            Db.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
           return Db.Set<TEntity>().ToList();
        }

        public void Update(TEntity Obj)
        {
            Db.Entry(Obj).State = EntityState.Modified;
            Db.SaveChanges();
        }

        public void Remove(TEntity Obj)
        {
            Db.Set<TEntity>().Remove(Obj);
            Db.SaveChanges();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
    
}
