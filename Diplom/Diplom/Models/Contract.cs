using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    public class Contract
    {
        [Key]
        public int ContractID { get; set; }
        public double Pay { get; set; }
        public DateTime ConcDate { get; set; }
        public DateTime BegDate { get; set; }
        public DateTime CompDate { get; set; }

        [ForeignKey("TypeList")]
        public int TypeID { get; set; }

        [ForeignKey("ObjectSec")]
        public int ObjectID { get; set; }
        public ObjectSec ObjectSec { get; set; }

        public virtual ICollection<TypeList> TypeList { get; set; }
        //public virtual ICollection<User> Users { get; set; }
        public Contract() : base()
        {
            TypeList = new List<TypeList>();
            //Users = new List<User>();

        }
    }
}
