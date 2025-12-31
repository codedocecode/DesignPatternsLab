
namespace _02_State.States
{
    internal class ShippedState : IOrderState
    {
        public IOrderState? Pay()
        {
            Console.WriteLine("El pedido ya ha sido pagado");
            return null;
        }

        public IOrderState? Ship()
        {
            Console.WriteLine("El pedido ya ha sido pagado");
            return null;
        }
        public IOrderState? Complete()
        {
            Console.WriteLine("Pedido completado con éxito");
            return new CompletedState();
        }
    }
}
