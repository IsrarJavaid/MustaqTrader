using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MushtaqTraders.Models.DomainObjects
{
    public class Purchase
    {
        [Key]
        public int Id { get; set; } 
        public decimal TotalBill { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

      
        public Supplier Supplier { get; set; }
    }
}