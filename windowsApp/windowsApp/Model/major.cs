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
     [Table("major_tbl")]
    public class major
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int major_cod { get; set; }
        public string name { get; set; }
        public ICollection<student> student { get; set; }
        public ICollection<course> course { get; set; }

    }
}
