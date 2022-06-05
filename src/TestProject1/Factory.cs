using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.DependencyInjection;
using Pro.FileStore.WebApi.Tests;
using WebApplication1;

namespace TestProject1;

public class Factory:WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(ConfigureServices);
    }

    private void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddOptions();
        services.AddAuthorization(f =>
        {
            f.DefaultPolicy = new AuthorizationPolicyBuilder().AddRequirements(new AuthRequirement()).Build();
        });
        services.AddRazorPages();
        services.AddScoped<IAuthorizationHandler, AuthRequirementHandler>();
    }
}