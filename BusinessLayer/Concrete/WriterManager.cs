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
    public class WriterManager : IWriterService
    {
        IWriter _writer;
        public WriterManager(IWriter writer) 
        {
            _writer = writer;
        }

        public void AddWriter(Writer writer)
        {
            _writer.Add(writer);
        }
    }
}
