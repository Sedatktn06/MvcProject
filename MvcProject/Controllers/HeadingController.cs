using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class HeadingController : Controller
    {

        HeadingManager headingManager = new HeadingManager(new EfHeadingDal());
        
        public ActionResult Index()
        {
            var headingValues = headingManager.GetAll();
            return View(headingValues);
        }
    }
}