using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace windowsApp.Model
{
     [Table("student_tbl")]
    public class student
    {
        [Key]
        public int s_id { get; set; }
        public int p_id { get; set; }       
        public DateTime enteringDate { get; set; }
        public ICollection<major> major { get; set; }
        public person person { get; set; }
        public ICollection<course> course { get; set; }

    }
}
