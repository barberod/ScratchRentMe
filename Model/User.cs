﻿namespace ScratchRentMe.Model
{
    public class User
    {
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }

        public User(string name, string password, bool isAdmin)
        {
            Name = name;
            Password = password;
            IsAdmin = isAdmin;
        }
    }

}
