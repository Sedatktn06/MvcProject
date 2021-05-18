using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        T Get(Expression<Func<T, bool>> filter);
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        List<T> List(Expression<Func<T, bool>> filter);
    }
}
