using Leave_Manager.Contracts;
using Leave_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Repository
{
    public class LeaveTypeRepository : ILeaveTypeRepository
    {
        private readonly ApplicationDbContext _db;

        public LeaveTypeRepository(ApplicationDbContext  db)
        {
            _db = db;
        }

        public bool create(Leave_Type entity)
        {
            _db.Leave_Types.Add(entity);
            return save();

        }

        public bool Delete(Leave_Type entity)
        {
            _db.Leave_Types.Remove(entity);
            return save();

        }

        public ICollection<Leave_Type> Findall()
        {
           var leavetypes= _db.Leave_Types.ToList();
            return leavetypes;
        }

        public Leave_Type FindbyID(int id)
        {
            var leavetype = _db.Leave_Types.Find(id);
            return leavetype;
             }

        public ICollection<Leave_Type> GetEMployeesByLeaveType(int id)
        {
            throw new NotImplementedException();
        }

        public bool save()
        {
           var changes= _db.SaveChanges();
            return changes > 0;
        }

        public bool Update(Leave_Type entity)
        {
            _db.Leave_Types.Update(entity);
            return save();
        }
    }
}
