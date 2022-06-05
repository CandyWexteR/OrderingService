using Core;

namespace DataAccess;

public class Service:IService
{
    public string GetSomeString()
    {
        return "asdasdsadasdasdasdsad";
    }

    public Person GetPerson()
    {
        return new Person()
        {
            Name = "Рома",
            Surname = "Черемных"
        };
    }
}