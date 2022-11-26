using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NatureStore.Model.Entitys
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }    
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public UserType UserType { get; set; }
    }
}
