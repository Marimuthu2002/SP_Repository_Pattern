using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public interface IDataLayer
    {
        public List<DBModel> getMethod();
    }
}
