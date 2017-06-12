namespace WebApplication.Core.Models.Entity
{
    /// <summary>
    /// Класс, описывающий пользователя. 
    /// </summary>
    public class User
    {

        public User(int id, string name, int age, string email, string pass, int? groupId = null)
        {
            Id = id; 
            Name = name;
            Age = age;
            Email = email;
            Password = pass;
            GroupId = groupId; 
        }

        /// <summary>
        /// Айди пользователя. 
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Имя. 
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Возраст. 
        /// </summary>
        public int Age { get; private set; }

        /// <summary>
        /// Имейл. 
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Пароль. 
        /// </summary>
        public string Password { get; private set; }

        /// <summary>
        /// Id группы пользователя. 
        /// </summary>
        public int? GroupId { get; set; }
    }
}
