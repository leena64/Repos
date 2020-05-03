using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Models
{
    public class UserContract
    {
        [Key]
        public int UserContractID { get; set; }
        //  [ForeignKey("Users")]
        public int UserID { get; set; }
        public User User { get; set; }

        //  [ForeignKey("Contracts")]
        public int ContractID { get; set; }
        public Contract Contract { get; set; }
    }
}
