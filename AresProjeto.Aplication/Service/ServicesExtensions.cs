using AresProjeto.Aplication.UseCase.Users.AddUsers;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;


namespace AresProjeto.Aplication.Service;

public static class ServicesExtensions
{
    public static void ConfigureApplicationApp(this IServiceCollection services)
    {
        services.AddAutoMapper(Assembly.GetExecutingAssembly());
        services.AddMediatR(cfg =>
        cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
        services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

        services.AddAutoMapper(typeof(AddUsersMap));
    }
}
