using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabCRUD.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int ServiceId { get; set; }
        public Service Service { get; set; }

        [Required]
        public DateTime AppointmentDateTime { get; set; }

        // Other appointment details like status, notes, etc.

    }
}
