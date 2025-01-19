using GroupTrainingAppointment.Utilities.Models;

namespace GroupTrainingAppointment.Repositories.Interfaces
{
    public interface ITrainerRepository
    {
        IEnumerable<Trainer> GetAllTrainers();
        Trainer GetTrainerByEmail(string email);
        void AddTrainer(Trainer trainer);
        void RemoveTrainer(string email);
    }
}
