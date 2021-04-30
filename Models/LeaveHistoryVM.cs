using System;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Models
{
    public class LeaveHistoryVM
    {
        public int Id { get; set; }


        public EmployeeVM RequestingEmployee { get; set; }

        public string RequestingEmployeeID { get; set; }
        [Required]
        public DateTime startdate { get; set; }
        [Required]
        public DateTime enddate { get; set; }

        public DetailsLeavetypeVM leavetype { get; set; }

        public int LeavetypeID { get; set; }

        public IEnumerable<SelectListItem> Leave_Types { get; set; }

        public DateTime DateRequested { get; set; }

        public DateTime DateActtioned { get; set; }

        public bool? Approved { get; set; }

        public EmployeeVM Approvedby { get; set; }

        public string ApprovedbyID { get; set; }

       }


    }

