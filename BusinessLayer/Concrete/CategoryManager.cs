using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public List<Category> GetAll()
        {
            return _categoryDal.GetAll();
        }
        public void CategoryAdd(Category category)
        {
            if (category.CategoryName=="" || category.CategoryName.Length<=3 || category.CategoryDescription=="" || category.CategoryName>=51)
            {
                //Hata Mesajı
            }
            else
            {
                _categoryDal.Insert(category);
            }
        }
    }
}
