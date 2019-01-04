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
     [Table("person_tbl")]
    public class person
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int p_id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int n_cod { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string personType { get; set; }
       
        public ICollection<student> student { get; set; }
        public ICollection<teacher> teacher { get; set; }


    }
}
