using DTO;
using SP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.DLL
{
    public interface IStudentD
    {
        public object getEmploye();
        public object PostSpMethod(ViewModel studentDBModel);
        public object PutSpMethod(StudentDBModel studentDBModel);
        public object DeleteSpMethod(int id);
    }
}
