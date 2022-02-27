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
    internal class StudentRepository : IStudentRepository
    {
        AppDbContext appDbContext = new AppDbContext();
        public Student Create(Student student)
        {
            appDbContext.Students.Add(student);
            appDbContext.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            try
            {
                Student student = appDbContext.Students.Find(id);
                appDbContext.Students.Remove(student);
                appDbContext.SaveChanges();
                return student;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Student Get(int id)
        {
            try
            {
                Student student = appDbContext.Students.Find(id);
                return student;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Student> GetAll(Expression<Func<Student, bool>> predicate = null)
        {
            Expression<Func<Student, bool>> pred = p => true;

            return (List<Student>)appDbContext.Students.Where(predicate ?? pred);
        }

        public Student Update(int id)
        {
            try
            {
                Student student = appDbContext.Students.Find(id);
                appDbContext.Students.Update(student);
                appDbContext.SaveChanges();
                return student;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
