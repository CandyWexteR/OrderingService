using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Moq;
using WebApplication1;

namespace TestProject1;

public class Tests
{
    private Factory GetFactory()
    {
        return new Factory();
    }
    
    [Test]
    public async Task Test1()
    {
        var factory = GetFactory();
        
        var testMock = new Mock<ITestInterface>();
        testMock.Setup(f => f.GetString()).Returns("Некоторая возвращаемая строка");


        var client = factory.CreateClient();
        
        var request = new HttpRequestMessage();

        var response = await factory.Server.CreateRequest("/cool").GetAsync();
        var @string = string.Empty;
        @string.Should().BeEmpty();
        var content = await response.Content.ReadAsStringAsync();

        var list = new List<string>() { "SomeString" };
        list.Should().Contain("SomeString");
        
        
        
        
        new List<int>().Should();
        new Dictionary<string, string>().Should().;
        Array.Empty<int>().Should().
    }
}