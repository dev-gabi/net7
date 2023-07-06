using Bl;
using Dal;
using Entities.OptionsConfig;
using Microsoft.Extensions.Configuration;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class MyConfigServiceCollectionExtensions
    {
        public static IServiceCollection AddConfig(
             this IServiceCollection services, IConfiguration config)
        {
            services.Configure<NameConfig>(
                config.GetSection("Name"));

            return services;
        }

        public static IServiceCollection AddMyDependencyGroup(
             this IServiceCollection services)
        {
            services.AddScoped<TodoDbContext>();
            services.AddScoped<ITodo, TodoBL>();

            return services;
        }
    }
}