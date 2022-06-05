using Application;
using Core;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers;

[ApiController]
[Route("api/v1/[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly IMainService _service;

    public WeatherForecastController(IMainService service)
    {
        _service = service;
    }
    
    [HttpGet("get")]
    public async Task<string> GetCool()
    {
        return _service.GetStringFromService();
    }
    
    [HttpGet("person")]
    public async Task<Person> GetPerson()
    {
        return _service.GetPerson();
    }
}