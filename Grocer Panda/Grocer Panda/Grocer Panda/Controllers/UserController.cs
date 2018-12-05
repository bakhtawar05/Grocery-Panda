using Grocer_Panda.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Grocer_Panda.Controllers
{
    public class UserController : Controller
    {
        GroceryEntities1 db = new GroceryEntities1();

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(CustomerInfo cust)
        {
            string message = "";
            bool status = false;
            if (ModelState.IsValid)
            {
                Customer ct = new Customer();
                ct.Email = cust.Email;
                ct.CustomerName = cust.Customer_Name;
                ct.Pasword = cust.Pasword;
                ct.Phone_ = cust.Phone_;
                ct.city = cust.city;
                message = "Succssessfully reistered";
                db.Customers.Add(ct);
                db.SaveChanges();
                return RedirectToAction("Login", "User");
            }
            else
            {
                message = "Incorrect information";
                status = true;
            }
            ViewBag.Message = message;
            ViewBag.Status = status;
            return View(cust);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(CustomerInfo cust)
        {
            string dis = "";
            bool df = false;
            var ke = db.Customers.Where(fd => fd.CustomerName == cust.Customer_Name && fd.Pasword ==cust.Pasword).FirstOrDefault();
            if (ke != null)
            {
                dis = "successfully login";
                return RedirectToAction("Profile");
            }
            else
            {
                dis = "Incorrect information";
            }
            ViewBag.Status = df;
            ViewBag.Message = dis;
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }


        [Authorize]
        [HttpGet]
        public ActionResult ShowProducts()
        {
            GroceryEntities1 Gro = new GroceryEntities1();
            List<Product> pd = Gro.Products.ToList();
            return View(pd);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginUser", "User");
        }
    }
}