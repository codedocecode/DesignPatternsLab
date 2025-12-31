namespace _01_Strategy.Strategies
{
    internal class EmployeePricingStrategy : IPricingStrategy
    {
        public decimal CalculatePrice(decimal basePrice)
        {
            return basePrice * 0.7m;
        }
    }
}
