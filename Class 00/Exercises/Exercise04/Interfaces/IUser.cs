using Exercise04.Enums;


namespace Exercise04.Interfaces
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        Roles UserRole { get; set; }
    }
}
