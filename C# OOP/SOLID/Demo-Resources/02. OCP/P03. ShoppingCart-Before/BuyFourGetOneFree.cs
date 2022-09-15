using P03._ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before {
    public class BuyFourGetOneFree : IPriceRule {
        public decimal CalculatePrice(OrderItem item) {
            decimal total = 0m;

            total += item.Quantity * 1m;
            int setsOffFive = item.Quantity / 5;
            total -= setsOffFive * 1m;

            return total;
        }

        public bool IsMatch(OrderItem item) => item.Sku.StartsWith("BFGO");
    }
}
