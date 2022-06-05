using System.Security.AccessControl;

namespace Core;

public class Order
{

    protected Order(Guid id, string userName, string phoneNumber, string carNumber, DateTimeOffset time)
    {
        Id = id;
        UserName = userName;
        PhoneNumber = phoneNumber;
        CarNumber = carNumber;
        Time = time;
    }

    public Guid Id { get; protected set; }
    public string UserName { get; protected set; }
    public DateTimeOffset Time { get; protected set; }
    public string PhoneNumber { get; protected set; }
    public string CarNumber { get; protected set; }

    protected static void ValidateProperties(Guid name, string userName, string phoneNumber, string carNumber,
        DateTimeOffset time)
    {
        //TODO: Проверки
    }
    
    public static Order Create(Guid id, string userName, string phoneNumber, string carNumber, DateTimeOffset time)
    {
        ValidateProperties(id, userName, phoneNumber, carNumber, time);

        return new Order(id, userName, phoneNumber, carNumber, time);
    }
    public void ChangeInfo(string userName, string phoneNumber, string carNumber, DateTimeOffset time)
    {
        ValidateProperties(Id, userName, phoneNumber, carNumber, time);

        UserName = userName;
        PhoneNumber = phoneNumber;
        CarNumber = carNumber;
        Time = time;
    }
}