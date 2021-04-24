using EntityLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T:class,IEntity,new()
    {
        List<T> List();
        void Insert(T t);
        void Delete(T t);
        void Update(T t);
    }
}
