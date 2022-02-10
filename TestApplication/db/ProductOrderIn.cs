using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.db
{
    public partial class ProductOrderIn
    {
        public int? IdProduct { get; set; }
        public int? IdOrder { get; set; }
        public int? Count { get; set; }
        public decimal? Price { get; set; }
        public int Id { get; set; }
        public int? Remains { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual Product IdProductNavigation { get; set; }
    }
}
