using System.Collections.Generic;
using System.Linq;

namespace WebApplication.Core.Models.Entity
{
    public class Context
    {
        public Context()
        {
            Groups = new List<Group>
            {
                new Group("Some group")
            };

            Users = new List<User>
            {
                new User("Артём Шиленко", 18, "shilenko.at@mail.ru", "donthateme", Groups.First())
            };
        }
        
        public List<User> Users { get; private set; }
        public List<Group> Groups { get; private set; }
    }
}
