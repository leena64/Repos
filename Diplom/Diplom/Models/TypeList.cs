using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class TypeList
    {
        [Key]
        public int TypeID { get; set; }
        public string TypeName { get; set; }
    }
}
