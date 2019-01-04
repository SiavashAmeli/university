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
     [Table("teacher_tbl")]
    public class teacher
    {
         [Key]
        public int t_id { get; set; }
        public int p_id { get; set; }
        public string degree_of_education { get; set; }
        public person person { get; set; }
        public ICollection<course> course { get; set; }
        
        
    
    }
}
