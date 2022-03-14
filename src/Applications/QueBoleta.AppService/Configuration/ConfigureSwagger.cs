using Microsoft.Extensions.DependencyInjection;

namespace QueBoleta.AppService.Configuration
{
    /// <summary>
    /// ConfigureSwagger
    /// </summary>
    public static class ConfigureSwagger
    {
        /// <summary>
        /// AddServices
        /// </summary>
        /// <param name="services"></param>
        /// <returns></returns>
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            #region UseCase
            #endregion UseCase

            return services;
        }
    }
}
