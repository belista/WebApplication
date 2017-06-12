namespace WebApplication.Core.Models.Entity
{
    /// <summary>
    /// Класс, описывающий группы. 
    /// </summary>
    public class Group
    {
        public Group(string name)
        {
            Name = name; 
        }

        public string Name { get; private set; }
    }
}