using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.Models
{
    [Table("reserve")]
    public class ReserveModel
    {
        [Key]
        [Column("id_reserve")]
        public int IdReserve { get; set; }

        [Column("id_book")]
        public int IdBook { get; set; }

        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("dt_reserve")]
        public DateTime DtReserve { get; set; }

        [Column("status_reserve")]
        public string StatusReserve { get; set; }
        public virtual BookModel Book { get; set; }
        public virtual UserData User { get; set; }
    }
}