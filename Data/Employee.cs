using Microsoft.AspNetCore.Identity;
using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Data
{
    public class Employee : IdentityUser
    {

        public string Firstname { get; set; }
        public string lastname { get; set; }
        public string Taxid { get; set; }

        public DateTime Dateofbirth { get; set; }

        public DateTime Dateofjoining { get; set; }    
    }
}
