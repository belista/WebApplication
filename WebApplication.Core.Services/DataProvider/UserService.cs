using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;
using WebApplication.Core.Services.DataProvider.Interfaces;

namespace WebApplication.Core.Services.DataProvider
{
    class UserService : IUserService
    {
        Context _context;

        public UserService(Context context)
        {

        }

        public async Task<User> AddGroupToUserAsync(int groupId, int userId)
        {
            return await Task.Run(() =>
            {
                if (_context.Users.SingleOrDefault(u => u.Id == userId) is User user)
                {
                    user.GroupId = groupId;
                    user.Group = _context.Groups.SingleOrDefault(g => g.Id == groupId);
                    return user;
                }
                return default(User);
            });
        }

        public async Task<bool> AddUserAsync(User user)
        {
           
            return await Task.Run(() =>
            {
                if (user == null)
                {
                    return false;
                }
                _context.Users.Add(user);
                return true;
            });
        }

        public async Task<List<User>> GetUsersAsync(int count, int offset)
        {
            return await Task.Run(() =>
            {
                return _context.Users.Skip(offset).Take(count).ToList();
            });
        }
    }
}
