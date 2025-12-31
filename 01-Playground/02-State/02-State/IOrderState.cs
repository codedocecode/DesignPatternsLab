
namespace _02_State
{
    public interface IOrderState
    {
        IOrderState? Pay();
        IOrderState? Ship();
        IOrderState? Complete();
    }
}
