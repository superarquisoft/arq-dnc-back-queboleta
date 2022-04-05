using Domain.Model.Entities.Token;
using Domain.Model.Entities.Users;
using System.Threading.Tasks;

namespace Domain.Interfaces.Authentication
{
    public interface IAuthUseCase
    {
        Task<TokenConfig> loginUser(User user);

        Task logoutUser(User user);
    }
}
