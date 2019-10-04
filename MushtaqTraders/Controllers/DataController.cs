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
                    Quantity = obj.QuantityId,
                    Supplier = _db.Suppliers.Where(x => x.Id == obj.supplierId).FirstOrDefault(),
                    TotalBill = obj.TBId,
                };
                _db.Purchases.Add(p);
                _db.SaveChanges();
                PurchaseProduct pp = new PurchaseProduct()
                {
                    ProductId = obj.productId,
                    PurchasingPrice = obj.purchaseprice,
                    PurchaseId = _db.Purchases.ToList().LastOrDefault().Id,
                    Quantity = obj.QuantityId,
                };
                _db.PurchaseProducts.Add(pp);
                var purchasedProduct = _db.products.Where(x => x.Id == obj.productId).FirstOrDefault();
                purchasedProduct.Quantity += obj.QuantityId;

                _db.SaveChanges();
            }
            else
            {
                Product prod = new Product() {
                    Id = obj.productId,
                    Name = obj.productName,
                    Description = "New item ",
                    Quantity = obj.QuantityId,
                    
                    
                };
                _db.products.Add(prod);
                _db.SaveChanges();

                PurchaseProduct pp = new PurchaseProduct()
                {
                    ProductId = obj.productId,
                    PurchasingPrice = obj.purchaseprice,
                    PurchaseId = _db.Purchases.ToList().LastOrDefault().Id,
                    Quantity = obj.QuantityId,
                };
                _db.PurchaseProducts.Add(pp);
                var purchasedProduct = _db.products.Where(x => x.Id == obj.productId).FirstOrDefault();
                purchasedProduct.Quantity += obj.QuantityId;

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

            if (obj.productId == null)
            {
                return "Select Product";
            }
            else
            {
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

            }

            return "Sale Successfully Done!!!";
        }
    }
}

