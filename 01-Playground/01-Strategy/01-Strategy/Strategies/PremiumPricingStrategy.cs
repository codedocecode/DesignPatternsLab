
namespace _01_Strategy.Strategies
{
    internal class PremiumPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 0.9m;
        }
    }
}
