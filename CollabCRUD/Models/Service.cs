using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CollabCRUD.Models
{
    public class Service
    {
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(100)")]
        public string ServiceName { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Description { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string imgSource { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
