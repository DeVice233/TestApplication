using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.db
{
    public partial class SaleType
    {
        public SaleType()
        {
            OrderOuts = new HashSet<OrderOut>();
        }

        public int Id { get; set; }
        public string Title { get; set; }

        public virtual ICollection<OrderOut> OrderOuts { get; set; }
    }
}
