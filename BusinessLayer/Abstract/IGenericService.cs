using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IGenericService<T>
    {
        void AddT(T t);

        void DeleteT(T t);

        void UpdateT(T t);

        T GetTById(int id);

        List<T> GetAllTs();
    }
}
