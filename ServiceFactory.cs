using Microsoft.Extensions.DependencyInjection;
using FluentValidation;

public static class ServiceFactory
{
    public static ServiceProvider GetServiceProvider()
    {
        var services = new ServiceCollection();
        services.AddValidatorsFromAssemblyContaining<UpdateRoomCommandValidator>();
        services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(UpdateRoomCommand).Assembly));
        return services.BuildServiceProvider();
    }
}