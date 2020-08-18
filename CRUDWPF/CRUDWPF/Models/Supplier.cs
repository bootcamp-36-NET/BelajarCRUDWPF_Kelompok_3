using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDWPF.Models
{
    [Table("TB_M_Supplier")]
    class Supplier
    {
        public Supplier(string text)
        {

        }


        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }

        public Supplier()
        {
        }
    
    }
}
