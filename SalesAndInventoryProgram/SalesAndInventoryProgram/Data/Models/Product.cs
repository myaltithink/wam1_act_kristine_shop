using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndInventoryProgram.Data.Models
{
    internal class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string ItemName {  get; set; }

        public string Category { get; set; }

        public double Price { get; set; }

        public int Quantity { get; set; }

        public ICollection<Sale> ItemSales { get; } = new List<Sale>();

    }
}
