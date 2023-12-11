using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabCRUD.Models
{
    public class Chat
    {
        [Key]
        public int ChatId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public bool IsAdmin { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(max)")]
        public string Message { get; set; }

        public DateTime Timestamp { get; set; }
    }
}
