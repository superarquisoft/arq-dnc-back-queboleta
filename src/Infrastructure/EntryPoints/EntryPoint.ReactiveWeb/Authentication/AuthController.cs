using Domain.Interfaces.Logging;
using EntryPoint.ReactiveWeb.Base;
using Microsoft.AspNetCore.Mvc;

namespace EntryPoint.ReactiveWeb.Authentication
{
    /// <summary>
    /// Authentication Controller
    /// </summary>
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/[controller]/[action]")]
    public class AuthController : BaseController<AuthController>
    {
        public AuthController(ILoggerService<AuthController> loggerService) : base(loggerService)
        {
        }
    }
}
