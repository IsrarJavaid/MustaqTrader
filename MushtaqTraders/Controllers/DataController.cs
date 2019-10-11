using MushtaqTraders.Models;
using MushtaqTraders.Models.DomainObjects;
using MushtaqTraders.Models.RequestObjects;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
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
        public string getCategory()
        {
            return JsonConvert.SerializeObject(_db.Categories.ToList());
        }

        [HttpGet]
        public string getproducts()
        {
            return JsonConvert.SerializeObject(_db.products.ToList());
        }
        [HttpPost]
        public string addPurchase()
        {
            var responseBody = Request.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<AddPurchaseModel>(responseBody.Result);
            if (obj.isExisting)
            {
                Purchase p = new Purchase()
                {
                    Date = DateTime.Now,
                    Description = "Purchased on 30 day credit",
                    Supplier = _db.Suppliers.Where(x => x.Id == obj.supplierId).FirstOrDefault(),
                    TotalBill = obj.TBId,
                   

                };
                _db.Purchases.Add(p);
                _db.SaveChanges();
                PurchaseProduct pp = new PurchaseProduct()
                {
                    ProductId = (int)obj.productId,
                    PurchasingPrice = obj.purchaseprice,
                    Quantity = obj.QuantityId,
                    PurchaseId = _db.Purchases.ToList().LastOrDefault().Id,
                    
                };
                _db.PurchaseProducts.Add(pp);
                var purchasedProduct = _db.products.Where(x => x.Id == obj.productId).FirstOrDefault();
                purchasedProduct.Quantity += obj.QuantityId;

                _db.SaveChanges();
            }
            else
            {
                //insert
                Product prod = new Product() {
                    Name = obj.productName,
                    Description = "New item ",
                    Quantity = obj.QuantityId,
                    
                };
                _db.products.Add(prod);
                _db.SaveChanges();


                Purchase p = new Purchase()
                {
                    Date = DateTime.Now,                   
                    Supplier = _db.Suppliers.Where(x => x.Id == obj.supplierId).FirstOrDefault(),
                    TotalBill = obj.TBId,
                    Description="item purchased"

                };
                _db.Purchases.Add(p);
                _db.SaveChanges();

                PurchaseProduct pp = new PurchaseProduct()
                {
                    //Update
                    ProductId = _db.products.ToList().LastOrDefault().Id,
                    PurchasingPrice = obj.purchaseprice,
                    PurchaseId = _db.Purchases.ToList().LastOrDefault().Id,
                    Quantity = obj.QuantityId,
                    
                };
                _db.PurchaseProducts.Add(pp);
                _db.SaveChanges();
                //1- add product
                //2- add in purchase product table
            }

            return "Purchase Successfully Done!!!";
        }
        [HttpPost]
        public string addSale()
        {
            var responseBody = Request.Content.ReadAsStringAsync();
            var obj = JsonConvert.DeserializeObject<AddSaleModel>(responseBody.Result);

         
                Sale s = new Sale() {
                    Date = DateTime.Now,
                    TotalBill = obj.TotalBill,

                   
                };
                _db.Sales.Add(s);
                _db.SaveChanges();
                SaleProduct sp = new SaleProduct() {
                    ProductId = obj.productId,
                    SaleId = _db.Sales.ToList().FirstOrDefault().Id,
                    Quantity = obj.QuantityId,
                    SellingPrice=obj.SellingPrice

                };
                _db.SaleProducts.Add(sp);
                var saleProduct = _db.products.Where(x => x.Id == obj.productId).FirstOrDefault();
                saleProduct.Quantity -= obj.QuantityId;

                _db.SaveChanges();

            

            return "Sale Successfully Done!!!";
        }
    }
}

