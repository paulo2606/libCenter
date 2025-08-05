using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.Models
{
    [Table("publisher")]
    public class PublisherModel
    {
        [Key]
        [Column("id_publisher")]
        public int IdPublisher { get; set; }

        [Required]
        [Column("name_publisher")]
        public string NamePublisher { get; set; }

        [Column("phone_publisher")]
        public string PhonePublisher { get; set; }

        [Column("site")]
        public string Site { get; set; }
    }
}