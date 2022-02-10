﻿using ModelsApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApplication.db
{
    public partial class ProductCostHistory
    {

        public static explicit operator ProductCostHistoryApi(ProductCostHistory productCostHistory)
        {
            if (productCostHistory == null)
            {
                return null;
            }
            return new ProductCostHistoryApi { Id = productCostHistory.Id, ChangeDate = productCostHistory.ChangeDate, IdProduct = productCostHistory.IdProduct , RetailPriceValue = productCostHistory.RetailPriceValue, WholesalePriceValue=productCostHistory.RetailPriceValue};
        }

        public static explicit operator ProductCostHistory(ProductCostHistoryApi productCostHistory)
        {
            if (productCostHistory == null)
            {
                return null;
            }
            return new ProductCostHistory { Id = productCostHistory.Id, ChangeDate = productCostHistory.ChangeDate, IdProduct = productCostHistory.IdProduct, RetailPriceValue = productCostHistory.RetailPriceValue, WholesalePirceValue = productCostHistory.RetailPriceValue };
        }
    }
}
