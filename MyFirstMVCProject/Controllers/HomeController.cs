using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCProject.Controllers
{
    public class HomeController : Controller
    {
        SurveyEntities _context = new SurveyEntities();
        public ActionResult Index()
        {
            try
            {
                this.bindDropdown();
                //this.initialiseList();
                return View();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public void bindDropdown()
        {
            try
            {
                List<SessionSelect_Result> sessions = _context.SessionSelect().ToList();
                ViewBag.sessionlist = new SelectList(sessions, "SessionId", "Session");
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

       
    }
}