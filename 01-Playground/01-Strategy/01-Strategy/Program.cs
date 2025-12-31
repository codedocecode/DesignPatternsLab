using _01_Strategy.Strategies;

namespace _01_Strategy;

public class Program
{
    static void Main (string[] args) 
    {
        decimal price = 120.50m;

        Order order = new Order(price, new StandardPricingStrategy());
        Console.WriteLine($"El precio total del pedido es: {order.CalculateFinalPrice()}");

        Order orderEmployee = new Order(price, new EmployeePricingStrategy());
        Console.WriteLine($"El precio total del pedido es: {orderEmployee.CalculateFinalPrice()}");

        Order orderPremium = new Order(price, new PremiumPricingStrategy());
        Console.WriteLine($"El precio total del pedido es: {orderPremium.CalculateFinalPrice()}");
    }

    //decimal CalculatePrice(Order order)
    //{
    //    if (order.CustomerType == CustomerType.Standard)
    //        return order.BasePrice;

    //    if (order.CustomerType == CustomerType.Premium)
    //        return order.BasePrice * 0.9m;

    //    if (order.CustomerType == CustomerType.Employee)
    //        return order.BasePrice * 0.7m;

    //    throw new Exception("Unknown customer type");
    //}

}
