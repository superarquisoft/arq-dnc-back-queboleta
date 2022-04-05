using Domain.Interfaces.Logging;
using Helpers.Commons.Logging;
using Microsoft.Extensions.DependencyInjection;
using QueBoleta.AppService.Automapper;

namespace QueBoleta.AppService.Configuration
{
    /// <summary>
    /// ConfigureServices
    /// </summary>
    public static class ConfigureServices
    {
        /// <summary>
        /// AddServices
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            #region AutoMapper
            services.AddAutoMapper(typeof(EntityProfile));
            #endregion AutoMapper

            #region UseCase
            #endregion UseCase

            #region Helpers
            services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));
            #endregion Helpers

            return services;
        }
    }
}
