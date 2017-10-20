using System;
using FluentValidation.Attributes;
using Store.Domain.Validation;

namespace Store.Domain.Entities
{
    [Validator(typeof(UserValidator))]
    public class User
    {
        public User(string email, string password, string confirmPassword)
        {
            Id = Guid.NewGuid();
            Email = email;
            Password = password;
            ConfirmPassword = confirmPassword;
            Active = false;
        }

        public Guid Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public string ConfirmPassword{ get; private set; }
        public DateTime RegisterDate { get; private set; }
        public bool Active { get; private set; }

        public void Activation()
        {
            
        }
    }
}
