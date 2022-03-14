using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace QueBoleta.AppService
{
    public class Startup
    {
        // <summary>
        /// EnvironmentHost
        /// </summary>
        public IWebHostEnvironment EnvironmentHost { get; }

        /// <summary>
        /// Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// Startup
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="environment"></param>
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            EnvironmentHost = environment;
        }

        /// <summary>
        /// ConfigureServices
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {

            #region Logging
            #endregion Logging
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        { }
    }
}
