using MushtaqTraders.Models;
using MushtaqTraders.Models.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MushtaqTraders.Controllers
{
    public class HomeController : Controller
    {
        DatabaseContext db = new DatabaseContext();
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.ProuctList = new SelectList(GetProductList(), "Id", "Name");
            ViewBag.SupplierList = new SelectList(GetSupplierList(), "Id", "Name");

            return View();
        }
        public ActionResult Purchase()
        {
            ViewBag.ProuctList = new SelectList(GetProductList(), "Id", "Name");
            ViewBag.SupplierList = new SelectList(GetSupplierList(), "Id", "Name");
            return View();
        }
        public void submitForm()
        {

        }
        public List<Supplier> GetSupplierList()
        {
            List<Supplier> Suppliers = db.Suppliers.ToList();
            return Suppliers;

        }
        public List<Product> GetProductList()
        {

            List<Product> Products = db.products.ToList();
            return Products;

        }
    }
}