using AutoMapper;
using Leave_Manager.Data;
using Leave_Manager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Leave_Type, DetailsLeavetypeVM>().ReverseMap();
            CreateMap<Leave_Type, CreateLeavetypeVM>().ReverseMap();
            CreateMap<Leave_History, LeaveHistoryVM>().ReverseMap();
            CreateMap<Leave_ALlocation, LeaveallocationVM>().ReverseMap();
            CreateMap<Employee, EmployeeVM>().ReverseMap();








        }
    }
}
