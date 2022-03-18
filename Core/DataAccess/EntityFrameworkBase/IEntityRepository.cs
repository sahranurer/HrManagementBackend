using Core.Concrete.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityRepository<T> where T :class,IEntity,new()
    {
        T Get(Expression<Func<T,bool>> filter);
        IList<T> GetAll(Expression<Func<T,bool>> filter =null);
        void Update(T entity);
        void Add(T entity);
        void Delete(T entity);

    }
}
