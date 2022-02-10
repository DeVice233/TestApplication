using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.db
{
    public partial class ProductOrderOut
    {
        public int? IdProductOrderIn { get; set; }
        public int? IdOrderOut { get; set; }
        public double? Count { get; set; }
        public decimal? Price { get; set; }
        public decimal? Discount { get; set; }

        public virtual OrderOut IdOrderOutNavigation { get; set; }
        public virtual ProductOrderIn IdProductOrderInNavigation { get; set; }
    }
}
