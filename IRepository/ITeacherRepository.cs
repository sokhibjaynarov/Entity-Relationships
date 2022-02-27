using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using vazifa0224.Models;

namespace vazifa0224.IRepository
{
    internal interface ITeacherRepository
    {
        Teacher Create(Teacher teacher);
        Teacher Update(int id);
        Teacher Delete(int id);
        Teacher Get(int id);
        List<Teacher> GetAll(Expression<Func<Teacher, bool>> predicate = null);
        Teacher AddSubjectToTeacher(int teacherId, int subjectId);
    }
}
