using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WhitelabelHousehold.Models;

namespace WhitelabelHousehold.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // On form POST method

        [HttpPost]
        public ActionResult YourQuote(YourDetailsQuestions model)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("YourQuote");
            }

            return View("Index");
        }

        // ----------------------------------------------------------------------------------

        public ActionResult YourQuote()
        {
            return View();
        }

        // -------------------------------------------------------------------

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
