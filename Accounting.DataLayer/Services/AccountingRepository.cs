using Accounting.DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    internal class AccountingRepository<TEntity>:IAccountingRepository<TEntity>  where TEntity : class
    {
        Accounting_DBEntities _db;
        DbSet<TEntity> _dbSet;
        public AccountingRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = db.Set<TEntity>();
        }
        public virtual void Delete(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _db.Entry(entity).State = EntityState.Deleted;
        }

        public virtual void DeleteById(object id)
        {
           TEntity entity = _dbSet.Find(id);
            _dbSet.Remove(entity);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            TEntity entity = _dbSet.First();
            if(where != null)
            {
                entity = _dbSet.FirstOrDefault(where);
            }
            return entity;
        }

        public virtual IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null)
        {
            IQueryable<TEntity> _query = _dbSet;
            if (where != null)
            {
                _query = _dbSet.Where(where);
            }
            return _query.ToList();
        }

        public virtual TEntity GetById(object id)
        {
            return _dbSet.Find(id);
        }

        public virtual void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public virtual void Update(TEntity entity)
        {
            if (_db.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
           _db.Entry(entity).State = EntityState.Modified;
        }
    }
}
