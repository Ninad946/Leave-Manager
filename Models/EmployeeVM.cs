using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Models
{
    public class EmployeeVM
    {
        public int ID { get; set; }
        public string UserName { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string Firstname { get; set; }
        public string lastname { get; set; }
        public string Taxid { get; set; }

        public DateTime Dateofbirth { get; set; }

        public DateTime Dateofjoining { get; set; }
    }
}
