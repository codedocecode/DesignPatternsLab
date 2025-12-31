
namespace _02_State.States
{
    internal class CompletedState : IOrderState
    {
        public IOrderState? Pay()
        {
            Console.WriteLine("El pedido ya ha sido pagado");
            return null;
        }

        public IOrderState? Ship()
        {
            Console.WriteLine("El pedido ya ha sido enviado");
            return null;
        }
        public IOrderState? Complete()
        {
            Console.WriteLine("El pedido ya ha sido enviado");
            return null;
        }
    }
}
