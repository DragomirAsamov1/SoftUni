using P03._ShoppingCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P03._ShoppingCart_Before {
    public class PricingCalculator : IPricingCalculator{
        private readonly List<IPriceRule> pricingRules;

        public PricingCalculator() {
            pricingRules = new List<IPriceRule>() {
                new EachPriceRule(),
                new PerGramPriceRule(),
                new SpecialPriceRule(),
                new BuyFourGetOneFree(),
            };
        }

        public decimal CalculatePrice(OrderItem item) => this.pricingRules.First(x => x.IsMatch(item)).CalculatePrice(item);
    }
}
