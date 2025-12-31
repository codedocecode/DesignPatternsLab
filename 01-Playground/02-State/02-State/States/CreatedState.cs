
namespace _02_State.States
{
    internal class CreatedState : IOrderState
    {
        public IOrderState? Pay()
        {
            Console.WriteLine("Pedido pagado con éxito");
            return new PaidState();
        }

        public IOrderState? Ship()
        {
            Console.WriteLine("El pedido aun no ha sido pagado");
            return null;
        }
        public IOrderState? Complete()
        {
            Console.WriteLine("El pedido aun no ha sido enviado");
            return null;
        }
    }
}
