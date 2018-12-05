using Grocer_Panda.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Grocer_Panda.Controllers
{
    public class AdminController : Controller
    {

        GroceryEntities1 db = new GroceryEntities1();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Admin ad)
        {
            string dis = "";
            bool df = false;
            var ke = db.adminbds.Where(fd => fd.name == ad.name && fd.password == ad.password).FirstOrDefault();
            if(ke!= null)
            {
                dis = "successfully login";
                return RedirectToAction("ShowProducts");
            }
            else
            {
                dis = "Incorrect information";
            }
            ViewBag.Status = df;
            ViewBag.Message = dis;
            return View();
        }

        [HttpGet]
        public ActionResult Register(int id=0)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(Admin ad)
        {
            string message = "";
            bool sta = false;
            if (ModelState.IsValid)
            {
                adminbd admin = new adminbd();
                admin.name = ad.name;
                admin.password = ad.password;
                admin.storeName = ad.storeName;
                admin.contact = ad.contact;
                admin.address = ad.address;
                message = "Succssessfully reistered";
                db.adminbds.Add(admin);
                db.SaveChanges();
                return RedirectToAction("Login", "Admin");
            }
            else
            {
                message = "Incorrect information";
                sta = true;
            }
            ViewBag.Message = message;
            ViewBag.Status = sta;
            return View(ad);
        }
        

    }
}