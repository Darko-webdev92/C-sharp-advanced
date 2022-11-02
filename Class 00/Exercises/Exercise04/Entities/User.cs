using Exercise04.Enums;
using Exercise04.Interfaces;


namespace Exercise04
{
    public abstract class User : IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Roles UserRole { get; set; }
    }
}
