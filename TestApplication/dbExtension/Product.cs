using ModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.db
{
    public partial class Product
    {
        public static explicit operator ProductApi(Product product)
        {
            if (product == null)
            {
                return null;
            }
            return new ProductApi { Article = product.Article, Barcode = product.Barcode, Description = product.Description, Id = product.Id, IdProductType = product.IdProductType, IdUnit = product.IdUnit, Image = product.Image, RetailPrice = product.RetailPrice, Title = product.Title, WholesalePrice = product.WholesalePrice };
        }

        public static explicit operator Product(ProductApi product)
        {
            if (product == null)
            {
                return null;
            }
            return new Product { Article = product.Article, Barcode = product.Barcode, Description = product.Description, Id = product.Id, IdProductType = product.IdProductType, IdUnit = product.IdUnit, Image = product.Image, RetailPrice = product.RetailPrice, Title = product.Title, WholesalePrice = product.WholesalePrice };
        }
    }
}
