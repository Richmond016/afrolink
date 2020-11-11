using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RescuRect.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Transfer()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }


        public ActionResult Register_Inmate()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Cell_maintenance()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}