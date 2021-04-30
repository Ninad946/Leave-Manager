using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Models
{
    public class LeaveallocationVM
    {
        public int Id { get; set; }

        public int NumberofDays { get; set; }

        public DateTime Datecreated { get; set; }
        public EmployeeVM Emp { get; set; }

        public string EmployeeID { get; set; }
        public DetailsLeavetypeVM Leavetype { get; set; }

        public int LeaveTypeID { get; set; }

        public IEnumerable<SelectListItem> Employees { get;set;}
        public IEnumerable<SelectListItem> Leave_Types { get; set; }



    }
}
