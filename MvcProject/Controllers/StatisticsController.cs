using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class StatisticsController : Controller
    {

        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        Context context = new Context();

        // GET: Statistics
        public ActionResult Index()
        {
            var result1 = context.Categories.Count();
            ViewBag.CategoryCount = result1;

            var result2 = context.Headings.Count(c => c.CategoryID == 14);
            ViewBag.HeadingCount = result2;

            var result3 = context.Writers.Count(c => c.WriterName.Contains("a"));
            ViewBag.ContainA = result3;

            var result4 = context.Categories.Where(x => x.CategoryID == context.Headings.GroupBy(y => y.CategoryID).OrderByDescending(z => z.Count()).Select(t => t.Key).FirstOrDefault()).Select(k => k.CategoryName).FirstOrDefault();
            ViewBag.HeadingMax = result4;

            var result5 = context.Categories.Count(c => c.CategoryStatus == true);
            var result6 = context.Categories.Count(c => c.CategoryStatus == false);
            var result7 = result6 - result5;
            var result8 = System.Math.Abs(result7);
            ViewBag.Difference = result8;

            

            return View();
        }

        
    }
}