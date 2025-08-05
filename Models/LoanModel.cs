using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace libCenter.Models
{
    [Table("loan")]
    public class LoanModel
    {
        [Key]
        [Column("id_loan")]
        public int IdLoan { get; set; }

        [Column("id_user")]
        public int IdUser { get; set; }

        [Column("id_book")]
        public int IdBook { get; set; }

        [Column("dt_loan")]
        public DateTime DtLoan { get; set; }

        [Column("expected_return_dt")]
        public DateTime ExpectedReturnDt { get; set; }

        [Column("real_return_dt")]
        public DateTime? RealReturnDt { get; set; }

        [Column("status_loan")]
        public string StatusLoan { get; set; }

        public virtual UserData User { get; set; }
        public virtual BookModel Book { get; set; }
    }
}