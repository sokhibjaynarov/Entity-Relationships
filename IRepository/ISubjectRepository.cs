using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using vazifa0224.Models;

namespace vazifa0224.IRepository
{
    internal interface ISubjectRepository
    {
        Subject Create(Subject subject);
        Subject Update(int id);
        Subject Delete(int id);
        Subject Get(int id);
        List<Subject> GetAll(Expression<Func<Subject, bool>> predicate = null);
    }
}
