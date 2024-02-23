namespace ScratchRentMe.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public int IsAdmin { get; set; }

        public User(string name = "jane", string password = "pw123", int isAdmin = 1)
        {
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }
    }

}
