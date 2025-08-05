using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.src.Models
{
    [Table("author")]
    public class AuthorModel
    {
        [Key]
        [Column("id_author")]
        public int IdAuthor { get; set; }

        [Required]
        [Column("name_author")]
        public string NameAuthor { get; set; }

        [Column("description_author")]
        public string DescriptionAuthor { get; set; }
    }
}