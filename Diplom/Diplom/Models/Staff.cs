using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Diplom.Models
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }

        //разряд охранника (обозначается числом 1-6), null - если это не охранник
        public int? Skill { get; set; }

        [ForeignKey("Post")]
        public int PostID { get; set; }
        public Post Post { get; set; }
    }
}
