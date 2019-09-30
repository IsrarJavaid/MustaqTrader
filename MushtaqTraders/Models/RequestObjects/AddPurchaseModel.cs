using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MushtaqTraders.Models.RequestObjects
{
    public class AddPurchaseModel
    {
        public bool isExisting { get; set; }
        public string productName { get; set; }
        public int productId { get; set; }
        public float purchaseprice { get; set; }
        public int supplierId { get; set; }
    }
}