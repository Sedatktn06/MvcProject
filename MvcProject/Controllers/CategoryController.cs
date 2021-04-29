using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class CategoryController : Controller
    {
        //ICategoryService _categoryService;

        //public CategoryController()
        //{

        //}

        //public CategoryController(ICategoryService categoryService)
        //{
        //    this._categoryService = categoryService;
        //}

        CategoryManager cm = new CategoryManager();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            var categoryValues = cm.GetAll();
            return View(categoryValues);
        }
        public ActionResult AddCategory(Category category)
        {
            cm.CategoryAdd(category);
            return RedirectToAction("GetCategoryList");
        }

    }
}