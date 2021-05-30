using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        // GET: About
        public ActionResult Index()
        {
            var aboutValues = aboutManager.GetAll();
            return View(aboutValues);
        }

        [HttpGet]
        public ActionResult AddAbout()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddAbout(About about)
        {
            aboutManager.AboutAdd(about);
            return RedirectToAction("Index");
        }


        public PartialViewResult AboutPartial()
        {
            return PartialView();
        }

    }
}