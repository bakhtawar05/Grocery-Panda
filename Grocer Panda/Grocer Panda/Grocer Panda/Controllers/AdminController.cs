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
    
        [HttpGet]
        public ActionResult AddProducts()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public ActionResult AddProducts(ProductDb product)
        {

            if (db.Products.Any(x => x.name == product.name))
            {
                ViewBag.DuplicateMessage = "Product Already exists";
                return View(product);
            }
            else
            {
                string filename = Path.GetFileNameWithoutExtension(product.ImageFile.FileName);
                string extension = Path.GetExtension(product.ImageFile.FileName);
                filename = filename + DateTime.Now.ToString("yymmssfff") + extension;
                product.image = "~/Image/" + filename;
                filename = Path.Combine(Server.MapPath("~/Image/"), filename);
                product.ImageFile.SaveAs(filename);

                Product p = new Product();
                p.name = product.name;
                p.Id = product.Id;
                p.quantity = product.quantity;
                p.image = product.image;
                p.category = product.category;
                p.price = product.price;
                db.Products.Add(p);
                db.SaveChanges();
                ModelState.Clear();
                ViewBag.SuccessMessage = "Successful";
                return View();
            }
            
        }

        [HttpGet]
        public ActionResult ShowProducts()
        {
            GroceryEntities1 Gro = new GroceryEntities1();
            List<Product> data = Gro.Products.ToList();
            return View(data);
        }

        [Authorize]
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("LoginUser", "Admin");
        }
        // GET: Products/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(System.Net.HttpStatusCode.BadRequest);
            }
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return HttpNotFound();
            }
            return View(product);
        }

        public ActionResult Profile()
        {
            return View();
        }

    }
}