using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    public class User
    {
          [Key]
        public int UserID { get; set; }
        public string UserLogin { get; set; }
        public string UserName { get; set; }
        public string UserSName { get; set; }
        public string UserPatronymic { get; set; }
        public string UserEmail { get; set; }
        public string UserPhone { get; set; }
        public string UserPassword { get; set; }
        public string UserAddress { get; set; }
        public bool Privilege1 { get; set; }
        public bool Privilege2 { get; set; }

            [ForeignKey("Staff")]
        public int? StaffID { get; set; }
        public Staff Staff { get; set; }

        public virtual ICollection<ObjectSec> ObjectSec { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
        //public User() : base()
        //{
        //    ObjectSec = new List<ObjectSec>();
        //    Contracts = new List<Contract>();
        //}
    }
}
