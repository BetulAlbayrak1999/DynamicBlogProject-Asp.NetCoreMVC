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

        public List<About> GetAll()
        {
            return _about.GetAll();
        }
    }
}
