namespace Core;

public class Order
{

    protected Order(string userName, string phoneNumber, string carNumber, DateTimeOffset time)
    {
        UserName = userName;
        PhoneNumber = phoneNumber;
        CarNumber = carNumber;
        Time = time;
    }
    public string UserName { get; protected set; }
    public DateTimeOffset Time { get; protected set; }
    public string PhoneNumber { get; protected set; }
    public string CarNumber { get; protected set; }

    public static Order Create(string userName, string phoneNumber, string carNumber, DateTimeOffset time)
    {
        //TODO: Проверки

        return new(userName, phoneNumber, carNumber, time);
    }
}