using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPF.Models
{
    [Table("TB_M_Transaction")]
    class Transaction
    {
        [Key]
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }

        public ICollection<TransactionItem> TransactionItem { get; set; }

        public Transaction()
        {

        }

        public Transaction(DateTime date)
        {
            this.OrderDate = date;
        }
    }
}
