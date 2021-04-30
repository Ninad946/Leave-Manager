using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manager.Contracts
{
    public interface IRepositoryBase<T> where T:class
    {
        ICollection<T> Findall();

        T FindbyID(int id);

        bool create(T entity);

        bool Update(T entity);

        bool Delete(T entity);

        bool save();



    }

}
