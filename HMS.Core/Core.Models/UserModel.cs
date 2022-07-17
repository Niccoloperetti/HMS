using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS
{
    public abstract class UserModel
    {
        #region properties
        public string Name { get; set; }
        public string Surname { get; set; }
        public string FiscalCode { get; set; }  
        public DateTime Birthday { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserId { get; set; }
        public DateTime Created { get; set; }
        #endregion
    }
}
