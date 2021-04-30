using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Models
{
    public class DetailsLeavetypeVM
    {
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }

        public DateTime Datecreated { get; set; }
    }


    public class CreateLeavetypeVM
    {
        [Required]
        public string Name { get; set; }

    }

}
