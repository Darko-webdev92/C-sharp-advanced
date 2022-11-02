using Exercise01.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise01.Entities
{
    public abstract class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


        public User(int id, string name, string username, string password)
        {
            Id = id;
            Name = name;
            Username = username;
            Password = password;
        }

        public virtual void PrintUser()
        {
            Console.WriteLine($"{Id} {Name} {Username}");
        }
    }
}
