using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using vazifa0224.Data;
using vazifa0224.IRepository;
using vazifa0224.Models;

namespace vazifa0224.Repository
{
    internal class TeacherRepository : ITeacherRepository
    {
        AppDbContext appDbContext = new AppDbContext();

        public Teacher AddSubjectToTeacher(int teacherId, int subjectId)
        {
            try
            {
                Subject subject = appDbContext.Subjects.Find(subjectId);
                Teacher teacher = appDbContext.Teachers.Find(teacherId);
                teacher.Subjects.Add(subject);
                appDbContext.SaveChanges();
                return teacher;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Teacher Create(Teacher teacher)
        {
            appDbContext.Teachers.Add(teacher);
            appDbContext.SaveChanges();
            return teacher;
        }

        public Teacher Delete(int id)
        {
            try
            {
                Teacher teacher = appDbContext.Teachers.Find(id);
                appDbContext.Teachers.Remove(teacher);
                appDbContext.SaveChanges();
                return teacher;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Teacher Get(int id)
        {
            try
            {
                Teacher teacher = appDbContext.Teachers.Find(id);
                return teacher;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Teacher> GetAll(Expression<Func<Teacher, bool>> predicate = null)
        {
            Expression<Func<Teacher, bool>> pred = p => true;

            return (List<Teacher>)appDbContext.Teachers.Where(predicate ?? pred);
        }

        public Teacher Update(int id)
        {
            try
            {
                Teacher teacher = appDbContext.Teachers.Find(id);
                appDbContext.Teachers.Update(teacher);
                appDbContext.SaveChanges();
                return teacher;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
