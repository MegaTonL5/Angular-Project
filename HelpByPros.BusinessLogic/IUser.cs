

namespace HelpByPros.BusinessLogic
{
    public interface IUser
    {
        int Id { get; set; }

        string FirstName { get; set; }

        string LastName { get; set; }

        string Phone { get; set; }

        string Email { get; set; }

        string Password { get; set; }
    }
}
