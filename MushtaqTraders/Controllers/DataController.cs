using MushtaqTraders.Models;
using MushtaqTraders.Models.RequestObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MushtaqTraders.Controllers
{
    public class DataController : ApiController
    {
        DatabaseContext _db = new DatabaseContext();
        [HttpGet]
        public string getSuppliers()
        {
            return JsonConvert.SerializeObject(_db.Suppliers.ToList());
        }

        [HttpGet]
        public string getproducts()
        {
            return JsonConvert.SerializeObject(_db.products.ToList());
        }
        [HttpPost]
        public string addPurchase(string isExisting, string productName, string productId, string purchaseprice, string supplierId)
        {
           // var body = Request.Content.ReadAsStringAsync();
            // save data and return message
           return "save" ;
        }
       
    }
}
