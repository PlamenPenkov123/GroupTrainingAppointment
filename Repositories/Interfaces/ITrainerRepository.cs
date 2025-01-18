using GroupTrainingAppointment.Utilities.Models;

namespace GroupTrainingAppointment.Repositories.Interfaces
{
    public interface ITrainerRepository
    {
        IEnumerable<Trainer> GetAllTrainers();
        void AddTrainer(Trainer trainer);
        void UpdateTrainer(string email);
        void RemoveTrainer(string email);
    }
}
