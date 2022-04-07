using Domain.Interfaces.Auth;
using Domain.Interfaces.Logging;
using Domain.UseCases.Auth;
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
            #region CORS
            services.AddCors(options =>
            {
                options.AddPolicy("cors", b => b.AllowAnyHeader().AllowAnyMethod().AllowCredentials());
            });
            #endregion CORS

            #region AutoMapper
            services.AddAutoMapper(typeof(EntityProfile));
            #endregion AutoMapper

            #region UseCase
            services.AddScoped<IAuthUseCase, AuthUseCase>();
            #endregion UseCase

            #region Helpers
            services.AddScoped(typeof(ILoggerService<>), typeof(LoggerService<>));
            #endregion Helpers

            return services;
        }
    }
}
