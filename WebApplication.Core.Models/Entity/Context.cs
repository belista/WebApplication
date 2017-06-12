using System.Collections.Generic;

namespace WebApplication.Core.Models.Entity
{
    public class Context
    {
        public Context()
        {
            Groups = new List<Group>
            {
                new Group(1, "Some group")
            };

            Users = new List<User>
            {
                new User(1, "Артём Шиленко", 18, "shilenko.at@mail.ru", "donthateme")
            };
        }
        
        public List<User> Users { get; private set; }
        public List<Group> Groups { get; private set; }
    }
}
