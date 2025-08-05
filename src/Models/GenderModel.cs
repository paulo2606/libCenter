using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.src.Models
{
    [Table("gender")]
    public class GenderModel
    {
        [Key]
        [Column("id_gender")]
        public int IdGender { get; set; }

        [Required]
        [Column("gender")]
        public string Gender { get; set; }

        [Column("description")]
        public string Description { get; set; }
    }
}