using _01_Strategy.Strategies;

namespace _01_Strategy
{
    internal class Order
    {
        public decimal BasePrice { get; }   
        public IPricingStrategy PricingStrategy { get; }

        public Order(decimal price, IPricingStrategy pricingStrategy) 
        {
            BasePrice = price;
            PricingStrategy = pricingStrategy;

            CalculateFinalPrice();
        }

        public decimal CalculateFinalPrice() 
        {
            return PricingStrategy.CalculatePrice(BasePrice);
        }
    }
}
