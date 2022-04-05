using Domain.Interfaces.Authentication;
using Domain.Model.Entities.Token;
using Domain.Model.Entities.Users;
using Domain.Model.Enums;
using Helpers.Commons.AppSettings;
using Helpers.Commons.Exceptions;
using Helpers.Commons.Extensions;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases.Auth
{
    public class AuthUseCase : IAuthUseCase
    {
        private readonly IOptions<QueBoletaAppSettings> _appSettings;
        private readonly IDictionary<string, string> _users = new Dictionary<string, string>
        {
            { "antonio@gmail.com", "asdfg123" },
            { "carlos@gmail.com", "lol123" },
            { "vanessa@gmail.com", "angie123" }
        };

        public AuthUseCase(IOptions<QueBoletaAppSettings> appSettings)
        {
            _appSettings = appSettings;
        }


        public async Task<TokenConfig> loginUser(User user)
        {
            var jwtKey = _appSettings.Value.JwtConfig.Key;

            if (!_users.Any(x => x.Key == user.Email && x.Value == user.Password))
                throw new BusinessException(
                    (int)ExceptionsDetail.UserNotFound,
                    ExceptionsDetail.UserNotFound.GetDescription());

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenKey = Encoding.ASCII.GetBytes(jwtKey);
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email)
                }),
                Expires = DateTime.Now.AddDays(2),
                SigningCredentials = new SigningCredentials(
                    new SymmetricSecurityKey(tokenKey),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenReady = tokenHandler.WriteToken(token);

            await Task.Delay(200);

            return new()
            {
                Token = tokenReady,
                RefreshToken = "NoHay"
            };
        }

        public Task logoutUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
