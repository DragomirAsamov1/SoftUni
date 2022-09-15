using P03._ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before {
    public class SpecialPriceRule : IPriceRule {
        public decimal CalculatePrice(OrderItem item) {
            decimal total = item.Quantity * 4m;
            int setsOfThree = item.Quantity / 3;
            total -= setsOfThree * .2m;

            return total;
        }

        public bool IsMatch(OrderItem item) => item.Sku.StartsWith("SPECIAL");
    }
}
