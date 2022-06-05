namespace Application.InputModels;

public class OrderInputModel
{
    public string UserName { get; set; }
    public DateTimeOffset Time { get; set; }
    public string PhoneNumber { get; set; }
    public string CarNumber { get; set; }
}