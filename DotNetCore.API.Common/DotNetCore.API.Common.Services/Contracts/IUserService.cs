using DotNetCore.API.Common.Services.Model;
using System.Threading.Tasks;

namespace DotNetCore.API.Common.Services.Contracts
{
    public interface IUserService
    {
        Task<User> CreateAsync(User user);

        Task<bool> UpdateAsync(User user);

        Task<bool> DeleteAsync(string id);

        Task<User> GetAsync(string id);
    }
}
