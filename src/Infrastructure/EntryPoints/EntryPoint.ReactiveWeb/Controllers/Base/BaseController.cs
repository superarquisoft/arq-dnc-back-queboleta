using Domain.Interfaces.Logging;
using Domain.Model.Entities.Base;
using Domain.Model.Enums;
using Helpers.Commons.AppSettings;
using Helpers.Commons.Exceptions;
using Helpers.Commons.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace EntryPoint.ReactiveWeb.Controllers.Base
{
    /// <summary>
    /// BaseController
    /// </summary>
    /// <typeparam name="TController"></typeparam>
    [ApiController]
    public class BaseController<TController> : ControllerBase
    {
        private readonly ILoggerService<TController> _loggerService;
        private IOptions<QueBoletaAppSettings> _appSettings;

        /// <summary>
        /// BaseController
        /// </summary>
        /// <param name="loggerService"></param>
        public BaseController(ILoggerService<TController> loggerService, IOptions<QueBoletaAppSettings> appSettings)
        {
            _loggerService = loggerService;
            _appSettings = appSettings;
        }

        public async Task<IActionResult> HandleRequestAsync<TResult>(Func<Task<TResult>> requestHandler)
        {
            MethodBase? method = MethodBase.GetCurrentMethod();
            string function = string.Empty, message = string.Empty;
            int errorCode = 0;
            bool error = false;
            dynamic? data = null;

            //string actionName = ControllerContext.RouteData.Values["action"].ToString();
            //string controllerName = ControllerContext.RouteData.Values["controller"].ToString();
            //string eventName = $"{_credinetAppSettings.Value.DomainName}.{controllerName}.{actionName}";

            try
            {
                data = await requestHandler();
            }
            catch (BusinessException ex)
            {
                _loggerService.ConsoleErrorLog(ex.Message, method, ex);
                error = true;
                errorCode = ex.code;
                message = ex.Message;
            }
            catch (Exception ex)
            {
                _loggerService.ConsoleErrorLog(ex.Message, method, ex);
                error = true;
                errorCode = (int)ExceptionsDetail.UnhandledException;
                message = ExceptionsDetail.UnhandledException.GetDescription();
            }

            ResponseEntity response = new ResponseEntity().Build(function, message, errorCode, error, data);

            return error
                ? BadRequest(response)
                : Ok(response);
        }

    }
}
