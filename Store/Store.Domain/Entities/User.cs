namespace Store.Domain.Entities
{
    public class User
    {
        public User(string email, string password)
        {
            Email = email;
            Password = password;
            IsAdmin = false;
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }
        public bool IsAdmin { get; private set; }


    }
}
