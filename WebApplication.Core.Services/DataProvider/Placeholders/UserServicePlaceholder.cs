using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;
using WebApplication.Core.Services.DataProvider.Interfaces;

namespace WebApplication.Core.Services.DataProvider.Placeholders
{
    public class UserServicePlaceholder : IUserService
    {
        Context context; 

        public UserServicePlaceholder(Context context)
        {
            this.context = context; 
        }

        public Task<User> AddGroupToUserAsync(int groupId, int userId) =>
            Task.Factory.StartNew(() => new User(1, $"This is some user with id = {userId}", 18, "email", "password", groupId)); 

        public Task<bool> AddUserAsync(User user) => 
            Task.Factory.StartNew(() => true);

        public Task<List<User>> GetUsersAsync(int count, int offset) =>
            Task.Factory.StartNew(() => new List<User>
            {
                new User(1, $"This is first user", 18, "one", "password"),
                new User(2, $"This is second user", 18, "two", "password"),
                new User(3, $"This is third user", 18, "three", "password"),
                new User(4, $"This is fourth user", 18, "four", "password"),
                new User(5, $"This is fifth user", 18, "five", "password")
            }); 
    }
}
