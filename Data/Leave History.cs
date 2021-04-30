using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Data
{
    public class Leave_History
    {

        public int Id { get; set; }


        [ForeignKey("RequestingEmployeeID")]
        public Employee RequestingEmployee { get; set; }

         public string RequestingEmployeeID { get; set; }

        public DateTime startdate { get; set; }
        public DateTime enddate { get; set; }

        [ForeignKey("LeavetypeID")]
        public Leave_Type leavetype { get; set; }

        public int LeavetypeID { get; set; }

        public DateTime DateRequested { get; set; }

        public DateTime DateActtioned { get; set; }

        public bool? Approved { get; set; }

        [ForeignKey("ApprovedbyID")]
        public Employee Approvedby { get; set; }

        public string ApprovedbyID { get; set; }
    }

}
