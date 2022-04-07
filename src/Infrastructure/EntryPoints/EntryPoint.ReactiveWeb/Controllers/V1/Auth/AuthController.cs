using Domain.Interfaces.Auth;
using Domain.Interfaces.Logging;
using Domain.Model.Entities.Token;
using Domain.Model.Entities.Users;
using EntryPoint.ReactiveWeb.Controllers.Base;
using EntryPoint.ReactiveWeb.DTO.Auth;
using Helpers.Commons;
using Helpers.Commons.AppSettings;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Threading.Tasks;

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
        private readonly IAuthUseCase _authUseCase;

        /// <summary>
        /// AuthController
        /// </summary>
        /// <param name="loggerService"></param>
        /// <param name="appSettings"></param>
        /// <param name="authUseCase"></param>
        public AuthController(ILoggerService<AuthController> loggerService, IOptions<QueBoletaAppSettings> appSettings,
            IAuthUseCase authUseCase)
            : base(loggerService, appSettings)
        {
            _loggerService = loggerService;
            _appSettings = appSettings;
            _authUseCase = authUseCase;
        }

        /// <summary>
        /// Creates a TodoItem.
        /// </summary>
        /// <param name="authController"></param>
        /// <returns>A newly created TodoItem</returns>
        /// <remarks>
        /// Sample request:
        ///
        ///     POST /Todo
        ///     {
        ///        "id": 1,
        ///        "name": "Item #1",
        ///        "isComplete": true
        ///     }
        ///
        /// </remarks>
        /// <response code="201">Returns the newly created item</response>
        /// <response code="400">If the item is null</response>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> TestMethod([FromBody] LoginDto authController) =>
            await HandleRequestAsync<LoginDto>(async () => await GetUserTest());

        private async Task<LoginDto> GetUserTest()
        {
            await Task.Delay(500);
            return new()
            {
                Email = "Jhosfly",
                Password = "Bebelyn"
            };
        }

        [HttpPost]
        public async Task<IActionResult> Login([FromBody] LoginDto login) =>
            await HandleRequestAsync<TokenConfig>(async () =>
            {
                User user = login.MapDto<LoginDto,User>();
                //TokenConfig tokenConfig = await _authUseCase.loginUser();

                //return tokenConfig;

                await Task.Delay(3000);
                return new TokenConfig();
            });




        //// PUT: api/Employee/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] Employee employee)
        //{
        //    // Logic to update an Employee
        //}
    }
}
