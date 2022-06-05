using Application.InputModels;
using Application.Services;
using Application.ViewModels;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class OrderController : ControllerBase
{
    private readonly IOrderService _service;

    public OrderController(IOrderService service)
    {
        _service = service;
    }

    [HttpGet("{id:guid}")]
    public async Task<OrderViewModel> GetOrder(Guid id)
    {
        return _service.GetOrder(id);
    }

    [HttpPost]
    public async Task<Guid> CreateOrder(OrderInputModel model)
    {
        return _service.CreateOrder(model);
    }

    [HttpPut("{id:guid}")]
    public async Task ChangeOrderIndo(Guid id, OrderInputModel model)
    {
        _service.ChangeOrderInfo(id, model);
    }
}