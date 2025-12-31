
namespace _01_Strategy.Strategies
{
    public class StandardPricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice;
        }
    }
}
