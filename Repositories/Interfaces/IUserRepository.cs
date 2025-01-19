using GroupTrainingAppointment.Utilities.Models;

namespace GroupTrainingAppointment.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        void DeleteUser(string email);
    }
}
