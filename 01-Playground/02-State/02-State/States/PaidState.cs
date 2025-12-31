
namespace _02_State.States
{
    internal class PaidState : IOrderState
    {
        public IOrderState? Pay()
        {
            Console.WriteLine("El pedido ya ha sido pagado");
            return null;
        }

        public IOrderState? Ship()
        {
            Console.WriteLine("Pedido enviado con éxito");
            return new ShippedState();
        }
        public IOrderState? Complete()
        {
            Console.WriteLine("El pedido aun no ha sido enviado");
            return null;
        }
    }
}
