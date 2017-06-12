using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;

namespace WebApplication.Core.Services.DataProvider.Interfaces
{
    public interface IGroupService
    {
        Task<Group> AddGroupAsync(string name);
        Task<bool> RemoveGroupAsync(int id); 
    }
}
