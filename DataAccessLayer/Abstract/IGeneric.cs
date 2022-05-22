using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGeneric<T> where T: class
    {
        void Add(T item);
        void Delete(T item);
        void Update(T item);
        T GetById(int id);
        List<T> GetAll();

        List<T> GetAll(Expression<Func<T, bool>> filter);
    }
}
