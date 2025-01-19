using System.Text.RegularExpressions;

namespace GroupTrainingAppointment.Repositories.Interfaces
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetAllGroups();
        Group GetGroupById(int id);
        void AddGroup(Group group);

    }
}
