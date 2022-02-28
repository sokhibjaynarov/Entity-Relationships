using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vazifa0224.Models
{
    internal class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; }
        public Subject()
        {
            Teachers = new List<Teacher>();
        }
    }
}
