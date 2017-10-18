using System;

namespace Store.Domain.Entities
{
    public class User
    {
        public User(int id, string name, string email, string password)
        {
            Id = id;
            Name = name;
            Email = email;
            Password = password;
            RegisterDate = DateTime.Now;
            Active = false;
        }

        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public DateTime RegisterDate { get; private set; }
        public bool Active { get; private set; }

        public void ConfirmarPassword(string confirmPassword)
        {
            if (confirmPassword == Password)
            {
                Active = true;
            }
        }

    }
}
