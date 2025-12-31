using _01_Strategy.Strategies;

namespace _02_State;

public class Program
{
    static void Main(string[] args)
    {
        Order order = new Order(200, new StandardPricingStrategy());

        Console.WriteLine($"Precio final: {order.CalculateFinalPrice()}");
        order.PrintState();

        order.Complete();
        Console.WriteLine($"Precio final: {order.CalculateFinalPrice()}");
        order.PrintState();

        order.Pay();
        Console.WriteLine($"Precio final: {order.CalculateFinalPrice()}");
        order.PrintState();

        order.Complete();
        Console.WriteLine($"Precio final: {order.CalculateFinalPrice()}");
        order.PrintState();

        order.Ship();
        Console.WriteLine($"Precio final: {order.CalculateFinalPrice()}");
        order.PrintState();

        order.Complete();
        Console.WriteLine($"Precio final: {order.CalculateFinalPrice()}");
        order.PrintState();

    }

}
