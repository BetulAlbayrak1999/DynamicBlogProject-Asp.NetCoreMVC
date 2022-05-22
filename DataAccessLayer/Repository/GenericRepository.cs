using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGeneric<T> where T : class
    {
        private readonly Context context = new Context();
        public void Add(T item)
        {
            context.Add<T>(item);
            context.SaveChanges();
        }

        public void Delete(T item)
        {
            context.Remove<T>(item);
            context.SaveChanges();
        }

        public List<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return context.Find<T>(id);
        }

        public void Update(T item)
        {
            context.Update<T>(item);
            context.SaveChanges();
        }
    }
}
