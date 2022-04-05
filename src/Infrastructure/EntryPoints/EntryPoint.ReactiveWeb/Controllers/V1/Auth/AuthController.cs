using Domain.Interfaces.Logging;
using EntryPoint.ReactiveWeb.DTO.Auth;
using Helpers.Commons.AppSettings;

namespace EntryPoint.ReactiveWeb.Controllers.V1.Auth
{
    /// <summary>
    /// Authentication Controller
    /// </summary>
    [Produces("application/json")]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class AuthController : BaseController<AuthController>
    {
        private readonly ILoggerService<AuthController> _loggerService;
        private readonly IOptions<QueBoletaAppSettings> _appSettings;

        /// <summary>
        /// AuthController
        /// </summary>
        /// <param name="loggerService"></param>
        /// <param name="appSettings"></param>
        public AuthController(ILoggerService<AuthController> loggerService, IOptions<QueBoletaAppSettings> appSettings)
            : base(loggerService, appSettings)
        {
            _loggerService = loggerService;
            _appSettings = appSettings;
        }


        [HttpPost]
        public async Task<IActionResult> Login([FromBody] UserLoginDto authController) =>
            await HandleRequestAsync(async () => await GetUserTest());

        private async Task<UserLoginDto> GetUserTest()
        {
            await Task.Delay(500);
            return new()
            {
                Usuario = "Jhosfly",
                Password = "Bebelyn"
            };
        }


        //// PUT: api/Employee/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Employee employee)
        //{
        //    // Logic to update an Employee
        //}
    }
}
