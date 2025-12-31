using _01_Strategy.Strategies;
using _02_State.States;

namespace _02_State
{
    public class Order
    {
        public decimal BasePrice { get; }   
        public IPricingStrategy PricingStrategy { get; }
        private IOrderState State { get; set; }

        public Order(decimal price, IPricingStrategy pricingStrategy) 
        {
            BasePrice = price;
            PricingStrategy = pricingStrategy;
            State = new CreatedState();
        }

        public void PrintState() => Console.WriteLine($"Estado actual: {State.GetType().Name}");

        public decimal CalculateFinalPrice() 
        {
            return PricingStrategy.CalculatePrice(BasePrice);
        }

        public void Pay() => State = State.Pay() ?? State;
        public void Ship() => State = State.Ship() ?? State;
        public void Complete() => State = State.Complete() ?? State;

    }
}
