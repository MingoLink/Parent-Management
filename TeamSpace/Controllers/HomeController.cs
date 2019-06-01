using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TeamSpace.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult Account()
		{
			ViewBag.Message = "Your Account page.";

			return View();
		}

		public ActionResult Calendar()
		{
			ViewBag.Message = "Your Calendar page.";

			return View();
		}

        public ActionResult Squads()
        {
            ViewBag.Message = "Your Squads page.";
            return View();
        }

        public ActionResult Messages()
        {
            ViewBag.Message = "Your Messages page.";

            return View();
        }

        public ActionResult FAQ()
        {
            ViewBag.Message = "Your FAQs page.";

            return View();
        }

        public ActionResult FreshmanSquad()
        {
            ViewBag.Message = "Freshman Squad Page.";
            return View(); 
        }

        public ActionResult ProfileDarrenBrown()
        {
            ViewBag.Message = "Darren Brown's Profile.";
            return View(); 
        }

        public ActionResult Event()
        {
            ViewBag.Message = "Cheerapalooza";
            return View();
        }
    }
}