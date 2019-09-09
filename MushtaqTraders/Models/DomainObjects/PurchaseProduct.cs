﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MushtaqTraders.Models.DomainObjects
{
    public class PurchaseProduct
    {
        [Key, Column(Order = 0)]
        public int PurchaseId { get; set; }
        [Key, Column(Order = 1)]
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public float PurchasingPrice { get; set; }
    }
}