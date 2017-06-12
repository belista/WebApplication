using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebApplication.Core.Models.Entity;
using WebApplication.Core.Services.DataProvider.Interfaces;
using System.Linq;

namespace WebApplication.Core.Services.DataProvider
{
    class GroupService : IGroupService
    {
        Context _context;
        public GroupService(Context context, int Id, string Name)
        {
            _context = context;
            
        }
        public async Task<Group> AddGroupAsync(int id, string name)
        {
            var group = new Group(id, name);
            return await Task.Run(() => 
            {
                _context.Groups.Add(group); 

                return group; 
            });

        }

        public async Task<List<Group>> GetGroupsAsync(int count, int offset)
        {
            return await Task.Run(() =>
            {
                return _context.Groups.Skip(offset).Take(count).ToList();
            });
        }

        public async Task<bool> RemoveGroupAsync(int id)
        {
            return await Task.Run(() =>
            {
                foreach (var group in _context.Groups)
                {
                    if (group.Id == id)
                    {
                        _context.Groups.Remove(group);
                        return true;
                    }
                }
                return false;
            });
            
        }
    }
}
