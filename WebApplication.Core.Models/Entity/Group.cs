namespace WebApplication.Core.Models.Entity
{
    /// <summary>
    /// Класс, описывающий группы. 
    /// </summary>
    public class Group
    {
        public Group(int id, string name)
        {
            Id = id; 
            Name = name; 
        }

        /// <summary>
        /// Айди группы. 
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Название группы. 
        /// </summary>
        public string Name { get; private set; }
    }
}