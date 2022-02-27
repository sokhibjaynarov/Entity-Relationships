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
    internal class GroupRepository : IGroupRepository
    {
        AppDbContext appDbContext = new AppDbContext();

        public Group AddTeacherToGroup(int teacherId, int groupId)
        {
            try
            {
                Group group = appDbContext.Groups.Find(groupId);
                Teacher teacher = appDbContext.Teachers.Find(teacherId);
                group.Teachers.Add(teacher);
                appDbContext.SaveChanges();
                return group;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Group Create(Group group)
        {
            appDbContext.Groups.Add(group);
            appDbContext.SaveChanges();
            return group;
        }

        public Group Delete(int id)
        {
            try
            {
                Group group = appDbContext.Groups.Find(id);
                appDbContext.Groups.Remove(group);
                appDbContext.Groups.Update(group);
                appDbContext.SaveChanges();
                return group;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public Group Get(int id)
        {
            try
            {
                Group group = appDbContext.Groups.Find(id);
                return group;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }

        public List<Group> GetAll(Expression<Func<Group, bool>> predicate = null)
        {
            Expression<Func<Group, bool>> pred = p => true;

            return (List<Group>)appDbContext.Groups.Where(predicate ?? pred);
        }

        public Group Update(int id)
        {
            try
            {
                Group group = appDbContext.Groups.Find(id);
                appDbContext.Groups.Update(group);
                appDbContext.SaveChanges();
                return group;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
