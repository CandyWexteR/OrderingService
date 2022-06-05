using Core;

namespace DataAccess;

public class OrderRepository:IOrderRepository
{
    private List<Order> _orders;

    public OrderRepository()
    {
        _orders = new List<Order>();
    }

    public void Add(Order order)
    {
        _orders.Add(order);
    }

    public void Update(Order order)
    {
        var old = _orders.FirstOrDefault(f=>f.Id == order.Id);
        
        //TODO: Exception
        if(old == null)
            throw new Exception("Не существующая заявка");
        
        var index = _orders.IndexOf(old);

        _orders[index] = order;
    }

    public void Remove(Guid id)
    {
        var old = _orders.FirstOrDefault(f=>f.Id == id);
        
        //TODO: Exception
        if(old == null)
            throw new Exception("Не существующая заявка");
        
        _orders.Remove(old);
    }

    public Order Get(Guid id)
    {
        var old = _orders.FirstOrDefault(f=>f.Id == id);
        
        //TODO: Exception
        if(old == null)
            throw new Exception("Не существующая заявка");

        return old;
    }
}