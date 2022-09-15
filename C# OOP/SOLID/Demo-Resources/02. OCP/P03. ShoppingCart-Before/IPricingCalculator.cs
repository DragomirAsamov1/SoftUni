using P03._ShoppingCart;
using System;
using System.Collections.Generic;
using System.Text;

namespace P03._ShoppingCart_Before {
    public interface IPricingCalculator {
        decimal CalculatePrice(OrderItem item);
    }
}
