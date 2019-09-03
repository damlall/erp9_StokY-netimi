using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sy.Core.Abstracts
{
    public interface IRepository<TEntity,Tkey> 
        where TEntity : IEntity<Tkey> // iki tiple çalışcak entitynn tipi bide anahtarının tipi tentitye bağlı şeyler ıentıtyden gelsin tkey le bağladık
    {
        TEntity GetById(Tkey id);
        Tkey Insert(TEntity entity);
        int Update(TEntity entity);
        int Delete(TEntity entity);
        int Save();
        IQueryable<TEntity> Query(Expression<Func<TEntity,bool>> predicate = null);

    }
}
