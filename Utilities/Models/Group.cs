using GroupTrainingAppointment.Utilities.ENUMS;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GroupTrainingAppointment.Utilities.Models
{
    public class Group
    {
        [Key]
        public int groupId { get; set; }

        [ForeignKey("trainerId")]
        public Trainer trainer { get; set; }

        [Required]
        public WorkoutType workoutType { get; set; }
    }
}
