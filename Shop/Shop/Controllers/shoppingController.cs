using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
using Microsoft.AspNet.Identity;
using System.Net;

namespace Shop.Controllers
{
    public class shoppingController : Controller
    {
        private Entities db = new Entities();
        //
        // GET: /shopping/
        public ActionResult Index()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Jewelry").ToList();
            
            return View(product);
        }


       



        public ActionResult Register()
        {
            return View();
        }
        [Authorize]
        public ActionResult Cart()
        {
            String id = User.Identity.GetUserId();
            var user = db.AspNetUsers.Find(id);
            var list = db.User_Products.Where(x => x.UserId == id).ToList().Select(x => x.Product);
            return View(list);
        }
        public ActionResult Watch()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "watch").ToList();
            return View(product);
        }
        public ActionResult Fashion()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Fashion").ToList();
            return View(product);
        }
        public ActionResult Jewelry()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Jewelry" || m.Catagory == "Ring").ToList();
            return View(product);
        }

        public ActionResult Car()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Car").ToList();
            return View(product);
        }

        public ActionResult Engagement()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Rings" || m.Catagory == "Cloth" || m.Catagory == "Jewelry").ToList();
            return View(product);
        }

        public ActionResult MenJewelry()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Jewelry" && m.Gender == "Men").ToList();
            return View(product);
        }

        public ActionResult MenCloth()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Cloth" && m.Gender == "Men").ToList();
            return View(product);
        }

        public ActionResult WomenCloth()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Cloth" && m.Gender == "Women").ToList();
            return View(product);
        }

        public ActionResult AllJewelry()
        {
            IEnumerable<Product> product = db.Products.Where(m => m.Catagory == "Jewelry" || m.Catagory == "Ring" || m.Catagory == "locket").ToList();
            return View(product);
        }
	}
}