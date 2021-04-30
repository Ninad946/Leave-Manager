using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Data
{
    public class Leave_ALlocation
    {

        [Key]
        public int Id { get; set; }

        public int NumberofDays { get; set; }

        public DateTime Datecreated { get; set; }
        [ForeignKey("EmployeeID")]
        public Employee Emp { get; set; }

        public string EmployeeID { get; set; }
        [ForeignKey("LeaveTypeID")]
        public Leave_Type Leavetype { get; set; }

        public int LeaveTypeID { get; set; }
    }
}
