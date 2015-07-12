using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_EF.Models
{
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Lecture> Lecture { get; set; }
    }
}
