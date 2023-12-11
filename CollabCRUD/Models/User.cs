using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabCRUD.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string? Email { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string? Phone { get; set; }


        public ICollection<Appointment> Appointments { get; set; }
        public ICollection<Pick> Picks { get; set; }
        public ICollection<Chat> Chats { get; set; }
    }
}
