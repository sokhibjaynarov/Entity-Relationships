using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using vazifa0224.Models;

namespace vazifa0224.IRepository
{
    internal interface IStudentRepository
    {
        Student Create(Student student);
        Student Update(int id);
        Student Delete(int id);
        Student Get(int id);
        List<Student> GetAll(Expression<Func<Student, bool>> predicate = null);
    }
}
