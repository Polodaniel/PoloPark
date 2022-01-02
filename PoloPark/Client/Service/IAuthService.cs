using PoloPark.Shared.Model.Account;
using PoloPark.Shared.Model.Account.Result;

namespace PoloPark.Client.Service
{
    public interface IAuthService
    {
        Task<LoginResult> Login(LoginModel loginModel);
        Task Logout();
        Task<RegisterResult> Register(RegisterModel registerModel);
    }
}
