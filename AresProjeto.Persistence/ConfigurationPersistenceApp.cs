using AresProjeto.Domain.Interfaces;
using AresProjeto.Persistence.Context;
using AresProjeto.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AresProjeto.Persistence
{
    public static class ConfigurationPersistenceApp
    {
        public static void ConfigurationPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("MySql");
            services.AddDbContext<UserTaskContext>(opt => opt.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

            services.AddScoped<IUser, UserRepository>();
        }
    }
}
