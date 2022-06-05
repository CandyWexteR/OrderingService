using Core;

namespace Application;

public class MainService:IMainService
{
    private readonly IService _service;
    public MainService(IService service)
    {
        _service = service;
    }
    public string GetStringFromService()
    {
        return _service.GetSomeString();
    }

    public Person GetPerson()
    {
        return _service.GetPerson();
    }
}