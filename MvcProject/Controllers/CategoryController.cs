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

        CategoryManager categoryManager = new CategoryManager();

        // GET: Category
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GetCategoryList()
        {
            //var categoryValues = categoryManager.GetAll();
            return View();
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddCategory(Category category)
        {
            //categoryManager.CategoryAdd(category);
            return RedirectToAction("GetCategoryList");
        }

    }
}