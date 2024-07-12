using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DqdK22CNT3Lesson12_2210900139.Controllers
{
    public class DqdHomeController : Controller
    {
        public ActionResult DqdIndex()
        {
            return View();
        }

        public ActionResult DqdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult DqdContact()
        {
            ViewBag.msv = "2210900139";
            ViewBag.fullname = "Đinh Quốc Đạt";

            return View();
        }
    }
}