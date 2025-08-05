using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.Models
{
    [Table("adm")]
    public class AdmModel
    {
        [Key]
        [Column("id_adm")]
        public int IdAdm { get; set; }

        [Column("name_adm")]
        public string NameAdm { get; set; }

        [Column("email_adm")]
        public string EmailAdm { get; set; }

        [Column("pwd_hash_adm")]
        public string PwdHashAdm { get; set; }

        [Column("dt_criation_adm")]
        public DateTime DtCriationAdm { get; set; }
    }
}