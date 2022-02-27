using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vazifa0224.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        [ForeignKey(nameof(Group))]
        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
