using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Data
{
    public partial class Product
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
        public int IdTypeProduct { get; set; }
    }
}
