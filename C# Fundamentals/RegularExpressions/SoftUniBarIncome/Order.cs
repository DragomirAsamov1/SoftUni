using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniBarIncome {
    internal class Order {

        public Order(string customerName, string product, decimal totalPrice) {
            CustomerName = customerName;
            Product = product;
            TotalPrice = totalPrice;
        }
        public string CustomerName { get; }
        public string Product { get; }
        public decimal TotalPrice { get; }

        public override string ToString() {
            return $"{CustomerName}: {Product} - {TotalPrice:f2}";
        }
    }
}
