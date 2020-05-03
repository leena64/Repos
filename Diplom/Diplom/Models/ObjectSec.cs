using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    public class ObjectSec
    {
        [Key]
        public int ObjectID { get; set; }
        //Площадь охраняемого объекта (может отсутствовать, если охраняется груз или человек)
        private int? Area { get; set; }
        public string ObjAddress { get; set; }
        [ForeignKey("OdjectList")]
        public int ObjTypeID { get; set; }
        public ObjectList ObjectList { get; set; }
        //public int UserID { get; set; }
        //public User User { get; set; } 
    }
}
