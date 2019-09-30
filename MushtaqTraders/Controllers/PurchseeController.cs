using MushtaqTraders.Models;
using MushtaqTraders.Models.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MushtaqTraders.Controllers
{
    public class PurchseeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Purchsee
        public ActionResult Index()
        {
            ViewBag.ProuctList = new SelectList(GetProductList(), "Id", "Name");
            return View();
        }
        public List<Product> GetProductList()
        {
           
            List<Product> Products = db.products.ToList();
            return Products;

        }
    }
}