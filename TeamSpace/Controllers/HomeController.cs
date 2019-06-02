using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TeamSpace.Models;

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

            MessagesModel m = new MessagesModel
            {
                Message1 = "Did my daughter leave her uniform at your house?? I can't find it and its only a few hours away from the competition!!! I am freaking out!",
                Message2 = "I have your daughters uniform. I washed it after she left it at my house when she had a sleepover with Michelle.I'll bring it to the competition.",
                Message3 = "Hey, Just checking in.. Did you remember to bring the Gluten Free Snacks? Also, what is Gluten Free mean?",
                Message4 = "Yes we are good! Also, check the FAQ page dude!",
                Message5 = "Who is your daughter riding with?",
                Message6 = "Who is your daughter riding with?"
            };
            ViewBag.Message = m;
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