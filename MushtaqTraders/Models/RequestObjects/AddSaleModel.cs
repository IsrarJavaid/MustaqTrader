using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MushtaqTraders.Models.RequestObjects
{
    public class AddSaleModel
    {
        public int categoryId { get; set; }
        public string productName { get; set; }
        public int productId { get; set; }
        public int QuantityId { get; set; }
        public float SellingPrice { get; set; }
        public decimal TotalBill { get; set; }
    }
}