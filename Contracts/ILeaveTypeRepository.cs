using System;
using Leave_Manager.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Contracts
{
   public interface ILeaveTypeRepository : IRepositoryBase<Leave_Type>
    {
        ICollection<Leave_Type> GetEMployeesByLeaveType(int id);
    }
}
