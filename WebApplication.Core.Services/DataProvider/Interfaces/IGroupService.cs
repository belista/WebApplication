using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;

namespace WebApplication.Core.Services.DataProvider.Interfaces
{
    public interface IGroupService
    {
        Task<List<Group>> GetGroupsAsync(int count, int offset); 
        Task<Group> AddGroupAsync(int id, string name);
        Task<bool> RemoveGroupAsync(int id); 
    }
}
