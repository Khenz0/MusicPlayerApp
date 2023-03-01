using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerApp
{
    public class User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        private string Password { get; set; }

        public User(string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

        //Function to check if the password entered is correct.
        public bool CheckPassword(string password)
        {
            return password == Password;
        }
    }
}
