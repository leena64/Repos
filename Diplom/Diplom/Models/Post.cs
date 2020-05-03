using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    public class Post
    {
        [Key]
        public int PostID { get; set; }
        public string PostName { get; set; }
    }
}
