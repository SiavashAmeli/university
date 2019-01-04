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
     [Table("course_tbl")]
    public class course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]  
        public int course_cod { get; set; }
        public string name { get; set; }
        public int units_number { get; set; }
        public ICollection<major> major { get; set; }
        public ICollection<student> student { get; set; }
        public ICollection<teacher> teacher { get; set; }
    }
}
