using Helpers.Commons.AppSettings;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using QueBoleta.AppService.Configuration;

namespace QueBoleta.AppService
{
    public class Startup
    {

        /// <summary>
        /// Logger
        /// </summary>
        private readonly ILogger<Startup> _logger;

        // <summary>
        /// EnvironmentHost
        /// </summary>
        public IWebHostEnvironment EnvironmentHost { get; }

        /// <summary>
        /// Configuration
        /// </summary>
        public IConfiguration Configuration { get; }

        /// <summary>
        /// AppSettings
        /// </summary>
        public QueBoletaAppSettings AppSettings { get; set; }

        /// <summary>
        /// Startup
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="environment"></param>
        public Startup(IConfiguration configuration, IWebHostEnvironment environment, ILogger<Startup> logger)
        {
            Configuration = configuration;
            EnvironmentHost = environment;
            _logger = logger;
        }

        /// <summary>
        /// ConfigureServices
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<QueBoletaAppSettings>(Configuration.GetSection(nameof(QueBoletaAppSettings)));
            AppSettings = Configuration.GetSection(nameof(QueBoletaAppSettings)).Get<QueBoletaAppSettings>();

            services.AddServices();
            services.AddSwagger();

            #region Logging
            _logger.LogInformation("================= STARTUP =================");
            _logger.LogInformation("=========================================== ");
            #endregion Logging
        }


        public void Configure(IApplicationBuilder app, IHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.AppSwagger();
            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
