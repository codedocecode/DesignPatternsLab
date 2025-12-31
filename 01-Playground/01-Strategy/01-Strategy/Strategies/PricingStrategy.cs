using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Strategy.Strategies
{
    internal interface IPricingStrategy
    {
        decimal CalculatePrice(decimal basePrice);
    }
}
