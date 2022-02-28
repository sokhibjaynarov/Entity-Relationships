using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vazifa0224.Models
{
    internal class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual ICollection<Group> Groups { get; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public Teacher()
        {
            Groups = new List<Group>();
            Subjects = new List<Subject>();
        }
    }
}
