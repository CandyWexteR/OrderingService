namespace Core;

public interface IOrderRepository
{
    public void Add(Order order);
    public void Update(Order order);
    public void Remove(Guid id);
    public Order Get(Guid id);
}