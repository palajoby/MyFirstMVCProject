using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFirstMVCProject.Services;

namespace MyFirstMVCProject.Controllers
{
    public class FirstController : Controller
    {
        private IMailService _obj;

        public FirstController(IMailService obj)
        {
            _obj = obj;
        }
        
        // GET: First
        public ActionResult First()
        {
            ViewBag.Message = "First";
            Session["First"] = "First";
            return View();
        }

        public ActionResult Second()
        {
            ViewBag.Message = "First";
            Session["First"] = "First";
            return View();
        }
        [HttpPost]
        public ActionResult Second(SecondModel mymodel)
        {
            //var emailobj = new MailService();
            _obj.sendEmail();
            ViewBag.MailSent = "True";
            return View();
        }
    }

   
}