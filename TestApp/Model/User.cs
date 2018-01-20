using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model
{
    public class User
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        public short Age { get; set; }

        public int PhoneNumber { get; set; }

        public Roles Role { get; set; }  
    }
}
