using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repository
{
    public interface IAccountingRepository<TEntity> where TEntity : class
    {
        void DeleteById(object id);
        void Delete(TEntity entity);
        void Insert(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> where = null);
        TEntity Get(Expression<Func<TEntity,bool>> where);
        TEntity GetById(object id);
    }
}
