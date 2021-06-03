using BusinessLayer.Concrete;
using BusinessLayer.FluentValidation;
using DataAccessLayer.Concrete;
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
        Context context = new Context();


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
            var receiverMail = context.Messages.Count(m => m.ReceiverMail == "admin@gmail.com").ToString();
            ViewBag.ReceiverMail = receiverMail;

            var senderMail = context.Messages.Count(m => m.SenderMail == "admin@gmail.com").ToString();
            ViewBag.SenderMail = senderMail;

            var contact = context.Contacts.Count().ToString();
            ViewBag.Contact = contact;

            return PartialView();
        }
     
    }
}