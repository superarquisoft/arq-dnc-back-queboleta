using Domain.Interfaces.Logging;

namespace EntryPoint.ReactiveWeb.Base
{
    /// <summary>
    /// BaseController
    /// </summary>
    /// <typeparam name="TController"></typeparam>
    public class BaseController<TController>
    {
        private readonly ILoggerService<TController> _loggerService;

        /// <summary>
        /// BaseController
        /// </summary>
        /// <param name="loggerService"></param>
        public BaseController(ILoggerService<TController> loggerService)
        {
            _loggerService = loggerService;
        }


    }
}
