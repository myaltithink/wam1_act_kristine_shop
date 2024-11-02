﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesAndInventoryProgram.Data.Models
{
    internal class Sale
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int ProductId { get; set; }

        public int Quantity { get; set; }

        public double ItemPrice { get; set; }

        public double Total { get; set; }

        public Product Product { get; set; }

    }
}
