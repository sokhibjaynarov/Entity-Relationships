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
    internal class SubjectRepository : ISubjectRepository
    {
        AppDbContext appDbContext = new AppDbContext();
        public Subject Create(Subject subject)
        {
            appDbContext.Subjects.Add(subject);
            appDbContext.SaveChanges();
            return subject;
        }

        public Subject Delete(int id)
        {
            try
            {
                Subject subject = appDbContext.Subjects.Find(id);
                appDbContext.Subjects.Remove(subject);
                appDbContext.SaveChanges();
                return subject;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Subject Get(int id)
        {
            try
            {
                Subject Subject = appDbContext.Subjects.Find(id);
                return Subject;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Subject> GetAll(Expression<Func<Subject, bool>> predicate = null)
        {
            Expression<Func<Subject, bool>> pred = p => true;

            return (List<Subject>)appDbContext.Subjects.Where(predicate ?? pred);
        }

        public Subject Update(int id)
        {
            try
            {
                Subject subject = appDbContext.Subjects.Find(id);
                appDbContext.Subjects.Update(subject);
                appDbContext.SaveChanges();
                return subject;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
