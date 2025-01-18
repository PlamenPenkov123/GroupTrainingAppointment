using GroupTrainingAppointment.Utilities.Models;

namespace GroupTrainingAppointment.Repositories.Interfaces
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUsers();
        void AddUser(User user);
        void UpdateUser(string email);
        void DeleteUser(string email);
    }
}
