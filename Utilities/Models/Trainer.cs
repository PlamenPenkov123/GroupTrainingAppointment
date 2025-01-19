using System.ComponentModel.DataAnnotations;

namespace GroupTrainingAppointment.Utilities.Models
{
    public class Trainer
    {
        [Key]
        public int trainerId { get; set; }

        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string lastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string email { get; set; }
    }
}
