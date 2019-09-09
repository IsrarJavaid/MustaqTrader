using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MushtaqTraders.Models.DomainObjects
{
    public class Sale
    {
        [Key]
        public int Id { get; set; }
        public decimal TotalBill { get; set; }
        public DateTime Date { get; set; }
    }
}