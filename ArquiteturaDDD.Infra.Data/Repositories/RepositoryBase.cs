
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using ArquiteturaDDD.Domain.Interfaces;
using ArquiteturaDDD.Domain.Interfaces.Repositories;
using ArquiteturaDDD.Infra.Data.Contexto;

namespace ArquiteturaDDD.Infra.Data.Repositories
{
   public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity :class 
   {
       protected ArquiteturaDDDContext Db = new ArquiteturaDDDContext();

       public void add(TEntity obj)
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

       public void Update(TEntity obj)
       {
            Db.Entry(obj).State = EntityState.Modified;
           Db.SaveChanges();
       }

       public void Remove(TEntity obj)
       {
           Db.Set<TEntity>().Remove(obj);
           Db.SaveChanges();
       }

       void IRepositoryBase<TEntity>.Dispose()
       {
           throw new NotImplementedException();
       }

       void IDisposable.Dispose()
       {
           throw new NotImplementedException();
       }
   }
}
