using P03._ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before {
    public class PerGramPriceRule : IPriceRule {
        public decimal CalculatePrice(OrderItem item) => item.Quantity * 4m / 1000;

        public bool IsMatch(OrderItem item) => item.Sku.StartsWith("WEIGHT");
    }
}
