using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        IAbout _about;

        public AboutManager(IAbout about)
        {
            _about = about;
        }

        public void AddT(About t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(About t)
        {
            throw new NotImplementedException();
        }

        public List<About> GetAllTs()
        {
            return _about.GetAll();
        }

        public About GetTById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateT(About t)
        {
            throw new NotImplementedException();
        }
    }
}
