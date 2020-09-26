using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace NightSightsCoffee.Models
{
    public class Product
    {
        public long ProductID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string TastingNotes { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        public string Category { get; set; }
    }
}
