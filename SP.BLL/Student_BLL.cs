using DTO;
using SP.DLL;
using SP.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SP.BLL
{
    public class Student_BLL : IStudent_BLL
    {
        private readonly IStudentD _student;

        public Student_BLL(IStudentD stud_dll)
        {
            _student = stud_dll;
        }
        public List<StudentDBModel> getMethod()
        {
            throw new NotImplementedException();
        }

        public object getSpMethod()
        {
           return _student.getEmploye();
        }


        public object? PostSpMethod(ViewModel studentDBModel)
        {
            return _student.PostSpMethod(studentDBModel);
        }

        public object PutSpMethod(StudentDBModel studentDBModel)
        {
            return _student.PutSpMethod(studentDBModel);
        }

        public object DeleteSpMethod(int id)
        {
            return _student.DeleteSpMethod(id);
        }

    }
}
