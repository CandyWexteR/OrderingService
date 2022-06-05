using Application.InputModels;
using Application.ViewModels;

namespace Application.Services;

public interface IOrderService
{
    public Guid CreateOrder(OrderInputModel model);
    public void ChangeOrderInfo(Guid id, OrderInputModel model);
    public OrderViewModel GetOrder(Guid id);
}