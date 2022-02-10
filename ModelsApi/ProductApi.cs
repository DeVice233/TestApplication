using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsApi
{
   public class ProductApi : ApiBaseType
    {
        public string Title { get; set; }
        public int? Article { get; set; }
        public int? Barcode { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal? WholesalePrice { get; set; }
        public decimal? RetailPrice { get; set; }
        public int? IdUnit { get; set; }
        public int? IdProductType { get; set; }

        public ProductTypeApi ProductType { get; set; }
        public UnitApi Unit { get; set; }
    }
}
