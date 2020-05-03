using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Diplom.Models
{
    public class ObjectList
    {
        [Key]
        public int ObjTypeID { get; set; }
        public string ObTypeName { get; set; }
        //Объект - (физ лицо - true/юр.лицо - false/не имеет значения - null)
        //Ибо используются различные охранные мероприятия
        public bool Individual { get; set; }
        //public virtual ICollection<ObjectSec> ObjectSecs { get; set; }
        //public ObjectList()
        //{
        //    ObjectSecs = new List<ObjectSec>();
        //}
    }
}
