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
           

            return View();
        }
        public ActionResult Purchase()
        {
           
            return View();
        }
        public void submitForm()
        {

        }
        public ActionResult sale()
        {

            return View();
        }

    }
}