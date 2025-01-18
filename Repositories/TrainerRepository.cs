using GroupTrainingAppointment.Repositories.Interfaces;
using GroupTrainingAppointment.Utilities.Models;

namespace GroupTrainingAppointment.Repositories
{
    public class TrainerRepository : ITrainerRepository
    {
        private readonly AppDbContext _context;
        public TrainerRepository(AppDbContext context) 
        {
            _context = context;
        }

        public IEnumerable<Trainer> GetAllTrainers()
        {
            return _context.Trainers.ToList();
        }
        
        public void AddTrainer(Trainer trainer)
        {
            _context.Trainers.Add(trainer);
            _context.SaveChanges();
        }
        
        public void UpdateTrainer(string email)
        {
            throw new NotImplementedException();
        }

        public void RemoveTrainer(string email)
        {
            var trainer = _context.Trainers.Find(email);

            if (trainer != null)
            {

                _context.Trainers.Remove(trainer);
                _context.SaveChanges();
            }
        }
    }
}
