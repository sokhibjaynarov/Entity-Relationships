﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vazifa0224.Models
{
    internal class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public Group()
        {
            Teachers = new List<Teacher>();
        }
    }
}
