using Leave_Manager.Contracts;
using Leave_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Repository
{
    public class Leave_AllocationRepository : ILeaveAllocationRepository
    {

        private readonly ApplicationDbContext _db;

        public Leave_AllocationRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool create(Leave_ALlocation entity)
        {
            _db.Leave_ALlocations.Add(entity);
            return save();

        }

        public bool Delete(Leave_ALlocation entity)
        {

            _db.Leave_ALlocations.Remove(entity);
            return save();
        }

        public ICollection<Leave_ALlocation> Findall()
        {
            var leaveallocation=_db.Leave_ALlocations.ToList();
            return leaveallocation;
        }

        public Leave_ALlocation FindbyID(int id)
        {
            var leaveallocations=_db.Leave_ALlocations.Find(id);
            return leaveallocations;
        }

        public bool save()
        {
            var changes=_db.SaveChanges();
            return changes > 0;

        }

        public bool Update(Leave_ALlocation entity)
        {
            _db.Leave_ALlocations.Update(entity);
            return save();
        }
    }
}

       