using System;
using System.Collections.Generic;

#nullable disable

namespace Domain.Data
{
    public partial class ShoppingHistory
    {
        public int Id { get; set; }
        public int? IdProduct { get; set; }
        public int? Amount { get; set; }
        public decimal? SubTotal { get; set; }
        public decimal? Taxes { get; set; }
        public decimal? Total { get; set; }
        public DateTime? DateShopping { get; set; }
        public int? IdUser { get; set; }
    }
}
