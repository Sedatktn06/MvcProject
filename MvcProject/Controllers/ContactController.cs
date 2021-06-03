using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class ContactController : Controller
    {

        ContactManager contactManager = new ContactManager(new EfContactDal());
        ContactValidator contactValidator = new ContactValidator();


        // GET: Contact
        public ActionResult Index()
        {
            var contactValues = contactManager.GetAll();
            return View(contactValues);
        }


        public ActionResult GetContactDetails(int id)
        {
            var contactValues = contactManager.GetById(id);
            return View(contactValues);
        }

        public PartialViewResult ContactDetailsPartial()
        {
            return PartialView();
        }
     
    }
}