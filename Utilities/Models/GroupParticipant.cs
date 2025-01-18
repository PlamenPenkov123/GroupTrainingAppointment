using System.ComponentModel.DataAnnotations.Schema;

namespace GroupTrainingAppointment.Utilities.Models
{
    public class GroupParticipant
    {
        [ForeignKey("GroupId")]
        public Group group { get; set; }

        [ForeignKey("UserId")]
        public User user { get; set; }
    }
}
