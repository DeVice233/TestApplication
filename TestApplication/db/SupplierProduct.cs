using System;
using System.Collections.Generic;

#nullable disable

namespace TestApplication.db
{
    public partial class SupplierProduct
    {
        public int? IdSupplier { get; set; }
        public int? IdProduct { get; set; }

        public virtual Product IdProductNavigation { get; set; }
    }
}
