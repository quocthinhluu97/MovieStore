namespace MovieStore.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}