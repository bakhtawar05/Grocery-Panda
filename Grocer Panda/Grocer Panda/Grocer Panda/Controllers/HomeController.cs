using Grocer_Panda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grocer_Panda.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Single()
        {
            return View();
        }

        public ActionResult Vegetables()
        {
            return View();
        }

        [Authorize]
        public ActionResult Products()
        {
            return View();
        }

        [Authorize]
        public ActionResult Services()
        {
            return View();
        }
        public ActionResult Reset_Pasword()
        {
            return View();
        }
  
    
        [HttpGet]
        public ActionResult SignUpExp()
        {
            CustomerInfo ci = new CustomerInfo();
            return View(ci);
        }



        public ActionResult FAQS()
        {
            return View();
        }

        public ActionResult Privacy()
        {
            return View();
        }
        public ActionResult Kitchen()
        {
            return View();
        }

        


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Households()
        {
            return View();
        }

        public ActionResult Frozen()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Bread()
        {
            return View();
        }



        public ActionResult Drinks()
        {
            return View();
        }


        public ActionResult Events()
        {
            return View();
        }




        public ActionResult Mail()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
        public ActionResult Payment()
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