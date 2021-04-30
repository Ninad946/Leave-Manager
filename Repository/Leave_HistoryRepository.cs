using Leave_Manager.Contracts;
using Leave_Manager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Repository
{
    public class Leave_HistoryRepository : ILeaveHistoryRepository
    {
        private readonly ApplicationDbContext _db;

        public Leave_HistoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool create(Leave_History entity)
        {  
             _db .Leave_Historie.Add(entity);
            return save();

        }

        public bool Delete(Leave_History entity)
        {
            _db.Leave_Historie.Remove(entity);
            return save();

        }

        public ICollection<Leave_History> Findall()
        {
            var leavehistory=_db.Leave_Historie.ToList();
            return leavehistory;
        }

        public Leave_History FindbyID(int id)
        {
            var leavehistories=_db.Leave_Historie.Find(id);
            return leavehistories;
        }

        public bool save()
        {
           var changes =  _db.SaveChanges();
            return changes > 0; 
         }

        public bool Update(Leave_History entity)
        {
            _db.Leave_Historie.Update(entity);
            return save();

        }
    }
}
