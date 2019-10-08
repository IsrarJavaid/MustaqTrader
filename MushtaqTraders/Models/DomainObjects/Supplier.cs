using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MushtaqTraders.Models.DomainObjects
{
    public class Supplier
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Contact { get; set; }

        public ICollection<Purchase> Purchases { get; set; }
    }
}