using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diplom.Models.HTML
{
    public class AccountData
    {
        #region UserData For HeaderSet
        public bool Autorize { get; set; } = false;
        public string AccFamilyName { get; set; }
        public string AccFirstName { get; set; }
        public string AccPatronymic { get; set; }
        public bool Privilege1 { get; set; }
        #endregion
    }
}
