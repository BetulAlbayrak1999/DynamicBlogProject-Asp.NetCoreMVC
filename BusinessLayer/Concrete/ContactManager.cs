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
    public class ContactManager : IContactService
    {
        IContact _contact;

        public ContactManager(IContact contact)
        {
            _contact = contact;
        }

        public void AddContact(Contact contact)
        {
            _contact.Add(contact);
        }
    }
}
