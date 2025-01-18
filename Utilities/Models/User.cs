using System.ComponentModel.DataAnnotations;
using GroupTrainingAppointment.Utilities.ENUMS;

namespace GroupTrainingAppointment.Utilities.Models
{
    public class User
    {
        [Key]
        public int userId { get; set; }

        [Required]
        [MaxLength(100)]
        public string firstName { get; set; }

        [Required]
        [MaxLength(100)]
        public string lastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string email { get; set; }

        [Required]
        [MaxLength(100)]
        public string password { get; set; }

        [Required]
        public UserRole userRole { get; set; } = UserRole.USER;

    }
}
