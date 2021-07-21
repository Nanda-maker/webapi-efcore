using System.Threading.Tasks;
using webapi_efcore.Models;

namespace webapi_efcore.Data
{
    public interface IAuthRepository
    {
        Task<ServiceResponse<int>> Register(User user, string password);
        Task<ServiceResponse<string>> Login(string username, string password);
        Task<bool> UserExist(string username);

    }
}