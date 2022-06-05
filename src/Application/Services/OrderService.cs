using Application.InputModels;
using Application.ViewModels;
using Core;

namespace Application.Services;

public class OrderService : IOrderService
{
    private readonly IIdGenerator _idGenerator;
    private readonly IOrderRepository _repository;

    public OrderService(IIdGenerator idGenerator, IOrderRepository repository)
    {
        _idGenerator = idGenerator;
        _repository = repository;
    }

    public Guid CreateOrder(OrderInputModel model)
    {
        var id = _idGenerator.GenerateId();

        var order = Order.Create(id, model.UserName, model.PhoneNumber, model.CarNumber, model.Time);

        _repository.Add(order);

        return id;
    }

    public void ChangeOrderInfo(Guid id, OrderInputModel model)
    {
        var order = _repository.Get(id);

        order.ChangeInfo(model.UserName, model.PhoneNumber, model.CarNumber, model.Time);

        _repository.Update(order);
    }

    public OrderViewModel GetOrder(Guid id)
    {
        var order = _repository.Get(id);

        return OrderViewModel.Create(order.CarNumber, order.PhoneNumber, order.Time);
    }
}