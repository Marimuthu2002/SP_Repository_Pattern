using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class DataLayer : IDataLayer
    {
        public readonly DBContext _DBContext;
        public DataLayer(DBContext dbcontext)
        {
            _DBContext = dbcontext;
        }
        public List<DBModel> getMethod()
        {
            var data = _DBContext.Employee.ToList();
            return data;
        }
    }
}
