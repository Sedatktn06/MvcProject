using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Repositories
{
    public class CategoryRepository : ICategoryDal
    {
        
        DbSet<Category> _object;

        public void Delete(Category category)
        {
            using(Context context = new Context())
            {
                _object.Remove(category);
                context.SaveChanges();
            }
        }

        public List<Category> Get(Expression<Func<Category, bool>> filter)
        {
            using(Context context=new Context())
            {
                throw new NotImplementedException();
            }
        }

       

        public void Insert(Category category)
        {
            using(Context context = new Context())
            {
               _object.Add(category);
               context.SaveChanges();
            }
           
        }

        public List<Category> GetAll()
        {
            using(Context context = new Context())
            {
                return _object.ToList();
            }
            
        }

        public void Update(Category category)
        {
            using (Context context = new Context())
            {
                context.SaveChanges();
            }
        }
    }
}
