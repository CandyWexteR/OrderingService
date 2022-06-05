namespace Application.ViewModels;

public class OrderViewModel
{
    protected OrderViewModel(string carNumber, string phoneNumber, DateTimeOffset time)
    {
        CarNumber = carNumber;
        PhoneNumber = phoneNumber;
        Time = time;
    }

    public DateTimeOffset Time { get; }
    public string PhoneNumber { get; }
    public string CarNumber { get; }

    public static OrderViewModel Create(string carNumber, string phoneNumber, DateTimeOffset time)
    {
        return new OrderViewModel(carNumber, phoneNumber, time);
    }
}