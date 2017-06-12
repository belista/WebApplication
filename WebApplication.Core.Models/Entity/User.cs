namespace WebApplication.Core.Models.Entity
{
    /// <summary>
    /// Класс, описывающий пользователя. 
    /// </summary>
    public class User
    {

        public User(string name, int age, string email, string pass, Group group = null)
        {
            Name = name;
            Age = age;
            Email = email;
            Password = pass;
            Group = group; 
        }

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
        /// Группа пользователя. 
        /// </summary>
        Group Group { get; set; }
    }
}
