using Application;
using Application.Services;
using Core;
using DataAccess;
using Microsoft.OpenApi.Models;

namespace WebApplication1;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddSwaggerGen();

        services.AddTransient<IIdGenerator, IdGenerator>();
        services.AddSingleton<IOrderRepository, OrderRepository>();
        services.AddTransient<IOrderService, OrderService>();
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        if (env.IsDevelopment())
        {
            app.UseDeveloperExceptionPage();
        }
        else
        {
            //app.UseExceptionHandler("/Error");
        }

        app.UseSwagger();
        app.UseSwaggerUI();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.UseRouting();

        app.UseEndpoints(f => { f.MapControllers(); });
    }
}