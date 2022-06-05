namespace Application.Services;

public class IdGenerator:IIdGenerator
{
    public Guid GenerateId()
    {
        return Guid.NewGuid();
    }
}