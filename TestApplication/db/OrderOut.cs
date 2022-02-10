using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.db
{
    public partial class OrderOut
    {
        public int Id { get; set; }
        public int? IdSaleType { get; set; }
        public string Status { get; set; }
        public int? IdOrder { get; set; }

        public virtual Order IdOrderNavigation { get; set; }
        public virtual SaleType IdSaleTypeNavigation { get; set; }
    }
}
