using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;

namespace WebApplication.Core.Services.DataProvider.Interfaces
{
    public interface IUserService
    {
        Task<List<User>> GetUsersAsync(int count, int offset);
        Task<bool> AddUserAsync(User user);
        Task<User> AddGroupToUserAsync(int groupId, int userId);
    }
}
