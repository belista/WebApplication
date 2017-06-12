using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;
using WebApplication.Core.Services.DataProvider.Interfaces;

namespace WebApplication.Core.Services.DataProvider.Placeholders
{
    public class GroupServicePlaceholder : IGroupService
    {
        public Task<Group> AddGroupAsync(int id, string name) =>
            Task.Factory.StartNew(() => new Group(0, name));

        public Task<List<Group>> GetGroupsAsync(int count, int offset) =>
            Task.Factory.StartNew(() => new List<Group>
            {
                new Group(1, "First group"),
                new Group(2, "Second group"),
                new Group(3, "Third group"),
                new Group(4, "Fourth group")
            }); 

        public Task<bool> RemoveGroupAsync(int id) =>
            Task.FromResult(true); 
    }
}
