
namespace _01_Strategy.Strategies
{
    internal class StandardPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice;
        }
    }
}
