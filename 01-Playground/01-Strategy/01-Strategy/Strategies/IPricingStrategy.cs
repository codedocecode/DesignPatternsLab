using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Strategy.Strategies
{
    public interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }
}
