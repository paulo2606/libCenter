using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.src.Models
{
    [Table("book")]
    public class BookModel
    {
        [Key]
        [Column("id_book")]
        public int IdBook { get; set; }

        [Column("id_publisher")]
        public int IdPublisher { get; set; }

        [Column("id_author")]
        public int IdAuthor { get; set; }

        [Column("id_gender")]
        public int IdGender { get; set; }

        [Required]
        [Column("title")]
        public string Title { get; set; }

        [Column("description_book")]
        public string DescriptionBook { get; set; }

        [Column("year_publication")]
        public int YearPublication { get; set; }

        [Column("isbn")]
        public string Isbn { get; set; }

        [Column("full_amount")]
        public int FullAmount { get; set; }

        [Column("available_amount")]
        public int AvailableAmount { get; set; }

        public virtual PublisherModel Publisher { get; set; }
        public virtual AuthorModel Author { get; set; }
        public virtual GenderModel Gender { get; set; }
    }
}