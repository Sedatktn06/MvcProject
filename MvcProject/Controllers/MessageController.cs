using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProject.Controllers
{
    public class MessageController : Controller
    {
        // GET: Message
        public ActionResult Inbox()
        {
            return View();
        }
    }
}