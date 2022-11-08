using SportSchadule.Core.Contracts;
using SportSchadule.Core.Services;
using SportsSchedule.Infrastructure.Data.Common;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class SportSchaduleServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IRepository, Repository>();
            services.AddScoped<ISportService, SportService>();

            return services;
        }
    }
}
