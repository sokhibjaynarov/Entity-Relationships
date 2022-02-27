using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using vazifa0224.Models;

namespace vazifa0224.IRepository
{
    internal interface IGroupRepository
    {
        Group Create(Group group);
        Group Update(int id);
        Group Delete(int id);
        Group Get(int id);
        List<Group> GetAll(Expression<Func<Group, bool>> predicate = null);
        Group AddTeacherToGroup(int teacherId, int groupId);
    }
}
